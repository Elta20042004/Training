namespace Test_I
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
            this.usButtonFormIII1 = new Test_I.UsButtonFormIII();
            this.usButtonFormIII2 = new Test_I.UsButtonFormIII();
            this.usButtonFormIII3 = new Test_I.UsButtonFormIII();
            this.uc1 = new Test_I.UC();
            this.SuspendLayout();
            // 
            // usButtonFormIII1
            // 
            this.usButtonFormIII1.Location = new System.Drawing.Point(12, 12);
            this.usButtonFormIII1.Name = "usButtonFormIII1";
            this.usButtonFormIII1.Size = new System.Drawing.Size(210, 40);
            this.usButtonFormIII1.TabIndex = 0;
            // 
            // usButtonFormIII2
            // 
            this.usButtonFormIII2.Location = new System.Drawing.Point(12, 58);
            this.usButtonFormIII2.Name = "usButtonFormIII2";
            this.usButtonFormIII2.Size = new System.Drawing.Size(210, 40);
            this.usButtonFormIII2.TabIndex = 1;
            // 
            // usButtonFormIII3
            // 
            this.usButtonFormIII3.Location = new System.Drawing.Point(12, 104);
            this.usButtonFormIII3.Name = "usButtonFormIII3";
            this.usButtonFormIII3.Size = new System.Drawing.Size(210, 40);
            this.usButtonFormIII3.TabIndex = 2;
            // 
            // uc1
            // 
            this.uc1.DoSomething = null;
            this.uc1.Location = new System.Drawing.Point(12, 191);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(210, 150);
            this.uc1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 419);
            this.Controls.Add(this.uc1);
            this.Controls.Add(this.usButtonFormIII3);
            this.Controls.Add(this.usButtonFormIII2);
            this.Controls.Add(this.usButtonFormIII1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UsButtonFormIII usButtonFormIII1;
        private UsButtonFormIII usButtonFormIII2;
        private UsButtonFormIII usButtonFormIII3;
        private UC uc1;
    }
}