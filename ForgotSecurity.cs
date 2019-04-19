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
    public partial class ForgotSecurity : Form
    {
        StreamReader sr;
        int count = 0;
        public ForgotSecurity()
        {
            InitializeComponent();
        }
        private void cancelBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cross button
        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        
        private void ConfirmBt_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("Security_Questions.txt");
            if (sr.ReadLine().Equals(SecurityQuesCb.Text) && count <= 2)
            {
                sr.Close();
                sr = new StreamReader("Answer.txt");
                if (sr.ReadLine().Equals(newPassTb.Text))
                {
                    Message msg = new Message("correct question answer");
                    msg.Show();
                    count = 0;
                }
                else
                {
                    count++;
                    Message msg = new Message("Security ques_ans error");
                    msg.Show();
                }
            }
            else if ((sr.ReadLine() != newPassTb.Text) && count <= 2)
            {
                count++;
                Message msg = new Message("Security ques_ans error");
                msg.Show();
            }
            else
            {
                Capture capture = new Capture();
                capture.captureImage();
                count = 0;
            }
            sr.Close();
            this.Close();
        }
    }
}
