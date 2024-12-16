using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            frm.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.ShowDialog();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmKullanici k = new frmKullanici();
            k.ShowDialog();
        }

        private void btnMaasZamları_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar frm = new frmYapilanZamlar();
            frm.ShowDialog();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            frmPrimEkle frm = new frmPrimEkle();
            frm.ShowDialog();
        }
    }
}
