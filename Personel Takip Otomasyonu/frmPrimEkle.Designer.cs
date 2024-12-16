namespace Personel_Takip_Otomasyonu
{
    partial class frmPrimEkle
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
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimleriGöster = new System.Windows.Forms.Button();
            this.btnPrimOdeme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(149, 56);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(227, 22);
            this.txtPersonelID.TabIndex = 0;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(149, 94);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(227, 22);
            this.txtPersonelAdSoyad.TabIndex = 1;
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Location = new System.Drawing.Point(40, 12);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(124, 20);
            this.radioKisiyeOzel.TabIndex = 3;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Location = new System.Drawing.Point(240, 12);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(180, 20);
            this.radioTumPersoneller.TabIndex = 4;
            this.radioTumPersoneller.TabStop = true;
            this.radioTumPersoneller.Text = "Tüm Personeller İçin Prim";
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(78, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dönem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(257, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(276, 130);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(100, 24);
            this.comboYil.TabIndex = 12;
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
            this.comboAy.Location = new System.Drawing.Point(149, 130);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(103, 24);
            this.comboAy.TabIndex = 11;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(493, 56);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(227, 22);
            this.txtPrimTutari.TabIndex = 15;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(493, 92);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(227, 65);
            this.txtAciklama.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(818, 249);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Persnel Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "PersonelID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(397, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Prim Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(409, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Açıklama:";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.Location = new System.Drawing.Point(56, 181);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(127, 56);
            this.btnPrimEkle.TabIndex = 22;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimleriGöster
            // 
            this.btnPrimleriGöster.Location = new System.Drawing.Point(200, 181);
            this.btnPrimleriGöster.Name = "btnPrimleriGöster";
            this.btnPrimleriGöster.Size = new System.Drawing.Size(127, 56);
            this.btnPrimleriGöster.TabIndex = 23;
            this.btnPrimleriGöster.Text = "Primleri Göster";
            this.btnPrimleriGöster.UseVisualStyleBackColor = true;
            this.btnPrimleriGöster.Click += new System.EventHandler(this.btnPrimleriGöster_Click);
            // 
            // btnPrimOdeme
            // 
            this.btnPrimOdeme.Location = new System.Drawing.Point(343, 181);
            this.btnPrimOdeme.Name = "btnPrimOdeme";
            this.btnPrimOdeme.Size = new System.Drawing.Size(127, 56);
            this.btnPrimOdeme.TabIndex = 24;
            this.btnPrimOdeme.Text = "Personel Primleri";
            this.btnPrimOdeme.UseVisualStyleBackColor = true;
            this.btnPrimOdeme.Click += new System.EventHandler(this.btnPrimOdeme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(627, 181);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(127, 56);
            this.btnCikis.TabIndex = 26;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(484, 181);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(127, 56);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmPrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 511);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPrimOdeme);
            this.Controls.Add(this.btnPrimleriGöster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "frmPrimEkle";
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimleriGöster;
        private System.Windows.Forms.Button btnPrimOdeme;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}