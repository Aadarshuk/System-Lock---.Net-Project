namespace System_Lock
{
    partial class ChangeSecurityQuestion
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
            this.changeSecurityQuestionLb = new System.Windows.Forms.Label();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetLb = new System.Windows.Forms.GroupBox();
            this.ShowPassCb = new System.Windows.Forms.CheckBox();
            this.enterPassLb = new System.Windows.Forms.Label();
            this.enterCurrentPassTb = new System.Windows.Forms.TextBox();
            this.cancelBt = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.resetLb.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.changeSecurityQuestionLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(534, 30);
            this.header.TabIndex = 2;
            // 
            // changeSecurityQuestionLb
            // 
            this.changeSecurityQuestionLb.AutoSize = true;
            this.changeSecurityQuestionLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.changeSecurityQuestionLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeSecurityQuestionLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeSecurityQuestionLb.Location = new System.Drawing.Point(176, 4);
            this.changeSecurityQuestionLb.Name = "changeSecurityQuestionLb";
            this.changeSecurityQuestionLb.Size = new System.Drawing.Size(200, 18);
            this.changeSecurityQuestionLb.TabIndex = 3;
            this.changeSecurityQuestionLb.Text = "Change Security Question";
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(504, 0);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resetLb
            // 
            this.resetLb.Controls.Add(this.ShowPassCb);
            this.resetLb.Controls.Add(this.enterPassLb);
            this.resetLb.Controls.Add(this.enterCurrentPassTb);
            this.resetLb.Controls.Add(this.cancelBt);
            this.resetLb.Controls.Add(this.okBtn);
            this.resetLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.resetLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetLb.Location = new System.Drawing.Point(12, 36);
            this.resetLb.Name = "resetLb";
            this.resetLb.Size = new System.Drawing.Size(509, 178);
            this.resetLb.TabIndex = 4;
            this.resetLb.TabStop = false;
            this.resetLb.Text = "Reset Security Question";
            // 
            // ShowPassCb
            // 
            this.ShowPassCb.AutoSize = true;
            this.ShowPassCb.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassCb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPassCb.Location = new System.Drawing.Point(232, 70);
            this.ShowPassCb.Name = "ShowPassCb";
            this.ShowPassCb.Size = new System.Drawing.Size(126, 19);
            this.ShowPassCb.TabIndex = 39;
            this.ShowPassCb.Text = "Show password";
            this.ShowPassCb.UseVisualStyleBackColor = false;
            this.ShowPassCb.CheckedChanged += new System.EventHandler(this.ShowPassCb_CheckedChanged_1);
            // 
            // enterPassLb
            // 
            this.enterPassLb.AutoSize = true;
            this.enterPassLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.enterPassLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterPassLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enterPassLb.Location = new System.Drawing.Point(27, 44);
            this.enterPassLb.Name = "enterPassLb";
            this.enterPassLb.Size = new System.Drawing.Size(181, 18);
            this.enterPassLb.TabIndex = 9;
            this.enterPassLb.Text = "Enter Current Password :";
            // 
            // enterCurrentPassTb
            // 
            this.enterCurrentPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCurrentPassTb.Location = new System.Drawing.Point(232, 39);
            this.enterCurrentPassTb.Multiline = true;
            this.enterCurrentPassTb.Name = "enterCurrentPassTb";
            this.enterCurrentPassTb.Size = new System.Drawing.Size(253, 25);
            this.enterCurrentPassTb.TabIndex = 8;
            // 
            // cancelBt
            // 
            this.cancelBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelBt.Location = new System.Drawing.Point(378, 122);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(107, 40);
            this.cancelBt.TabIndex = 7;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = false;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okBtn.Location = new System.Drawing.Point(259, 122);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(113, 40);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ChangeSecurityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(533, 226);
            this.Controls.Add(this.resetLb);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeSecurityQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.resetLb.ResumeLayout(false);
            this.resetLb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label changeSecurityQuestionLb;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox resetLb;
        private System.Windows.Forms.Label enterPassLb;
        private System.Windows.Forms.TextBox enterCurrentPassTb;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.CheckBox ShowPassCb;
    }
}