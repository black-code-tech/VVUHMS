using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVUHMS.Forms.UserControls.Nurse;
using VVUHMS.Forms.UserControls.DoctorForms;

namespace VVUHMS.Forms.UserControls
{
    public partial class NursePage : UserControl
    {

        #region Instance
        /// <summary>
        /// Creating an instance of the class
        /// </summary>
        static NursePage _obj;

        public static NursePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new NursePage();
                }
                return _obj;
            }
        }

        #endregion

        #region Constructor
        public NursePage()
        {
            InitializeComponent();

            //The following 4 lines will dock search page in nurse page
            _obj = this;
            SearchPage sp = new SearchPage();
            sp.Dock = DockStyle.Fill;
            NursePnlContainer.Controls.Add(sp);

            SideMenu.Width = 55;
            picLogo.Visible = false;
        }
        #endregion

        #region NursePnlContainer
        /// <summary>
        /// Assigning controls to the Nurse Body Panel.
        /// </summary>
        public Panel NursePnlContainer
        {
            get
            { 
                return NurseBodyPanel;
            }

            set
            {
                NurseBodyPanel = value;
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
        private void btnSearchRecords_Click(object sender, EventArgs e)
        {
            Instance.NursePnlContainer.Controls["SearchPage"].BringToFront();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.NursePnlContainer.Controls.ContainsKey("AddRecordPage"))
            {
                AddRecordPage arp = new AddRecordPage();
                arp.Dock = DockStyle.Fill;
                Instance.NursePnlContainer.Controls.Add(arp);
            }

            //Bring the user control to the front of the nurse page..
            Instance.NursePnlContainer.Controls["AddRecordPage"].BringToFront();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.NursePnlContainer.Controls.ContainsKey("UpdateRecordsPage"))
            {
                UpdateRecordsPage urp = new UpdateRecordsPage();
                urp.Dock = DockStyle.Fill;
                Instance.NursePnlContainer.Controls.Add(urp);
            }

            //Bring the user control to the front of the nurse page..
            Instance.NursePnlContainer.Controls["UpdateRecordsPage"].BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.NursePnlContainer.Controls.ContainsKey("profile"))
            {
                profile pro = new profile();
                pro.Dock = DockStyle.Fill;
                Instance.NursePnlContainer.Controls.Add(pro);
            }

            //Bring the user control to the front of the nurse page..
            Instance.NursePnlContainer.Controls["profile"].BringToFront();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            ParentForm.Close();

            lf.Show();

        }
        #endregion

        
    }
}
