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
using VVUHMS.Properties;
using System.Data.Entity;

namespace VVUHMS.Forms.UserControls.AdminForms
{
    public partial class SearchPatNStaff : UserControl
    {
        #region Global Variables
        Staff model = new Staff();
        Patient model1 = new Patient();
        string stfID = "";
        string patID = "";
        int val = 0;
        #endregion

        #region Constructor
        public SearchPatNStaff()
        {
            InitializeComponent();
            searchPatients(PatientSearchBox.Text);
            searchStaff(StaffSearchBox.Text);
        }
        #endregion

        #region Load Data
        private void btnAllPatients_Click(object sender, EventArgs e)
        {
            btnAllPatients.Visible = false;
            btnAllStaff.Visible = true;
            materialTabControl1.SelectTab(1);
        }

        private void btnAllStaff_Click(object sender, EventArgs e)
        {
            btnAllStaff.Visible = false;
            btnAllPatients.Visible = true;
            materialTabControl1.SelectTab(0);
        }

        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void searchPatients(string keyword)
        {

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

            ///Creating and instance of the sql connection
            using (var conn = new SqlConnection(connInfo))
            {
                try
                {
                    ///Our query to be run
                    string query = "";

                    if (PatientSearchBox.Text != "")
                    {
                        query = @"select Patient_ID,NHIS_ID, CONCAT(FirstName,' ', OtherName, ' ', LastName) 
                                as Name,Address,DOB,Gender,Email,Occupation
                                ,Primary_Phone,Secondary_Phone from dbo.Patients where
                                    FirstName like '" + keyword + "%'" + "or OtherName like '" + keyword + "%'" +
                                    "or LastName like '" + keyword + "%'" +
                            "or Email like '" + keyword + "%' or Primary_Phone like '" + keyword + "%'" +
                            "or Patient_ID like '" + keyword + "%' or NHIS_ID like '" + keyword + "%';";
                    }
                    else
                    {
                        query = @"select Patient_ID,NHIS_ID, CONCAT(FirstName,' ', OtherName, ' ', LastName) 
                                as Name,Address,DOB,Gender,Email,Occupation
                                ,Primary_Phone,Secondary_Phone from dbo.Patients;";
                    }


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    ///Rendering our data grid view to be read only
                    dgvPatients.ReadOnly = true;

                    dgvPatients.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvPatients.DataSource = ds.Tables[0];

                    /// Clossing our connection to the server
                    //conn.Close();
                }
                catch (Exception a)
                {
                    /// Display errors
                    MessageBox.Show(a.Message);
                }

                numRowsCheck();
            }
        }

        public void PatProfileLoad()
        {
            try
            {
                model1.Patient_ID = dgvPatients.CurrentRow.Cells["Patient_ID"].Value.ToString();
                using (var db = new VVUHMSEntities())
                {
                    model1 = db.Patients.Where(x => x.Patient_ID == model1.Patient_ID).FirstOrDefault();

                    txtNHIS.Text = model1.NHIS_ID;
                    txtPatFName.Text = model1.FirstName;
                    txtPatOName.Text = model1.OtherName;
                    txtPatLName.Text = model1.LastName;
                    txtPatEmail.Text = model1.Email;
                    txtPatAddress.Text = model1.Address;
                    txtPatPPhone.Text = model1.Primary_Phone;
                    txtPatSPhone.Text = model1.Secondary_Phone;
                    ddPatSex.Text = model1.Gender;
                    txtPatOccupation.Text = model1.Occupation;
                    txtPatDOB.Value = model1.DOB;

                }
            }
            catch (Exception a)
            {
                Alert(a.Message, Notification.enmType.Warning);
            }
        }

