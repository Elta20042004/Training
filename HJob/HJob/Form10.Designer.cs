namespace HJob
{
    partial class Form10
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
            this.tbOpenNewChat = new System.Windows.Forms.TextBox();
            this.tbConnect2Chats = new System.Windows.Forms.TextBox();
            this.btnOpenNewChat = new System.Windows.Forms.Button();
            this.btnConnect2Chats = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOpenNewChat
            // 
            this.tbOpenNewChat.Location = new System.Drawing.Point(13, 13);
            this.tbOpenNewChat.Name = "tbOpenNewChat";
            this.tbOpenNewChat.Size = new System.Drawing.Size(311, 22);
            this.tbOpenNewChat.TabIndex = 0;
            // 
            // tbConnect2Chats
            // 
            this.tbConnect2Chats.Location = new System.Drawing.Point(12, 41);
            this.tbConnect2Chats.Name = "tbConnect2Chats";
            this.tbConnect2Chats.Size = new System.Drawing.Size(311, 22);
            this.tbConnect2Chats.TabIndex = 1;
            // 
            // btnOpenNewChat
            // 
            this.btnOpenNewChat.Location = new System.Drawing.Point(331, 11);
            this.btnOpenNewChat.Name = "btnOpenNewChat";
            this.btnOpenNewChat.Size = new System.Drawing.Size(173, 23);
            this.btnOpenNewChat.TabIndex = 2;
            this.btnOpenNewChat.Text = "Open new chat";
            this.btnOpenNewChat.UseVisualStyleBackColor = true;
            this.btnOpenNewChat.Click += new System.EventHandler(this.btnOpenNewChat_Click);
            // 
            // btnConnect2Chats
            // 
            this.btnConnect2Chats.Location = new System.Drawing.Point(330, 39);
            this.btnConnect2Chats.Name = "btnConnect2Chats";
            this.btnConnect2Chats.Size = new System.Drawing.Size(174, 23);
            this.btnConnect2Chats.TabIndex = 3;
            this.btnConnect2Chats.Text = "Connect 2 chats";
            this.btnConnect2Chats.UseVisualStyleBackColor = true;
            this.btnConnect2Chats.Click += new System.EventHandler(this.btnConnect2Chats_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 179);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect2Chats);
            this.Controls.Add(this.btnOpenNewChat);
            this.Controls.Add(this.tbConnect2Chats);
            this.Controls.Add(this.tbOpenNewChat);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOpenNewChat;
        private System.Windows.Forms.TextBox tbConnect2Chats;
        private System.Windows.Forms.Button btnOpenNewChat;
        private System.Windows.Forms.Button btnConnect2Chats;
        private System.Windows.Forms.Button btnCancel;
    }
}