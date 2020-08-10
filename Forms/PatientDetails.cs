using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVUHMS.Forms
{
    public partial class PatientDetails : Form
    {
        #region Global variables
        Consultation model1 = new Consultation();
        Prescription model2 = new Prescription();
        PatientVital model3 = new PatientVital();
        #endregion

        #region Constructor
        public PatientDetails()
        {
            InitializeComponent();
        }
        
        public PatientDetails(int id)
        {
            InitializeComponent();

            fillData(id);
        }
        #endregion

        #region fill form with data
        public void fillData(int id)
        {
            try
            {
                using (var db = new VVUHMSEntities())
                {
                    //Loading vitals
                    model3 = db.PatientVitals.Where(x => x.VitalID == id).FirstOrDefault();

                    txtDate.Text = model3.Date.ToString();
                    txtBP.Text = model3.BloodPressure;
                    txtSugar.Text = model3.SugarLevel.ToString();
                    txtTemp.Text = model3.Temperature.ToString();
                    txtWeight.Text = model3.Weight.ToString();
                    txtPreg.Text = model3.PregnancyTest;

                    //Loading Consultation report
                    model1 = db.Consultations.Where(x => x.VitalID == id).FirstOrDefault();

                    txtReport.Text = model1.Consultation1;

                    //Loading Prescriptions
                    lstPrescription.DataSource = GetData(id);
                    lstPrescription.DisplayMember = "value";
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        public DataTable GetData(int id)
        {
            DataTable meds = new DataTable();

            string query = @"select value from Prescriptions 
                            CROSS APPLY STRING_SPLIT(Medicine, ',')
                            where VitalID = '" + id + "';";

            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

            using (var conn = new SqlConnection(connInfo))
            {
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    meds.Load(reader);
                }
            }
            return meds;
        }
        #endregion

        #region Consultation
        //private void btnClrPres_Click(object sender, EventArgs e)
        //{
        //    txtPrescription.Clear();
        //}

        private void btnClrCons_Click(object sender, EventArgs e)
        {
            txtReport.Clear();
        }

        //private void btnClrAll_Click(object sender, EventArgs e)
        //{
        //    txtPrescription.Clear();
        //    txtReport.Clear();
        //}

        #endregion

        #region Close
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void btnSaveVitals_Click(object sender, EventArgs e)
        {

        }

    }
}
