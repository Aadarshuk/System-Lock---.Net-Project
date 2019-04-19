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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.Win32;
using System.Security;
using System.Security.Principal;

namespace System_Lock
{
    public partial class MainForm : Form
    {
        StreamReader sr;
        int Count = 0;
        //RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
        public MainForm()
        {
            InitializeComponent();
            
            //regkey.SetValue("DisableTaskMgr", "1");
            //regkey.Close();
            
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Failed to disable............" + ex.ToString());
            //}

            PasswordTb.PasswordChar = '⚫';
            PasswordTb.MaxLength = 10;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(ForgotPasswordLlb, " forgot password ");
            toolTip1.SetToolTip(LaunchhBtn, " Submit ");
            toolTip1.SetToolTip(ShutDownBtn, " Shut down ");
            toolTip1.SetToolTip(HelpBtn, " Get help ");
            toolTip1.SetToolTip(PasswordTb, " Enter password here ");
            toolTip1.SetToolTip(SettingBtn, " Setting ");
        }
        //Confirm Password
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == (Keys.Alt | Keys.F4))
        //    {
        //        return true;
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
        
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = true;
        //}
        private void launchhBtn_Click(object sender, EventArgs e)
        {
            sr = new StreamReader("Passward.txt");

            if (PasswordTb.Text == "" && Count <= 2)
            {
                Message msg = new Message("please enter pass");
                msg.Show();
            }
            else if(PasswordTb.Text ==sr.ReadLine() && Count <= 2)
            {
               // Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                Process.Start("C:\\Windows\\explorer.exe");
                Application.Exit();
            }
            else if((PasswordTb.Text != sr.ReadLine()) && Count < 2)
            {
                Count++;
                PasswordTb.Text = "";
                Message msg = new Message("Error");
                msg.Show();
            }
            else
            {
                Directory.CreateDirectory("D:\\Unknown_User");
                Capture capture = new Capture();
                capture.captureImage();
                Count = 0;
                Process.Start("shutdown", "/s /t 0");
            }
            sr.Close();            
        }
        //Shut Down Pc
        private void shutDownBtn_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }
        //For help
        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }
        //Forgot Password
        private void ForgotPasswordLlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotSecurity fs = new ForgotSecurity();
            fs.Show();
        }
        //Taking Password From Picture Box
        private void Sun0_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "0";
        }
        private void MercuryPb1_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "1";
        }
        private void VenusPb2_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "2";
        }
        private void EarthPb3_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "3";
        }
        private void MarsPb4_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "4";
        }
        private void jupiterPb5_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "5";
        }
        private void SiturnPb6_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "6";
        }
        private void UranusPb7_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "7";
        }
        private void NaptunePb8_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "8";
        }
        private void PlutoPb9_Click(object sender, EventArgs e)
        {
            PasswordTb.Text = PasswordTb.Text + "9";
        }
        private void SettingBtn_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, Control.MousePosition);
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm("Change password menu item");
            cpf.Show();
        }
        private void changeSecurityQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSecurityQuestion csq = new ChangeSecurityQuestion();
            csq.Show();
        }
        private void ShowPassCb_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTb.PasswordChar = ShowPassCb.Checked ? '\0' : '⚫';
        }
        private void PasswordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                sr = new StreamReader("Passward.txt");
                if (PasswordTb.Text == "")
                {
                    Message msg = new Message("please enter pass");
                    msg.Show();
                }
                else if (PasswordTb.Text == sr.ReadLine() && Count <= 2)
                {
                   // Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                    Process.Start("C:\\Windows\\explorer.exe");
                    Application.Exit();
                }
                else if ((PasswordTb.Text != sr.ReadLine()) && Count < 2)
                {
                    Count++;
                    PasswordTb.Text = "";
                    Message msg = new Message("Error");
                    msg.Show();
                }
                else
                {
                    //try
                    //{
                    //    Registry.CurrentUser.DeleteSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                    //}
                    //catch(Exception ex)
                    //{
                    //    MessageBox.Show(ex.ToString());
                    //}

                    Directory.CreateDirectory("D:\\Unknown_User");
                    Capture capture = new Capture();
                    capture.captureImage();
                    Count = 0;
                    Process.Start("shutdown", "/s /t 0");

                }
                sr.Close(); 
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        
        }    

    }
}
