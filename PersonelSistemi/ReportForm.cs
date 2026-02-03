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
using PersonelSistemi.BLL;

namespace PersonelSistemi
{
    public partial class ReportForm : Form
    {
        public string GelenRol { get; set; }
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public ReportForm()
        {
            InitializeComponent();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            if (GelenRol.Trim().ToLower() != "admin")
            {
                MessageBox.Show("Raporları görüntüleme yetkiniz kısıtlıdır.");
            }
        }
        private void btnRaporuGetir_Click(object sender, EventArgs e)
        {
            dgvRaporSonuclari.DataSource = null;
            chart1.Series[0].Points.Clear();
            if (cmbRaporTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir rapor türü seçin!");
                return;
            }
            string secilen = cmbRaporTuru.SelectedItem.ToString();
            DataTable dt = new DataTable();
            try
            {
                switch (secilen)
                {
                    case "Maaş Özeti":
                        dt = personelBll.RaporMaasOzeti();
                        break;
                    case "İzin Hakediş":
                        dt = personelBll.RaporIzinHakedis();
                        break;
                    case "Performans Analizi":
                        dt = personelBll.PerformansRaporuGetir(true);
                        break;
                    case "Departman Dağılımı":
                        dt = personelBll.RaporDepartmanDagilimi();
                        break;
                    case "İzin Raporu":
                        dt = personelBll.RaporTarihliIzinler(dtpBaslangic.Value, dtpBitis.Value);                     
                        break;
                }
                dgvRaporSonuclari.DataSource = dt;
                if (dt != null && dt.Rows.Count > 0)
                {
                    GrafikDoldur(dt, secilen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor hatası: " + ex.Message);
            }
        }
        private void GrafikDoldur(DataTable dt, string raporTuru)
        {
            chart1.Series.Clear();
            var seri = chart1.Series.Add(raporTuru);
            seri.ChartType = SeriesChartType.Pie;
            seri.Label = "#VALX - #VALY";
            if (chart1.Legends.Count > 0) chart1.Legends[0].Enabled = true;
            foreach (DataRow satir in dt.Rows)
            {
                try
                {
                    string baslik = satir[0].ToString();
                    double deger = 0;
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        if (double.TryParse(satir[i].ToString(), out deger))
                        {
                            break;
                        }
                    }
                    if (!string.IsNullOrEmpty(baslik))
                    {
                        seri.Points.AddXY(baslik, deger);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Satır hatası: " + ex.Message);
                }
            }
            chart1.Invalidate();
        }
    }
}
