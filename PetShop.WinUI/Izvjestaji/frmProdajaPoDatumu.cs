using Microsoft.Reporting.WinForms;
using PetShop.Model;
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
    public partial class frmProdajaPoDatumu : Form
    {
        APIService _serviceTransakcija = new APIService("Transakcija");
        List<Transakcija> transakcije = null;
        List<Transakcija> transakcijeFilter = null;
        public frmProdajaPoDatumu()
        {
            InitializeComponent();
        }

        private async Task LoadData()
        {
            transakcije = await _serviceTransakcija.Get<List<Transakcija>>();
        }

        private async void frmProdajaPoDatumu_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void prikaziIzvjestaj()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            var tabela = new dsProdajaPoDatumu.NarudzbeDataTable();

            if(transakcijeFilter != null)
            {
                foreach (var item in transakcijeFilter)
                {
                    var row = tabela.NewNarudzbeRow();
                    row.Datum = item.Datum;
                    row.Iznos = item.Iznos;
                    row.NacinPlacanja = item.NacinPlacanja;
                    row.KorisnickoIme = item.Narudzba.Korisnik.KorisnickoIme;
                    tabela.Rows.Add(row);
                }
            }

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsNarudzbe";
            rds.Value = tabela;

            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private void btnPrikaziIzvjestaj_Click(object sender, EventArgs e)
        {
            var datum1 = dtpDatumOd.Value;
            var datum2 = dtpDatumDo.Value;

            transakcijeFilter = transakcije.Where(x => x.Datum.Date >= datum1.Date && x.Datum.Date <= datum2.Date).ToList();
            if(transakcijeFilter.Count == 0)
            {
                MessageBox.Show("Ne postoji nijedna kupovina izmedju oznacenih datuma");
            }
            prikaziIzvjestaj();
        }
    }
}
