using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<Korisnik> _korisnici;
        bool updateImage = false;
        public frmDetaljiKorisnika(Korisnik korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmDetaljiKorisnika_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadRole();
            await LoadDrzava();
            await LoadGrad();
            await LoadSpol();
            await LoadKorisnici();
            LoadKorisnik();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;

                var file = File.ReadAllBytes(fileName);

                insert.Slika = update.Slika = file;
                updateImage = true;

                Image image = Image.FromFile(fileName);

                pbxSlika.Image = image;
                pbxSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoadKorisnik()
        {
            if (_korisnik != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;
                txtEmail.Text = _korisnik.Email;
                dtpDatumRodjenja.Value = _korisnik.DatumRodjenja;
                //test
                cmbSpol.SelectedValue = _korisnik.SpolId;
                cmbGrad.SelectedValue = _korisnik.GradId;
                cmbDrzava.SelectedValue = _korisnik.Grad.DrzavaId;
                if (_korisnik.Slika.Length != 0)
                {
                    pbxSlika.Image = ByteToImage(_korisnik.Slika);
                    pbxSlika.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                txtIme.ReadOnly = true;
                txtPrezime.ReadOnly = true;
                dtpDatumRodjenja.Enabled = false;
                txtPassword.ReadOnly = true;
                txtPasswordPotvrda.ReadOnly = true;
                clbRole.Enabled = false;
            }
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

        private async Task LoadKorisnici()
        {
            _korisnici = await _serviceKorisnici.Get<List<Model.Korisnik>>(null);
        }

        KorisnikInsertRequest insert = new KorisnikInsertRequest();
        KorisnikUpdateRequest update = new KorisnikUpdateRequest();

        private async void btnSacuvajKorisnika_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatke() && ValidirajEmailIKorisnickoIme())
            {
                if (cmbGrad.SelectedValue != null && cmbSpol.SelectedValue != null && (int)cmbGrad.SelectedValue > 0 && (int)cmbSpol.SelectedValue > 0)
                {
                    var gradObj = cmbGrad.SelectedValue;
                    var spolObj = cmbSpol.SelectedValue;

                    if (int.TryParse(gradObj.ToString(), out int gradId))
                    {
                        insert.GradId = gradId;
                        update.GradId = gradId;
                    }

                    if (int.TryParse(spolObj.ToString(), out int spolId))
                    {
                        insert.SpolId = spolId;
                    }

                    insert.Ime = txtIme.Text;
                    insert.Prezime = txtPrezime.Text;
                    insert.KorisnickoIme = update.KorisnickoIme = txtKorisnickoIme.Text;
                    insert.Email = update.Email = txtEmail.Text;
                    insert.DatumRodjenja = DateTime.ParseExact(dtpDatumRodjenja.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
                    insert.Password = txtPassword.Text;
                    insert.PotvrdaPassword = txtPasswordPotvrda.Text;

                    var roleList = clbRole.CheckedItems.Cast<Rola>();
                    var roleIdList = roleList.Select(x => x.Id).ToList();
                    insert.Role = roleIdList;

                    if (_korisnik == null)
                    {
                        if (roleIdList.Count > 0)
                        {
                            var korisnik = await _serviceKorisnici.Insert<Korisnik>(insert);
                            MessageBox.Show("Uspješno izvršeno");
                        }
                        else
                        {
                            MessageBox.Show("Niste odabrali rolu", "Greška",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (ValidirajUpdateEmailIKorisnickoIme())
                        {
                            if (updateImage == false)
                            {
                                update.Slika = _korisnik.Slika;
                            }
                            var korisnik = await _serviceKorisnici.Update<Korisnik>(_korisnik.Id, update);
                            MessageBox.Show("Uspješno izvršeno");
                        }
                        else
                        {
                            MessageBox.Show("Email ili korisničko ime već postoji", "Greška",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Niste označili grad ili spol", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!ValidirajEmailIKorisnickoIme())
                {
                    MessageBox.Show("Korisničko ime ili email već postoji", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nisu sva polja popunjena", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidirajEmailIKorisnickoIme()
        {
            foreach (var item in _korisnici)
            {
                if ((item.KorisnickoIme.Equals(txtKorisnickoIme.Text) || item.Email.Equals(txtEmail.Text)) && _korisnik == null)
                {
                    return false;
                }
            }

            return true;
        }

        private bool ValidirajUnesenePodatke()
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || dtpDatumRodjenja.Value == null ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                return false;
            }

            return true;
        }

        private bool ValidirajUpdateEmailIKorisnickoIme()
        {
            foreach(var item in _korisnici)
            {
                if ((item.Email.Equals(txtEmail.Text) || item.KorisnickoIme.Equals(txtKorisnickoIme.Text)) && item.Id != _korisnik.Id)
                {
                    return false;
                }
            }

            return true;
        }

        private async void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cmbDrzava.SelectedValue;

            if (int.TryParse(selectedIndex.ToString(), out int id))
            {
                if (id > 0)
                {
                    GradSearchObject request = new GradSearchObject()
                    {
                        Id = id
                    };

                    var gradoviFilter = await _serviceGrad.Get<List<Model.Grad>>(request);

                    cmbGrad.DataSource = gradoviFilter;
                    cmbGrad.DisplayMember = "Naziv";
                    cmbGrad.ValueMember = "Id";
                }
            }
        }
    }
}
