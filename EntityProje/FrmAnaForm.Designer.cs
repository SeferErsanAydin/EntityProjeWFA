namespace EntityProje
{
    partial class FrmAnaForm
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
            this.BtnKategoriler = new System.Windows.Forms.Button();
            this.BtnUrunler = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnIstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategoriler
            // 
            this.BtnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKategoriler.Location = new System.Drawing.Point(61, 87);
            this.BtnKategoriler.Name = "BtnKategoriler";
            this.BtnKategoriler.Size = new System.Drawing.Size(117, 75);
            this.BtnKategoriler.TabIndex = 0;
            this.BtnKategoriler.Text = "Kategori İşlemleri";
            this.BtnKategoriler.UseVisualStyleBackColor = true;
            this.BtnKategoriler.Click += new System.EventHandler(this.BtnKategoriler_Click);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUrunler.Location = new System.Drawing.Point(184, 87);
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(117, 75);
            this.BtnUrunler.TabIndex = 3;
            this.BtnUrunler.Text = "Urunler";
            this.BtnUrunler.UseVisualStyleBackColor = true;
            this.BtnUrunler.Click += new System.EventHandler(this.BtnUrunler_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(184, 206);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(75, 39);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIstatistik.Location = new System.Drawing.Point(307, 87);
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.Size = new System.Drawing.Size(117, 75);
            this.BtnIstatistik.TabIndex = 4;
            this.BtnIstatistik.Text = "İstatistikler";
            this.BtnIstatistik.UseVisualStyleBackColor = true;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 257);
            this.Controls.Add(this.BtnIstatistik);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnUrunler);
            this.Controls.Add(this.BtnKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategoriler;
        private System.Windows.Forms.Button BtnUrunler;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnIstatistik;
    }
}