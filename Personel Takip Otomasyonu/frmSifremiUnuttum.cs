using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            comboSoru.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = int.Parse(txtKullaniciID.Text);
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.Adisoyadi = txtAdsoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;

            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                string sql = "update Kullanicilar set KullaniciAdi='" + k.KullaniciAdi + "',Sifre='" + k.Sifre + "',AdiSoyadi='" + k.Adisoyadi + "',Soru='" + k.Soru + "',Cevap='" + k.Cevap + "'" +
                        ",Tarih=@Tarih,Aciklama='" + k.Aciklama + "' where KullaniciID='" + k.KullaniciID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                Veritabani.ESG(komut, sql);
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle(); 
            }
            else
            {
                MessageBox.Show("Şifreler Aynı Olmak Zorunda", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
