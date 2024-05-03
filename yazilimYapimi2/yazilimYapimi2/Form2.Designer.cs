namespace yazilimYapimi2
{
    partial class Form2
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
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.txtBoxKayitAdSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxKayitEmail = new System.Windows.Forms.TextBox();
            this.txtBoxKayitSifre = new System.Windows.Forms.TextBox();
            this.lblKayitEmail = new System.Windows.Forms.Label();
            this.lblKayitSifre = new System.Windows.Forms.Label();
            this.lblKayitAdSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.Location = new System.Drawing.Point(232, 277);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(157, 43);
            this.btnKayitOl.TabIndex = 15;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // txtBoxKayitAdSoyad
            // 
            this.txtBoxKayitAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKayitAdSoyad.Location = new System.Drawing.Point(243, 42);
            this.txtBoxKayitAdSoyad.Name = "txtBoxKayitAdSoyad";
            this.txtBoxKayitAdSoyad.Size = new System.Drawing.Size(189, 30);
            this.txtBoxKayitAdSoyad.TabIndex = 14;
            // 
            // txtBoxKayitEmail
            // 
            this.txtBoxKayitEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKayitEmail.Location = new System.Drawing.Point(243, 89);
            this.txtBoxKayitEmail.Name = "txtBoxKayitEmail";
            this.txtBoxKayitEmail.Size = new System.Drawing.Size(189, 30);
            this.txtBoxKayitEmail.TabIndex = 13;
            // 
            // txtBoxKayitSifre
            // 
            this.txtBoxKayitSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKayitSifre.Location = new System.Drawing.Point(243, 137);
            this.txtBoxKayitSifre.Name = "txtBoxKayitSifre";
            this.txtBoxKayitSifre.Size = new System.Drawing.Size(189, 30);
            this.txtBoxKayitSifre.TabIndex = 12;
            // 
            // lblKayitEmail
            // 
            this.lblKayitEmail.AutoSize = true;
            this.lblKayitEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitEmail.Location = new System.Drawing.Point(90, 88);
            this.lblKayitEmail.Name = "lblKayitEmail";
            this.lblKayitEmail.Size = new System.Drawing.Size(91, 29);
            this.lblKayitEmail.TabIndex = 11;
            this.lblKayitEmail.Text = "Email:";
            // 
            // lblKayitSifre
            // 
            this.lblKayitSifre.AutoSize = true;
            this.lblKayitSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitSifre.Location = new System.Drawing.Point(90, 136);
            this.lblKayitSifre.Name = "lblKayitSifre";
            this.lblKayitSifre.Size = new System.Drawing.Size(100, 29);
            this.lblKayitSifre.TabIndex = 10;
            this.lblKayitSifre.Text = "Parola:";
            // 
            // lblKayitAdSoyad
            // 
            this.lblKayitAdSoyad.AutoSize = true;
            this.lblKayitAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitAdSoyad.Location = new System.Drawing.Point(42, 41);
            this.lblKayitAdSoyad.Name = "lblKayitAdSoyad";
            this.lblKayitAdSoyad.Size = new System.Drawing.Size(139, 29);
            this.lblKayitAdSoyad.TabIndex = 9;
            this.lblKayitAdSoyad.Text = "Ad Soyad:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.txtBoxKayitAdSoyad);
            this.Controls.Add(this.txtBoxKayitEmail);
            this.Controls.Add(this.txtBoxKayitSifre);
            this.Controls.Add(this.lblKayitEmail);
            this.Controls.Add(this.lblKayitSifre);
            this.Controls.Add(this.lblKayitAdSoyad);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.TextBox txtBoxKayitAdSoyad;
        private System.Windows.Forms.TextBox txtBoxKayitEmail;
        private System.Windows.Forms.TextBox txtBoxKayitSifre;
        private System.Windows.Forms.Label lblKayitEmail;
        private System.Windows.Forms.Label lblKayitSifre;
        private System.Windows.Forms.Label lblKayitAdSoyad;
    }
}