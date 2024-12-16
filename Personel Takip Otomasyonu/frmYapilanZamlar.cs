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
    public partial class frmYapilanZamlar : Form
    {
        public frmYapilanZamlar()
        {
            InitializeComponent();
            comboPersoneller.SelectedIndex = 0;//hata
            radioYüzde.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            YapilanZamlar y = new YapilanZamlar();
            y.Dönem = comboAy.Text + "/" + comboYil.Text;
            y.Personel = comboPersoneller.Text;
            y.Aciklama = txtAciklama.Text;
            k.KullaniciID = Kullanicilar.kid;
            y.Tarih = DateTime.Now;
            if (radioYüzde.Checked)
            {
                y.Yüzde = decimal.Parse(txtYüzde.Text);
                if (comboPersoneller.SelectedIndex == 0)
                {
                    string sql = "update Personeller set Maasi=Maasi+(Maasi*'" + y.Yüzde + "')/100";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show("Tüm Personelin Maaşına yüzde " + y.Yüzde + " zam yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "update Personeller set Maasi=Maasi+(Maasi+'" + y.Yüzde + "')/100 where PersonelID='" + lblPersonelID.Text + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show("" + comboPersoneller.Text + "Personelin Maaşına yüzde " + y.Yüzde + " zam yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql2 = "insert into YapilanZamlar(KullaniciID,Dönem,Personeller,Yüzde,Aciklama,Tarih)" +
                    " values('" + k.KullaniciID + "','" + y.Dönem + "','" + y.Personel + "',@Yüzde,'" + y.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Yüzde", SqlDbType.Decimal).Value = y.Yüzde;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                Veritabani.ESG(komut2, sql2);

            }
            if (radioFiyat.Checked)
            {
                y.Fiyat = decimal.Parse(txtFiyat.Text);//giriş vizesi doğru şekilde değil
                //decimal fiyat = decimal.Parse(txtFiyat.Text);//hata alındı
                if (comboPersoneller.SelectedIndex == 0)
                {
                    string sql = "update Personeller set Maasi=Maasi+'" + y.Fiyat + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show("Tüm Personelin Maaşına " + y.Fiyat + " TL zam yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string sql = "update Personeller set Maasi=Maasi+'" + y.Fiyat + "' where PersonelID='" + lblPersonelID.Text + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabani.ESG(komut, sql);
                    MessageBox.Show("'" + comboPersoneller.Text + " Personelinin Maaşına " + y.Fiyat + "' TL zam yapıldı", "Maaş Zammı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql2 = "insert into YapilanZamlar(KullaniciID,Dönem,Personeller,Fiyat,Aciklama,Tarih)" +
                    " values('" + k.KullaniciID + "','" + y.Dönem + "','" + y.Personel + "',@Fiyat,'" + y.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = y.Fiyat;
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = y.Tarih;
                Veritabani.ESG(komut2, sql2);
            }
        }

        private void frmYapilanZamlar_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
            YapilanZamlar.ComboyaPersoneGetir(comboPersoneller);
        }

        private void radioYüzde_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = false;
            txtYüzde.Enabled = true;
        }

        private void radioFiyat_CheckedChanged(object sender, EventArgs e)
        {
            txtYüzde.Enabled=false;
            txtFiyat.Enabled=true;
        }

        private void comboPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboPersoneller.SelectedIndex == 0)
            {
                lblPersonelID.Text = "0";
                return;
            }
            YapilanZamlar.ComboSecilirsePersoneIDGetir(comboPersoneller,lblPersonelID);
        }
    }
}
