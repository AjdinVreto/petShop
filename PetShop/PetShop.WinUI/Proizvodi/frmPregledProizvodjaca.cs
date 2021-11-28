using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Proizvodi
{
    public partial class frmPregledProizvodjaca : Form
    {
        APIService _serviceProizvodjaci = new APIService("Proizvodjac");
        APIService _serviceDrzave = new APIService("Drzava");
        public frmPregledProizvodjaca()
        {
            InitializeComponent();
            dgvProizvodjaci.AutoGenerateColumns = false;
        }

        private async void frmPregledProizvodjaca_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadProizvodjaci();
            await LoadDrzave();
        }

        private async Task LoadProizvodjaci()
        {
            ProizvodjacSearchObject search = new ProizvodjacSearchObject()
            {
                IncludeDrzava = true
            };

            dgvProizvodjaci.DataSource = await _serviceProizvodjaci.Get<List<Model.Proizvodjac>>(search);
        }

        private async Task LoadDrzave()
        {
            var _drzave = await _serviceDrzave.Get<List<Model.Drzava>>(null);

            _drzave.Insert(0, new Drzava());
            cmbDrzave.DataSource = _drzave;
            cmbDrzave.DisplayMember = "Naziv";
            cmbDrzave.ValueMember = "Id";
        }

        private async void btnDodajProizvodjaca_Click(object sender, EventArgs e)
        {
            ProizvodjacInsertRequest request = new ProizvodjacInsertRequest()
            {
                Naziv = txtNazivProizvodjaca.Text,
                DrzavaId = (int)cmbDrzave.SelectedValue
            };

            var proizvodjac = await _serviceProizvodjaci.Insert<Model.Proizvodjac>(request);
            await LoadProizvodjaci();
        }
    }
}
