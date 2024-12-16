namespace Personel_Takip_Otomasyonu
{
    partial class frmDepartmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanlar));
            this.txtDepartmanID = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DepartmanID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtDepartmanID
            // 
            this.txtDepartmanID.Location = new System.Drawing.Point(161, 35);
            this.txtDepartmanID.Name = "txtDepartmanID";
            this.txtDepartmanID.Size = new System.Drawing.Size(154, 22);
            this.txtDepartmanID.TabIndex = 0;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(161, 76);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(154, 22);
            this.txtDepartman.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(161, 118);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(154, 75);
            this.txtAciklama.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departman ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Açıklama:";
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(356, 35);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 62);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(356, 103);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(86, 62);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.FlatAppearance.BorderSize = 0;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 3;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(448, 36);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(129, 62);
            this.btnGüncelle.TabIndex = 8;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 2;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(448, 103);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(96, 62);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepartmanID,
            this.Departman,
            this.Aciklama});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 218);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(619, 220);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // DepartmanID
            // 
            this.DepartmanID.Text = "Departman ID";
            this.DepartmanID.Width = 110;
            // 
            // Departman
            // 
            this.Departman.Text = "Departman";
            this.Departman.Width = 123;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 376;
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
            // frmDepartmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.txtDepartmanID);
            this.Name = "frmDepartmanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Sayfası";
            this.Load += new System.EventHandler(this.frmDepartmanlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmanID;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DepartmanID;
        private System.Windows.Forms.ColumnHeader Departman;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ImageList ımageList1;
    }
}