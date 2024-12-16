namespace Personel_Takip_Otomasyonu
{
    partial class frmYapilanZamlar
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
            this.radioYüzde = new System.Windows.Forms.RadioButton();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.txtYüzde = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioYüzde
            // 
            this.radioYüzde.AutoSize = true;
            this.radioYüzde.Location = new System.Drawing.Point(134, 35);
            this.radioYüzde.Name = "radioYüzde";
            this.radioYüzde.Size = new System.Drawing.Size(114, 20);
            this.radioYüzde.TabIndex = 0;
            this.radioYüzde.TabStop = true;
            this.radioYüzde.Text = "Yüzdeye Göre";
            this.radioYüzde.UseVisualStyleBackColor = true;
            this.radioYüzde.CheckedChanged += new System.EventHandler(this.radioYüzde_CheckedChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.Location = new System.Drawing.Point(362, 35);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(98, 20);
            this.radioFiyat.TabIndex = 1;
            this.radioFiyat.TabStop = true;
            this.radioFiyat.Text = "Fiyata Göre";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged);
            // 
            // txtYüzde
            // 
            this.txtYüzde.Location = new System.Drawing.Point(134, 145);
            this.txtYüzde.Name = "txtYüzde";
            this.txtYüzde.Size = new System.Drawing.Size(330, 22);
            this.txtYüzde.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(134, 182);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(330, 22);
            this.txtFiyat.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(134, 221);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(330, 117);
            this.txtAciklama.TabIndex = 4;
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
            this.comboAy.Location = new System.Drawing.Point(134, 62);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(151, 24);
            this.comboAy.TabIndex = 5;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(313, 61);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(151, 24);
            this.comboYil.TabIndex = 6;
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.comboPersoneller.Location = new System.Drawing.Point(134, 104);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(307, 24);
            this.comboPersoneller.TabIndex = 7;
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(290, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "/";
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelID.Location = new System.Drawing.Point(447, 107);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(17, 18);
            this.lblPersonelID.TabIndex = 9;
            this.lblPersonelID.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dönem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personeller:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(45, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yüzde(%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Zam Miktarı(TL):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(49, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Açıklama:";
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.Location = new System.Drawing.Point(133, 352);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(151, 53);
            this.btnOnay.TabIndex = 15;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(306, 352);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(157, 53);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmYapilanZamlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 435);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtYüzde);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYüzde);
            this.Name = "frmYapilanZamlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Maaş Zamları Sayfası";
            this.Load += new System.EventHandler(this.frmYapilanZamlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioYüzde;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.TextBox txtYüzde;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnCikis;
    }
}