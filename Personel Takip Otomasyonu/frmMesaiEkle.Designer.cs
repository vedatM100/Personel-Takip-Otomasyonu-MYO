namespace Personel_Takip_Otomasyonu
{
    partial class frmMesaiEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPersonelAdsoyad = new System.Windows.Forms.ComboBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlangıç Saati:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Açıklama:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 260);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tutar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dönem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mesai Saat Ücreti:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bitiş Saati:";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboPersonelAdsoyad
            // 
            this.comboPersonelAdsoyad.FormattingEnabled = true;
            this.comboPersonelAdsoyad.Location = new System.Drawing.Point(187, 50);
            this.comboPersonelAdsoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPersonelAdsoyad.Name = "comboPersonelAdsoyad";
            this.comboPersonelAdsoyad.Size = new System.Drawing.Size(377, 24);
            this.comboPersonelAdsoyad.TabIndex = 1;
            this.comboPersonelAdsoyad.SelectedIndexChanged += new System.EventHandler(this.comboPersonelAdsoyad_SelectedIndexChanged);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(187, 101);
            this.dateTimeBaslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(189, 22);
            this.dateTimeBaslangic.TabIndex = 2;
            this.dateTimeBaslangic.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // maskedtxtBaslangic
            // 
            this.maskedtxtBaslangic.Location = new System.Drawing.Point(399, 101);
            this.maskedtxtBaslangic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedtxtBaslangic.Mask = "90:00";
            this.maskedtxtBaslangic.Name = "maskedtxtBaslangic";
            this.maskedtxtBaslangic.Size = new System.Drawing.Size(165, 22);
            this.maskedtxtBaslangic.TabIndex = 3;
            this.maskedtxtBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBaslangic.ValidatingType = typeof(System.DateTime);
            this.maskedtxtBaslangic.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtxtBaslangic_MaskInputRejected);
            this.maskedtxtBaslangic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(187, 150);
            this.dateTimeBitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(189, 22);
            this.dateTimeBitis.TabIndex = 2;
            this.dateTimeBitis.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // maskedtxtBitis
            // 
            this.maskedtxtBitis.Location = new System.Drawing.Point(399, 150);
            this.maskedtxtBitis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedtxtBitis.Mask = "00:00";
            this.maskedtxtBitis.Name = "maskedtxtBitis";
            this.maskedtxtBitis.Size = new System.Drawing.Size(165, 22);
            this.maskedtxtBitis.TabIndex = 3;
            this.maskedtxtBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBitis.ValidatingType = typeof(System.DateTime);
            this.maskedtxtBitis.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedtxtBitis_MaskInputRejected);
            this.maskedtxtBitis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(187, 210);
            this.txtMesaiSaatUcreti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(377, 22);
            this.txtMesaiSaatUcreti.TabIndex = 4;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(187, 260);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(377, 22);
            this.txtTutar.TabIndex = 4;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(187, 313);
            this.comboAy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(177, 24);
            this.comboAy.TabIndex = 5;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(399, 313);
            this.comboYil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(165, 24);
            this.comboYil.TabIndex = 5;
            this.comboYil.SelectedIndexChanged += new System.EventHandler(this.comboYil_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(187, 369);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(377, 95);
            this.txtAciklama.TabIndex = 4;
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.Location = new System.Drawing.Point(285, 472);
            this.btnMesaiEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(128, 43);
            this.btnMesaiEkle.TabIndex = 6;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(436, 472);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(128, 43);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "/";
            // 
            // frmMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.maskedtxtBitis);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedtxtBaslangic);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboPersonelAdsoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPersonelAdsoyad;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedtxtBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.MaskedTextBox maskedtxtBitis;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label3;
    }
}