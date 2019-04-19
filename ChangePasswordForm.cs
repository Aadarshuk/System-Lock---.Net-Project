using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime;
using System.IO;

namespace System_Lock
{
    public partial class ChangePasswordForm : Form
    {
        int count = 0;
        StreamReader sr;
        StreamWriter sw;
        public ChangePasswordForm(String a)
        {
            InitializeComponent();
            newPassTb.PasswordChar = '⚫';
            oldPassTb.PasswordChar = '⚫';
            changePassTb.PasswordChar = '⚫';
            String msg = a;
            if (msg == "Forgot Password to Change Password")
            {
                oldPassTb.Visible = false;
                oldPasswordLb.Text = "Provide New Password";
                this.oldPasswordLb.Location = new Point(191,51);
                oldPassTb.BackColor = Color.Black;
                count++;
            }
        }
        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {   
        }
        private void cancelBt_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                Process.Start("C:\\Windows\\explorer.exe");
                Environment.Exit(0);
            }
            this.Close();
        }
        private void changeBt_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("Passward.txt");
            if ((oldPassTb.Text.Equals(sr.ReadLine())) || count > 0 )
            {
                sr.Close();
                sw = new StreamWriter("Passward.txt");
                if (newPassTb.Text.Equals(changePassTb.Text))
                {
                    string pass = changePassTb.Text;
                    sw.WriteLine(pass);
                    sw.Close();
                    Message msg= new Message("Password Successfully Changed");
                    msg.Show();
                    this.Close();       
                }
                else
                {
                    Message msg = new Message("Error");
                    msg.Show();
                }
            }
            else
            {
                Message msg = new Message("incorrect old password");
                msg.Show();
            }
        }
        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            oldPassTb.PasswordChar = ShowPassCb.Checked ? '\0' : '⚫';
            newPassTb.PasswordChar = ShowPassCb.Checked ? '\0' : '⚫';
            changePassTb.PasswordChar = ShowPassCb.Checked ? '\0' : '⚫';
        }
    }
}
