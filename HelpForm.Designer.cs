namespace System_Lock
{
    partial class HelpForm
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
            this.helpLb = new System.Windows.Forms.Label();
            this.closeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InitialPassLb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.helpLb);
            this.header.Controls.Add(this.closeBt);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Location = new System.Drawing.Point(1, -1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1063, 32);
            this.header.TabIndex = 3;
            // 
            // helpLb
            // 
            this.helpLb.AutoSize = true;
            this.helpLb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.helpLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.helpLb.Location = new System.Drawing.Point(492, 4);
            this.helpLb.Name = "helpLb";
            this.helpLb.Size = new System.Drawing.Size(42, 18);
            this.helpLb.TabIndex = 3;
            this.helpLb.Text = "Help";
            // 
            // closeBt
            // 
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeBt.BackgroundImage = global::System_Lock.Properties.Resources.close_button1;
            this.closeBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBt.Location = new System.Drawing.Point(1033, 0);
            this.closeBt.Name = "closeBt";
            this.closeBt.Size = new System.Drawing.Size(30, 32);
            this.closeBt.TabIndex = 1;
            this.closeBt.UseVisualStyleBackColor = false;
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::System_Lock.Properties.Resources.help2;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InitialPassLb
            // 
            this.InitialPassLb.AutoSize = true;
            this.InitialPassLb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialPassLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InitialPassLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InitialPassLb.Location = new System.Drawing.Point(9, 34);
            this.InitialPassLb.Name = "InitialPassLb";
            this.InitialPassLb.Size = new System.Drawing.Size(150, 17);
            this.InitialPassLb.TabIndex = 10;
            this.InitialPassLb.Text = "Initially password is 0000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::System_Lock.Properties.Resources.helpform1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1041, 519);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1065, 585);
            this.Controls.Add(this.InitialPassLb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label helpLb;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label InitialPassLb;
    }
}