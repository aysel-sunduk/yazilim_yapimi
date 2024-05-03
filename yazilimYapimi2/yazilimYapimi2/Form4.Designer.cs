namespace yazilimYapimi2
{
    partial class Form4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPageKelimeEkle = new System.Windows.Forms.TabPage();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.btnKelimeKayit = new System.Windows.Forms.Button();
            this.txtBoxCumle = new System.Windows.Forms.TextBox();
            this.lblCumle = new System.Windows.Forms.Label();
            this.txtBoxIng = new System.Windows.Forms.TextBox();
            this.lblKelimeIng = new System.Windows.Forms.Label();
            this.txtBoxTurk = new System.Windows.Forms.TextBox();
            this.lblKelimeTurk = new System.Windows.Forms.Label();
            this.tbPageSinav = new System.Windows.Forms.TabPage();
            this.btnSinavaBasla = new System.Windows.Forms.Button();
            this.pnlSinavBilgi = new System.Windows.Forms.Panel();
            this.tbPageAyar = new System.Windows.Forms.TabPage();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbBoxKelimeSayi = new System.Windows.Forms.ComboBox();
            this.tbPageAnalizRap = new System.Windows.Forms.TabPage();
            this.pnlAlan = new System.Windows.Forms.Panel();
            this.prBarBasariYuzde = new System.Windows.Forms.ProgressBar();
            this.lblSinavBasari = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPageKelimeEkle.SuspendLayout();
            this.tbPageSinav.SuspendLayout();
            this.tbPageAyar.SuspendLayout();
            this.tbPageAnalizRap.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPageKelimeEkle);
            this.tabControl1.Controls.Add(this.tbPageSinav);
            this.tabControl1.Controls.Add(this.tbPageAyar);
            this.tabControl1.Controls.Add(this.tbPageAnalizRap);
            this.tabControl1.Location = new System.Drawing.Point(-2, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 513);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPageKelimeEkle
            // 
            this.tbPageKelimeEkle.Controls.Add(this.btnResimEkle);
            this.tbPageKelimeEkle.Controls.Add(this.btnKelimeKayit);
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxCumle);
            this.tbPageKelimeEkle.Controls.Add(this.lblCumle);
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxIng);
            this.tbPageKelimeEkle.Controls.Add(this.lblKelimeIng);
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxTurk);
            this.tbPageKelimeEkle.Controls.Add(this.lblKelimeTurk);
            this.tbPageKelimeEkle.Location = new System.Drawing.Point(4, 25);
            this.tbPageKelimeEkle.Name = "tbPageKelimeEkle";
            this.tbPageKelimeEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageKelimeEkle.Size = new System.Drawing.Size(793, 484);
            this.tbPageKelimeEkle.TabIndex = 0;
            this.tbPageKelimeEkle.Text = "Kelime Ekleme";
            this.tbPageKelimeEkle.UseVisualStyleBackColor = true;
            this.tbPageKelimeEkle.Click += new System.EventHandler(this.tbPageKelimeEkle_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.Location = new System.Drawing.Point(574, 29);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(206, 49);
            this.btnResimEkle.TabIndex = 16;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnKelimeKayit
            // 
            this.btnKelimeKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeKayit.Location = new System.Drawing.Point(279, 408);
            this.btnKelimeKayit.Name = "btnKelimeKayit";
            this.btnKelimeKayit.Size = new System.Drawing.Size(288, 49);
            this.btnKelimeKayit.TabIndex = 15;
            this.btnKelimeKayit.Text = "Kelime Kaydet";
            this.btnKelimeKayit.UseVisualStyleBackColor = true;
            this.btnKelimeKayit.Click += new System.EventHandler(this.btnKelimeKayit_Click);
            // 
            // txtBoxCumle
            // 
            this.txtBoxCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxCumle.Location = new System.Drawing.Point(296, 164);
            this.txtBoxCumle.Multiline = true;
            this.txtBoxCumle.Name = "txtBoxCumle";
            this.txtBoxCumle.Size = new System.Drawing.Size(189, 177);
            this.txtBoxCumle.TabIndex = 14;
            // 
            // lblCumle
            // 
            this.lblCumle.AutoSize = true;
            this.lblCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCumle.Location = new System.Drawing.Point(98, 163);
            this.lblCumle.Name = "lblCumle";
            this.lblCumle.Size = new System.Drawing.Size(181, 29);
            this.lblCumle.TabIndex = 13;
            this.lblCumle.Text = "Örnek Cümle:";
            // 
            // txtBoxIng
            // 
            this.txtBoxIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxIng.Location = new System.Drawing.Point(296, 28);
            this.txtBoxIng.Name = "txtBoxIng";
            this.txtBoxIng.Size = new System.Drawing.Size(189, 30);
            this.txtBoxIng.TabIndex = 12;
            // 
            // lblKelimeIng
            // 
            this.lblKelimeIng.AutoSize = true;
            this.lblKelimeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeIng.Location = new System.Drawing.Point(64, 29);
            this.lblKelimeIng.Name = "lblKelimeIng";
            this.lblKelimeIng.Size = new System.Drawing.Size(215, 29);
            this.lblKelimeIng.TabIndex = 11;
            this.lblKelimeIng.Text = "İngilizce Kelime:";
            // 
            // txtBoxTurk
            // 
            this.txtBoxTurk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTurk.Location = new System.Drawing.Point(296, 97);
            this.txtBoxTurk.Name = "txtBoxTurk";
            this.txtBoxTurk.Size = new System.Drawing.Size(189, 30);
            this.txtBoxTurk.TabIndex = 10;
            // 
            // lblKelimeTurk
            // 
            this.lblKelimeTurk.AutoSize = true;
            this.lblKelimeTurk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeTurk.Location = new System.Drawing.Point(24, 96);
            this.lblKelimeTurk.Name = "lblKelimeTurk";
            this.lblKelimeTurk.Size = new System.Drawing.Size(255, 29);
            this.lblKelimeTurk.TabIndex = 9;
            this.lblKelimeTurk.Text = "Kelimenin Türkçesi:";
            // 
            // tbPageSinav
            // 
            this.tbPageSinav.Controls.Add(this.btnSinavaBasla);
            this.tbPageSinav.Controls.Add(this.pnlSinavBilgi);
            this.tbPageSinav.Location = new System.Drawing.Point(4, 25);
            this.tbPageSinav.Name = "tbPageSinav";
            this.tbPageSinav.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSinav.Size = new System.Drawing.Size(793, 484);
            this.tbPageSinav.TabIndex = 1;
            this.tbPageSinav.Text = "Sınav";
            this.tbPageSinav.UseVisualStyleBackColor = true;
            this.tbPageSinav.Click += new System.EventHandler(this.tbPageSinav_Click);
            // 
            // btnSinavaBasla
            // 
            this.btnSinavaBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavaBasla.Location = new System.Drawing.Point(536, 401);
            this.btnSinavaBasla.Name = "btnSinavaBasla";
            this.btnSinavaBasla.Size = new System.Drawing.Size(230, 42);
            this.btnSinavaBasla.TabIndex = 1;
            this.btnSinavaBasla.Text = "Sınava Başla";
            this.btnSinavaBasla.UseVisualStyleBackColor = true;
            this.btnSinavaBasla.Click += new System.EventHandler(this.btnSinavaBasla_Click);
            // 
            // pnlSinavBilgi
            // 
            this.pnlSinavBilgi.Location = new System.Drawing.Point(27, 30);
            this.pnlSinavBilgi.Name = "pnlSinavBilgi";
            this.pnlSinavBilgi.Size = new System.Drawing.Size(468, 413);
            this.pnlSinavBilgi.TabIndex = 0;
            // 
            // tbPageAyar
            // 
            this.tbPageAyar.Controls.Add(this.btnCikis);
            this.tbPageAyar.Controls.Add(this.cmbBoxKelimeSayi);
            this.tbPageAyar.Location = new System.Drawing.Point(4, 25);
            this.tbPageAyar.Name = "tbPageAyar";
            this.tbPageAyar.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageAyar.Size = new System.Drawing.Size(793, 484);
            this.tbPageAyar.TabIndex = 2;
            this.tbPageAyar.Text = "Ayarlar";
            this.tbPageAyar.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(472, 362);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(199, 44);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cmbBoxKelimeSayi
            // 
            this.cmbBoxKelimeSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBoxKelimeSayi.FormattingEnabled = true;
            this.cmbBoxKelimeSayi.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10",
            "15",
            "20",
            "30",
            "50"});
            this.cmbBoxKelimeSayi.Location = new System.Drawing.Point(125, 85);
            this.cmbBoxKelimeSayi.Name = "cmbBoxKelimeSayi";
            this.cmbBoxKelimeSayi.Size = new System.Drawing.Size(226, 37);
            this.cmbBoxKelimeSayi.TabIndex = 0;
            this.cmbBoxKelimeSayi.Text = "Kelime Sayısı";
            // 
            // tbPageAnalizRap
            // 
            this.tbPageAnalizRap.Controls.Add(this.pnlAlan);
            this.tbPageAnalizRap.Controls.Add(this.prBarBasariYuzde);
            this.tbPageAnalizRap.Controls.Add(this.lblSinavBasari);
            this.tbPageAnalizRap.Controls.Add(this.btnYazdir);
            this.tbPageAnalizRap.Location = new System.Drawing.Point(4, 25);
            this.tbPageAnalizRap.Name = "tbPageAnalizRap";
            this.tbPageAnalizRap.Size = new System.Drawing.Size(793, 484);
            this.tbPageAnalizRap.TabIndex = 3;
            this.tbPageAnalizRap.Text = "Analiz Raporu";
            this.tbPageAnalizRap.UseVisualStyleBackColor = true;
            // 
            // pnlAlan
            // 
            this.pnlAlan.Location = new System.Drawing.Point(244, 183);
            this.pnlAlan.Name = "pnlAlan";
            this.pnlAlan.Size = new System.Drawing.Size(538, 289);
            this.pnlAlan.TabIndex = 3;
            // 
            // prBarBasariYuzde
            // 
            this.prBarBasariYuzde.Location = new System.Drawing.Point(244, 118);
            this.prBarBasariYuzde.Name = "prBarBasariYuzde";
            this.prBarBasariYuzde.Size = new System.Drawing.Size(328, 35);
            this.prBarBasariYuzde.TabIndex = 2;
            // 
            // lblSinavBasari
            // 
            this.lblSinavBasari.AutoSize = true;
            this.lblSinavBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavBasari.Location = new System.Drawing.Point(239, 59);
            this.lblSinavBasari.Name = "lblSinavBasari";
            this.lblSinavBasari.Size = new System.Drawing.Size(333, 29);
            this.lblSinavBasari.TabIndex = 1;
            this.lblSinavBasari.Text = "Sınavlarda Başarı Durumu";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(19, 12);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(128, 42);
            this.btnYazdir.TabIndex = 0;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tabControl1.ResumeLayout(false);
            this.tbPageKelimeEkle.ResumeLayout(false);
            this.tbPageKelimeEkle.PerformLayout();
            this.tbPageSinav.ResumeLayout(false);
            this.tbPageAyar.ResumeLayout(false);
            this.tbPageAnalizRap.ResumeLayout(false);
            this.tbPageAnalizRap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPageKelimeEkle;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.Button btnKelimeKayit;
        private System.Windows.Forms.TextBox txtBoxCumle;
        private System.Windows.Forms.Label lblCumle;
        private System.Windows.Forms.TextBox txtBoxIng;
        private System.Windows.Forms.Label lblKelimeIng;
        private System.Windows.Forms.TextBox txtBoxTurk;
        private System.Windows.Forms.Label lblKelimeTurk;
        private System.Windows.Forms.TabPage tbPageSinav;
        private System.Windows.Forms.Button btnSinavaBasla;
        private System.Windows.Forms.Panel pnlSinavBilgi;
        private System.Windows.Forms.TabPage tbPageAyar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbBoxKelimeSayi;
        private System.Windows.Forms.TabPage tbPageAnalizRap;
        private System.Windows.Forms.Panel pnlAlan;
        private System.Windows.Forms.ProgressBar prBarBasariYuzde;
        private System.Windows.Forms.Label lblSinavBasari;
        private System.Windows.Forms.Button btnYazdir;
    }
}