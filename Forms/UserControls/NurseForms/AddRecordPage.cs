using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VVUHMS.Forms.UserControls
{
    public partial class AddRecordPage : UserControl
    {
        #region Global variable
        Patient model = new Patient();

        int randNum;
        #endregion

        #region Constructor
        public AddRecordPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Clear fields
        /// <summary>
        /// This is the method to clear the fields and rename button save
        /// </summary>
        public void clear()
        {
            //Setting the value of the fields to null;
            txtAddress.Text = "";
            txtNHIS.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtOName.Text = "";
            ddSex.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtDisease.Text = "";
            txtPPhone.Text = "";
            txtSPhone.Text = "";
            txtOccupation.Text = "";
            txtDOB.Value = DateTime.Now.Date;
        }
        #endregion

        #region Notificaiton
        /// <summary>
        /// Method to call the notification form
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        public void Alert(string msg, Notification.enmType type)
        {
            Notification noti = new Notification();

            noti.showAlert(msg, type);
        }

        /// <summary>
        /// This method closes the notification window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Alert("All good, proceed", Notification.enmType.Success);
        }
        #endregion

        #region Random Numbers
        /// <summary>
        /// This method will generate random numbers for the patient id
        /// </summary>
        public void GenerateRandomNumber()
        {
            Random r = new Random();
            randNum = r.Next(1000000, 9999999);
        }
        #endregion

        #region Add Record
        /// <summary>
        /// This method checks if the not null fields to be passed to the db
        /// contains values if not requests the user to pass in values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ///Checking if the nescessary fields are filled
            if (txtNHIS.Text == "" || txtFName.Text == "" || txtLName.Text == ""
                || txtAddress.Text == "" || txtPPhone.Text == "" || txtSPhone.Text == ""
                || ddSex.Text == "" || txtDOB.Text == DateTime.Now.Date.ToLongDateString())
            {
                Alert("Make sure all fields are filled properly",Notification.enmType.Warning);
            }
            else
            {
                try
                {
                    GenerateRandomNumber();

                    ///Inserting trimmed values into their respective columns
                    model.FirstName = txtFName.Text.Trim();
                    model.OtherName = txtOName.Text.Trim();
                    model.LastName = txtLName.Text.Trim();
                    model.Email = txtEmail.Text.Trim();
                    model.Address = txtAddress.Text.Trim();
                    model.Primary_Phone = txtPPhone.Text.Trim();
                    model.Secondary_Phone = txtSPhone.Text.Trim();
                    model.Gender = ddSex.Text.Trim();
                    model.NHIS_ID = txtNHIS.Text.Trim();
                    model.DOB = txtDOB.Value;
                    model.Occupation = txtOccupation.Text.Trim();
                    model.Patient_ID = "VVUH" + randNum;


                    using (var db = new VVUHMSEntities())
                    {
                        //Adding to the db
                        db.Patients.Add(model);

                        //Saving to the database
                        db.SaveChanges();
                    }

                    //Calling clear method
                    clear();

                    //Displaying a success message
                    Alert("Submitted Successfully", Notification.enmType.Success);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
        }
        #endregion
 
    }
}
