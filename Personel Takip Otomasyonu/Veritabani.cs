using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=VEDAT\\SQLEXPRESS;Initial Catalog=Personel_Takip;Integrated Security=True;Pooling=False");
        public static void ESG(SqlCommand cmd, string sql)
        {
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();//hata alınıyor 
            baglanti.Close();
        }
        public static DataTable Listele_Ara(DataGridView gridView, string sql)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }
    }
}
