namespace Personel_Takip_Otomasyonu
{
    partial class frmizinHareketleri
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
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.txtizinHareketID = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboizinTuru = new System.Windows.Forms.ComboBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(1106, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Location = new System.Drawing.Point(66, 488);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(158, 59);
            this.btnExceleAktar.TabIndex = 1;
            this.btnExceleAktar.Text = "Excele Aktar";
            this.btnExceleAktar.UseVisualStyleBackColor = true;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(556, 488);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 59);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(720, 488);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 59);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(884, 488);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(158, 59);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // txtizinHareketID
            // 
            this.txtizinHareketID.Location = new System.Drawing.Point(134, 342);
            this.txtizinHareketID.Name = "txtizinHareketID";
            this.txtizinHareketID.Size = new System.Drawing.Size(223, 22);
            this.txtizinHareketID.TabIndex = 2;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(134, 398);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(223, 22);
            this.txtAdiSoyadi.TabIndex = 3;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(134, 370);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(223, 22);
            this.txtPersonelID.TabIndex = 4;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "İzin Hareket ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personel ID :";
            // 
            // comboizinTuru
            // 
            this.comboizinTuru.FormattingEnabled = true;
            this.comboizinTuru.Location = new System.Drawing.Point(552, 337);
            this.comboizinTuru.Name = "comboizinTuru";
            this.comboizinTuru.Size = new System.Drawing.Size(121, 24);
            this.comboizinTuru.TabIndex = 8;
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(552, 367);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dateTimeBaslangic.TabIndex = 12;
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(552, 395);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(200, 22);
            this.dateTimeBitis.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(829, 364);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(223, 59);
            this.txtAciklama.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "İzin Türleri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "İzin Başlangıç:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "İzin Bitiş:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(394, 488);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(158, 59);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "İzin Türleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnizinTurleri_Click);
            // 
            // frmizinHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboizinTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.txtizinHareketID);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmizinHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareketleri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmizinHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtizinHareketID;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboizinTuru;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button button1;
    }
}