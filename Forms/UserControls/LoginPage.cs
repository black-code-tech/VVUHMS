using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;
using BunifuAnimatorNS;
using System.Data.SqlClient;
using System.IO;

namespace VVUHMS.Forms.UserControls
{
    public partial class LoginPage : UserControl
    {
        #region Global variables
        Staff model = new Staff();

        /// <summary>
        /// These are boolean variables to determine the users job.
        /// </summary>
        bool isNurse = false;
        bool isDoctor = false;
        bool isPharmacist = false;
        bool isAdmin = false;
        #endregion

        #region Constructor
        public LoginPage()
        {
            InitializeComponent();
            pages.SetPage(2);
        }
        #endregion

        #region Read More
        /// <summary>
        /// This function is fired if the read more button is clicked
        /// and it redirects one to the vvu website.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadMore_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vvu.edu.gh");
        }
        #endregion

        #region Sign In

        /// <summary>
        /// This functions is fired if the sign in button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void checkEnterPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                ValidateLogin();
            }
        }

        public void ValidateLogin()
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                string msg = "Please make sure all the fields are filled.";
                //txtError.Visible = true;
                Noti(msg, Notification.enmType.Error);
            }
            else
            {

                if (isDoctor == true)
                {
                    verifyCred("Doctor");
                }
                else if (isNurse == true)
                {
                    verifyCred("Nurse");
                }
                else if (isPharmacist == true)
                {
                    verifyCred("Pharmacist");
                }
                else if (isAdmin == true)
                {
                    verifyCred("Admin");
                }
            }
        }

        /// <summary>
        /// Verify the credentials entered by the user
        /// </summary>
        /// <param name="Job"></param>
        public void verifyCred(string Job)
        {
            string query = "";

            query = "select StaffID,Password from dbo.Staff where Position = '" + Job +"'" +
                      " and StaffID = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text
                      + "'";

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

            try
            {
                using (var conn = new SqlConnection(connInfo))
                {
                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    int i = ds.Tables[0].Rows.Count;

                    if (i == 1)
                    {
                        using (var db = new VVUHMSEntities())
                        {
                            model = db.Staffs.Where(x => x.StaffID == txtUserName.Text).FirstOrDefault();

                            string fn = model.FirstName;
                            string on = model.OtherName;
                            string ln = model.LastName;

                            string username = fn + " " + on + " " + ln;
                            File.WriteAllText("username.txt", username);
                            File.WriteAllText("userID.txt", txtUserName.Text);
                        }
                        ParentForm.Hide();
                        Main main = new Main(Job);
                        main.Show();
                    }
                    else
                    {
                        string msg = "Sorry your credentials are incorrect !!";
                        Noti(msg, Notification.enmType.Error);
                    }
                }
            }
            catch (Exception a)
            {
                Noti(a.ToString(), Notification.enmType.Info);
                MessageBox.Show(a.Message,"Error");
            }
        }
        #endregion

        #region Notification
        public void Noti(string msg, Notification.enmType type)
        {
            Notification noti = new Notification();

            noti.showAlert(msg, type);
        }
        #endregion

        #region Forgot password
        /// <summary>
        /// If you forgot password button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forgotPass_Click(object sender, EventArgs e)
        {
            pages.SetPage(1);
        }

        /// <summary>
        /// This function is fired if, the user clicks the ok button
        /// in the forgot page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            pages.SetPage(0);
        }
        #endregion

        #region Back button
        private void txtBack_Click(object sender, EventArgs e)
        {
            pages.SetPage(2);
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
        #endregion

        #region Select Job Type
        private void JobSelected(object sender, EventArgs e)
        {
            pages.SetPage(0);


            BunifuButton btn = (BunifuButton)sender;

            if (btn.Text == "A Nurse")
            {

                isNurse = true;
                isDoctor = false;
                isPharmacist = false;
                isAdmin = false;

            }
            else if (btn.Text == "An Admin")
            {
                isNurse = false;
                isDoctor = false;
                isPharmacist = false;
                isAdmin = true;
            }
            else if (btn.Text == "A Doctor")
            {
                isNurse = false;
                isDoctor = true;
                isPharmacist = false;
                isAdmin = false;
            }
            else if (btn.Text == "A Pharmacist")
            {
                isNurse = false;
                isDoctor = false;
                isPharmacist = true;
                isAdmin = false;
            }
        }

        #endregion

        #region On form load
        /// <summary>
        /// This function is fired when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtYear.Text = "Copyright " + DateTime.Now.Year.ToString() + ". All rights reserved by VVUHMS";
        }
        #endregion

    }
}
