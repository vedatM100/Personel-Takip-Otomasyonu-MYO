using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class YapilanZamlar
    {
        #region Zamlar Kapsulleme
        private int _ZamID;
        private string _Dönem;
        private String _Personel;
        private decimal _Yüzde;
        private decimal _Fiyat;
        private string _Aciklama;
        private DateTime _Tarih;

        public int ZamID { get => _ZamID; set => _ZamID = value; }
        public string Dönem { get => _Dönem; set => _Dönem = value; }
        public string Personel { get => _Personel; set => _Personel = value; }
        public decimal Yüzde { get => _Yüzde; set => _Yüzde = value; }
        public decimal Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        #endregion

        public static SqlDataReader ComboyaPersoneGetir(ComboBox cmd)
        {
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID,Adi,Soyadi from Personeller", Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();//hata
            while (dr.Read())
            {
                cmd.Items.Add(dr[0] + "." + dr[1] + " " + dr[2]);
            }
            Veritabani.baglanti.Close();
            return dr;
        }
        public static SqlDataReader ComboSecilirsePersoneIDGetir(ComboBox combo, Label lbl_PersonelID)
        {
            Veritabani.baglanti.Open();
            SqlCommand komut = new SqlCommand("select PersonelID, Adi, Soyadi from Personeller",Veritabani.baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if(combo.SelectedItem.ToString() == dr[0] + "." + dr[1] + " " + dr[2])
                {
                    lbl_PersonelID.Text = dr[0].ToString();
                }
            }
            Veritabani.baglanti.Close();
            return dr;
        }
    }
}
