namespace Personel_Takip_Otomasyonu
{
    partial class frmPrimleriGöster
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.btnTumPrimlerOde = new System.Windows.Forms.Button();
            this.btnPrimÖde = new System.Windows.Forms.Button();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(952, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(419, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(407, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Prim Tutarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "PersonelID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Persnel Ad Soyad:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(501, 497);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(366, 53);
            this.txtAciklama.TabIndex = 32;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(501, 465);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(227, 22);
            this.txtPrimTutari.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(430, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Dönem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(609, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(628, 433);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(100, 24);
            this.comboYil.TabIndex = 28;
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
            this.comboAy.Location = new System.Drawing.Point(501, 433);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(103, 24);
            this.comboAy.TabIndex = 27;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(169, 498);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(227, 22);
            this.txtPersonelAdSoyad.TabIndex = 26;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(169, 467);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(227, 22);
            this.txtPersonelID.TabIndex = 25;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(97, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "Prim ID:";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(169, 439);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(227, 22);
            this.txtPrimID.TabIndex = 37;
            // 
            // btnTumPrimlerOde
            // 
            this.btnTumPrimlerOde.Location = new System.Drawing.Point(66, 566);
            this.btnTumPrimlerOde.Name = "btnTumPrimlerOde";
            this.btnTumPrimlerOde.Size = new System.Drawing.Size(128, 53);
            this.btnTumPrimlerOde.TabIndex = 39;
            this.btnTumPrimlerOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimlerOde.UseVisualStyleBackColor = true;
            this.btnTumPrimlerOde.Click += new System.EventHandler(this.btnTumPrimlerOde_Click);
            // 
            // btnPrimÖde
            // 
            this.btnPrimÖde.Location = new System.Drawing.Point(205, 566);
            this.btnPrimÖde.Name = "btnPrimÖde";
            this.btnPrimÖde.Size = new System.Drawing.Size(128, 53);
            this.btnPrimÖde.TabIndex = 40;
            this.btnPrimÖde.Text = "Prim Öde";
            this.btnPrimÖde.UseVisualStyleBackColor = true;
            this.btnPrimÖde.Click += new System.EventHandler(this.btnPrimÖde_Click);
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(344, 566);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(128, 53);
            this.btnGuncelleme.TabIndex = 41;
            this.btnGuncelleme.Text = "Prim Güncelle";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.Location = new System.Drawing.Point(483, 566);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(128, 53);
            this.btnPrimSil.TabIndex = 42;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.UseVisualStyleBackColor = true;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.Location = new System.Drawing.Point(734, 432);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(133, 57);
            this.btnDonemDegistir.TabIndex = 43;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(760, 566);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(127, 56);
            this.btnCikis.TabIndex = 45;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(622, 566);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(127, 56);
            this.btnTemizle.TabIndex = 44;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmPrimleriGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 631);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.btnPrimÖde);
            this.Controls.Add(this.btnTumPrimlerOde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGöster";
            this.Text = "frmPrimleriGöster";
            this.Load += new System.EventHandler(this.frmPrimleriGöster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Button btnTumPrimlerOde;
        private System.Windows.Forms.Button btnPrimÖde;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}