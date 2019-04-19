using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Lock
{
    public partial class IncorrectPassword : Form
    {
        public IncorrectPassword()
        {
            InitializeComponent();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
