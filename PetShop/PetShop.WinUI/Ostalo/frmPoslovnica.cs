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
            cmbGrad.SelectedValue = _poslovnica.GradId;
        }

        private async void btnSacuvajPoslovnicu_Click(object sender, EventArgs e)
        {
            if(_poslovnica == null)
            {
                PoslovnicaInsertRequest request = new PoslovnicaInsertRequest()
                {
                    Adresa = txtAdresa.Text,
                    BrojTelefona = txtBrojtelefona.Text,
                    GradId = (int)cmbGrad.SelectedValue
                };

                var poslovnica = await _servicePoslovnica.Insert<Model.Poslovnica>(request);
                await LoadPoslovnica();
            }
            else
            {
                PoslovnicaUpdateRequest request = new PoslovnicaUpdateRequest()
                {
                    Adresa = txtAdresa.Text,
                    BrojTelefona = txtBrojtelefona.Text,
                    GradId = (int)cmbGrad.SelectedValue
                };

                var poslovnica = await _servicePoslovnica.Update<Model.Poslovnica>(_poslovnica.Id, request);
                await LoadPoslovnica();
            }
        }
    }
}
