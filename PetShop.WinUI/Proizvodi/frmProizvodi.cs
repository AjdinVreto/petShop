using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Proizvodi
{
    public partial class frmProizvodi : Form
    {
        APIService _serviceProizvodi = new APIService("Proizvod");
        APIService _serviceKategorije = new APIService("Kategorija");
        APIService _serviceProizvodjaci = new APIService("Proizvodjac");

        private Proizvod _proizvod;
        bool updateImage = false;
        public frmProizvodi()
        {
            InitializeComponent();
            dgvProizvodi.AutoGenerateColumns = false;
            _proizvod = null;
        }

        private async void frmProizvodi_Load(object sender, EventArgs e)
        {
            await LoadData();
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

        public static Bitmap ByteToImage(byte[] blob)
        {
            System.IO.MemoryStream mStream = new System.IO.MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private async Task LoadData()
        {
            await LoadKategorije();
            await LoadProizvodjaci();
            await LoadProizvodi();
        }

        private async Task LoadKategorije()
        {
            var kategorije = await _serviceKategorije.Get<List<Model.Kategorija>>(null);

            kategorije.Insert(0, new Kategorija());
            cmbKategorija.DataSource = kategorije;
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "Id";
        }

        private async Task LoadProizvodjaci()
        {
            var proizvodjaci = await _serviceProizvodjaci.Get<List<Model.Proizvodjac>>(null);

            proizvodjaci.Insert(0, new Proizvodjac());
            cmbProizvodjac.DataSource = proizvodjaci;
            cmbProizvodjac.DisplayMember = "Naziv";
            cmbProizvodjac.ValueMember = "Id";
        }

        private async Task LoadProizvodi()
        {
            dgvProizvodi.DataSource = await _serviceProizvodi.Get<List<Model.Proizvod>>();
        }

        private void dgvProizvodi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var proizvod = dgvProizvodi.SelectedRows[0].DataBoundItem as Model.Proizvod;
            _proizvod = proizvod;

            
            txtNaziv.Text = proizvod.Naziv;
            txtCijena.Text = proizvod.Cijena.ToString();
            txtOpis.Text = proizvod.Opis;
            cmbKategorija.SelectedValue = proizvod.KategorijaId;
            cmbProizvodjac.SelectedValue = proizvod.ProizvodjacId;
            if(_proizvod.Slika.Length != 0)
            {
                pbxSlika.Image = ByteToImage(_proizvod.Slika);
                pbxSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        ProizvodInsertRequest insert = new ProizvodInsertRequest();
        ProizvodUpdateRequest update = new ProizvodUpdateRequest();
        private async void btnSacuvajProizvod_Click(object sender, EventArgs e)
        {
            if (updateImage == false && _proizvod != null)
            {
                update.Slika = _proizvod.Slika;
                insert.Slika = _proizvod.Slika;
            }

            if (ValidirajUnesenePodatke())
            {
                if (cmbKategorija.SelectedValue != null && cmbProizvodjac.SelectedValue != null && (int)cmbKategorija.SelectedValue > 0 && (int)cmbProizvodjac.SelectedValue > 0)
                {
                    var kategorijaObj = cmbKategorija.SelectedValue;
                    var proizvodjacObj = cmbProizvodjac.SelectedValue;

                    if (int.TryParse(kategorijaObj.ToString(), out int kategorijaId))
                    {
                        insert.KategorijaId = kategorijaId;
                        update.KategorijaId = kategorijaId;
                    }

                    if (int.TryParse(proizvodjacObj.ToString(), out int proizvodjacId))
                    {
                        insert.ProizvodjacId = proizvodjacId;
                        update.ProizvodjacId = proizvodjacId;
                    }

                    if (decimal.TryParse(txtCijena.Text, out decimal cijena))
                    {
                        insert.Cijena = update.Cijena = cijena;
                    }

                    insert.Naziv = update.Naziv = txtNaziv.Text;
                    insert.Opis = update.Opis = txtOpis.Text;

                    if (_proizvod == null)
                    {
                        var proizvod = await _serviceProizvodi.Insert<Proizvod>(insert);
                        await LoadProizvodi();
                        MessageBox.Show("Uspješno izvršeno");
                    }
                    else
                    {
                        var proizvod = await _serviceProizvodi.Update<Proizvod>(_proizvod.Id, update);
                        await LoadProizvodi();
                        MessageBox.Show("Uspješno izvršeno");
                    }
                }
                else
                {
                    MessageBox.Show("Niste oznacili kategoriju ili proizvodjaca", "Greska",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nisu sva polja unesena", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProizvodi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private bool ValidirajUnesenePodatke()
        {
            if(string.IsNullOrEmpty(txtCijena.Text) || string.IsNullOrEmpty(txtNaziv.Text) || string.IsNullOrEmpty(txtOpis.Text))
            {
                return false;
            }

            if(insert.Slika == null)
            {
                return false;
            }

            return true;
        }
    }
}
