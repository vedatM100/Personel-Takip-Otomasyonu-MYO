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
    public partial class frmPrimleriGöster : Form
    {
        public frmPrimleriGöster()
        {
            InitializeComponent();
        }

        private void frmPrimleriGöster_Load(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil; i >= (yil - 5); i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersoneAdSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString()=="Ödenmedi")
            {
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutari.Text = dataGridView1.CurrentRow.Cells["PrimTutari"].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            }    
        }

        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler p = new Primler();
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Islem = "Dönem bilgisi değişti.";
            p.Aciklama = "Seçili Kaydın dönem bilgisi değişti.";
            p.Tarih = DateTime.Now;
            string sql = "Update Primler set Donem='" + p.Donem + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
                " '" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);

            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Prim için Dönem Değişikliği yapıldı.", "Dönem Değişikliği", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnTumPrimlerOde_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.OdenmeDurumu = "Ödendi";
            string sql = "Update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' where OdenmeDurumu='Ödenmedi'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                {
                    Kullanicilar k = new Kullanicilar();
                    k.KullaniciID = Kullanicilar.kid;
                    p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells["PersonelID"].Value.ToString());
                    p.PrimID = int.Parse(dataGridView1.Rows[i].Cells["PrimID"].Value.ToString());
                    p.Islem = "Tüm personellerin Ödenmeyen Primleri Ödendi";
                    p.Aciklama = "Tüm personellerin Ödenmeyen Primleri Ödendi";
                    p.Tarih = DateTime.Now;

                    string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "'," +
                      " '" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    Veritabani.ESG(komut2, sql2);
                }
            }



            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Ödenmeyen Tüm Primler Ödendi", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimÖde_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            Primler p = new Primler();
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PersonelID + " nolu Personel " + txtPersonelAdSoyad.Text + " için ödeme yapıldı.";
            p.OdenmeDurumu = "Ödendi";

            p.PrimID = int.Parse(txtPrimID.Text);
            p.Tarih = DateTime.Now;
            string sql = "Update Primler set OdenmeDurumu='" + p.OdenmeDurumu + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sql);
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");

            MessageBox.Show("Seçili Kayda Göre Prim Ödendi", "Prim Ödemeleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;

            Primler p = new Primler();
            p.PrimID = int.Parse(txtPrimID.Text);
            p.PersonelID = int.Parse(txtPersonelID.Text);
            p.PrimTutari = decimal.Parse(txtPrimTutari.Text);//hata
            p.Aciklama = txtAciklama.Text;
            p.Islem = p.PrimID + " Bilgileri değiştirildi.";

            string sql = "Update Primler set PersonelID='" + p.PersonelID + "',PrimTutari=@PrimTutari,Aciklama='" + p.Aciklama + "' where PrimID='" + p.PrimID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@PrimTutari", SqlDbType.Decimal).Value = p.PrimTutari;
            Veritabani.ESG(komut, sql);
            ////////////////////////
            string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            Veritabani.ESG(komut2, sql2);
            ////////////////////////
            Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
            MessageBox.Show("Seçili Kaydın Prim Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnTemizle.PerformClick();
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Silinsin mi?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Primler p = new Primler();
                p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
                p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells["PrimID"].Value.ToString());

                p.Aciklama = "Kayıt Silindi";
                p.Islem = p.PrimID + "Nolu Prim Kaydı Silindi.";
                string sql = "delete from Primler where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sql);
                /////////////////////////////////////
                string sql2 = "insert into PrimHareketleri values('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                Veritabani.ESG(komut2, sql2);
                /////////////////////////////////////
                
                

                Veritabani.Listele_Ara(dataGridView1, "select * from Primler");
                MessageBox.Show("Seçili Prim Kaydı Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnTemizle.PerformClick(); 
            }
        }
    }
}
