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
    public partial class frmPregledProizvodjaca : Form
    {
        APIService _serviceProizvodjaci = new APIService("Proizvodjac");
        APIService _serviceDrzave = new APIService("Drzava");
        public frmPregledProizvodjaca()
        {
            InitializeComponent();
            dgvProizvodjaci.AutoGenerateColumns = false;
        }

        private async void frmPregledProizvodjaca_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadProizvodjaci();
            await LoadDrzave();
        }

        private async Task LoadProizvodjaci()
        {
            ProizvodjacSearchObject search = new ProizvodjacSearchObject()
            {
                IncludeDrzava = true
            };

            dgvProizvodjaci.DataSource = await _serviceProizvodjaci.Get<List<Model.Proizvodjac>>(search);
        }

        private async Task LoadDrzave()
        {
            var _drzave = await _serviceDrzave.Get<List<Model.Drzava>>(null);

            _drzave.Insert(0, new Drzava());
            cmbDrzave.DataSource = _drzave;
            cmbDrzave.DisplayMember = "Naziv";
            cmbDrzave.ValueMember = "Id";
        }

        ProizvodjacInsertRequest insert = new ProizvodjacInsertRequest();
        private async void btnDodajProizvodjaca_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatke())
            {
                if(cmbDrzave.SelectedValue != null && (int)cmbDrzave.SelectedValue > 0)
                {
                    insert.Naziv = txtNazivProizvodjaca.Text;
                    insert.DrzavaId = (int)cmbDrzave.SelectedValue;

                    await _serviceProizvodjaci.Insert<Model.Proizvodjac>(insert);
                    await LoadProizvodjaci();
                    MessageBox.Show("Uspješno izvršeno");
                    OcistiPolja();
                }
                else
                {
                    MessageBox.Show("Niste označili grad", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nisu sva polja unesena", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajUnesenePodatke()
        {
            if (string.IsNullOrEmpty(txtNazivProizvodjaca.Text))
            {
                return false;
            }

            return true;
        }

        private void OcistiPolja()
        {
            txtNazivProizvodjaca.Clear();
        }

        private void dgvProizvodjaci_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
