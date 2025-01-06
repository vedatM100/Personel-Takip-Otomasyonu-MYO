namespace Personel_Takip_Otomasyonu
{
    partial class frmMesailer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.maskedtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.btnTumMesaileriOde = new System.Windows.Forms.Button();
            this.btnMesaiOde = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPersonelMesaileri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(916, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(935, 386);
            this.comboYil.Margin = new System.Windows.Forms.Padding(4);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(122, 24);
            this.comboYil.TabIndex = 21;
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
            this.comboAy.Location = new System.Drawing.Point(783, 386);
            this.comboAy.Margin = new System.Windows.Forms.Padding(4);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(125, 24);
            this.comboAy.TabIndex = 22;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(783, 418);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(287, 81);
            this.txtAciklama.TabIndex = 18;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(406, 477);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(279, 22);
            this.txtTutar.TabIndex = 19;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(406, 447);
            this.txtMesaiSaatUcreti.Margin = new System.Windows.Forms.Padding(4);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(279, 22);
            this.txtMesaiSaatUcreti.TabIndex = 20;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // maskedtxtBitis
            // 
            this.maskedtxtBitis.Location = new System.Drawing.Point(578, 416);
            this.maskedtxtBitis.Margin = new System.Windows.Forms.Padding(4);
            this.maskedtxtBitis.Mask = "00:00";
            this.maskedtxtBitis.Name = "maskedtxtBitis";
            this.maskedtxtBitis.Size = new System.Drawing.Size(107, 22);
            this.maskedtxtBitis.TabIndex = 16;
            this.maskedtxtBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBitis.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(406, 414);
            this.dateTimeBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(146, 22);
            this.dateTimeBitis.TabIndex = 14;
            // 
            // maskedtxtBaslangic
            // 
            this.maskedtxtBaslangic.Location = new System.Drawing.Point(578, 384);
            this.maskedtxtBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.maskedtxtBaslangic.Mask = "90:00";
            this.maskedtxtBaslangic.Name = "maskedtxtBaslangic";
            this.maskedtxtBaslangic.Size = new System.Drawing.Size(106, 22);
            this.maskedtxtBaslangic.TabIndex = 17;
            this.maskedtxtBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(406, 384);
            this.dateTimeBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(146, 22);
            this.dateTimeBaslangic.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(721, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dönem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 477);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 418);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 445);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mesai Saat Ücreti:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bitiş Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mesai ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Personel ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Adı Soyadı:";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Location = new System.Drawing.Point(100, 386);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(135, 22);
            this.txtMesaiID.TabIndex = 26;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(100, 418);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(135, 22);
            this.txtPersonelID.TabIndex = 26;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(100, 449);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(135, 22);
            this.txtAdiSoyadi.TabIndex = 26;
            // 
            // btnTumMesaileriOde
            // 
            this.btnTumMesaileriOde.Location = new System.Drawing.Point(209, 545);
            this.btnTumMesaileriOde.Name = "btnTumMesaileriOde";
            this.btnTumMesaileriOde.Size = new System.Drawing.Size(158, 51);
            this.btnTumMesaileriOde.TabIndex = 27;
            this.btnTumMesaileriOde.Text = "Tüm Mesaileri Öde";
            this.btnTumMesaileriOde.UseVisualStyleBackColor = true;
            this.btnTumMesaileriOde.Click += new System.EventHandler(this.btnTumMesaileriOde_Click);
            // 
            // btnMesaiOde
            // 
            this.btnMesaiOde.Location = new System.Drawing.Point(385, 545);
            this.btnMesaiOde.Name = "btnMesaiOde";
            this.btnMesaiOde.Size = new System.Drawing.Size(151, 51);
            this.btnMesaiOde.TabIndex = 28;
            this.btnMesaiOde.Text = "Mesai Öde";
            this.btnMesaiOde.UseVisualStyleBackColor = true;
            this.btnMesaiOde.Click += new System.EventHandler(this.btnMesaiOde_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(561, 545);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 51);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(693, 545);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 51);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPersonelMesaileri
            // 
            this.btnPersonelMesaileri.Location = new System.Drawing.Point(40, 545);
            this.btnPersonelMesaileri.Name = "btnPersonelMesaileri";
            this.btnPersonelMesaileri.Size = new System.Drawing.Size(152, 51);
            this.btnPersonelMesaileri.TabIndex = 29;
            this.btnPersonelMesaileri.Text = "Personel Mesaileri";
            this.btnPersonelMesaileri.UseVisualStyleBackColor = true;
            this.btnPersonelMesaileri.Click += new System.EventHandler(this.btnPersonelMesaileri_Click_1);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(816, 545);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 51);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(950, 545);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(107, 51);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 626);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnPersonelMesaileri);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMesaiOde);
            this.Controls.Add(this.btnTumMesaileriOde);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.maskedtxtBitis);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedtxtBaslangic);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesailer Sayfası";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.MaskedTextBox maskedtxtBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.MaskedTextBox maskedtxtBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Button btnTumMesaileriOde;
        private System.Windows.Forms.Button btnMesaiOde;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPersonelMesaileri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnCikis;
    }
}