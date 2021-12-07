using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.WinUI.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetShop.WinUI
{
    public partial class Login : Form
    {
        private readonly APIService _api = new APIService("Korisnik");
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtKorisnickoIme.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                KorisnikSearchObject request = new KorisnikSearchObject()
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    AdminChecked = true
                };
 
                var result = await _api.Get<List<Korisnik>>(request);

                frmPregledKorisnika frm = new frmPregledKorisnika();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Niste administrator ili uneseni podaci nisu tacni !");
            }
        }
    }
}
