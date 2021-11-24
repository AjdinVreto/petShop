using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        APIService _serviceProizvodi = new APIService("Proizvod");
        APIService _serviceKategorije = new APIService("Kategorija");
        APIService _serviceProizvodjaci = new APIService("Proizvodjac");

        private Proizvod _proizvod;
        public frmProizvodi()
        {
            InitializeComponent();
            dgvProizvodi.AutoGenerateColumns = false;
            _proizvod = null;
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadData();

            ProizvodSearchObject search = new ProizvodSearchObject();
            search.IncludeKategorija = true;
            search.IncludeProizvodjac = true;
            dgvProizvodi.DataSource = await _serviceProizvodi.Get<List<Model.Proizvod>>(search);
        }

        private async Task LoadData()
        {
            await LoadKategorije();
            await LoadProizvodjaci();
        }

        private async Task LoadKategorije()
        {
            var kategorije = await _serviceKategorije.Get<List<Model.Kategorija>>(null);

            kategorije.Insert(0, new Kategorija());
            cmbKategorija.DataSource = kategorije;
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "Id";
        }

        private async Task LoadProizvodjaci()
        {
            var proizvodjaci = await _serviceProizvodjaci.Get<List<Model.Proizvodjac>>(null);

            proizvodjaci.Insert(0, new Proizvodjac());
            cmbProizvodjac.DataSource = proizvodjaci;
            cmbProizvodjac.DisplayMember = "Naziv";
            cmbProizvodjac.ValueMember = "Id";
        }

        private void dgvProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var proizvod = dgvProizvodi.SelectedRows[0].DataBoundItem as Model.Proizvod;
            _proizvod = proizvod;

            txtNaziv.Text = proizvod.Naziv;
            txtCijena.Text = proizvod.Cijena.ToString();
            txtOpis.Text = proizvod.Opis;
            cmbKategorija.SelectedValue = proizvod.KategorijaId;
            cmbProizvodjac.SelectedValue = proizvod.ProizvodjacId;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();

            if (result == DialogResult.OK)
            {
                var filename = ofdSlika.FileName;
                var file = File.ReadAllBytes(filename);

                pbxSlika.Image = Image.FromFile(filename);
            }
        }

        private async void btnSacuvajProizvod_Click(object sender, EventArgs e)
        {
           // CultureInfo culture = new CultureInfo("en-US");
            //Convert.ToDecimal(txtCijena.Text, culture)

            if (_proizvod == null)
            {
                ProizvodInsertRequest request = new ProizvodInsertRequest()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = decimal.Parse(txtCijena.Text),
                    Opis = txtOpis.Text,
                    KategorijaId = (int)cmbKategorija.SelectedValue,
                    ProizvodjacId = (int)cmbProizvodjac.SelectedValue
                };

                var proizvod = await _serviceProizvodi.Insert<Proizvod>(request);
            }
            else
            {
                ProizvodUpdateRequest request = new ProizvodUpdateRequest()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = decimal.Parse(txtCijena.Text),
                    Opis = txtOpis.Text,
                    KategorijaId = (int)cmbKategorija.SelectedValue,
                    ProizvodjacId = (int)cmbProizvodjac.SelectedValue
                };

                var korisnik = await _serviceProizvodi.Update<Proizvod>(_proizvod.Id, request);
            }
        }
    }
}
