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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.comboyaDepartmanGetir(comboDepartman);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtAdi.Text;
            p.Soyaadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboDepartman.SelectedValue;
            p.Maas = decimal.Parse(txtMaas.Text);
            p.GirisTarihi = dtiseGiris.Value;
            p.Aciklama = txtAciklama.Text;
            string sorgu = "insert into Personeller(Adi,Soyadi,Telefon,Adres,Email,DepartmanID,Maasi,GirisTarihi,Aciklama) values('" + p.Adi + "'," +
                " '" + p.Soyaadi + "', '" + p.Telefon + "','" + p.Adres + "','" + p.Email + "','" + p.DepartmanID + "',@Maasi,@GirisTarihi,'" + p.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value=p.Maas;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;

            Veritabani.ESG(komut, sorgu);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
