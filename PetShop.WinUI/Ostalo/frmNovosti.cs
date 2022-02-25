using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Ostalo
{
    public partial class frmNovosti : Form
    {
        APIService _serviceNovosti = new APIService("Novost");

        private Novost _novost;
        public frmNovosti()
        {
            InitializeComponent();
            dgvNovosti.AutoGenerateColumns = false;
            _novost = null;
        }

        private async void frmNovosti_Load(object sender, EventArgs e)
        {
            await LoadNovosti();
        }
        private async Task LoadNovosti()
        {
            dgvNovosti.DataSource = await _serviceNovosti.Get<List<Model.Novost>>(null);
        }


        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;

                var file = File.ReadAllBytes(fileName);

                insert.Slika = update.Slika = file;

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

        private void dgvNovosti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var novost = dgvNovosti.SelectedRows[0].DataBoundItem as Model.Novost;
            _novost = novost;

            txtNaslov.Text = _novost.Naslov;
            txtTekst.Text = _novost.Tekst;
            if (novost.Slika.Length != 0)
            {
                pbxSlika.Image = ByteToImage(novost.Slika);
                pbxSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        NovostInsertRequest insert = new NovostInsertRequest();
        NovostUpdateRequest update = new NovostUpdateRequest();
        private async void btnDodajNovost_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatke())
            {
                insert.Naslov = update.Naslov = txtNaslov.Text;
                insert.Tekst = update.Tekst = txtTekst.Text;
                insert.Datum = update.Datum = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null);
                insert.KorisnikId = 1;

                if (_novost == null)
                {
                    await _serviceNovosti.Insert<Model.Novost>(insert);
                }
                else
                {
                    await _serviceNovosti.Update<Model.Novost>(_novost.Id, update);
                }
                await LoadNovosti();
                MessageBox.Show("Uspješno izvršeno");
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Nisu sva polja popunjena", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNovosti_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private bool ValidirajUnesenePodatke()
        {
            if(string.IsNullOrEmpty(txtNaslov.Text) || string.IsNullOrEmpty(txtTekst.Text))
            {
                return false;
            }

            if (insert.Slika == null && _novost == null)
            {
                return false;
            }

            return true;
        }

        private void OcistiPolja()
        {
            _novost = null;
            txtNaslov.Clear();
            txtTekst.Clear();
        }
    }
}
