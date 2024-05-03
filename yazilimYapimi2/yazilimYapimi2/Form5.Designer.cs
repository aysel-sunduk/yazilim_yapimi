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
            this.txtBoxSoru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSinavBitir
            // 
            this.btnSinavBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavBitir.Location = new System.Drawing.Point(525, 295);
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
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(12, 295);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(148, 55);
            this.btnC.TabIndex = 9;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(186, 210);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(153, 57);
            this.btnB.TabIndex = 8;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(12, 210);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(148, 57);
            this.btnA.TabIndex = 7;
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // txtBoxSoru
            // 
            this.txtBoxSoru.Location = new System.Drawing.Point(12, 12);
            this.txtBoxSoru.Multiline = true;
            this.txtBoxSoru.Name = "txtBoxSoru";
            this.txtBoxSoru.Size = new System.Drawing.Size(327, 165);
            this.txtBoxSoru.TabIndex = 6;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSinavBitir);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.txtBoxSoru);
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
        private System.Windows.Forms.TextBox txtBoxSoru;
    }
}