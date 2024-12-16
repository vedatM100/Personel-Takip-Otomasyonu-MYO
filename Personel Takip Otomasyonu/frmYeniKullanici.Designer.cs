namespace Personel_Takip_Otomasyonu
{
    partial class frmYeniKullanici
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.comboSoru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdsoyadi = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(138, 25);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(266, 22);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(138, 53);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(266, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(138, 81);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(266, 22);
            this.txtSifreTekrar.TabIndex = 2;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(138, 170);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(266, 22);
            this.txtCevap.TabIndex = 3;
            // 
            // comboSoru
            // 
            this.comboSoru.FormattingEnabled = true;
            this.comboSoru.Items.AddRange(new object[] {
            "1)En sevdiğiniz renk hangisidir",
            "2)İlkokul Öğretmenizin ismi nedir",
            "3)En sevdiğiniz Film Hangisidir"});
            this.comboSoru.Location = new System.Drawing.Point(138, 140);
            this.comboSoru.Name = "comboSoru";
            this.comboSoru.Size = new System.Drawing.Size(266, 24);
            this.comboSoru.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre Tekrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soru:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cevap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ad Soyad:";
            // 
            // txtAdsoyadi
            // 
            this.txtAdsoyadi.Location = new System.Drawing.Point(138, 109);
            this.txtAdsoyadi.Name = "txtAdsoyadi";
            this.txtAdsoyadi.Size = new System.Drawing.Size(266, 22);
            this.txtAdsoyadi.TabIndex = 10;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(270, 288);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(134, 48);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(138, 288);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 48);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(138, 204);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(266, 78);
            this.txtAciklama.TabIndex = 14;
            // 
            // frmYeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 350);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdsoyadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSoru);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Name = "frmYeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Kullanıcı Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.ComboBox comboSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdsoyadi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
    }
}