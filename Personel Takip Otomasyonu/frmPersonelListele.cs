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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            Personeller.comboyaKayitGetir(comboDepartman);
            YenileListele();
        }
        private void YenileListele()
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama \r\nfrom Personeller p, Departmanlar d where p.DepartmanID=d.DepartmanID\r\n");
            lblToplamKayıt.Text = "Toplam " + (dataGridView1.Rows.Count - 1) + "kayıt Listelendi.";
            decimal toplammaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                toplammaas += decimal.Parse(dataGridView1.Rows[i].Cells["Maasi"].Value.ToString());
            }
            lblToplamMaas.Text = "Toplam maas tutarı= " + toplammaas.ToString("0.00") + "TL";
        }
        void Temizle()
        {
            dtiseGiris.Value = DateTime.Now;
            comboDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        Personeller p = new Personeller();
        Kullanicilar k = new Kullanicilar();
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
        
            p.PERSONELID = int.Parse(txtPersonelID.Text);
            p.Adi = txtAdi.Text;
            p.Soyaadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboDepartman.SelectedValue;
            p.Maas = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dtiseGiris.Value;
            p.Aciklama = txtAciklama.Text;
            string sorgu = "update Personeller set Adi= '" + p.Adi + "',Soyadi= '" + p.Soyaadi + "',Telefon= '" + p.Telefon + "',Adres= '" + p.Adres +
                "',Email= '" + p.Email + "',DepartmanID= '" + p.DepartmanID + "',Maasi= @Maasi,GirisTarihi= @GirisTarihi,Aciklama= '" + p.Aciklama + "' where PersonelID= '" + p.PERSONELID + "'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maas;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
            Veritabani.ESG(komut, sorgu);
            p.Islem = p.PERSONELID + "nolu personelin bilgileri güncellendi";
            p.Aciklama = "Personel güncelleme";
            Personeller.PersonelislemEkle(p,k);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YenileListele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            p.PERSONELID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //string sorgu = "delete from Personeller where PersonelID='" + p.PERSONELID + "'";
            //SqlCommand komut = new SqlCommand();
            //Veritabani.ESG(komut, sorgu);
            p.CikisTarihi=DateTime.Now;
            string sorgu2 = "update Personeller set Durumu='Pasif',CikisTarihi=@CikisTarihi where PersonelID='" + p.PERSONELID + "'";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.Add("@CikisTarihi",SqlDbType.Date).Value=p.CikisTarihi;
            Veritabani.ESG(komut2, sorgu2);
            p.Islem = p.PERSONELID + " nolu personel işten çıkarıldı.";
            p.Aciklama = " işten çıkarma";
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Sil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            YenileListele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMaasi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dtiseGiris.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void txtPersonelIDAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama \r\nfrom Personeller p, Departmanlar d where p.DepartmanID=d.DepartmanID and PersonelID like '%"+txtPersonelIDAra.Text+"%'");
        }

        private void txtPersonelAdAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama \r\nfrom Personeller p, Departmanlar d where p.DepartmanID=d.DepartmanID and Adi like '%" + txtPersonelAdAra.Text + "%'");

        }

        private void txtPersonelSoyadAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama \r\nfrom Personeller p, Departmanlar d where p.DepartmanID=d.DepartmanID and Soyadi like '%" + txtPersonelSoyadAra.Text + "%'");

        }

        private void txtPersonelTelefonAra_TextChanged(object sender, EventArgs e)
        {
            Veritabani.Listele_Ara(dataGridView1, "select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama \r\nfrom Personeller p, Departmanlar d where p.DepartmanID=d.DepartmanID and Telefon like '%" + txtPersonelTelefonAra.Text + "%'");

        }

        private void dateTimePickerG_Tarihi_ValueChanged(object sender, EventArgs e)
        {
            Personeller.TariheGöreAra(dateTimePickerG_Tarihi,dataGridView1);
        }
    }
}