        private void btnPatUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new VVUHMSEntities())
            {
                model1 = db.Patients.Where(x => x.Patient_ID == model1.Patient_ID).FirstOrDefault();

                model1.NHIS_ID = txtNHIS.Text.Trim();
                model1.FirstName = txtPatFName.Text.Trim();
                model1.OtherName = txtPatOName.Text.Trim();
                model1.LastName = txtPatLName.Text.Trim();
                model1.Email = txtPatEmail.Text.Trim();
                model1.Address = txtPatAddress.Text.Trim();
                model1.Primary_Phone = txtPatPPhone.Text.Trim();
                model1.Secondary_Phone = txtPatSPhone.Text.Trim();
                model1.Occupation = txtPatOccupation.Text.Trim();
                model1.Gender = ddPatSex.Text.Trim();
                model1.DOB = txtPatDOB.Value;

                try
                {
                    db.Entry(model1).State = EntityState.Modified;
                    db.SaveChanges();
                    searchPatients(PatientSearchBox.Text);
                    Alert("Patient Record Updated Successfully.", Notification.enmType.Success);
                }
                catch (Exception a)
                {
                    Alert(a.Message, Notification.enmType.Warning);
                }
            }
        }

        private void btnPatYes_Click(object sender, EventArgs e)
        {
            try
            {
                ///Creating a connection string
                string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";
                string query = @"delete from Patients
                            where Patient_ID = '" + model1.Patient_ID + "';";

                using (SqlConnection connection = new SqlConnection(connInfo))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    //connection.Open();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    searchPatients(PatientSearchBox.Text);
                    Alert("Patient Profile Deleted Successfully", Notification.enmType.Info);
                }
            }
            catch (Exception a)
            {
                Alert(a.Message, Notification.enmType.Error);
            }

            materialTabControl1.SelectTab(1);
        }

        private void btnPatDeleteRecord_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(5);
            btnPatDeleteRecord.Visible = false;
            btnPatientProfile.Visible = false;
        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPatients.CurrentRow.Index != -1)
                {
                    PatProfileLoad();
                    btnPatientProfile.Visible = true;
                    btnPatDeleteRecord.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                Alert("Sorry, no patients available", Notification.enmType.Info);
            }

        }

        private void btnPatDone_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);
        }

        private void btnPatientProfile_Click(object sender, EventArgs e)
        {
            if (txtNHIS.Text == "")
            {
                Alert("No Patient selected", Notification.enmType.Warning);
            }
            else
            {
                materialTabControl1.SelectTab(4);
            }

            btnPatDeleteRecord.Visible = false;
            btnPatientProfile.Visible = false;
        }

        

        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void searchStaff(string keyword)
        {

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

            ///Creating and instance of the sql connection
            using (var conn = new SqlConnection(connInfo))
            {
                try
                {
                    ///Our query to be run
                    string query = "";

                    if (StaffSearchBox.Text != "")
                    {
                        query = @"select StaffID, CONCAT(FirstName, ' ', OtherName, ' ', LastName) as Name,
                                  DOB, Gender, Phone, Position, Salary, Email, Address,Password from dbo.Staff
                                where FirstName like '" + keyword + "%'" +
                            "or OtherName like '" + keyword + "%' or LastName like '" + keyword + "%'" +
                            "or StaffID like '" + keyword + "%' or Address like '" + keyword + "%' or Phone like '"
                            + keyword + "%' or Email like '" + keyword + "%';";
                    }
                    else
                    {
                        query = @"select StaffID, CONCAT(FirstName, ' ', OtherName, ' ', LastName) as Name,
                                  DOB, Gender, Phone, Position, Salary, Email, Address,Password from staff;";
                    }


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    ///Rendering our data grid view to be read only
                    dgvStaff.ReadOnly = true;

                    dgvStaff.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvStaff.DataSource = ds.Tables[0];

                    /// Clossing our connection to the server
                    //conn.Close();
                }
                catch (Exception a)
                {
                    /// Display errors
                    MessageBox.Show(a.Message);
                }

                numRowsCheck();
            }
        }


        private void dgvStaff_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvStaff.CurrentRow.Index != -1)
                {
                    stfProfileLoad();
                    btnStaffProfile.Visible = true;
                    btnStfDeleteRecords.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                Alert("Sorry, no patients available", Notification.enmType.Info);
            }

        }

        #region staffProfileLoad
        public void stfProfileLoad()
        {
            try
            {
                model.StaffID = dgvStaff.CurrentRow.Cells["StaffID"].Value.ToString();
                using (var db = new VVUHMSEntities())
                {
                    model = db.Staffs.Where(x => x.StaffID == model.StaffID).FirstOrDefault();

                    txtPosition.Text = model.Position;
                    txtFName.Text = model.FirstName;
                    txtOName.Text = model.OtherName;
                    txtLName.Text = model.LastName;
                    txtEmail.Text = model.Email;
                    txtAddress.Text = model.Address;
                    txtPhone.Text = model.Phone;
                    ddSex.Text = model.Gender;
                    txtSalary.Text = model.Salary.ToString();
                    txtPassword.Text = model.Password;
                    txtshowpass.Text = model.Password;
                    txtDOB.Value = model.DOB.Value;

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void picShowHide_Click(object sender, EventArgs e)
        {
            if (val == 0)
            {
                picShowHide.Image = Resources.hidePass;
                txtPassword.Visible = false;
                txtshowpass.Visible = true;
                val = 1;
            }
            else
            {
                picShowHide.Image = Resources.revealPass;
                txtshowpass.Visible = false;
                txtPassword.Visible = true;
                val = 0;
            }
        }
        #endregion

        #region Staff Update profile
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (btnEditUpdate.Text == "Edit Profile")
            {
                txtPassword.Enabled = true;
                txtshowpass.Enabled = true;
                txtFName.Enabled = true;
                txtOName.Enabled = true;
                txtLName.Enabled = true;
                txtEmail.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
                txtDOB.Enabled = true;
                txtPosition.Enabled = true;
                txtSalary.Enabled = true;

                btnEditUpdate.Text = "Update Profile";
            }
            else
            {
                model.StaffID = dgvStaff.CurrentRow.Cells["StaffID"].Value.ToString();

                using (var db = new VVUHMSEntities())
                {
                    model = db.Staffs.Where(x => x.StaffID == model.StaffID).FirstOrDefault();


                    if (txtPassword.Text == txtshowpass.Text)
                    {
                        model.Password = txtPassword.Text.Trim();
                        model.FirstName = txtFName.Text.Trim();
                        model.OtherName = txtOName.Text.Trim();
                        model.LastName = txtLName.Text.Trim();
                        model.Email = txtEmail.Text.Trim();
                        model.Address = txtAddress.Text.Trim();
                        model.Phone = txtPhone.Text.Trim();
                        model.DOB = txtDOB.Value;
                        model.Position = txtPosition.Text.Trim();
                        model.Salary = Convert.ToDouble(txtSalary.Text.Trim());

                        try
                        {
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                            Alert("Staff Profile Has Been Updated Successfully.", Notification.enmType.Success);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString(), "Error");
                        }
                    }
                    else
                    {
                        Alert("Password Error", Notification.enmType.Warning);
                    }
                }

                txtPassword.Enabled = false;
                txtshowpass.Enabled = false;
                txtFName.Enabled = false;
                txtOName.Enabled = false;
                txtLName.Enabled = false;
                txtEmail.Enabled = false;
                txtAddress.Enabled = false;
                txtPhone.Enabled = false;
                txtDOB.Enabled = false;
                txtPosition.Enabled = false;
                txtSalary.Enabled = false;

                btnEditUpdate.Text = "Edit Profile";
            }
        }
        #endregion

        /// <summary>
        /// Checks if the data grid view is empty or not
        /// </summary>
        public void numRowsCheck()
        {
            if (dgvStaff.RowCount >= 1)
            {
                txtSTFAvailable.Visible = false;
            }
            else
            {
                txtSTFAvailable.Visible = true;
            }

            if (dgvPatients.RowCount >= 1)
            {
                txtPatAvailable.Visible = false;
            }
            else
            {
                txtPatAvailable.Visible = true;
            }
        }

        private void StaffSearchBox_TextChange(object sender, EventArgs e)
        {
            searchStaff(StaffSearchBox.Text);
        }

        private void PatientsSearchBox_TextChange(object sender, EventArgs e)
        {
            searchPatients(PatientSearchBox.Text);
        }

        private void stfRefresh_Click(object sender, EventArgs e)
        {
            searchStaff(StaffSearchBox.Text);
        }

        private void btnStaffProfile_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text == "")
            {
                Alert("No staff selected", Notification.enmType.Warning);
            }
            else
            {
                materialTabControl1.SelectTab(2);
            }

            btnStaffProfile.Visible = false;
            btnStfDeleteRecords.Visible = false;
        }

        private void btnStfDeleteRecords_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(3);
            btnStfDeleteRecords.Visible = false;
            btnStaffProfile.Visible = false;
        }

        private void DeleteStaff(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                ///Creating a connection string
                string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";
                string query = @"delete from Staff
                            where StaffID = '" + model.StaffID + "';";

                using (SqlConnection connection = new SqlConnection(connInfo))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    //connection.Open();
                    command.Connection.Open();
                    command.ExecuteNonQuery();

                    searchStaff(StaffSearchBox.Text);
                    Alert("Staff Profile Deleted Successfully", Notification.enmType.Info);
                }
            }
            catch (Exception a)
            {
                Alert(a.Message, Notification.enmType.Error);
            }

            materialTabControl1.SelectTab(0);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            searchStaff(StaffSearchBox.Text);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);
        }
        #endregion

        #region Alert
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










        #endregion
    }
}
