using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelSistemi.BLL;

namespace PersonelSistemi
{
    public partial class SalaryForm : Form
    {
        PersonelIslemleri personelBll = new PersonelIslemleri();
        public SalaryForm()
        {
            InitializeComponent();
        }
        private decimal sonHesaplananNetMaas = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double brut = double.Parse(txtBrutMaas.Text == "" ? "0" : txtBrutMaas.Text);
                double prim = double.Parse(txtPrim.Text == "" ? "0" : txtPrim.Text);
                double kesinti = double.Parse(txtKesinti.Text == "" ? "0" : txtKesinti.Text);
                double netMaas = brut + prim - kesinti;
                lblNetMaas.Text = netMaas.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen sadece sayısal değerler giriniz!");
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPersoneller.SelectedValue != null)
                {
                    int pId = Convert.ToInt32(cmbPersoneller.SelectedValue);                   
                    if (sonHesaplananNetMaas > 0)
                    {
                        personelBll.MaasKaydet(pId, sonHesaplananNetMaas);
                        MessageBox.Show("Maaş bilgisi başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen önce maaş hesaplaması yapın!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
        }
        private void SalaryForm_Load(object sender, EventArgs e)
        {
            cmbPersoneller.DataSource = personelBll.PersonelleriGetir();
            cmbPersoneller.DisplayMember = "name"; 
            cmbPersoneller.ValueMember = "personelID"; 
        }
    }
}
