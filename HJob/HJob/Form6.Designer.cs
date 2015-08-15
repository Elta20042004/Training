namespace HJob
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.SendFromAlex = new System.Windows.Forms.Button();
            this.textBoxAlex = new System.Windows.Forms.TextBox();
            this.labelForAlex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SendFromAlex
            // 
            this.SendFromAlex.Location = new System.Drawing.Point(525, 12);
            this.SendFromAlex.Name = "SendFromAlex";
            this.SendFromAlex.Size = new System.Drawing.Size(75, 23);
            this.SendFromAlex.TabIndex = 1;
            this.SendFromAlex.Text = "Send";
            this.SendFromAlex.UseVisualStyleBackColor = true;
            this.SendFromAlex.Click += new System.EventHandler(this.SendFromAlex_Click);
            // 
            // textBoxAlex
            // 
            this.textBoxAlex.Location = new System.Drawing.Point(13, 12);
            this.textBoxAlex.Name = "textBoxAlex";
            this.textBoxAlex.Size = new System.Drawing.Size(506, 22);
            this.textBoxAlex.TabIndex = 2;
            // 
            // labelForAlex
            // 
            this.labelForAlex.AutoSize = true;
            this.labelForAlex.Location = new System.Drawing.Point(13, 41);
            this.labelForAlex.Name = "labelForAlex";
            this.labelForAlex.Size = new System.Drawing.Size(0, 17);
            this.labelForAlex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 843);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alex";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 869);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelForAlex);
            this.Controls.Add(this.textBoxAlex);
            this.Controls.Add(this.SendFromAlex);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SendFromAlex;
        private System.Windows.Forms.TextBox textBoxAlex;
        private System.Windows.Forms.Label labelForAlex;
        private System.Windows.Forms.Label label2;
    }
}