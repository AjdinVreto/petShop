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
    public partial class frmPregledKategorija : Form
    {
        APIService _serviceKategorije = new APIService("Kategorija");
        public frmPregledKategorija()
        {
            InitializeComponent();
            dgvKategorije.AutoGenerateColumns = false;
        }

        private async void frmPregledKategorija_Load(object sender, EventArgs e)
        {
            await LoadKategorija();
        }

        public async Task LoadKategorija()
        {
            dgvKategorije.DataSource = await _serviceKategorije.Get<List<Model.Kategorija>>(null);
        }

        private async void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            KategorijaInsertRequest request = new KategorijaInsertRequest()
            {
                Naziv = txtNazivKategorije.Text
            };

            var _kategorija = await _serviceKategorije.Insert<Kategorija>(request);
            await LoadKategorija();
        }
    }
}
