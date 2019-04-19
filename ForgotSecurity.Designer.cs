namespace System_Lock
{
    partial class ForgotSecurity
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
            this.ForgotPasswordLb = new System.Windows.Forms.Label();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForgotPassGb = new System.Windows.Forms.GroupBox();
            this.SecurityQuesCb = new System.Windows.Forms.ComboBox();
            this.SecurityQuesLb = new System.Windows.Forms.Label();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.ConfirmBt = new System.Windows.Forms.Button();
            this.AnswerLb = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ForgotPassGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.ForgotPasswordLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(591, 29);
            this.header.TabIndex = 2;
            // 
            // ForgotPasswordLb
            // 
            this.ForgotPasswordLb.AutoSize = true;
            this.ForgotPasswordLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForgotPasswordLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForgotPasswordLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ForgotPasswordLb.Location = new System.Drawing.Point(230, 4);
            this.ForgotPasswordLb.Name = "ForgotPasswordLb";
            this.ForgotPasswordLb.Size = new System.Drawing.Size(125, 18);
            this.ForgotPasswordLb.TabIndex = 3;
            this.ForgotPasswordLb.Text = "Forgot Password";
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(558, 0);
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
            this.ForgotPassGb.Controls.Add(this.SecurityQuesCb);
            this.ForgotPassGb.Controls.Add(this.SecurityQuesLb);
            this.ForgotPassGb.Controls.Add(this.newPassTb);
            this.ForgotPassGb.Controls.Add(this.cancelBt);
            this.ForgotPassGb.Controls.Add(this.ConfirmBt);
            this.ForgotPassGb.Controls.Add(this.AnswerLb);
            this.ForgotPassGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.ForgotPassGb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForgotPassGb.Location = new System.Drawing.Point(14, 35);
            this.ForgotPassGb.Name = "ForgotPassGb";
            this.ForgotPassGb.Size = new System.Drawing.Size(562, 225);
            this.ForgotPassGb.TabIndex = 3;
            this.ForgotPassGb.TabStop = false;
            this.ForgotPassGb.Text = "Forgot Password";
            // 
            // SecurityQuesCb
            // 
            this.SecurityQuesCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecurityQuesCb.FormattingEnabled = true;
            this.SecurityQuesCb.Items.AddRange(new object[] {
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
            this.SecurityQuesCb.Location = new System.Drawing.Point(232, 39);
            this.SecurityQuesCb.Name = "SecurityQuesCb";
            this.SecurityQuesCb.Size = new System.Drawing.Size(301, 24);
            this.SecurityQuesCb.TabIndex = 10;
            this.SecurityQuesCb.Text = "Select question...";
            // 
            // SecurityQuesLb
            // 
            this.SecurityQuesLb.AutoSize = true;
            this.SecurityQuesLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.SecurityQuesLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecurityQuesLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SecurityQuesLb.Location = new System.Drawing.Point(32, 43);
            this.SecurityQuesLb.Name = "SecurityQuesLb";
            this.SecurityQuesLb.Size = new System.Drawing.Size(144, 18);
            this.SecurityQuesLb.TabIndex = 9;
            this.SecurityQuesLb.Text = "Security Question :";
            // 
            // newPassTb
            // 
            this.newPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTb.Location = new System.Drawing.Point(232, 90);
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.Size = new System.Drawing.Size(301, 22);
            this.newPassTb.TabIndex = 8;
            // 
            // cancelBt
            // 
            this.cancelBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBt.Location = new System.Drawing.Point(413, 158);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(120, 40);
            this.cancelBt.TabIndex = 7;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = false;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // ConfirmBt
            // 
            this.ConfirmBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ConfirmBt.FlatAppearance.BorderSize = 0;
            this.ConfirmBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfirmBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConfirmBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConfirmBt.Location = new System.Drawing.Point(279, 158);
            this.ConfirmBt.Name = "ConfirmBt";
            this.ConfirmBt.Size = new System.Drawing.Size(128, 40);
            this.ConfirmBt.TabIndex = 6;
            this.ConfirmBt.Text = "Confirm";
            this.ConfirmBt.UseVisualStyleBackColor = false;
            this.ConfirmBt.Click += new System.EventHandler(this.ConfirmBt_Click);
            // 
            // AnswerLb
            // 
            this.AnswerLb.AutoSize = true;
            this.AnswerLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.AnswerLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AnswerLb.Location = new System.Drawing.Point(32, 90);
            this.AnswerLb.Name = "AnswerLb";
            this.AnswerLb.Size = new System.Drawing.Size(69, 18);
            this.AnswerLb.TabIndex = 3;
            this.AnswerLb.Text = "Answer :";
            // 
            // ForgotSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(588, 275);
            this.Controls.Add(this.ForgotPassGb);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotSecurity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ForgotPassGb.ResumeLayout(false);
            this.ForgotPassGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label ForgotPasswordLb;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox ForgotPassGb;
        private System.Windows.Forms.Label SecurityQuesLb;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button ConfirmBt;
        private System.Windows.Forms.Label AnswerLb;
        private System.Windows.Forms.ComboBox SecurityQuesCb;
    }
}