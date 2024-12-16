using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Primler
    {
        #region Kapsulleme
        private int _PrimID;
        private int _PersonelID;
        private int _KullaniciID;
        private string _Donem;
        private string _OdenmeDurumu;
        private decimal _PrimTutari;
        private string _Aciklama;
        private DateTime _Tarih;
        private string _Islem;
        public int PrimID { get => _PrimID; set => _PrimID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public decimal PrimTutari { get => _PrimTutari; set => _PrimTutari = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        #endregion

        #region chat - gpt den alındı 
        public static void PersoneAdSoyadGetir(TextBox txtPersonelID, TextBox txtAdSoyad)
         {
             using (SqlConnection connection = new SqlConnection(Veritabani.baglanti.ConnectionString))
             {
                 string query = "SELECT * FROM Personeller WHERE PersonelID = @PersonelID";
                 SqlCommand komut = new SqlCommand(query, connection);
                 komut.Parameters.AddWithValue("@PersonelID", txtPersonelID.Text);

                 connection.Open();
                 using (SqlDataReader dr = komut.ExecuteReader())
                 {
                     if (dr.Read())
                     {
                         txtAdSoyad.Text = dr["Adi"] + " " + dr["Soyadi"]; // Sütun adlarını kullanın
                     }//chat-gpt den alındı bu kod
                 }
             }
         }
        #endregion

        #region Çalışmıyor bu kod
        //public static SqlDataReader PersoneAdSoyadGetir(TextBox txtPersonelID, TextBox txtAdSoyad)
        //{
        //    Veritabani.baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select * from Personeller where PersonelID='" + txtPersonelID + "'", Veritabani.baglanti);
        //    SqlDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())//hata alınıyor
        //    {
        //        txtAdSoyad.Text = dr[1] + " " + dr[2];
        //    }
        //    Veritabani.baglanti.Close();
        //    return dr;
        //}
        #endregion
    }
}
