using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using PetShop.Database;
using PetShop.Filters;
using PetShop.Helpers;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Services
{
    public class ProizvodService : BaseCRUDService<Model.Proizvod, Database.Proizvod, ProizvodSearchObject, ProizvodInsertRequest, ProizvodUpdateRequest>, IProizvodService
    {
        private readonly IHttpContextAccessor _httpContext;
        public ProizvodService(PetShopContext context, IMapper mapper, IHttpContextAccessor httpContext) : base(context,mapper)
        {
            _httpContext = httpContext;
        }

        public override List<Model.Proizvod> Get(ProizvodSearchObject search = null)
        {
            var entity = ctx.Set<Database.Proizvod>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }

            if (search.KategorijaId.HasValue)
            {
                entity = entity.Where(x => x.KategorijaId == search.KategorijaId);
            }

            if (search.ProizvodjacId.HasValue)
            {
                entity = entity.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }

            if (search.ZivotinjaId.HasValue)
            {
                entity = entity.Where(x => x.ZivotinjaId == search.ZivotinjaId);
            }

            entity = entity.Include(x => x.Kategorija).Include(x => x.Proizvodjac).Include(x => x.Proizvodjac.Drzava).Include(x => x.Zivotinja);

            var list = entity.ToList();

            return _mapper.Map<List<Model.Proizvod>>(list);
        }

        public override Model.Proizvod Insert(ProizvodInsertRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            if (request.ProizvodjacId == 0)
            {
                throw new UserException("Niste oznacili proizvodjaca");
            }

            if (request.KategorijaId == 0)
            {
                throw new UserException("Niste oznacili kategoriju");
            }

            if (request.ZivotinjaId == 0)
            {
                throw new UserException("Niste oznacili zivotinju");
            }


            var entity = _mapper.Map<Database.Proizvod>(request);
            ctx.Add(entity);

            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if (!adminUposlenik)
            {
                throw new Exception("Niste administrator ili uposlenik");
            }

            ctx.SaveChanges();

            return _mapper.Map<Model.Proizvod>(entity);
        }

        public override Model.Proizvod Update(int id, ProizvodUpdateRequest request)
        {
            bool adminUposlenik = false;
            var userId = int.Parse(_httpContext.GetUserId());

            var entity = ctx.Proizvods.Find(id);

            if (request.ProizvodjacId == 0)
            {
                throw new UserException("Niste oznacili proizvodjaca");
            }

            if (request.KategorijaId == 0)
            {
                throw new UserException("Niste oznacili kategoriju");
            }

            if (request.ZivotinjaId == 0)
            {
                throw new UserException("Niste oznacili zivotinju");
            }

            _mapper.Map(request, entity);


            List<KorisnikRola> korisniciRole = ctx.KorisnikRolas.Where(x => x.Rola.Naziv.Equals("Administrator") || x.Rola.Naziv.Equals("Uposlenik")).ToList();

            foreach (var item in korisniciRole)
            {
                if (item.KorisnikId == userId)
                {
                    adminUposlenik = true;
                }
            }

            if (!adminUposlenik)
            {
                throw new Exception("Niste administrator ili uposlenik");
            }

            ctx.SaveChanges();
            return _mapper.Map<Model.Proizvod>(entity);
        }

        private static MLContext mlContext = null;
        private static ITransformer model = null;
        public List<Model.Proizvod> Recommend(int id)
        {
            bool provjera = false;

            var allNarudzbe = ctx.Narudzbas.Include("NarudzbaProizvods").ToList();

            foreach (var item in allNarudzbe)
            {
                if (item.NarudzbaProizvods.Count > 1)
                {
                    var itemId = item.NarudzbaProizvods.Select(x => x.ProizvodId).ToList();
                    itemId.ForEach(y =>
                    {
                        if (y == id)
                        {
                            provjera = true;
                        }
                    });
                }

                if (provjera == true)
                {
                    break;
                }
            }

            if (!provjera)
            {
                var proizvod = ctx.Proizvods.Where(x => x.Id == id).FirstOrDefault();
                var allProizvodi = ctx.Proizvods.Include(x => x.Proizvodjac).Include(x => x.Proizvodjac.Drzava).Where(x => x.KategorijaId == proizvod.KategorijaId).ToList();

                var recenzija = ctx.Recenzijas.Where(y => y.Proizvod.KategorijaId == proizvod.KategorijaId && y.ProizvodId != proizvod.Id).GroupBy(x => x.Proizvod.Id).Select(g => new Recenzija { ProizvodId = g.Key, Ocjena = g.Sum(s => s.Ocjena) }).OrderByDescending(z => z.Ocjena).Take(3).ToList();

                if (recenzija.Count > 1)
                {
                    List<Proizvod> proizvodiList = new List<Proizvod>();
                    foreach (var r in recenzija)
                    {
                        foreach (var p in allProizvodi)
                        {
                            if (r.ProizvodId == p.Id)
                            {
                                proizvodiList.Add(p);
                            }
                        }
                    }

                    return _mapper.Map<List<Model.Proizvod>>(proizvodiList);
                }
            }

            if (mlContext == null)
            {
                mlContext = new MLContext();

                var tempData = ctx.Narudzbas.Include("NarudzbaProizvods").ToList();
                var data = new List<ProductEntry>();

                foreach(var item in tempData)
                {
                    if(item.NarudzbaProizvods.Count > 1)
                    {
                        var distinctItemId = item.NarudzbaProizvods.Select(y => y.ProizvodId).ToList();
                        distinctItemId.ForEach(y =>
                        {
                            var relatedItems = item.NarudzbaProizvods.Where(z => z.ProizvodId != y);

                            foreach(var z in relatedItems)
                            {
                                data.Add(new ProductEntry()
                                {
                                    ProductID = (uint)y,
                                    CoPurchaseProductID = (uint)z.ProizvodId
                                });
                            }
                        });
                    }
                }

                var trainData = mlContext.Data.LoadFromEnumerable(data);

                //STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
                //        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer.
                MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
                options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
                options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
                options.LabelColumnName = "Label";
                options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
                options.Alpha = 0.01;
                options.Lambda = 0.025;
                // For better results use the following parameters
                options.NumberOfIterations = 100;
                options.C = 0.00001;

                //Step 4: Call the MatrixFactorization trainer by passing options.
                var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);

                model = est.Fit(trainData);
            }

            var allItems = ctx.Proizvods.Include(x => x.Proizvodjac).Include(x => x.Proizvodjac.Drzava).Where(x => x.Id != id).ToList();
            var predictionResult = new List<Tuple<Database.Proizvod, float>>();

            foreach (var item in allItems)
            {
                var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);

                var prediction = predictionEngine.Predict(new ProductEntry()
                {
                    ProductID = (uint)id,
                    CoPurchaseProductID = (uint)item.Id
                });

                predictionResult.Add(new Tuple<Database.Proizvod, float>(item, prediction.Score));
            }

            var finalResult = predictionResult.OrderByDescending(x => x.Item2).Select(x => x.Item1).Take(3).ToList();

            return _mapper.Map<List<Model.Proizvod>>(finalResult);
        }

        public class Copurchase_prediction
        {
            public float Score { get; set; }
        }

        public class ProductEntry
        {
            [KeyType(count: 100)]
            public uint ProductID { get; set; }

            [KeyType(count: 100)]
            public uint CoPurchaseProductID { get; set; }

            public float Label { get; set; }
        }

    }
}
