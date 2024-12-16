using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama = txtAciklama.Text;
            string sorgu = "insert into Departmanlar  values('"+d.Departman+"','"+d.Aciklama+"')";
            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı");
            Departmanlar.DepartmanGetir(listView1);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text); // ID alanını alıyoruz.
            d.Departman = txtDepartman.Text; // Departman adını alıyoruz.
            d.Aciklama = txtAciklama.Text; // Açıklama alanını alıyoruz.

            // Güncelleme sorgusunu oluşturuyoruz.
            string sorgu = "UPDATE Departmanlar SET Departman = '" + d.Departman + "', Aciklama = '" + d.Aciklama + "' WHERE DepartmanID = '" + d.DepartmanID + "'";

            SqlCommand komut = new SqlCommand();
            Veritabani.ESG(komut, sorgu); // ESG metodunu çağırıyoruz.

            MessageBox.Show("İşlem Başarılı");
            Departmanlar.DepartmanGetir(listView1); // ListView'i güncelliyoruz.
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0) {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sorgu = "delete from Departmanlar where DepartmanID= '" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabani.ESG(komut, sorgu);
                MessageBox.Show("İşlem Başarılı");
                Departmanlar.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Önce Kayıt Seçilmelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }
    }
}
