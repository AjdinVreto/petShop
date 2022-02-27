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
    public partial class frmPopustKuponi : Form
    {
        APIService _servicePopustKupon = new APIService("PopustKupon");

        private PopustKupon _popustKupon;
        bool provjeraAdmin;
        public frmPopustKuponi(bool _provjeraAdmin)
        {
            InitializeComponent();
            dgvPopustKuponi.AutoGenerateColumns = false;
            _popustKupon = null;
            provjeraAdmin = _provjeraAdmin;
        }

        private async void frmPopustKuponi_Load(object sender, EventArgs e)
        {
            await LoadPopustKuponi();
        }

        private async Task LoadPopustKuponi()
        {
            dgvPopustKuponi.DataSource = await _servicePopustKupon.Get<List<Model.PopustKupon>>(null);
        }

        private void dgvPopustKuponi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var popustKupon = dgvPopustKuponi.SelectedRows[0].DataBoundItem as Model.PopustKupon;
            _popustKupon = popustKupon;

            txtIznos.Text = _popustKupon.Iznos.ToString();
            txtKod.Text = _popustKupon.Kod;
            txtKod.Enabled = false;
        }

        PopustKuponInsertRequest insert = new PopustKuponInsertRequest();
        PopustKuponUpdateRequest update = new PopustKuponUpdateRequest();

        private async void btnDodajPopustKupon_Click(object sender, EventArgs e)
        {
            if (ValidirajUnesenePodatke())
            {
                if (provjeraAdmin)
                {
                    insert.Iznos = update.Iznos = int.Parse(txtIznos.Text);
                    insert.Kod = txtKod.Text;

                    if(_popustKupon == null)
                    {
                        await _servicePopustKupon.Insert<Model.PopustKupon>(insert);
                    }
                    else
                    {
                        await _servicePopustKupon.Update<Model.PopustKupon>(_popustKupon.Id, update);
                    }
                    await LoadPopustKuponi();
                    MessageBox.Show("Uspješno izvršeno");
                    OcistiPolja();

                }
                else
                {
                    MessageBox.Show("Niste autorizirani za ovu akciju, samo administratori", "Greška",
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
            if (string.IsNullOrEmpty(txtIznos.Text) || string.IsNullOrEmpty(txtKod.Text))
            {
                return false;
            }

            

            return true;
        }

        private void OcistiPolja()
        {
            _popustKupon = null;
            txtIznos.Clear();
            txtKod.Clear();
            txtKod.Enabled = true;
        }

        private void dgvPopustKuponi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void txtIznos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
