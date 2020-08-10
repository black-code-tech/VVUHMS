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
using System.IO;

namespace VVUHMS.Forms.UserControls.Pharmacist
{
    public partial class AllPatientsPrescription : UserControl
    {
        #region Global Variables
        public string ID, fname, oname, lname;
        Patient model = new Patient();
        PatientVital model1 = new PatientVital();
        #endregion

        #region Constructor
        public AllPatientsPrescription()
        {
            InitializeComponent();
            PatientPrescriptions(searchBox.Text);
            searchPatients(PatientsSearchBox.Text);
        }
        #endregion

        #region All Prescription

        /// <summary>
        /// This method calls the search patients method if the enter button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBox_Enter(object sender, EventArgs e)
        {
            PatientPrescriptions(searchBox.Text);
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PatientPrescriptions(searchBox.Text);
        }

        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void PatientPrescriptions(string keyword)
        {

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

            ///Creating and instance of the sql connection
            using (var conn = new SqlConnection(connInfo))
            {
                try
                {
                    string query = "";

                    if (searchBox.Text != "")
                    {
                        query = @"select * from PharmacyPatientPrescriptions where PatientName like '" + keyword + "%'" +
                            "or PatientID like '" + keyword + "%' or NHISID like '" + keyword + "%';";
                    }
                    else
                    {
                        //query = @"select * from dbo.Patients
                        //        inner join Prescriptions on PatientID = Patient_ID;";
                        query = @"select * from PharmacyPatientPrescriptions;";
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
                    dgvPrescriptions.ReadOnly = true;

                    dgvPrescriptions.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvPrescriptions.DataSource = ds.Tables[0];

                    /// Clossing our connection to the server
                    //conn.Close();
                }
                catch (Exception a)
                {
                    /// Display errors
                    MessageBox.Show(a.Message);
                }
            }
            numRowsCheck();
        }

        private void dgvPrescriptions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrescriptions.CurrentRow.Index != -1)
                {
                    btnPrescribe.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                Alert("Sorry, no patients available", Notification.enmType.Info);
            }
            
        }

        /// <summary>
        /// Checks if the data grid view is empty or not
        /// </summary>
        public void numRowsCheck()
        {
            if (dgvPrescriptions.RowCount >= 1)
            {
                txtPatAvailable.Visible = false;
            }
            else
            {
                txtPatAvailable.Visible = true;
            }

            if (dgvPatients.RowCount >= 1)
            {
                txtUnavailable.Visible = false;
            }
            else
            {
                txtUnavailable.Visible = true;
            }
        }

        #endregion

        #region Adding vitals to patients
        /// <summary>
        /// This method will take the vitals of the patient and then forward it
        /// to the available doctor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVitals_Click(object sender, EventArgs e)
        {
            VitalsForm vf = new VitalsForm();

            model.Patient_ID = dgvPatients.CurrentRow.Cells["PatientID"].Value.ToString();

            using (var db = new VVUHMSEntities())
            {
                model = db.Patients.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();

                ID = model.Patient_ID;

                string writeText = ID;
                File.WriteAllText("patID.txt", writeText);
                btnPrescribe.Visible = false;
            }

            vf.ShowDialog();
            btnVitals.Visible = false;
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

        #region Search database for patient

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

                    if (PatientsSearchBox.Text != "")
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


        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvPatients.CurrentRow.Index != -1)
                {
                    btnVitals.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                Alert("Sorry, no patients available", Notification.enmType.Info);
            }
            
        }

        private void btnPrescribe_Click(object sender, EventArgs e)
        {

            int vid = Convert.ToInt32(dgvPrescriptions.CurrentRow.Cells["VitalID"].Value.ToString());
            string nhis = dgvPrescriptions.CurrentRow.Cells["NHIS_ID"].Value.ToString();
            //using (var db = new VVUHMSEntities())
            //{
            //    model = db.Patients.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();

            //    ID = model.Patient_ID;

            //    string writeText = ID;
            //    File.WriteAllText("patID.txt", writeText);
            //    btnPrescribe.Visible = false;
            //}

            File.WriteAllText(@"NHIS_ID.txt",nhis);
            File.WriteAllText(@"Vital_ID.txt",vid.ToString());
            PatientPrescription pp = new PatientPrescription();
            btnPrescribe.Visible = false;
            pp.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            PatientPrescriptions(searchBox.Text);
        }

        private void PatientsSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchPatients(PatientsSearchBox.Text);
        }

        private void AllPatients(object sender, EventArgs e)
        {
            txtTitle.Text = "Search For Patient";
            btnAllPats.Visible = false;
            btnAllPres.Visible = true;
            searchTab.SelectTab(1);
        }

        private void allPrescription(object sender, EventArgs e)
        {
            txtTitle.Text = "Search Patients With Prescription";
            btnAllPres.Visible = false;
            btnAllPats.Visible = true;
            searchTab.SelectTab(0);
        }
        #endregion

    }
}
