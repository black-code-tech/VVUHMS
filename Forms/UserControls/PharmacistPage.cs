using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVUHMS.Forms.UserControls.Pharmacist;
using VVUHMS.Forms.UserControls.DoctorForms;

namespace VVUHMS.Forms.UserControls
{
    public partial class PharmacistPage : UserControl
    {
        #region Instance
        /// <summary>
        /// Creating an instance of the class
        /// </summary>
        static PharmacistPage _obj;

        public static PharmacistPage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new PharmacistPage();
                }
                return _obj;
            }
        }

        #endregion

        #region Constructor
        public PharmacistPage()
        {
            InitializeComponent();

            //The following 4 lines will dock search page in doctor page
            _obj = this;

            AllPatientsPrescription app = new AllPatientsPrescription();
            app.Dock = DockStyle.Fill;
            PharmacyPnlContainer.Controls.Add(app);

            SideMenu.Width = 55;
            picLogo.Visible = false;
        }
        #endregion

        #region PharmacyPnlContainer
        /// <summary>
        /// Assigning controls to the Nurse Body Panel.
        /// </summary>
        public Panel PharmacyPnlContainer
        {
            get
            {
                return PharmacyBodyPanel;
            }

            set
            {
                PharmacyBodyPanel = value;
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
            Instance.PharmacyPnlContainer.Controls["AllPatientsPrescription"].BringToFront();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.PharmacyPnlContainer.Controls.ContainsKey("AddRecordPage"))
            {
                AddRecordPage arp = new AddRecordPage();
                arp.Dock = DockStyle.Fill;
                Instance.PharmacyPnlContainer.Controls.Add(arp);
            }

            //Bring the user control to the front of the nurse page..
            Instance.PharmacyPnlContainer.Controls["AddRecordPage"].BringToFront();
        }

        private void btnAllDrugs_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.PharmacyPnlContainer.Controls.ContainsKey("AllDrugs"))
            {
                AllDrugs ad = new AllDrugs();
                ad.Dock = DockStyle.Fill;
                Instance.PharmacyPnlContainer.Controls.Add(ad);
            }

            //Bring the user control to the front of the nurse page..
            Instance.PharmacyPnlContainer.Controls["AllDrugs"].BringToFront();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.PharmacyPnlContainer.Controls.ContainsKey("UpdateRecordsPage"))
            {
                UpdateRecordsPage urp = new UpdateRecordsPage();
                urp.Dock = DockStyle.Fill;
                Instance.PharmacyPnlContainer.Controls.Add(urp);
            }

            //Bring the user control to the front of the nurse page..
            Instance.PharmacyPnlContainer.Controls["UpdateRecordsPage"].BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Checking if add record page user control has been added or not
            if (!Instance.PharmacyPnlContainer.Controls.ContainsKey("profile"))
            {
                profile pro = new profile();
                pro.Dock = DockStyle.Fill;
                Instance.PharmacyPnlContainer.Controls.Add(pro);
            }

            //Bring the user control to the front of the nurse page..
            Instance.PharmacyPnlContainer.Controls["profile"].BringToFront();
        }

        private void btnOTC_Click(object sender, EventArgs e)
        {
            PatientPrescription pp = new PatientPrescription(-1);
            pp.ShowDialog();
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
