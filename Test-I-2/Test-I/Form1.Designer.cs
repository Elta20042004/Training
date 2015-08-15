namespace Test_I
{
    partial class Form1
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
            this.uc2 = new Test_I.UC();
            this.uc1 = new Test_I.UC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uc2
            // 
            this.uc2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc2.DoSomething = null;
            this.uc2.Location = new System.Drawing.Point(315, 179);
            this.uc2.Name = "uc2";
            this.uc2.Size = new System.Drawing.Size(330, 316);
            this.uc2.TabIndex = 1;
            // 
            // uc1
            // 
            this.uc1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uc1.DoSomething = null;
            this.uc1.Location = new System.Drawing.Point(57, 27);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(150, 150);
            this.uc1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click counter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc2);
            this.Controls.Add(this.uc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC uc1;
        private UC uc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}