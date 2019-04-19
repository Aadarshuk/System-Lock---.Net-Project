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
    public partial class ResetSecurityQuestion : Form
    {
        StreamWriter sw;
        public ResetSecurityQuestion()
        {
            InitializeComponent();
        }
        private void ResetSecurityQuestion_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Security_Questions.txt");
            resetQuesCb.Text = sr.ReadLine();
        }
        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetBt_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter("Security_Questions.txt");
            sw.WriteLine(resetQuesCb.Text);
            sw.Close();
            sw = new StreamWriter("Answer.txt");
            sw.WriteLine(resetAnsTb.Text);
            sw.Close();
            this.Close();
            Message msg = new Message("security question changed");
            msg.Show();
            this.Close();
        }  
    }
}
