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
    public partial class frmKomentar : Form
    {
        APIService _serviceKomentari = new APIService("Komentar");
        public frmKomentar()
        {
            InitializeComponent();
            dgvKomentari.AutoGenerateColumns = false;
        }

        private async void frmKomentar_Load(object sender, EventArgs e)
        {
            await LoadKomentari();
        }

        private async Task LoadKomentari()
        {
            dgvKomentari.DataSource = await _serviceKomentari.Get<List<Model.Komentar>>();
        }

        private void dgvKomentari_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private async void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var komentar = dgvKomentari.SelectedRows[0].DataBoundItem as Model.Komentar;

                if (MessageBox.Show("Da li zelite obrisati komentar ?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _serviceKomentari.Delete<Komentar>(komentar.Id);
                }

                await LoadKomentari();
            }
        }
    }
}
