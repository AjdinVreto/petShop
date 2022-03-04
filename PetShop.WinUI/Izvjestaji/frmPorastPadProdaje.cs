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
using System.Windows.Forms.DataVisualization.Charting;

namespace PetShop.WinUI.Izvjestaji
{
    public partial class frmPorastPadProdaje : Form
    {
        APIService _serviceTransakcija = new APIService("Transakcija");
        List<Transakcija> transakcije = null;
        enum mjeseci { Jan = 1, Feb, Mar, Apr, Maj, Jun, Jul, Aug, Sep, Okt, Nov, Dec };
        public frmPorastPadProdaje()
        {
            InitializeComponent();
        }

        private async void frmPorastPadProdaje_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            transakcije = await _serviceTransakcija.Get<List<Transakcija>>();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGodina.Text))
            {
                //Priprema podataka za prikaz
                int god = int.Parse(txtGodina.Text);
                var tList = transakcije.Where(x => x.Datum.Year == god).GroupBy(y => y.Datum.Month).Select(z => z.Count()).ToList();

                string godina = txtGodina.Text;

                if(tList.Count == 0)
                {
                    MessageBox.Show("Ne postoje podaci za unesenu godinu");
                }


                if (tList.Count < 12)
                {
                    for (int i = tList.Count; i <= 11; i++)
                    {
                        tList.Add(0);
                    }
                }

                var label = new[] { "Jan", "Feb", "Mar", "Apr", "Maj", "Jun", "Jul", "Aug", "Sep", "Okt", "Nov", "Dec" };

                var objChart = chart.ChartAreas[0];

                // X osa
                objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisX.Title = "Mjesec";
                double startOffset = 0.5;
                double endOffset = 1.5;
                foreach (string name in label)
                {
                    CustomLabel monthLabel = new CustomLabel(startOffset, endOffset, name, 0, LabelMarkStyle.None);
                    objChart.AxisX.CustomLabels.Add(monthLabel);
                    startOffset = startOffset + 1;
                    endOffset = endOffset + 1;
                }

                //Y Osa
                objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisY.Title = "Broj narudzbi";
                objChart.AxisY.Minimum = 0;
                objChart.AxisY.Maximum = 10;

                chart.Series.Clear();

                //Ucitavanje podataka na linijski graf
                chart.Series.Add(godina);
                chart.Series[godina].Color = Color.Red;
                chart.Series[godina].Legend = "Legend1";
                chart.Series[godina].ChartArea = "ChartArea1";
                chart.Series[godina].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 1; i <= 12; i++)
                {
                    chart.Series[godina].Points.AddXY(i, tList[i - 1]);
                }
            }else
            {
                MessageBox.Show("Niste unijeli godinu");
            }
        }

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
