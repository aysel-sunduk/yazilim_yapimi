namespace yazilimYapimi2
{
    partial class Form3
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
            this.btnYeniSifre = new System.Windows.Forms.Button();
            this.txtBoxSifreAlEmail = new System.Windows.Forms.TextBox();
            this.lblSifreAlEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYeniSifre
            // 
            this.btnYeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniSifre.Location = new System.Drawing.Point(329, 175);
            this.btnYeniSifre.Name = "btnYeniSifre";
            this.btnYeniSifre.Size = new System.Drawing.Size(274, 43);
            this.btnYeniSifre.TabIndex = 12;
            this.btnYeniSifre.Text = "Yeni Şifre Al";
            this.btnYeniSifre.UseVisualStyleBackColor = true;
            this.btnYeniSifre.Click += new System.EventHandler(this.btnYeniSifre_Click);
            // 
            // txtBoxSifreAlEmail
            // 
            this.txtBoxSifreAlEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSifreAlEmail.Location = new System.Drawing.Point(171, 48);
            this.txtBoxSifreAlEmail.Name = "txtBoxSifreAlEmail";
            this.txtBoxSifreAlEmail.Size = new System.Drawing.Size(189, 30);
            this.txtBoxSifreAlEmail.TabIndex = 11;
            // 
            // lblSifreAlEmail
            // 
            this.lblSifreAlEmail.AutoSize = true;
            this.lblSifreAlEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreAlEmail.Location = new System.Drawing.Point(53, 49);
            this.lblSifreAlEmail.Name = "lblSifreAlEmail";
            this.lblSifreAlEmail.Size = new System.Drawing.Size(91, 29);
            this.lblSifreAlEmail.TabIndex = 10;
            this.lblSifreAlEmail.Text = "Email:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYeniSifre);
            this.Controls.Add(this.txtBoxSifreAlEmail);
            this.Controls.Add(this.lblSifreAlEmail);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniSifre;
        private System.Windows.Forms.TextBox txtBoxSifreAlEmail;
        private System.Windows.Forms.Label lblSifreAlEmail;
    }
}