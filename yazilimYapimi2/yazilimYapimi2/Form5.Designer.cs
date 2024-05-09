namespace yazilimYapimi2
{
    partial class Form5
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
            this.btnSinavBitir = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinavBitir
            // 
            this.btnSinavBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavBitir.Location = new System.Drawing.Point(496, 348);
            this.btnSinavBitir.Name = "btnSinavBitir";
            this.btnSinavBitir.Size = new System.Drawing.Size(209, 55);
            this.btnSinavBitir.TabIndex = 11;
            this.btnSinavBitir.Text = "Sınavı Bitir";
            this.btnSinavBitir.UseVisualStyleBackColor = true;
            this.btnSinavBitir.Click += new System.EventHandler(this.btnSinavKapat_Click_1);
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(186, 295);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(153, 55);
            this.btnD.TabIndex = 10;
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(12, 295);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(148, 55);
            this.btnC.TabIndex = 9;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(186, 210);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(153, 57);
            this.btnB.TabIndex = 8;
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(12, 210);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(148, 57);
            this.btnA.TabIndex = 7;
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonraki.Location = new System.Drawing.Point(496, 251);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(164, 55);
            this.btnSonraki.TabIndex = 12;
            this.btnSonraki.Text = "BAŞLA";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(604, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(491, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soru :";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(31, 47);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(87, 29);
            this.lblSoru.TabIndex = 15;
            this.lblSoru.Text = "label1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnSinavBitir);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinavBitir;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoru;
    }
}