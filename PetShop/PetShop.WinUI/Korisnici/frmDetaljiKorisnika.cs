using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Korisnici
{
    public partial class frmDetaljiKorisnika : Form
    {
        APIService _serviceKorisnici = new APIService("Korisnik");
        APIService _serviceRole = new APIService("Rola");
        APIService _serviceGrad = new APIService("Grad");
        APIService _serviceSpol = new APIService("Spol");
        APIService _serviceDrzava = new APIService("Drzava");

        private Korisnik _korisnik;
        public frmDetaljiKorisnika(Korisnik korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmDetaljiKorisnika_Load(object sender, EventArgs e)
        {
            await LoadData();
            if(_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtBrojTelefona.Text = _korisnik.BrojTelefona;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;
                txtEmail.Text = _korisnik.Email;
                txtDatumRodjenja.Text = _korisnik.DatumRodjenja;
                //test
                cmbSpol.SelectedValue = _korisnik.SpolId;
                cmbGrad.SelectedValue = _korisnik.GradId;
                cmbDrzava.SelectedValue = _korisnik.Grad.DrzavaId;
            }
        }

        private async Task LoadData()
        {
            await LoadRole();
            await LoadDrzava();
            await LoadGrad();
            await LoadSpol();
        }

        private async Task LoadRole()
        {
            var role = await _serviceRole.Get<List<Model.Rola>>(null);

            clbRole.DataSource = role;
            clbRole.DisplayMember = "Naziv";
            clbRole.ValueMember = "Id";
        }

        private async Task LoadSpol()
        {
            var spolovi = await _serviceSpol.Get<List<Model.Spol>>(null);

            spolovi.Insert(0, new Spol());
            cmbSpol.DataSource = spolovi;
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }
        private async Task LoadDrzava()
        {
            var drzave = await _serviceDrzava.Get<List<Model.Drzava>>(null);

            drzave.Insert(0, new Drzava());
            cmbDrzava.DataSource = drzave;
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "Id";
        }

        private async Task LoadGrad()
        {
            var gradovi = await _serviceGrad.Get<List<Model.Grad>>(null);

            gradovi.Insert(0, new Grad());
            cmbGrad.DataSource = gradovi;
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
        }

        private async void btnSacuvajKorisnika_Click(object sender, EventArgs e)
        {
            if(_korisnik == null)
            {
                var roleList = clbRole.CheckedItems.Cast<Rola>();
                var roleIdList = roleList.Select(x => x.Id).ToList();

                KorisnikInsertRequest request = new KorisnikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    BrojTelefona = txtBrojTelefona.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Email = txtEmail.Text,
                    DatumRodjenja = txtDatumRodjenja.Text,
                    Password = txtPassword.Text,
                    PotvrdaPassword = txtPasswordPotvrda.Text,
                    Role = roleIdList,
                    GradId = (int)cmbGrad.SelectedValue,
                    SpolId = (int)cmbSpol.SelectedValue
                };

                var korisnik = await _serviceKorisnici.Insert<Korisnik>(request);
            } 
            else
            {
                KorisnikUpdateRequest request = new KorisnikUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    BrojTelefona = txtBrojTelefona.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    GradId = (int)cmbGrad.SelectedValue
                };

                var korisnik = await _serviceKorisnici.Update<Korisnik>(_korisnik.Id, request);
            }
        }
    }
}
