using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVUHMS
{
    public partial class ConfirmToClose : Form
    {
        public ConfirmToClose()
        {
            InitializeComponent();
        }

        private void btnYes_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnNo_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
