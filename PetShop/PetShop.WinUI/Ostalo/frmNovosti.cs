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
        APIService _serviceKorisnik = new APIService("Korisnik");

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
                var filename = ofdSlika.FileName;
                var file = File.ReadAllBytes(filename);

                pbxSlika.Image = Image.FromFile(filename);
            }
        }
        private void dgvNovosti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var novost = dgvNovosti.SelectedRows[0].DataBoundItem as Model.Novost;
            _novost = novost;

            txtNaslov.Text = _novost.Naslov;
            txtTekst.Text = _novost.Tekst;
        }

        private async void btnDodajNovost_Click(object sender, EventArgs e)
        {
            if(_novost == null)
            {
                NovostInsertRequest request = new NovostInsertRequest()
                {
                    Naslov = txtNaslov.Text,
                    Tekst = txtTekst.Text,
                    Datum = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null),
                    KorisnikId = 1
                };

                var novost = await _serviceNovosti.Insert<Model.Novost>(request);
            }
            else
            {
                NovostUpdateRequest request = new NovostUpdateRequest()
                {
                    Naslov = txtNaslov.Text,
                    Tekst = txtTekst.Text,
                    Datum = DateTime.ParseExact(DateTime.Now.ToString("dd/MM/yyyy"), "dd/MM/yyyy", null)
                };

                var novost = await _serviceNovosti.Update<Model.Novost>(_novost.Id, request);
            }
        }
    }
}
