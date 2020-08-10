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

namespace VVUHMS.Forms.UserControls.Nurse
{
    public partial class SearchPage : UserControl
    {
        #region Global Variables
        public string ID,fname,oname,lname;
        Patient model = new Patient();
        #endregion

        #region Constructor
        /// <summary>
        /// Our main constructor
        /// </summary>
        public SearchPage()
        {
            InitializeComponent();
            searchPatients(searchBox.Text);
        }
        #endregion

        #region Form Load
        /// <summary>
        /// Animating the form when its loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPage_Load(object sender, EventArgs e)
        {
            SearchPageTransition.Show(this);
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
            
            model.Patient_ID = dgvPatients.CurrentRow.Cells["Patient_ID"].Value.ToString();
            
            using (var db = new VVUHMSEntities())
            {
                model = db.Patients.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();
                
                ID = model.Patient_ID;

                string writeText = ID;
                File.WriteAllText("patID.txt", writeText);
                btnVitals.Visible = false;
            }  

            vf.ShowDialog();

        }
        #endregion

        public string patientID()
        {
            Console.WriteLine(ID);
            return ID;
        }

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
        /// This method calls the search patients if the search button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchPatients(searchBox.Text);
        }

        /// <summary>
        /// This method calls the search patients method if the enter button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            searchPatients(searchBox.Text);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            searchPatients(searchBox.Text);
        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow.Index != -1)
            {
                btnVitals.Visible = true;
            }
        }

        private void searchBox_MouseClick(object sender, MouseEventArgs e)
        {
            btnVitals.Visible = false;
        }

        /// <summary>
        /// Checks if the data grid view is empty or not
        /// </summary>
        public void numRowsCheck()
        {
            if (dgvPatients.RowCount >= 1)
            {
                txtPatAvailable.Visible = false;
            }
            else
            {
                txtPatAvailable.Visible = true;
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
        #endregion

    }
}
