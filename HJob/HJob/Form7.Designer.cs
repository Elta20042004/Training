namespace HJob
{
    partial class Form7
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
            this.Lena = new System.Windows.Forms.Label();
            this.textBoxLena = new System.Windows.Forms.TextBox();
            this.SendFromLena = new System.Windows.Forms.Button();
            this.ChatForLena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lena
            // 
            this.Lena.AutoSize = true;
            this.Lena.Location = new System.Drawing.Point(12, 890);
            this.Lena.Name = "Lena";
            this.Lena.Size = new System.Drawing.Size(40, 17);
            this.Lena.TabIndex = 0;
            this.Lena.Text = "Lena";
            // 
            // textBoxLena
            // 
            this.textBoxLena.Location = new System.Drawing.Point(13, 13);
            this.textBoxLena.Name = "textBoxLena";
            this.textBoxLena.Size = new System.Drawing.Size(524, 22);
            this.textBoxLena.TabIndex = 1;
            // 
            // SendFromLena
            // 
            this.SendFromLena.Location = new System.Drawing.Point(543, 13);
            this.SendFromLena.Name = "SendFromLena";
            this.SendFromLena.Size = new System.Drawing.Size(75, 23);
            this.SendFromLena.TabIndex = 2;
            this.SendFromLena.Text = "Send";
            this.SendFromLena.UseVisualStyleBackColor = true;
            this.SendFromLena.Click += new System.EventHandler(this.SendFromLena_Click);
            // 
            // ChatForLena
            // 
            this.ChatForLena.AutoSize = true;
            this.ChatForLena.Location = new System.Drawing.Point(13, 42);
            this.ChatForLena.Name = "ChatForLena";
            this.ChatForLena.Size = new System.Drawing.Size(0, 17);
            this.ChatForLena.TabIndex = 3;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 916);
            this.Controls.Add(this.ChatForLena);
            this.Controls.Add(this.SendFromLena);
            this.Controls.Add(this.textBoxLena);
            this.Controls.Add(this.Lena);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lena;
        private System.Windows.Forms.TextBox textBoxLena;
        private System.Windows.Forms.Button SendFromLena;
        private System.Windows.Forms.Label ChatForLena;
    }
}