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
        APIService _serviceKorisnikRola = new APIService("KorisnikRola");

        Uposlenik _uposlenik;
        List<Korisnik> _korisnik;
        List<Korisnik> _korisnici;
        List<KorisnikRola> _korisnikRola;
        List<Uposlenik> _uposlenici;

        bool provjeraAdmin;

        public frmPregledUposlenika(bool _provjeraAdmin)
        {
            InitializeComponent();
            dgvUposlenici.AutoGenerateColumns = false;
            _uposlenik = null;
            _korisnik = null;
            _korisnikRola = null;
            _uposlenici = null;
            _korisnici = null;
            provjeraAdmin = _provjeraAdmin;
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

            _korisnikRola = await _serviceKorisnikRola.Get<List<Model.KorisnikRola>>(null);
            _uposlenici = await _serviceUposlenici.Get<List<Model.Uposlenik>>(request);
            _korisnici = await _serviceKorisnici.Get<List<Model.Korisnik>>(null);

            dgvUposlenici.DataSource = _uposlenici;
        }

        private async Task LoadPoslovnice()
        {
            var poslovnice = await _servicePoslovnice.Get<List<Model.Poslovnica>>(null);

            poslovnice.Insert(0, new Poslovnica());
            cmbPoslovnice.DataSource = poslovnice;
            cmbPoslovnice.DisplayMember = "Adresa";
            cmbPoslovnice.ValueMember = "Id";
        }

        UposlenikInsertRequest insert = new UposlenikInsertRequest();
        UposlenikUpdateRequest update = new UposlenikUpdateRequest();
        private async void btnSacuvajUposlenika_Click(object sender, EventArgs e)
        {
            KorisnikSearchObject request = new KorisnikSearchObject()
            {
                KorisnickoIme = txtKorisnickoIme.Text
            };

            if (ValidirajUnesenePodatke())
            {
                _korisnik = await _serviceKorisnici.Get<List<Model.Korisnik>>(request);

                if (cmbPoslovnice.SelectedValue != null)
                {
                    var poslovnicaObj = cmbPoslovnice.SelectedValue;

                    if (int.TryParse(poslovnicaObj.ToString(), out int poslovnicaId))
                    {
                        insert.PoslovnicaId = poslovnicaId;
                        update.PoslovnicaId = poslovnicaId;
                    }

                    insert.Aktivan = update.Aktivan = cbAktivan.Checked;
                    insert.DatumZaposlenja = update.DatumZaposlenja = DateTime.ParseExact(dtpDatumZaposlenja.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);

                    if ((int)poslovnicaObj == 0)
                    {
                        MessageBox.Show("Niste oznacili poslovnicu", "Greska",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (provjeraAdmin)
                        {
                            if (_uposlenik == null)
                            {
                                if (ValidirajUposlenika())
                                {
                                    insert.KorisnikId = _korisnik[0].Id;

                                    var uposlenik = await _serviceUposlenici.Insert<Uposlenik>(insert);
                                    await LoadData();

                                    MessageBox.Show("Uspješno izvršeno");
                                }
                                else
                                {
                                    MessageBox.Show("Uneseni korisnik nije uposlenik ili vec postoji", "Greska",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                update.KorisnikId = _uposlenik.KorisnikId;

                                var uposlenik = await _serviceUposlenici.Update<Uposlenik>(_uposlenik.Id, update);
                                await LoadData();

                                MessageBox.Show("Uspješno izvršeno");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Niste autorizirani za ovu akciju, samo administratori");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Niste oznacili poslovnicu", "Greska",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Korisnicko ime uposlenika nije uneseno ili ne postoji", "Greska",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValidirajUnesenePodatke()
        {
            bool postojiKorisnik = false;

            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                return false;
            }

            foreach (var item in _korisnici)
            {
                if (item.KorisnickoIme.Equals(txtKorisnickoIme.Text))
                {
                    postojiKorisnik = true;
                }
            }

            if (!postojiKorisnik)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidirajUposlenika()
        {
            bool provjeraUposlenik = false;

            foreach(var item in _uposlenici)
            {
                if (item.Korisnik.KorisnickoIme.Equals(txtKorisnickoIme.Text))
                {
                    return false;
                }
            }

            foreach(var item in _korisnikRola)
            {
                if(item.KorisnikId == _korisnik[0].Id)
                {
                    if (item.Rola.Naziv.Equals("Uposlenik"))
                    {
                        provjeraUposlenik = true;
                    }
                }
            }

            if(!provjeraUposlenik)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dgvUposlenici_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
