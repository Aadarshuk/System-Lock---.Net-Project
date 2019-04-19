namespace System_Lock
{
    partial class Message
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
            this.header = new System.Windows.Forms.Panel();
            this.MessageLb = new System.Windows.Forms.Label();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.QuestionLb = new System.Windows.Forms.Label();
            this.NoBt = new System.Windows.Forms.Button();
            this.YesBt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.MessageLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(-1, -2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(425, 31);
            this.header.TabIndex = 2;
            // 
            // MessageLb
            // 
            this.MessageLb.AutoSize = true;
            this.MessageLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.MessageLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MessageLb.Location = new System.Drawing.Point(166, 6);
            this.MessageLb.Name = "MessageLb";
            this.MessageLb.Size = new System.Drawing.Size(74, 18);
            this.MessageLb.TabIndex = 3;
            this.MessageLb.Text = "Message";
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(395, 2);
            this.closeBt.Name = "closeBt";
            this.closeBt.Size = new System.Drawing.Size(30, 29);
            this.closeBt.TabIndex = 1;
            this.closeBt.UseVisualStyleBackColor = false;
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::System_Lock.Properties.Resources.forgot_password;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // QuestionLb
            // 
            this.QuestionLb.AutoSize = true;
            this.QuestionLb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLb.Location = new System.Drawing.Point(128, 67);
            this.QuestionLb.Name = "QuestionLb";
            this.QuestionLb.Size = new System.Drawing.Size(268, 16);
            this.QuestionLb.TabIndex = 4;
            this.QuestionLb.Text = "Do you want to change your password ?";
            this.QuestionLb.Click += new System.EventHandler(this.QuestionLb_Click);
            // 
            // NoBt
            // 
            this.NoBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.NoBt.FlatAppearance.BorderSize = 0;
            this.NoBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NoBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NoBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoBt.Location = new System.Drawing.Point(168, 132);
            this.NoBt.Name = "NoBt";
            this.NoBt.Size = new System.Drawing.Size(118, 38);
            this.NoBt.TabIndex = 10;
            this.NoBt.Text = "No";
            this.NoBt.UseVisualStyleBackColor = false;
            this.NoBt.Click += new System.EventHandler(this.NoBt_Click);
            // 
            // YesBt
            // 
            this.YesBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.YesBt.FlatAppearance.BorderSize = 0;
            this.YesBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.YesBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YesBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YesBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YesBt.Location = new System.Drawing.Point(293, 132);
            this.YesBt.Name = "YesBt";
            this.YesBt.Size = new System.Drawing.Size(118, 38);
            this.YesBt.TabIndex = 11;
            this.YesBt.Text = "Yes";
            this.YesBt.UseVisualStyleBackColor = false;
            this.YesBt.Click += new System.EventHandler(this.YesBt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::System_Lock.Properties.Resources.help2;
            this.pictureBox2.Location = new System.Drawing.Point(44, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 182);
            this.Controls.Add(this.YesBt);
            this.Controls.Add(this.NoBt);
            this.Controls.Add(this.QuestionLb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label MessageLb;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label QuestionLb;
        private System.Windows.Forms.Button NoBt;
        private System.Windows.Forms.Button YesBt;

    }
}