using PetShop.Model;
using PetShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Proizvodi
{
    public partial class frmPregledKategorija : Form
    {
        APIService _serviceKategorije = new APIService("Kategorija");
        public frmPregledKategorija()
        {
            InitializeComponent();
            dgvKategorije.AutoGenerateColumns = false;
        }

        private async void frmPregledKategorija_Load(object sender, EventArgs e)
        {
            await LoadKategorija();
        }

        public async Task LoadKategorija()
        {
            dgvKategorije.DataSource = await _serviceKategorije.Get<List<Model.Kategorija>>(null);
        }

        KategorijaInsertRequest insert = new KategorijaInsertRequest();
        private async void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatke())
            {
                insert.Naziv = txtNazivKategorije.Text;

                await _serviceKategorije.Insert<Kategorija>(insert);
                await LoadKategorija();
                MessageBox.Show("Uspješno izvršeno");
                OcistiPolja();
            }
            else
            {
                MessageBox.Show("Nisu sva polja popunjena", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void dgvKategorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var kategorija = dgvKategorije.SelectedRows[0].DataBoundItem as Model.Kategorija;

                if (MessageBox.Show("Brisanje kategorije brise i proizvode sa ovom kategorijom. Da li zelite obrisati","Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _serviceKategorije.Delete<Kategorija>(kategorija.Id);
                }

                await LoadKategorija();
            }
        }

        private bool ValidirajUnesenePodatke()
        {
            if (string.IsNullOrEmpty(txtNazivKategorije.Text))
            {
                return false;
            }

            return true;
        }

        private void OcistiPolja()
        {
            txtNazivKategorije.Clear();
        }

        private void dgvKategorije_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
