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
    public partial class LoginForm : Form
    {
        double x, y;

        public LoginForm()
        {
            InitializeComponent();

            x = Screen.PrimaryScreen.WorkingArea.Width * 0.80;
            y = Screen.PrimaryScreen.WorkingArea.Height * 0.80;

            this.Width = (int)x;
            this.Height = (int)y;
        }

        #region TitleBar

        // Close, Minimize, Restore and Maximize Buttons and their functions
        #region Window Buttons
        /// <summary>
        /// This is to close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            ConfirmToClose confirm = new ConfirmToClose();
            confirm.ShowDialog();

        }

        /// <summary>
        /// This method is used to close the window by shortcut or any
        /// other means apart from the close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ConfirmToClose confirm = new ConfirmToClose();
            //confirm.ShowDialog();
        }

        /// <summary>
        /// This is to deal with the maximization and restoration of the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimize_Click(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Normal)
                {
                    WindowState = FormWindowState.Minimized;
                }
                else if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Minimized;
                }
                else if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        /// <summary>
        /// This is to deal with the minimization of the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Image img = Image.FromFile("C:\\Users\\Daniel Otoo\\source\\repos\\VVUHMS\\Images\\restore_down.png");
                maximize.Image = img;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

                Image img = Image.FromFile("C:\\Users\\Daniel Otoo\\source\\repos\\VVUHMS\\Images\\maximize.png");
                maximize.Image = img;
            }
        }

        #endregion


        //This will update the date and time of txtDateTime
        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtDateTime.Text = DateTime.Now.ToString();
        }


        #endregion
    }
}
