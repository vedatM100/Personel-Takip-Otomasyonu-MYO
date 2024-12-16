namespace Personel_Takip_Otomasyonu
{
    partial class frmPersonelEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelEkle));
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dtiseGiris = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(164, 34);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(193, 22);
            this.txtAdi.TabIndex = 0;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(164, 62);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(193, 22);
            this.txtSoyadi.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(164, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // comboDepartman
            // 
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(164, 216);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(193, 24);
            this.comboDepartman.TabIndex = 5;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(164, 246);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(193, 22);
            this.txtMaas.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(164, 307);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(193, 70);
            this.txtAciklama.TabIndex = 9;
            // 
            // dtiseGiris
            // 
            this.dtiseGiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtiseGiris.Location = new System.Drawing.Point(164, 279);
            this.dtiseGiris.Name = "dtiseGiris";
            this.dtiseGiris.Size = new System.Drawing.Size(193, 22);
            this.dtiseGiris.TabIndex = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(164, 118);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(193, 64);
            this.txtAdres.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(164, 90);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(193, 22);
            this.txtTelefon.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Personel Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(21, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Departman:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Maaş:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(21, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giriş Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(21, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Açıklama:";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(164, 383);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 62);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 2;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(264, 383);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(106, 62);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bin.png");
            this.ımageList1.Images.SetKeyName(1, "diskette.png");
            this.ımageList1.Images.SetKeyName(2, "switch.png");
            this.ımageList1.Images.SetKeyName(3, "updated.png");
            // 
            // frmPersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 594);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.dtiseGiris);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.comboDepartman);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Name = "frmPersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persone Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dtiseGiris;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}