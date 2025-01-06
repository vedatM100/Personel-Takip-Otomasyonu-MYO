namespace Personel_Takip_Otomasyonu
{
    partial class frmPersonelMesaileri
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
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.dataGridViewMesailer = new System.Windows.Forms.DataGridView();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblKyaitSayisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMesaiIDAra = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdıSoyadı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.RowHeadersWidth = 51;
            this.dataGridViewPersoneller.RowTemplate.Height = 24;
            this.dataGridViewPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(364, 674);
            this.dataGridViewPersoneller.TabIndex = 0;
            this.dataGridViewPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersoneller_CellClick);
            // 
            // dataGridViewMesailer
            // 
            this.dataGridViewMesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesailer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMesailer.Location = new System.Drawing.Point(364, 0);
            this.dataGridViewMesailer.Name = "dataGridViewMesailer";
            this.dataGridViewMesailer.RowHeadersWidth = 51;
            this.dataGridViewMesailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesailer.Size = new System.Drawing.Size(988, 569);
            this.dataGridViewMesailer.TabIndex = 0;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(1125, 607);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(215, 16);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Mesai Ücreti Tutarı=4546544554 TL";
            // 
            // lblKyaitSayisi
            // 
            this.lblKyaitSayisi.AutoSize = true;
            this.lblKyaitSayisi.Location = new System.Drawing.Point(931, 607);
            this.lblKyaitSayisi.Name = "lblKyaitSayisi";
            this.lblKyaitSayisi.Size = new System.Drawing.Size(163, 16);
            this.lblKyaitSayisi.TabIndex = 1;
            this.lblKyaitSayisi.Text = "Toplam 25 Kayıt Listelendi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mesai ID Ara:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMesaiIDAra
            // 
            this.txtMesaiIDAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMesaiIDAra.Location = new System.Drawing.Point(384, 622);
            this.txtMesaiIDAra.Name = "txtMesaiIDAra";
            this.txtMesaiIDAra.Size = new System.Drawing.Size(183, 22);
            this.txtMesaiIDAra.TabIndex = 3;
            this.txtMesaiIDAra.TextChanged += new System.EventHandler(this.txtMesaiIDAra_TextChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(576, 622);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(116, 22);
            this.txtPersonelID.TabIndex = 4;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtPersonelAdıSoyadı
            // 
            this.txtPersonelAdıSoyadı.Location = new System.Drawing.Point(698, 622);
            this.txtPersonelAdıSoyadı.Name = "txtPersonelAdıSoyadı";
            this.txtPersonelAdıSoyadı.Size = new System.Drawing.Size(210, 22);
            this.txtPersonelAdıSoyadı.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personel ID:";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personel Adı Soyadı:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPersonelMesaileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 674);
            this.Controls.Add(this.txtPersonelAdıSoyadı);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.txtMesaiIDAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKyaitSayisi);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dataGridViewMesailer);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Name = "frmPersonelMesaileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Mesaileri";
            this.Load += new System.EventHandler(this.frmPersonelMesaileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.DataGridView dataGridViewMesailer;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblKyaitSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMesaiIDAra;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdıSoyadı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}