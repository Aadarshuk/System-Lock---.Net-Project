namespace System_Lock
{
    partial class ChangePasswordForm
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
            this.changePasswordLb = new System.Windows.Forms.Label();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changePassGb = new System.Windows.Forms.GroupBox();
            this.ShowPassCb = new System.Windows.Forms.CheckBox();
            this.oldPassTb = new System.Windows.Forms.TextBox();
            this.oldPasswordLb = new System.Windows.Forms.Label();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.changeBt = new System.Windows.Forms.Button();
            this.changePassTb = new System.Windows.Forms.TextBox();
            this.newPasswordLb = new System.Windows.Forms.Label();
            this.confirmPasswordLb = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.changePassGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.changePasswordLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(1, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(584, 29);
            this.header.TabIndex = 1;
            // 
            // changePasswordLb
            // 
            this.changePasswordLb.AutoSize = true;
            this.changePasswordLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.changePasswordLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePasswordLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changePasswordLb.Location = new System.Drawing.Point(220, 6);
            this.changePasswordLb.Name = "changePasswordLb";
            this.changePasswordLb.Size = new System.Drawing.Size(139, 18);
            this.changePasswordLb.TabIndex = 3;
            this.changePasswordLb.Text = "Change Password";
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(554, 0);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // changePassGb
            // 
            this.changePassGb.Controls.Add(this.ShowPassCb);
            this.changePassGb.Controls.Add(this.oldPassTb);
            this.changePassGb.Controls.Add(this.oldPasswordLb);
            this.changePassGb.Controls.Add(this.newPassTb);
            this.changePassGb.Controls.Add(this.cancelBt);
            this.changePassGb.Controls.Add(this.changeBt);
            this.changePassGb.Controls.Add(this.changePassTb);
            this.changePassGb.Controls.Add(this.newPasswordLb);
            this.changePassGb.Controls.Add(this.confirmPasswordLb);
            this.changePassGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.changePassGb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePassGb.Location = new System.Drawing.Point(12, 46);
            this.changePassGb.Name = "changePassGb";
            this.changePassGb.Size = new System.Drawing.Size(562, 249);
            this.changePassGb.TabIndex = 2;
            this.changePassGb.TabStop = false;
            this.changePassGb.Text = "Change Password";
            // 
            // ShowPassCb
            // 
            this.ShowPassCb.AutoSize = true;
            this.ShowPassCb.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPassCb.Location = new System.Drawing.Point(232, 161);
            this.ShowPassCb.Name = "ShowPassCb";
            this.ShowPassCb.Size = new System.Drawing.Size(126, 19);
            this.ShowPassCb.TabIndex = 40;
            this.ShowPassCb.Text = "Show password";
            this.ShowPassCb.UseVisualStyleBackColor = false;
            this.ShowPassCb.CheckedChanged += new System.EventHandler(this.ShowPassCb_CheckedChanged);
            // 
            // oldPassTb
            // 
            this.oldPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassTb.Location = new System.Drawing.Point(232, 51);
            this.oldPassTb.Name = "oldPassTb";
            this.oldPassTb.Size = new System.Drawing.Size(301, 22);
            this.oldPassTb.TabIndex = 10;
            // 
            // oldPasswordLb
            // 
            this.oldPasswordLb.AutoSize = true;
            this.oldPasswordLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.oldPasswordLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oldPasswordLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.oldPasswordLb.Location = new System.Drawing.Point(32, 52);
            this.oldPasswordLb.Name = "oldPasswordLb";
            this.oldPasswordLb.Size = new System.Drawing.Size(114, 18);
            this.oldPasswordLb.TabIndex = 9;
            this.oldPasswordLb.Text = "Old Password :";
            // 
            // newPassTb
            // 
            this.newPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTb.Location = new System.Drawing.Point(232, 92);
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.Size = new System.Drawing.Size(301, 22);
            this.newPassTb.TabIndex = 8;
            // 
            // cancelBt
            // 
            this.cancelBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBt.Location = new System.Drawing.Point(413, 197);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(120, 40);
            this.cancelBt.TabIndex = 7;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = false;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // changeBt
            // 
            this.changeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.changeBt.FlatAppearance.BorderSize = 0;
            this.changeBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeBt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeBt.Location = new System.Drawing.Point(279, 197);
            this.changeBt.Name = "changeBt";
            this.changeBt.Size = new System.Drawing.Size(128, 40);
            this.changeBt.TabIndex = 6;
            this.changeBt.Text = "Change";
            this.changeBt.UseVisualStyleBackColor = false;
            this.changeBt.Click += new System.EventHandler(this.changeBt_Click);
            // 
            // changePassTb
            // 
            this.changePassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassTb.Location = new System.Drawing.Point(232, 134);
            this.changePassTb.Name = "changePassTb";
            this.changePassTb.Size = new System.Drawing.Size(301, 22);
            this.changePassTb.TabIndex = 5;
            // 
            // newPasswordLb
            // 
            this.newPasswordLb.AutoSize = true;
            this.newPasswordLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.newPasswordLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newPasswordLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newPasswordLb.Location = new System.Drawing.Point(32, 92);
            this.newPasswordLb.Name = "newPasswordLb";
            this.newPasswordLb.Size = new System.Drawing.Size(120, 18);
            this.newPasswordLb.TabIndex = 3;
            this.newPasswordLb.Text = "New Password :";
            // 
            // confirmPasswordLb
            // 
            this.confirmPasswordLb.AutoSize = true;
            this.confirmPasswordLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.confirmPasswordLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmPasswordLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.confirmPasswordLb.Location = new System.Drawing.Point(32, 134);
            this.confirmPasswordLb.Name = "confirmPasswordLb";
            this.confirmPasswordLb.Size = new System.Drawing.Size(145, 18);
            this.confirmPasswordLb.TabIndex = 2;
            this.confirmPasswordLb.Text = "Confirm Password :";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(586, 309);
            this.Controls.Add(this.changePassGb);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.changePassGb.ResumeLayout(false);
            this.changePassGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label changePasswordLb;
        private System.Windows.Forms.GroupBox changePassGb;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button changeBt;
        private System.Windows.Forms.TextBox changePassTb;
        private System.Windows.Forms.Label newPasswordLb;
        private System.Windows.Forms.Label confirmPasswordLb;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.TextBox oldPassTb;
        private System.Windows.Forms.Label oldPasswordLb;
        private System.Windows.Forms.CheckBox ShowPassCb;


    }
}