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
            KomentarSearchObject request = new KomentarSearchObject()
            {

            };

            dgvKomentari.DataSource = await _serviceKomentari.Get<List<Model.Komentar>>(request);
        }
    }
}
