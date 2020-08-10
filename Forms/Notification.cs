using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVUHMS.Properties;

namespace VVUHMS.Forms
{
    public partial class Notification : Form
    {
        #region Variables
        private Notification.enmAction action;
        private int x, y;
        #endregion

        #region Constructor
        public Notification()
        {
            InitializeComponent();
        }
        #endregion

        #region Enumeration
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Info,
            Error
        }

        #endregion

        #region Timer
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    this.timer1.Interval = 10000;
                    this.action = enmAction.close;
                    break;
                case enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    this.timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = enmAction.close;
        }

        #region Show alert
        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notification form = (Notification)Application.OpenForms[fname];

                if (form == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                default:
                    break;
            }

            lblMsg.Text = msg;
            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();

        }

        #endregion
    }
}
