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
            panelIslemler.Width = 80;
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

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm = new frmMesaiEkle();
            frm.ShowDialog();
        }

        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            frm.ShowDialog();
        }

        private void btnizinHareketListele_Click(object sender, EventArgs e)
        {
            frmizinHareketleri frm = new frmizinHareketleri();
            frm.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelIslemler.Width == 170)
            {
                panelIslemler.Width = 80;
            }
            else if (panelIslemler.Width == 80)
            {
                panelIslemler.Width = 170;
            }
        }
    }
}
