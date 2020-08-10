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
using VVUHMS.Forms.UserControls;

namespace VVUHMS.Forms
{
    public partial class Main : Form
    {

        #region Global Variables
        string username = "";
        double x, y;
        #endregion

        #region Instances
        static Main _obj;

        public static Main Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Main();
                }
                return _obj;
            }
        }
        

        /// <summary>
        /// To help place user controls in the main page
        /// </summary>
        public Panel PnlContainer
        {
            get
            {
                return Body;
            }

            set
            {
                Body = value;
            }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// This is the main constructor for the class
        /// </summary>
        public Main()
        {
            InitializeComponent();

            _obj = this;

            x = Screen.PrimaryScreen.WorkingArea.Width;
            y = Screen.PrimaryScreen.WorkingArea.Height;

            this.Width = (int) x;
            this.Height = (int) y;
            // Starting the timer
            //timer1.Start();
        }
        
        public Main(string formToOpen)
        {
            InitializeComponent();
            username = File.ReadAllText("username.txt");

            _obj = this;

            x = Screen.PrimaryScreen.WorkingArea.Width;
            y = Screen.PrimaryScreen.WorkingArea.Height * 0.999;

            this.Width = (int) x;
            this.Height = (int) y;
            // Starting the timer
            //timer1.Start();

            if (formToOpen == "Nurse")
            {
                //Checking if Nurse page user control has been added or not
                if (!Instance.PnlContainer.Controls.ContainsKey("NursePage"))
                {
                    NursePage np = new NursePage();
                    np.Dock = DockStyle.Fill;
                    Instance.PnlContainer.Controls.Add(np);
                }

                //Brings the user control to the front of the Main page..
                Instance.PnlContainer.Controls["NursePage"].BringToFront();
                string title = "Ns.";
                txtUsername.Text = title + " " + username;
                txtUsername.Visible = true;
            }
            else if (formToOpen == "Doctor")
            {
                //Checking if Doctor user control has been added or not
                if (!Instance.PnlContainer.Controls.ContainsKey("Doctor"))
                {
                    DoctorPage doc = new DoctorPage();
                    doc.Dock = DockStyle.Fill;
                    Instance.PnlContainer.Controls.Add(doc);
                }

                //Brings the user control to the front of the Main page..
                Instance.PnlContainer.Controls["Doctor"].BringToFront();

                string title = "Dr.";
                txtUsername.Text = title + " " + username;
                txtUsername.Visible = true;
            }
            else if (formToOpen == "Pharmacist")
            {
                //Checking if Doctor user control has been added or not
                if (!Instance.PnlContainer.Controls.ContainsKey("PharmacistPage"))
                {
                    PharmacistPage ph = new PharmacistPage();
                    ph.Dock = DockStyle.Fill;
                    Instance.PnlContainer.Controls.Add(ph);
                }

                //Brings the user control to the front of the Main page..
                Instance.PnlContainer.Controls["PharmacistPage"].BringToFront();

                string title = "Phar.";
                txtUsername.Text = title + " " + username;
                txtUsername.Visible = true;
            }
            else if (formToOpen == "Admin")
            {
                //Checking if Doctor user control has been added or not
                if (!Instance.PnlContainer.Controls.ContainsKey("AdminPage"))
                {
                    AdminPage ap = new AdminPage();
                    ap.Dock = DockStyle.Fill;
                    Instance.PnlContainer.Controls.Add(ap);
                }

                //Brings the user control to the front of the Main page..
                Instance.PnlContainer.Controls["AdminPage"].BringToFront();

                string title = "Admin.";
                txtUsername.Text = title + " " + username;
                txtUsername.Visible = true;
            }
        }

        #endregion

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
            catch (Exception a)
            {
                MessageBox.Show(a.Message,"Error");
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
                //maximize.Image = img;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

                Image img = Image.FromFile("C:\\Users\\Daniel Otoo\\source\\repos\\VVUHMS\\Images\\maximize.png");
                //maximize.Image = img;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
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
