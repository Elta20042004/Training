namespace HJob
{
    partial class Form11
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.tbText_1 = new System.Windows.Forms.TextBox();
            this.btnSend_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(12, 12);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(619, 350);
            this.dgv_1.TabIndex = 0;
            // 
            // tbText_1
            // 
            this.tbText_1.Location = new System.Drawing.Point(12, 415);
            this.tbText_1.Name = "tbText_1";
            this.tbText_1.Size = new System.Drawing.Size(472, 22);
            this.tbText_1.TabIndex = 1;
            // 
            // btnSend_1
            // 
            this.btnSend_1.Location = new System.Drawing.Point(490, 415);
            this.btnSend_1.Name = "btnSend_1";
            this.btnSend_1.Size = new System.Drawing.Size(140, 23);
            this.btnSend_1.TabIndex = 2;
            this.btnSend_1.Text = "Send";
            this.btnSend_1.UseVisualStyleBackColor = true;
            this.btnSend_1.Click += new System.EventHandler(this.btnSend_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend_1);
            this.Controls.Add(this.tbText_1);
            this.Controls.Add(this.dgv_1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.TextBox tbText_1;
        private System.Windows.Forms.Button btnSend_1;
        private System.Windows.Forms.Label label1;
    }
}