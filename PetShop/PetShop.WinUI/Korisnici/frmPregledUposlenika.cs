using PetShop.Model;
using PetShop.Model.Requests;
using PetShop.WinUI.Proizvodi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Korisnici
{
    public partial class frmPregledUposlenika : Form
    {
        APIService _serviceUposlenici = new APIService("Uposlenik");
        APIService _servicePoslovnice = new APIService("Poslovnica");
        APIService _serviceKorisnici = new APIService("Korisnik");
        Uposlenik _uposlenik;
        List<Korisnik> _korisnik;
        public frmPregledUposlenika()
        {
            InitializeComponent();
            dgvUposlenici.AutoGenerateColumns = false;
            _uposlenik = null;
            _korisnik = null;
        }

        private async void frmPregledUposlenika_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadPoslovnice();
        }

        private async Task LoadData()
        {
            UposlenikSearchObject request = new UposlenikSearchObject()
            {
                IncludeKorisnik = true,
                IncludePoslovnica = true
            };

            dgvUposlenici.DataSource = await _serviceUposlenici.Get<List<Model.Uposlenik>>(request);
        }

        private async Task LoadPoslovnice()
        {
            var poslovnice = await _servicePoslovnice.Get<List<Model.Poslovnica>>(null);

            poslovnice.Insert(0, new Poslovnica());
            cmbPoslovnice.DataSource = poslovnice;
            cmbPoslovnice.DisplayMember = "Adresa";
            cmbPoslovnice.ValueMember = "Id";
        }

        private async void btnSacuvajUposlenika_Click(object sender, EventArgs e)
        {
            if(_uposlenik == null)
            {
                KorisnikSearchObject request = new KorisnikSearchObject()
                {
                    KorisnickoIme = txtKorisnickoIme.Text
                };

                _korisnik = await _serviceKorisnici.Get<List<Model.Korisnik>>(request);
                int kId = _korisnik[0].Id;

                UposlenikInsertRequest requestInsert = new UposlenikInsertRequest()
                {
                    Aktivan = cbAktivan.Checked,
                    DatumZaposlenja = DateTime.ParseExact(dtpDatumZaposlenja.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null),
                    KorisnikId = kId,
                    PoslovnicaId = (int)cmbPoslovnice.SelectedValue
                };

                var uposlenik = await _serviceUposlenici.Insert<Uposlenik>(requestInsert);
            }
            else
            {
                UposlenikUpdateRequest request = new UposlenikUpdateRequest()
                {
                    Aktivan = cbAktivan.Checked,
                    DatumZaposlenja = dtpDatumZaposlenja.Value,
                    KorisnikId = _uposlenik.KorisnikId,
                    PoslovnicaId = _uposlenik.PoslovnicaId
                };

                var uposlenik = await _serviceUposlenici.Update<Uposlenik>(_uposlenik.Id, request);
            }
        }

        private void dgvUposlenici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var uposlenik = dgvUposlenici.SelectedRows[0].DataBoundItem as Model.Uposlenik;
            _uposlenik = uposlenik;

            txtKorisnickoIme.Text = _uposlenik.KorisnikKorisnickoIme;
            dtpDatumZaposlenja.Value = _uposlenik.DatumZaposlenja;
            cbAktivan.Checked = _uposlenik.Aktivan;
            cmbPoslovnice.SelectedValue = _uposlenik.PoslovnicaId;

            txtKorisnickoIme.ReadOnly = true;
        }
    }
}
