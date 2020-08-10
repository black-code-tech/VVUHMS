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

namespace VVUHMS.Forms.UserControls.DoctorForms
{
    public partial class AllDrugs : UserControl
    {
        #region Constructor
        public AllDrugs()
        {
            InitializeComponent();
            searchDrug(searchBox.Text);
        }
        #endregion

        #region Search Drug
        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void searchDrug(string keyword)
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
                        query = @"select * from dbo.Drugs where DrugName like '" + keyword + "%';";
                    }
                    else
                    {
                        query = @"select * from dbo.Drugs;";
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
                    dgvDrugs.ReadOnly = true;

                    dgvDrugs.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvDrugs.DataSource = ds.Tables[0];

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
            searchDrug(searchBox.Text);
        }

        /// <summary>
        /// Checks if the data grid view is empty or not
        /// </summary>
        public void numRowsCheck()
        {
            if (dgvDrugs.RowCount >= 1)
            {
                txtUnavailable.Visible = false;
            }
            else
            {
                txtUnavailable.Visible = true;
            }
        }
        #endregion

    }
}
