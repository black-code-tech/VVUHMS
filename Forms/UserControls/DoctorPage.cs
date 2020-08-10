using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVUHMS.Forms.UserControls.DoctorForms;

namespace VVUHMS.Forms.UserControls
{
    public partial class DoctorPage : UserControl
    {

        #region Instance
        /// <summary>
        /// Creating an instance of the class
        /// </summary>
        static DoctorPage _obj;

        public static DoctorPage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new DoctorPage();
                }
                return _obj;
            }
        }

        #endregion

        #region Constructor
        public DoctorPage()
        {
            InitializeComponent();

            //The following 4 lines will dock search page in doctor page
            _obj = this;
            ConsultPatients cp = new ConsultPatients();
            cp.Dock = DockStyle.Fill;
            DoctorPnlContainer.Controls.Add(cp);

            SideMenu.Width = 55;
            picLogo.Visible = false;
        }
        #endregion

        #region DoctorPnlContainer
        /// <summary>
        /// Assigning controls to the Nurse Body Panel.
        /// </summary>
        public Panel DoctorPnlContainer
        {
            get
            {
                return DoctorBodyPanel;
            }

            set
            {
                DoctorBodyPanel = value;
            }
        }
        #endregion

        #region Menu
        /// <summary>
        /// This method is going to deal with the animated showing and
        /// hiding of the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picMenuBtn_Click(object sender, EventArgs e)
        {
            if (SideMenu.Width == 55)
            {
                SideMenu.Visible = false;
                SideMenu.Width = 250;
                SideMenuTransition.ShowSync(SideMenu);
                logoTransition.ShowSync(picLogo);
            }
            else
            {
                logoTransition.HideSync(picLogo);
                SideMenu.Visible = false;
                SideMenu.Width = 55;
                SideMenuTransition.ShowSync(SideMenu);
            }

        }

        /// <summary>
        /// This will set the coresponding page names to the nurse page
        /// eg. Search record btn will be Search Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitingPatients(object sender, EventArgs e)
        {
            Instance.DoctorPnlContainer.Controls["ConsultPatients"].BringToFront();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.DoctorPnlContainer.Controls.ContainsKey("AddRecordPage"))
            {
                AddRecordPage arp = new AddRecordPage();
                arp.Dock = DockStyle.Fill;
                Instance.DoctorPnlContainer.Controls.Add(arp);
            }

            //Bring the user control to the front of the nurse page..
            Instance.DoctorPnlContainer.Controls["AddRecordPage"].BringToFront();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.DoctorPnlContainer.Controls.ContainsKey("UpdateRecordsPage"))
            {
                UpdateRecordsPage urp = new UpdateRecordsPage();
                urp.Dock = DockStyle.Fill;
                Instance.DoctorPnlContainer.Controls.Add(urp);
            }

            //Bring the user control to the front of the nurse page..
            Instance.DoctorPnlContainer.Controls["UpdateRecordsPage"].BringToFront();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            ParentForm.Close();

            lf.Show();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.DoctorPnlContainer.Controls.ContainsKey("profile"))
            {
                profile pro = new profile();
                pro.Dock = DockStyle.Fill;
                Instance.DoctorPnlContainer.Controls.Add(pro);
            }

            //Bring the user control to the front of the nurse page..
            Instance.DoctorPnlContainer.Controls["profile"].BringToFront();
        }

        private void btnAdmitted_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.DoctorPnlContainer.Controls.ContainsKey("AdmittedPatients"))
            {
                AllDrugs ap = new AllDrugs();
                ap.Dock = DockStyle.Fill;
                Instance.DoctorPnlContainer.Controls.Add(ap);
            }

            //Bring the user control to the front of the nurse page..
            Instance.DoctorPnlContainer.Controls["AdmittedPatients"].BringToFront();
        }

        #endregion

    }
}
