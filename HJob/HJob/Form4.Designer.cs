namespace HJob
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
            this.RBSumma = new System.Windows.Forms.RadioButton();
            this.RBUmnozhenie = new System.Windows.Forms.RadioButton();
            this.RBMax = new System.Windows.Forms.RadioButton();
            this.ButOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RBSumma
            // 
            this.RBSumma.AutoSize = true;
            this.RBSumma.Location = new System.Drawing.Point(13, 13);
            this.RBSumma.Name = "RBSumma";
            this.RBSumma.Size = new System.Drawing.Size(76, 21);
            this.RBSumma.TabIndex = 0;
            this.RBSumma.TabStop = true;
            this.RBSumma.Text = "Summa";
            this.RBSumma.UseVisualStyleBackColor = true;
            // 
            // RBUmnozhenie
            // 
            this.RBUmnozhenie.AutoSize = true;
            this.RBUmnozhenie.Location = new System.Drawing.Point(13, 41);
            this.RBUmnozhenie.Name = "RBUmnozhenie";
            this.RBUmnozhenie.Size = new System.Drawing.Size(108, 21);
            this.RBUmnozhenie.TabIndex = 1;
            this.RBUmnozhenie.TabStop = true;
            this.RBUmnozhenie.Text = "Umnozhenie";
            this.RBUmnozhenie.UseVisualStyleBackColor = true;
            // 
            // RBMax
            // 
            this.RBMax.AutoSize = true;
            this.RBMax.Location = new System.Drawing.Point(13, 69);
            this.RBMax.Name = "RBMax";
            this.RBMax.Size = new System.Drawing.Size(54, 21);
            this.RBMax.TabIndex = 2;
            this.RBMax.TabStop = true;
            this.RBMax.Text = "Max";
            this.RBMax.UseVisualStyleBackColor = true;
            // 
            // ButOK
            // 
            this.ButOK.Location = new System.Drawing.Point(13, 97);
            this.ButOK.Name = "ButOK";
            this.ButOK.Size = new System.Drawing.Size(75, 23);
            this.ButOK.TabIndex = 3;
            this.ButOK.Text = "OK";
            this.ButOK.UseVisualStyleBackColor = true;
            this.ButOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 550);
            this.Controls.Add(this.ButOK);
            this.Controls.Add(this.RBMax);
            this.Controls.Add(this.RBUmnozhenie);
            this.Controls.Add(this.RBSumma);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBSumma;
        private System.Windows.Forms.RadioButton RBUmnozhenie;
        private System.Windows.Forms.RadioButton RBMax;
        private System.Windows.Forms.Button ButOK;
    }
}