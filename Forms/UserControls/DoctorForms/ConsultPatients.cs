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

namespace VVUHMS.Forms.UserControls.DoctorForms
{
    public partial class ConsultPatients : UserControl
    {

        #region Global Variables
        Patient model = new Patient();
        string fname = "";
        string oname = "";
        string lname = "";
        string name = "";

        #endregion

        #region Constructor
        public ConsultPatients()
        {
            InitializeComponent();
            allWaitingPatients();
        }
        #endregion

        #region All Waiting Patients
        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void allWaitingPatients()
        {
            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

            ///Creating and instance of the sql connection
            using (var conn = new SqlConnection(connInfo))
            {
                try
                {
                    string DID = File.ReadAllText("userID.txt");
                    ///Our query to be run
                    string query = "";

                    query = @"select Patient_ID, FirstName, OtherName, LastName
	                        from Patients inner join ForwardRecords on
	                        Patient_ID = PID AND DID = '"+ DID +"';";


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    ///Rendering our data grid view to be read only
                    dgvWaitingPatients.ReadOnly = true;

                    dgvWaitingPatients.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvWaitingPatients.DataSource = ds.Tables[0];

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

        /// <summary>
        /// Checks if the data grid view is empty or not
        /// </summary>
        public void numRowsCheck()
        {
            if (dgvWaitingPatients.RowCount >= 1)
            {
                txtPatAvailable.Visible = false;
            }
            else
            {
                txtPatAvailable.Visible = true;
            }
        }
        #endregion

        #region Waiting Page

        private void dgvWaitingPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvWaitingPatients.CurrentRow.Index != -1)
                {
                    btnAttend.Visible = true;
                }
            }
            catch (NullReferenceException)
            {
                Noti("Sorry, no patients available", Notification.enmType.Info);
            }
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            model.Patient_ID = dgvWaitingPatients.CurrentRow.Cells["Patient_ID"].Value.ToString();

            using (var db = new VVUHMSEntities())
            {
                model = db.Patients.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();

                fname = model.FirstName;
                oname = model.OtherName;
                lname = model.LastName;

                name = fname + " " + oname + " " + lname;

                string writeText = name;
                File.WriteAllText("patName.txt", writeText);

                string id = model.Patient_ID;
                File.WriteAllText("patientID.txt", id);
                
                string NHISID = model.NHIS_ID;
                File.WriteAllText("patientNHIS_ID.txt", NHISID);

                btnAttend.Visible = false;
                AttendToPatient atp = new AttendToPatient();
                atp.ShowDialog();
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            allWaitingPatients();
        }
        #endregion

        #region Notification
        public void Noti(string msg, Notification.enmType type)
        {
            Notification noti = new Notification();

            noti.showAlert(msg, type);
        }
        #endregion

        
    }
}
