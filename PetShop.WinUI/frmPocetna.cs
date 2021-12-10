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
using System.Windows.Forms;

namespace PetShop.WinUI
{
    public partial class frmPocetna : Form
    {
        string logKorisnickoIme;
        public frmPocetna(string _logKorisnickoIme = null)
        {
            InitializeComponent();
            logKorisnickoIme = _logKorisnickoIme;
        }

        private void btnUpravljanjeKorisnicima_Click(object sender, EventArgs e)
        {
            frmPregledKorisnika frm = new frmPregledKorisnika();
            frm.ShowDialog();
        }

        private void btnUpravljanjeUposlenicima_Click(object sender, EventArgs e)
        {
            frmPregledUposlenika frm = new frmPregledUposlenika(logKorisnickoIme);
            frm.ShowDialog();
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
    }
}
