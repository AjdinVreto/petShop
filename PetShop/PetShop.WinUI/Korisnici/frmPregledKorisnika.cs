using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetShop.WinUI.Korisnici
{
    public partial class frmPregledKorisnika : Form
    {
        APIService _serviceKorisnici = new APIService("Korisnik");
        public frmPregledKorisnika()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            KorisnikSearchObject request = new KorisnikSearchObject()
            {
                KorisnickoIme = txtPretraga.Text,
                Email = txtPretraga.Text,
                IncludeGrad = true,
                IncludeSpol = true
            };
            
            dgvKorisnici.DataSource = await _serviceKorisnici.Get<List<Model.Korisnik>>(request);
        }

        private async void frmPregledKorisnika_Load(object sender, EventArgs e)
        {
            //dgvKorisnici.DataSource = await _serviceKorisnici.Get<List<Model.Korisnik>>(null);
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem;

            frmDetaljiKorisnika frm = new frmDetaljiKorisnika(item as Model.Korisnik);
            frm.ShowDialog();
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            frmDetaljiKorisnika frm = new frmDetaljiKorisnika(null);
            frm.ShowDialog();
        }

        private void btnUpravljanjeProizvodima_Click(object sender, EventArgs e)
        {
            frmProizvodi frm = new frmProizvodi();
            frm.ShowDialog();
        }
    }
}
