using PetShop.Model.Requests;
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
        }

        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            KorisnikSearchObject request = new KorisnikSearchObject()
            {
                KorisnickoIme = txtPretraga.Text,
                Email = txtPretraga.Text
            };
            
            dgvKorisnici.DataSource = await _serviceKorisnici.Get<List<Model.Korisnik>>(request);
        }

        private async void frmPregledKorisnika_Load(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = await _serviceKorisnici.Get<List<Model.Korisnik>>(null);
        }
    }
}
