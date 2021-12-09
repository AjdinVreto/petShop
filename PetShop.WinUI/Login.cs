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
        private readonly APIService _api = new APIService("Uposlenik");
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
                var result = await _api.Get<List<Uposlenik>>();

                frmPregledKorisnika frm = new frmPregledKorisnika(txtKorisnickoIme.Text);
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Niste administrator/uposlenik ili uneseni podaci nisu tacni !");
            }
        }
    }
}
