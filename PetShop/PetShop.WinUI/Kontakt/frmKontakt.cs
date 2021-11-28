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

namespace PetShop.WinUI.Kontakt
{
    public partial class frmKontakt : Form
    {
        APIService _serviceKontakti = new APIService("Kontakt");
        private Model.Kontakt _kontakt;
        public frmKontakt()
        {
            InitializeComponent();
            dgvKontakt.AutoGenerateColumns = false;
            txtEmail.ReadOnly = true;
            _kontakt = null;
        }

        private async void frmKontakt_Load(object sender, EventArgs e)
        {
            await LoadKontakt();
        }

        private async Task LoadKontakt()
        {
            dgvKontakt.DataSource = await _serviceKontakti.Get<List<Model.Kontakt>>(null);
        }

        private void dgvKontakt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var kontakt = dgvKontakt.SelectedRows[0].DataBoundItem as Model.Kontakt;
            _kontakt = kontakt;

            txtEmail.Text = kontakt.Email;
        }

        private async void btnOdgovor_Click(object sender, EventArgs e)
        {
            KontaktUpdateRequest request = new KontaktUpdateRequest()
            {
                Odgovoreno = true
            };

            var kontaktRequest = await _serviceKontakti.Update<Model.Kontakt>(_kontakt.Id, request);
            await LoadKontakt();
        }
    }
}
