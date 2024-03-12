using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDiary
{
    public partial class log_In_Form : Form
    {

        private Size oldFormSize;
        public log_In_Form()
        {
            InitializeComponent();

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 41);
        }

        private void MyLabelSize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            passwordField.Size = new Size(Size.Width * passwordField.Size.Width / oldFormSize.Width, Size.Height * passwordField.Size.Height / oldFormSize.Height);
        }
    }
}
