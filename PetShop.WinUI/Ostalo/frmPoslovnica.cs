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

namespace PetShop.WinUI.Ostalo
{
    public partial class frmPoslovnica : Form
    {
        APIService _servicePoslovnica = new APIService("Poslovnica");
        APIService _serviceGrad = new APIService("Grad");
        private Poslovnica _poslovnica;
        public frmPoslovnica()
        {
            InitializeComponent();
            dgvPoslovnice.AutoGenerateColumns = false;
            _poslovnica = null;
        }

        private async void frmPoslovnica_Load(object sender, EventArgs e)
        {
            await LoadPoslovnica();
            await LoadGrad();
        }

        private async Task LoadPoslovnica()
        {
            PoslovnicaSearchObject request = new PoslovnicaSearchObject()
            {
                IncludeGrad = true
            };
            dgvPoslovnice.DataSource = await _servicePoslovnica.Get<List<Model.Poslovnica>>(request);
        }

        private async Task LoadGrad()
        {
            var gradovi = await _serviceGrad.Get<List<Model.Grad>>(null);

            gradovi.Insert(0, new Grad());
            cmbGrad.DataSource = gradovi;
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
        }
        private void dgvPoslovnice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var poslovnica = dgvPoslovnice.SelectedRows[0].DataBoundItem as Model.Poslovnica;
            _poslovnica = poslovnica;

            txtAdresa.Text = _poslovnica.Adresa;
            txtBrojtelefona.Text = _poslovnica.BrojTelefona;
            update.GradId = _poslovnica.GradId;
            cmbGrad.Enabled = false;
        }

        PoslovnicaInsertRequest insert = new PoslovnicaInsertRequest();
        PoslovnicaUpdateRequest update = new PoslovnicaUpdateRequest();
        private async void btnSacuvajPoslovnicu_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatke())
            {
                if ((cmbGrad.SelectedValue != null && (int)cmbGrad.SelectedValue > 0) || _poslovnica != null)
                {
                    var gradObj = cmbGrad.SelectedValue;

                    if (int.TryParse(gradObj.ToString(), out int gradId))
                    {
                        insert.GradId = gradId;
                    }

                    insert.Adresa = update.Adresa = txtAdresa.Text;
                    insert.BrojTelefona = update.BrojTelefona = txtBrojtelefona.Text;

                    if (_poslovnica == null)
                    {
                        await _servicePoslovnica.Insert<Model.Poslovnica>(insert);
                    }
                    else
                    {
                        await _servicePoslovnica.Update<Model.Poslovnica>(_poslovnica.Id, update);
                    }
                    await LoadPoslovnica();
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
                MessageBox.Show("Nisu sva polja popunjena", "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajUnesenePodatke()
        {
            if(string.IsNullOrEmpty(txtAdresa.Text) || string.IsNullOrEmpty(txtBrojtelefona.Text))
            {
                return false;
            }

            return true;
        }

        private void OcistiPolja()
        {
            _poslovnica = null;
            txtAdresa.Clear();
            txtBrojtelefona.Clear();
            cmbGrad.SelectedIndex = 0;
            cmbGrad.Enabled = true;
        }

        private void dgvPoslovnice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtBrojtelefona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
