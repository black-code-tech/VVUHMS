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
using System.Data.Entity;

namespace VVUHMS.Forms.UserControls
{
    public partial class UpdateRecordsPage : UserControl
    {
        #region Global Variables
        Patient model = new Patient();
        #endregion

        #region Constructor
        public UpdateRecordsPage()
        {
            InitializeComponent();
            searchPatients(searchBox.Text);
        }
        #endregion

        #region Search Patients
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchPatients(searchBox.Text);
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            searchPatients(searchBox.Text);
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

                    if (searchBox.Text != "")
                    {
                        query = @"select * from dbo.Patients where FirstName like '" + keyword + "%'" +
                            "or OtherName like '" + keyword + "%' or LastName like '" + keyword + "%'" +
                            "or Patient_ID like '" + keyword + "%' or NHIS_ID like '" + keyword + "%';";
                    }
                    else
                    {
                        query = @"select * from dbo.Patients;";
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
                    updateDGV.ReadOnly = true;

                    updateDGV.AutoGenerateColumns = false;
                    /// Assigning a data source
                    updateDGV.DataSource = ds.Tables[0];

                    /// Clossing our connection to the server
                    //conn.Close();
                }
                catch (Exception a)
                {
                    /// Display errors
                    MessageBox.Show(a.Message);
                }
            }
        }
        #endregion

        #region Select patient to update

        private void updateDGV_DoubleClick(object sender, EventArgs e)
        {
            if (updateDGV.CurrentRow.Index != -1)
            {
                btnUpdate.Visible = true;
            }
        }

        private void MoveToUpdate(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            txtHeader.Text = "Update Record";
            btnCancel.Visible = true;
            btnUpdate.Visible = false;

            try
            {
                model.Patient_ID = updateDGV.CurrentRow.Cells["Patient_ID"].Value.ToString();

                using (var db = new VVUHMSEntities())
                {
                    model = db.Patients.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();

                    txtNHIS.Text = model.NHIS_ID;
                    txtFName.Text = model.FirstName;
                    txtOName.Text = model.OtherName;
                    txtLName.Text = model.LastName;
                    txtEmail.Text = model.Email;
                    txtAddress.Text = model.Address;
                    txtPPhone.Text = model.Primary_Phone;
                    txtSPhone.Text = model.Secondary_Phone;
                    txtOccupation.Text = model.Occupation;
                    ddSex.Text = model.Gender;
                    txtDOB.Value = model.DOB;

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        #endregion

        #region Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            txtHeader.Text = "Select A Record To Update";
            bunifuPages1.SetPage(0);
        }
        #endregion

        #region Notification
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

        #region Update record
        private void Update_Patient_Record(object sender, EventArgs e)
        {
            using (var db = new VVUHMSEntities())
            {
                model = db.Patients.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();

                model.NHIS_ID = txtNHIS.Text.Trim();
                model.FirstName = txtFName.Text.Trim();
                model.OtherName = txtOName.Text.Trim();
                model.LastName = txtLName.Text.Trim();
                model.Email = txtEmail.Text.Trim();
                model.Address = txtAddress.Text.Trim();
                model.Primary_Phone = txtPPhone.Text.Trim();
                model.Secondary_Phone = txtSPhone.Text.Trim();
                model.Occupation = txtOccupation.Text.Trim();
                model.Gender = ddSex.Text.Trim();
                model.DOB = txtDOB.Value;

                try
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    searchPatients(searchBox.Text);
                    Alert("Patient Record Updated Successfully.", Notification.enmType.Success);
                    btnCancel.Visible = false;
                    txtHeader.Text = "Select A Record To Update";
                    bunifuPages1.SetPage(0);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error");
                }
            }
        }

        #endregion
    }
}
