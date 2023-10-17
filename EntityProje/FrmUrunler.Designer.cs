namespace EntityProje
{
    partial class FrmUrunler
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
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUrunMarka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunDurum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.CmbKategoriler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun ID:";
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Enabled = false;
            this.TxtUrunID.Location = new System.Drawing.Point(59, 12);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Urun Adı:";
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(59, 38);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Markası:";
            // 
            // TxtUrunMarka
            // 
            this.TxtUrunMarka.Location = new System.Drawing.Point(59, 64);
            this.TxtUrunMarka.Name = "TxtUrunMarka";
            this.TxtUrunMarka.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunMarka.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = " Stok:";
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(59, 90);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunStok.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat:";
            // 
            // TxtUrunFiyat
            // 
            this.TxtUrunFiyat.Location = new System.Drawing.Point(59, 116);
            this.TxtUrunFiyat.Name = "TxtUrunFiyat";
            this.TxtUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunFiyat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Durum:";
            // 
            // TxtUrunDurum
            // 
            this.TxtUrunDurum.Location = new System.Drawing.Point(59, 142);
            this.TxtUrunDurum.Name = "TxtUrunDurum";
            this.TxtUrunDurum.Size = new System.Drawing.Size(100, 20);
            this.TxtUrunDurum.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kategori:";
            // 
            // BtnListele
            // 
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListele.Location = new System.Drawing.Point(59, 209);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(98, 46);
            this.BtnListele.TabIndex = 7;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEkle.Location = new System.Drawing.Point(59, 261);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(98, 46);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSil.Location = new System.Drawing.Point(59, 316);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(98, 46);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncelle.Location = new System.Drawing.Point(59, 368);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(98, 46);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 402);
            this.dataGridView1.TabIndex = 6231;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCikis.Location = new System.Drawing.Point(355, 420);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(73, 45);
            this.BtnCikis.TabIndex = 11;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click_1);
            // 
            // CmbKategoriler
            // 
            this.CmbKategoriler.FormattingEnabled = true;
            this.CmbKategoriler.Location = new System.Drawing.Point(59, 169);
            this.CmbKategoriler.Name = "CmbKategoriler";
            this.CmbKategoriler.Size = new System.Drawing.Size(100, 21);
            this.CmbKategoriler.TabIndex = 6;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 466);
            this.Controls.Add(this.CmbKategoriler);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtUrunDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtUrunFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtUrunStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUrunMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUrunID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUrunMarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUrunFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.ComboBox CmbKategoriler;
    }
}