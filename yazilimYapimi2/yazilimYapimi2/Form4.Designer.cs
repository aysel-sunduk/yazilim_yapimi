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
            this.txtBoxCumle2 = new System.Windows.Forms.TextBox();
            this.lblCumle2 = new System.Windows.Forms.Label();
            this.txtBoxCumle = new System.Windows.Forms.TextBox();
            this.lblCumle = new System.Windows.Forms.Label();
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
            this.tabControl1.Location = new System.Drawing.Point(-2, -4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 641);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPageKelimeEkle
            // 
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxCumle2);
            this.tbPageKelimeEkle.Controls.Add(this.lblCumle2);
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxCumle);
            this.tbPageKelimeEkle.Controls.Add(this.lblCumle);
            this.tbPageKelimeEkle.Controls.Add(this.btnResimEkle);
            this.tbPageKelimeEkle.Controls.Add(this.btnKelimeKayit);
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxIng);
            this.tbPageKelimeEkle.Controls.Add(this.lblKelimeIng);
            this.tbPageKelimeEkle.Controls.Add(this.txtBoxTurk);
            this.tbPageKelimeEkle.Controls.Add(this.lblKelimeTurk);
            this.tbPageKelimeEkle.Location = new System.Drawing.Point(4, 29);
            this.tbPageKelimeEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageKelimeEkle.Name = "tbPageKelimeEkle";
            this.tbPageKelimeEkle.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageKelimeEkle.Size = new System.Drawing.Size(893, 608);
            this.tbPageKelimeEkle.TabIndex = 0;
            this.tbPageKelimeEkle.Text = "Kelime Ekleme";
            this.tbPageKelimeEkle.UseVisualStyleBackColor = true;
            this.tbPageKelimeEkle.Click += new System.EventHandler(this.tbPageKelimeEkle_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimEkle.Location = new System.Drawing.Point(646, 36);
            this.btnResimEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(232, 61);
            this.btnResimEkle.TabIndex = 16;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // btnKelimeKayit
            // 
            this.btnKelimeKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeKayit.Location = new System.Drawing.Point(314, 510);
            this.btnKelimeKayit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKelimeKayit.Name = "btnKelimeKayit";
            this.btnKelimeKayit.Size = new System.Drawing.Size(324, 61);
            this.btnKelimeKayit.TabIndex = 15;
            this.btnKelimeKayit.Text = "Kelime Kaydet";
            this.btnKelimeKayit.UseVisualStyleBackColor = true;
            this.btnKelimeKayit.Click += new System.EventHandler(this.btnKelimeKayit_Click);
            // 
            // txtBoxIng
            // 
            this.txtBoxIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxIng.Location = new System.Drawing.Point(333, 35);
            this.txtBoxIng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxIng.Name = "txtBoxIng";
            this.txtBoxIng.Size = new System.Drawing.Size(212, 35);
            this.txtBoxIng.TabIndex = 12;
            // 
            // lblKelimeIng
            // 
            this.lblKelimeIng.AutoSize = true;
            this.lblKelimeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeIng.Location = new System.Drawing.Point(72, 36);
            this.lblKelimeIng.Name = "lblKelimeIng";
            this.lblKelimeIng.Size = new System.Drawing.Size(246, 36);
            this.lblKelimeIng.TabIndex = 11;
            this.lblKelimeIng.Text = "İngilizce Kelime:";
            // 
            // txtBoxTurk
            // 
            this.txtBoxTurk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTurk.Location = new System.Drawing.Point(333, 121);
            this.txtBoxTurk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTurk.Name = "txtBoxTurk";
            this.txtBoxTurk.Size = new System.Drawing.Size(212, 35);
            this.txtBoxTurk.TabIndex = 10;
            // 
            // lblKelimeTurk
            // 
            this.lblKelimeTurk.AutoSize = true;
            this.lblKelimeTurk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeTurk.Location = new System.Drawing.Point(27, 120);
            this.lblKelimeTurk.Name = "lblKelimeTurk";
            this.lblKelimeTurk.Size = new System.Drawing.Size(293, 36);
            this.lblKelimeTurk.TabIndex = 9;
            this.lblKelimeTurk.Text = "Kelimenin Türkçesi:";
            // 
            // tbPageSinav
            // 
            this.tbPageSinav.Controls.Add(this.btnSinavaBasla);
            this.tbPageSinav.Controls.Add(this.pnlSinavBilgi);
            this.tbPageSinav.Location = new System.Drawing.Point(4, 29);
            this.tbPageSinav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageSinav.Name = "tbPageSinav";
            this.tbPageSinav.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageSinav.Size = new System.Drawing.Size(893, 608);
            this.tbPageSinav.TabIndex = 1;
            this.tbPageSinav.Text = "Sınav";
            this.tbPageSinav.UseVisualStyleBackColor = true;
            this.tbPageSinav.Click += new System.EventHandler(this.tbPageSinav_Click);
            // 
            // btnSinavaBasla
            // 
            this.btnSinavaBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavaBasla.Location = new System.Drawing.Point(603, 501);
            this.btnSinavaBasla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSinavaBasla.Name = "btnSinavaBasla";
            this.btnSinavaBasla.Size = new System.Drawing.Size(259, 52);
            this.btnSinavaBasla.TabIndex = 1;
            this.btnSinavaBasla.Text = "Sınava Başla";
            this.btnSinavaBasla.UseVisualStyleBackColor = true;
            this.btnSinavaBasla.Click += new System.EventHandler(this.btnSinavaBasla_Click);
            // 
            // pnlSinavBilgi
            // 
            this.pnlSinavBilgi.Location = new System.Drawing.Point(30, 38);
            this.pnlSinavBilgi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSinavBilgi.Name = "pnlSinavBilgi";
            this.pnlSinavBilgi.Size = new System.Drawing.Size(526, 516);
            this.pnlSinavBilgi.TabIndex = 0;
            // 
            // tbPageAyar
            // 
            this.tbPageAyar.Controls.Add(this.btnCikis);
            this.tbPageAyar.Controls.Add(this.cmbBoxKelimeSayi);
            this.tbPageAyar.Location = new System.Drawing.Point(4, 29);
            this.tbPageAyar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageAyar.Name = "tbPageAyar";
            this.tbPageAyar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageAyar.Size = new System.Drawing.Size(893, 608);
            this.tbPageAyar.TabIndex = 2;
            this.tbPageAyar.Text = "Ayarlar";
            this.tbPageAyar.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(531, 452);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(224, 55);
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
            this.cmbBoxKelimeSayi.Location = new System.Drawing.Point(141, 106);
            this.cmbBoxKelimeSayi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBoxKelimeSayi.Name = "cmbBoxKelimeSayi";
            this.cmbBoxKelimeSayi.Size = new System.Drawing.Size(254, 44);
            this.cmbBoxKelimeSayi.TabIndex = 0;
            this.cmbBoxKelimeSayi.Text = "Kelime Sayısı";
            // 
            // tbPageAnalizRap
            // 
            this.tbPageAnalizRap.Controls.Add(this.pnlAlan);
            this.tbPageAnalizRap.Controls.Add(this.prBarBasariYuzde);
            this.tbPageAnalizRap.Controls.Add(this.lblSinavBasari);
            this.tbPageAnalizRap.Controls.Add(this.btnYazdir);
            this.tbPageAnalizRap.Location = new System.Drawing.Point(4, 29);
            this.tbPageAnalizRap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPageAnalizRap.Name = "tbPageAnalizRap";
            this.tbPageAnalizRap.Size = new System.Drawing.Size(893, 608);
            this.tbPageAnalizRap.TabIndex = 3;
            this.tbPageAnalizRap.Text = "Analiz Raporu";
            this.tbPageAnalizRap.UseVisualStyleBackColor = true;
            // 
            // pnlAlan
            // 
            this.pnlAlan.Location = new System.Drawing.Point(274, 229);
            this.pnlAlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAlan.Name = "pnlAlan";
            this.pnlAlan.Size = new System.Drawing.Size(605, 361);
            this.pnlAlan.TabIndex = 3;
            // 
            // prBarBasariYuzde
            // 
            this.prBarBasariYuzde.Location = new System.Drawing.Point(274, 148);
            this.prBarBasariYuzde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prBarBasariYuzde.Name = "prBarBasariYuzde";
            this.prBarBasariYuzde.Size = new System.Drawing.Size(369, 44);
            this.prBarBasariYuzde.TabIndex = 2;
            // 
            // lblSinavBasari
            // 
            this.lblSinavBasari.AutoSize = true;
            this.lblSinavBasari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinavBasari.Location = new System.Drawing.Point(269, 74);
            this.lblSinavBasari.Name = "lblSinavBasari";
            this.lblSinavBasari.Size = new System.Drawing.Size(385, 36);
            this.lblSinavBasari.TabIndex = 1;
            this.lblSinavBasari.Text = "Sınavlarda Başarı Durumu";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.Location = new System.Drawing.Point(21, 15);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(144, 52);
            this.btnYazdir.TabIndex = 0;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // txtBoxCumle2
            // 
            this.txtBoxCumle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxCumle2.Location = new System.Drawing.Point(333, 315);
            this.txtBoxCumle2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCumle2.Multiline = true;
            this.txtBoxCumle2.Name = "txtBoxCumle2";
            this.txtBoxCumle2.Size = new System.Drawing.Size(212, 53);
            this.txtBoxCumle2.TabIndex = 20;
            // 
            // lblCumle2
            // 
            this.lblCumle2.AutoSize = true;
            this.lblCumle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCumle2.Location = new System.Drawing.Point(95, 312);
            this.lblCumle2.Name = "lblCumle2";
            this.lblCumle2.Size = new System.Drawing.Size(225, 36);
            this.lblCumle2.TabIndex = 19;
            this.lblCumle2.Text = "Örnek Cümle2:";
            // 
            // txtBoxCumle
            // 
            this.txtBoxCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxCumle.Location = new System.Drawing.Point(333, 215);
            this.txtBoxCumle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCumle.Multiline = true;
            this.txtBoxCumle.Name = "txtBoxCumle";
            this.txtBoxCumle.Size = new System.Drawing.Size(212, 53);
            this.txtBoxCumle.TabIndex = 18;
            // 
            // lblCumle
            // 
            this.lblCumle.AutoSize = true;
            this.lblCumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCumle.Location = new System.Drawing.Point(110, 215);
            this.lblCumle.Name = "lblCumle";
            this.lblCumle.Size = new System.Drawing.Size(207, 36);
            this.lblCumle.TabIndex = 17;
            this.lblCumle.Text = "Örnek Cümle:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtBoxCumle2;
        private System.Windows.Forms.Label lblCumle2;
        private System.Windows.Forms.TextBox txtBoxCumle;
        private System.Windows.Forms.Label lblCumle;
    }
}