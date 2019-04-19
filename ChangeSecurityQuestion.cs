using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Lock
{
    public partial class ChangeSecurityQuestion : Form
    {
        StreamReader sr;
        public ChangeSecurityQuestion()
        {
            InitializeComponent();
            enterCurrentPassTb.PasswordChar = '⚫';
        }
        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("Passward.txt");
            if (enterCurrentPassTb.Text.Equals(sr.ReadLine()))
            {
                ResetSecurityQuestion rsq = new ResetSecurityQuestion();
                rsq.Show();
                sr.Close();          
            }
            else
            {
                Message msg = new Message("Error");
                msg.Show();  
            }
            this.Close();
        }
        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ShowPassCb_CheckedChanged_1(object sender, EventArgs e)
        {
            enterCurrentPassTb.PasswordChar = ShowPassCb.Checked ? '\0' : '⚫';
        }
    }
}
