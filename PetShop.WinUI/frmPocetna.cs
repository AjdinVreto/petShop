using PetShop.Model;
using PetShop.WinUI.Kontakt;
using PetShop.WinUI.Korisnici;
using PetShop.WinUI.Ostalo;
using PetShop.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI
{
    public partial class frmPocetna : Form
    {
        APIService _serviceKorisnici = new APIService("Korisnik");
        APIService _serviceKorisnikRola = new APIService("KorisnikRola");

        List<Korisnik> _korisnici;
        List<KorisnikRola> _korisnikRola;

        string logKorisnickoIme;
        int logKorisnikId = 0;
        bool provjeraAdmin = false;
        public frmPocetna(string _logKorisnickoIme = null)
        {
            InitializeComponent();
            logKorisnickoIme = _logKorisnickoIme;
        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            if (provjeraAdmin) 
            {
                frmPregledKorisnika frm = new frmPregledKorisnika();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste autorizirani za ovu akciju, samo administratori", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpravljanjeUposlenicima_Click(object sender, EventArgs e)
        {
            if (provjeraAdmin) 
            {
                frmPregledUposlenika frm = new frmPregledUposlenika(provjeraAdmin);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste autorizirani za ovu akciju, samo administratori", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpravljanjeProizvodima_Click(object sender, EventArgs e)
        {
            frmProizvodi frm = new frmProizvodi();
            frm.ShowDialog();
        }

        private void btnKategorije_Click(object sender, EventArgs e)
        {
            frmPregledKategorija frm = new frmPregledKategorija();
            frm.ShowDialog();
        }

        private void btnProizvodjaci_Click(object sender, EventArgs e)
        {
            frmPregledProizvodjaca frm = new frmPregledProizvodjaca();
            frm.ShowDialog();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmKontakt frm = new frmKontakt();
            frm.ShowDialog();
        }

        private void btnPoslovnice_Click(object sender, EventArgs e)
        {
            frmPoslovnica frm = new frmPoslovnica();
            frm.ShowDialog();
        }

        private void btnNovosti_Click(object sender, EventArgs e)
        {
            frmNovosti frm = new frmNovosti();
            frm.ShowDialog();
        }

        private void btnKomentari_Click(object sender, EventArgs e)
        {
            frmKomentar frm = new frmKomentar();
            frm.ShowDialog();
        }

        private void btnPopustKupon_Click(object sender, EventArgs e)
        {
            if (provjeraAdmin) 
            {
                frmPopustKuponi frm = new frmPopustKuponi(provjeraAdmin);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste autorizirani za ovu akciju, samo administratori", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmPocetna_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            _korisnici = await _serviceKorisnici.Get<List<Model.Korisnik>>(null);
            _korisnikRola = await _serviceKorisnikRola.Get<List<Model.KorisnikRola>>(null);

            foreach (var item in _korisnici)
            {
                if (item.KorisnickoIme.Equals(logKorisnickoIme))
                {
                    logKorisnikId = item.Id;
                }
            }

            foreach (var item in _korisnikRola)
            {
                if (item.KorisnikId == logKorisnikId)
                {
                    if (item.Rola.Naziv.Equals("Administrator"))
                    {
                        provjeraAdmin = true;
                    }
                }
            }

        }
    }
}
