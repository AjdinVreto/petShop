using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.WinUI.Izvjestaji
{
    public partial class frmOdabirIzvjestaja : Form
    {
        public frmOdabirIzvjestaja()
        {
            InitializeComponent();
        }

        private void btnProdajaPoDatumu_Click(object sender, EventArgs e)
        {
            frmProdajaPoDatumu forma = new frmProdajaPoDatumu();
            forma.ShowDialog();
        }

        private void btnTopKorisnici_Click(object sender, EventArgs e)
        {
            frmTopKorisnici forma = new frmTopKorisnici();
            forma.ShowDialog();
        }

        private void btnPorastPadKupovine_Click(object sender, EventArgs e)
        {
            frmPorastPadProdaje forma = new frmPorastPadProdaje();
            forma.ShowDialog();
        }
    }
}
