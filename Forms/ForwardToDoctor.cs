using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace VVUHMS.Forms
{
    public partial class ForwardToDoctor : Form
    {

        Staff model = new Staff();
        ForwardRecord model1 = new ForwardRecord();
        string query = "";
        string PID = "";
        string DID = "";

        #region Constructor
        public ForwardToDoctor()
        {
            InitializeComponent();
            allDoctors();
        }
        #endregion

        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void allDoctors()
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

                    query = @"select StaffID,FirstName,OtherName,
                                LastName from dbo.Staff
                                where Position = 'Doctor';";


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    ///Rendering our data grid view to be read only
                    dgvDoctors.ReadOnly = true;

                    dgvDoctors.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvDoctors.DataSource = ds.Tables[0];

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

        private void dgvDoctors_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow.Index != -1)
            {
                btnForward.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            try
            {
                model.StaffID = dgvDoctors.CurrentRow.Cells["StaffID"].Value.ToString();

                using (var db = new VVUHMSEntities())
                {
                    model = db.Staffs.Where(x => x.StaffID == model.StaffID).FirstOrDefault();

                    DID = model.StaffID;
                    Console.WriteLine(DID);
                    PID = File.ReadAllText("patID.txt");
                    Console.WriteLine(PID);

                    try
                    {
                        model1.DID = DID;
                        model1.PID = PID;

                        db.ForwardRecords.Add(model1);
                        db.SaveChanges();

                        bunifuPages1.SetPage(1);

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString(), "Error");
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
