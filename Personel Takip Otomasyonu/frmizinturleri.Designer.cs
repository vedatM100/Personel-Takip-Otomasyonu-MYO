namespace Personel_Takip_Otomasyonu
{
    partial class frmizinturleri
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtizinTurID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtizinTuru = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.izinTurID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izinTuru = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.izinTurID,
            this.izinTuru});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 276);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "İzin Tür ID:";
            // 
            // txtizinTurID
            // 
            this.txtizinTurID.Location = new System.Drawing.Point(39, 331);
            this.txtizinTurID.Name = "txtizinTurID";
            this.txtizinTurID.Size = new System.Drawing.Size(193, 22);
            this.txtizinTurID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İzin Türü:";
            // 
            // txtizinTuru
            // 
            this.txtizinTuru.Location = new System.Drawing.Point(307, 331);
            this.txtizinTuru.Name = "txtizinTuru";
            this.txtizinTuru.Size = new System.Drawing.Size(193, 22);
            this.txtizinTuru.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(39, 378);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 45);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(161, 378);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 45);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(280, 378);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 45);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(400, 378);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 45);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Cıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // izinTurID
            // 
            this.izinTurID.Text = "İzin Tür ID";
            // 
            // izinTuru
            // 
            this.izinTuru.Text = "İzin Türü";
            // 
            // frmizinturleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtizinTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtizinTurID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "frmizinturleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Türleri Sayfası";
            this.Load += new System.EventHandler(this.frmizinturleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtizinTurID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtizinTuru;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ColumnHeader izinTurID;
        private System.Windows.Forms.ColumnHeader izinTuru;
    }
}