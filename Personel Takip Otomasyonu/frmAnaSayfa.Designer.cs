namespace Personel_Takip_Otomasyonu
{
    partial class frmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnMaasZamları = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartman
            // 
            this.btnDepartman.Location = new System.Drawing.Point(24, 54);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(166, 93);
            this.btnDepartman.TabIndex = 0;
            this.btnDepartman.Text = "Departmanlar";
            this.btnDepartman.UseVisualStyleBackColor = true;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(216, 54);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(166, 93);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(408, 54);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(166, 93);
            this.btnPersonelListele.TabIndex = 2;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnMaasZamları
            // 
            this.btnMaasZamları.Location = new System.Drawing.Point(24, 190);
            this.btnMaasZamları.Name = "btnMaasZamları";
            this.btnMaasZamları.Size = new System.Drawing.Size(166, 93);
            this.btnMaasZamları.TabIndex = 3;
            this.btnMaasZamları.Text = "Maaş Zamları";
            this.btnMaasZamları.UseVisualStyleBackColor = true;
            this.btnMaasZamları.Click += new System.EventHandler(this.btnMaasZamları_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(216, 190);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(166, 93);
            this.btnPrim.TabIndex = 4;
            this.btnPrim.Text = "Primler";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 393);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnMaasZamları);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnDepartman);
            this.Name = "frmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button btnMaasZamları;
        private System.Windows.Forms.Button btnPrim;
    }
}

