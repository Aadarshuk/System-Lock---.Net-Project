using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime;
using AForge;

namespace System_Lock
{
    public partial class Message : Form
    {
        String messag;
        public Message(String msg)
        {
            InitializeComponent();
            messag=msg;
            if (messag == "Error")
            {
                YesBt.Visible = false;
                MessageLb.Text = " Error";
                QuestionLb.Text = "The password is incorrect.";
                pictureBox2.Image = Properties.Resources.cross_btn;
                NoBt.Text = "OK";
            }
            else if (messag.Equals("Security ques_ans error"))
            {
                MessageLb.Text = " Error";
                QuestionLb.Text = "Incorrect Security question";
                pictureBox2.Image = Properties.Resources.cross_btn;
                YesBt.Visible = false;
                NoBt.Text = "OK";
            }
            else if(messag.Equals("Password Successfully Changed"))
            {
                MessageLb.Text = " Message";
                QuestionLb.Text = "Password changed sucessfully.";
                pictureBox2.Image = Properties.Resources.correct_check;
                YesBt.Visible = false;
                NoBt.Text = "Ok";
            }
            else if(messag.Equals("incorrect old password"))
            {
                MessageLb.Text = " Error";
                QuestionLb.Text = "The password was not match.";
                pictureBox2.Image = Properties.Resources.cross_btn;
                YesBt.Visible = false;
                NoBt.Text = "Ok";
            }
            else if (messag.Equals("security question changed"))
            {
                MessageLb.Text = " Message";
                QuestionLb.Text = "Security question successfully changed.";
                pictureBox2.Image = Properties.Resources.correct_check;
                YesBt.Visible = false;
                NoBt.Text = "Ok";
            }
            else if (messag.Equals("please enter pass"))
            {
                MessageLb.Text = " Error";
                QuestionLb.Text = "Please enter your password.";
                pictureBox2.Image = Properties.Resources.cross_btn;
                YesBt.Visible = false;
                NoBt.Text = "Ok";
            }
        }
        private void NoBt_Click(object sender, EventArgs e)
        {
            if(messag.Equals("correct question answer"))
            {
                //Process.Start("C:\\Windows\\explorer.exe");
                Application.Exit();
            }
            this.Close();
        }
        //cross button
        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void YesBt_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm("Forgot Password to Change Password");
            cpf.Show();
            this.Close();
        }

        private void QuestionLb_Click(object sender, EventArgs e)
        {

        }
        
    }
}
