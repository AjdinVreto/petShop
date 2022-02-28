using Microsoft.Reporting.WinForms;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Izvjestaji
{
    public partial class frmTopKorisnici : Form
    {
        APIService _serviceTransakcija = new APIService("Transakcija");
        List<Transakcija> transakcije = null;
        public frmTopKorisnici()
        {
            InitializeComponent();
        }

        private async Task LoadData()
        {
            transakcije = await _serviceTransakcija.Get<List<Transakcija>>();
        }

        private async void frmTopKorisnici_Load(object sender, EventArgs e)
        {
            await LoadData();
            prikaziIzvjestaj();
        }

        private void prikaziIzvjestaj()
        {
            var tList = transakcije.GroupBy(x => x.Narudzba.KorisnikId).Select(g => new Transakcija{Narudzba = g.First().Narudzba,Iznos = g.Sum(s => s.Iznos)}).ToList();
            tList = tList.OrderByDescending(x => x.Iznos).Take(3).ToList();

            reportViewer1.LocalReport.DataSources.Clear();
            var tabela = new dsTopKorisnici.TopKorisniciDataTable();

            foreach (var item in tList)
            {
                var row = tabela.NewTopKorisniciRow();
                row.Ime = item.Narudzba.Korisnik.Ime;
                row.Prezime = item.Narudzba.Korisnik.Prezime;
                row.Email = item.Narudzba.Korisnik.Email;
                row.KorisnickoIme = item.Narudzba.Korisnik.KorisnickoIme;
                row.UkupnoPotroseno = item.Iznos;
                tabela.Rows.Add(row);
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsKorisnici";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
