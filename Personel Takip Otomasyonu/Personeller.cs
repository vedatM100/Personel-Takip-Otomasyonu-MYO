using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    internal class Personeller
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyaadi;
        private string _Telefon;
        private string _Adres;
        private string _Email;
        private int _DepartmanID;
        private decimal _Maas;
        private DateTime _GirisTarihi;
        private string _Aciklama;

        public int PERSONELID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyaadi { get => _Soyaadi; set => _Soyaadi = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public decimal Maas { get => _Maas; set => _Maas = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
   
        public static DataTable comboyaDepartmanGetir(ComboBox combo)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Departmanlar", Veritabani.baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = "DepartmanID";
            combo.DisplayMember = "Departman";
            Veritabani.baglanti.Close();
            return tbl;
        }

        public static DataTable TariheGöreAra(DateTimePicker dt,DataGridView gridview)
        {
            DataTable tbl = new DataTable();
            Veritabani.baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select p.PersonelID,p.Adi,p.Soyadi,p.Telefon,p.Adres,p.Email," +
               "\r\nd.Departman,p.Durumu,p.Maasi,p.GirisTarihi,p.Aciklama \r\nfrom Personeller p, Departmanlar d where p.DepartmanID=d.DepartmanID and GirisTarihi=@P1", Veritabani.baglanti);
            adtr.SelectCommand.Parameters.Add("@P1", SqlDbType.Date).Value = DateTime.Parse(dt.Value.ToShortDateString());
            adtr.Fill(tbl);
            gridview.DataSource = tbl;
            Veritabani.baglanti.Close();
            return tbl;
        }
    
    }
}
