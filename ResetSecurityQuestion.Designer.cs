namespace System_Lock
{
    partial class ResetSecurityQuestion
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
            this.resetQuesLb = new System.Windows.Forms.Label();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForgotPassGb = new System.Windows.Forms.GroupBox();
            this.resetQuesCb = new System.Windows.Forms.ComboBox();
            this.SecurityQuesLb = new System.Windows.Forms.Label();
            this.resetAnsTb = new System.Windows.Forms.TextBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.resetBt = new System.Windows.Forms.Button();
            this.AnswerLb = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ForgotPassGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.resetQuesLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(594, 29);
            this.header.TabIndex = 3;
            // 
            // resetQuesLb
            // 
            this.resetQuesLb.AutoSize = true;
            this.resetQuesLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.resetQuesLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetQuesLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resetQuesLb.Location = new System.Drawing.Point(193, 4);
            this.resetQuesLb.Name = "resetQuesLb";
            this.resetQuesLb.Size = new System.Drawing.Size(179, 18);
            this.resetQuesLb.TabIndex = 3;
            this.resetQuesLb.Text = "Reset Security Question";
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(564, 0);
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
            // ForgotPassGb
            // 
            this.ForgotPassGb.Controls.Add(this.resetQuesCb);
            this.ForgotPassGb.Controls.Add(this.SecurityQuesLb);
            this.ForgotPassGb.Controls.Add(this.resetAnsTb);
            this.ForgotPassGb.Controls.Add(this.cancelBt);
            this.ForgotPassGb.Controls.Add(this.resetBt);
            this.ForgotPassGb.Controls.Add(this.AnswerLb);
            this.ForgotPassGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ForgotPassGb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForgotPassGb.Location = new System.Drawing.Point(12, 35);
            this.ForgotPassGb.Name = "ForgotPassGb";
            this.ForgotPassGb.Size = new System.Drawing.Size(565, 207);
            this.ForgotPassGb.TabIndex = 4;
            this.ForgotPassGb.TabStop = false;
            this.ForgotPassGb.Text = "Reset Question";
            // 
            // resetQuesCb
            // 
            this.resetQuesCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetQuesCb.FormattingEnabled = true;
            this.resetQuesCb.Items.AddRange(new object[] {
            "What was your favorite place to visit as a child?",
            "Who is your favorite actor, musician, or artist?",
            "What is the name of your favorite pet?",
            "In what city were you born?",
            "What high school did you attend?",
            "What is the name of your first school?",
            "What is your favorite movie?",
            "What is your mother\'s maiden name?",
            "What street did you grow up on?",
            "What was the make of your first car?",
            "When is your anniversary?",
            "What is your favorite color?",
            "What is your father\'s middle name?"});
            this.resetQuesCb.Location = new System.Drawing.Point(232, 39);
            this.resetQuesCb.Name = "resetQuesCb";
            this.resetQuesCb.Size = new System.Drawing.Size(301, 24);
            this.resetQuesCb.TabIndex = 10;
            this.resetQuesCb.Text = "Select question...";
            // 
            // SecurityQuesLb
            // 
            this.SecurityQuesLb.AutoSize = true;
            this.SecurityQuesLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.SecurityQuesLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecurityQuesLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SecurityQuesLb.Location = new System.Drawing.Point(23, 40);
            this.SecurityQuesLb.Name = "SecurityQuesLb";
            this.SecurityQuesLb.Size = new System.Drawing.Size(205, 18);
            this.SecurityQuesLb.TabIndex = 9;
            this.SecurityQuesLb.Text = "Choose Security Question :";
            // 
            // resetAnsTb
            // 
            this.resetAnsTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnsTb.Location = new System.Drawing.Point(232, 90);
            this.resetAnsTb.Name = "resetAnsTb";
            this.resetAnsTb.Size = new System.Drawing.Size(301, 22);
            this.resetAnsTb.TabIndex = 8;
            // 
            // cancelBt
            // 
            this.cancelBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBt.Location = new System.Drawing.Point(413, 142);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(120, 40);
            this.cancelBt.TabIndex = 7;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = false;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // resetBt
            // 
            this.resetBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.resetBt.FlatAppearance.BorderSize = 0;
            this.resetBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.resetBt.Location = new System.Drawing.Point(279, 142);
            this.resetBt.Name = "resetBt";
            this.resetBt.Size = new System.Drawing.Size(128, 40);
            this.resetBt.TabIndex = 6;
            this.resetBt.Text = "Reset";
            this.resetBt.UseVisualStyleBackColor = false;
            this.resetBt.Click += new System.EventHandler(this.resetBt_Click);
            // 
            // AnswerLb
            // 
            this.AnswerLb.AutoSize = true;
            this.AnswerLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.AnswerLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AnswerLb.Location = new System.Drawing.Point(23, 91);
            this.AnswerLb.Name = "AnswerLb";
            this.AnswerLb.Size = new System.Drawing.Size(69, 18);
            this.AnswerLb.TabIndex = 3;
            this.AnswerLb.Text = "Answer :";
            // 
            // ResetSecurityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(593, 261);
            this.Controls.Add(this.ForgotPassGb);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetSecurityQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetSecurityQuestion";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ForgotPassGb.ResumeLayout(false);
            this.ForgotPassGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label resetQuesLb;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ForgotPassGb;
        private System.Windows.Forms.Label SecurityQuesLb;
        private System.Windows.Forms.TextBox resetAnsTb;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button resetBt;
        private System.Windows.Forms.Label AnswerLb;
        private System.Windows.Forms.ComboBox resetQuesCb;


    }
}