namespace System_Lock
{
    partial class IncorrectPassword
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
            this.incorrectLb = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.CrossPb = new System.Windows.Forms.PictureBox();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.MessageLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(365, 29);
            this.header.TabIndex = 3;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // MessageLb
            // 
            this.MessageLb.AutoSize = true;
            this.MessageLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.MessageLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MessageLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MessageLb.Location = new System.Drawing.Point(142, 4);
            this.MessageLb.Name = "MessageLb";
            this.MessageLb.Size = new System.Drawing.Size(74, 18);
            this.MessageLb.TabIndex = 3;
            this.MessageLb.Text = "Message";
            // 
            // incorrectLb
            // 
            this.incorrectLb.AutoSize = true;
            this.incorrectLb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLb.Location = new System.Drawing.Point(123, 65);
            this.incorrectLb.Name = "incorrectLb";
            this.incorrectLb.Size = new System.Drawing.Size(191, 16);
            this.incorrectLb.TabIndex = 5;
            this.incorrectLb.Text = "The password was Incorrect.";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.okBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okBtn.Location = new System.Drawing.Point(145, 119);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(106, 34);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // CrossPb
            // 
            this.CrossPb.Image = global::System_Lock.Properties.Resources.cross_btn;
            this.CrossPb.Location = new System.Drawing.Point(44, 53);
            this.CrossPb.Name = "CrossPb";
            this.CrossPb.Size = new System.Drawing.Size(45, 46);
            this.CrossPb.TabIndex = 4;
            this.CrossPb.TabStop = false;
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(332, 0);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IncorrectPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(363, 165);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.incorrectLb);
            this.Controls.Add(this.CrossPb);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncorrectPassword";
            this.Text = "IncorrectPassword";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CrossPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label MessageLb;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CrossPb;
        private System.Windows.Forms.Label incorrectLb;
        private System.Windows.Forms.Button okBtn;
    }
}