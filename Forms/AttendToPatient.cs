using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVUHMS.Forms.UserControls.DoctorForms;

namespace VVUHMS.Forms
{
    public partial class AttendToPatient : Form
    {

        #region Global Variables

        Consultation model1 = new Consultation();
        Prescription model2 = new Prescription();
        PatientVital model3 = new PatientVital();
        PharmacyPatientPrescription model4 = new PharmacyPatientPrescription();
        Patient model5 = new Patient();

        double x, y;
        bool isDoneConsultation = true;
        int index;
        string isConsulted;
        string isCU;
        #endregion

        #region Constructor

        public AttendToPatient()
        {
            InitializeComponent();

            string id = File.ReadAllText("patientID.txt");

            allVitals(id);

            txtPName.Text = File.ReadAllText("patName.txt");

            x = Screen.PrimaryScreen.WorkingArea.Width * 0.95;
            y = Screen.PrimaryScreen.WorkingArea.Height * 0.95;

            this.Width = (int)x;
            this.Height = (int)y;
        }

        #endregion

        #region History

        private void dgvHistory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow.Index != -1)
            {
                isConsulted = dgvHistory.CurrentRow.Cells["SeenDoctor"].Value.ToString();
                isCU = dgvHistory.CurrentRow.Cells["isCheckUp"].Value.ToString();

                if (isConsulted == "True" && isCU =="False")
                {
                    btnHistory.Visible = true;
                    btnConsult.Visible = false;
                }
                else if (isConsulted == "False" && isCU == "False")
                {
                    if (isDoneConsultation == true)
                    {
                        btnConsult.Visible = true;
                    }
                    else
                    {
                        btnConsult.Visible = false;
                    }

                    btnHistory.Visible = false;
                }
                else
                {
                    btnHistory.Visible = false;
                    btnConsult.Visible = false;
                    Noti("This is a check up record, so there are no more details to show."
                        , Notification.enmType.Info);
                }
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            int id = (int)dgvHistory.CurrentRow.Cells["VitalID"].Value;
            PatientDetails pd = new PatientDetails(id);
            pd.Show();
            btnHistory.Visible = false;
            btnConsult.Visible = false;
        }

        #region Loads Vitals data
        /// <summary>
        /// This method is used to search the database for a patients....
        /// </summary>
        /// <param name="keyword"></param>
        public void allVitals(string id)
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

                    query = @"select * from dbo.PatientVitals 
                            where Patient_ID = '" + id + "' order by Date desc;";


                    //Instanciating the sql command class
                    SqlCommand cmd = new SqlCommand(query, conn);

                    ///Instanciating the sql data adapter class
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);

                    //Define the dataset
                    DataSet ds = new DataSet();

                    ///Fill the dataset with the query results
                    DA.Fill(ds);

                    ///Rendering our data grid view to be read only
                    dgvHistory.ReadOnly = true;

                    dgvHistory.AutoGenerateColumns = false;
                    /// Assigning a data source
                    dgvHistory.DataSource = ds.Tables[0];

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

        private void btnConsult_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvHistory.CurrentRow.Cells["VitalID"].Value;

                using (var db = new VVUHMSEntities())
                {
                    model3 = db.PatientVitals.Where(x => x.VitalID == ID).FirstOrDefault();

                    txtDate.Text = model3.Date.ToString();
                    txtBP.Text = model3.BloodPressure;
                    txtSugar.Text = model3.SugarLevel.ToString();
                    txtTemp.Text = model3.Temperature.ToString();
                    txtWeight.Text = model3.Weight.ToString();
                    txtPreg.Text = model3.PregnancyTest;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }

            materialTabControl1.SelectTab(1);
            btnHistory.Visible = false;
            btnConsult.Visible = false;
            isDoneConsultation = false;
        }

        #endregion

        #region Consultation

        private void ClearReport(object sender, EventArgs e)
        {
            txtReport.Clear();
        }

        #region Save report
        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            if (txtReport.Text == "")
            {
                Noti("Consultation report can not be empty", Notification.enmType.Error);
            }
            else
            {
                try
                {
                    int ID = (int)dgvHistory.CurrentRow.Cells["VitalID"].Value;
                    /// inserting into Consultation model 
                    using (var db = new VVUHMSEntities())
                    {
                        model1.Consultation1 = txtReport.Text;
                        model1.Date = DateTime.Now.Date;
                        model1.VitalID = ID;
                        model1.PatientID = File.ReadAllText("patientID.txt");
                        model1.StaffID = File.ReadAllText("userID.txt");
                        
                        db.Consultations.Add(model1);
                        db.SaveChanges();
                    }

                    /// inserting into prescription model
                    int num = lstPrescription.Items.Count;

                    using (var db = new VVUHMSEntities())
                    {
                        model2.StaffID = File.ReadAllText("userID.txt");
                        model2.PatientID = File.ReadAllText("patientID.txt");
                        model2.Date = DateTime.Now.Date;
                        model2.VitalID = ID;
                        string text = "";
                        for (int i = 0; i < num; i++)
                        {
                            if (i == (num - 1))
                            {
                                text += lstPrescription.Items[i].ToString();
                            }
                            else
                            {
                                text += lstPrescription.Items[i].ToString() + ",";
                            }
                        }
                        model2.Medicine = text;

                        model4.Date = DateTime.Now.Date;
                        model4.VitalID = ID;
                        model4.PatientID = File.ReadAllText("patientID.txt");
                        model4.PatientName = File.ReadAllText("patName.txt");
                        model4.NHISID = File.ReadAllText("patientNHIS_ID.txt");
                        
                        db.PharmacyPatientPrescriptions.Add(model4);
                        db.Prescriptions.Add(model2);
                        db.SaveChanges();
                    }
                    
                    using (var db = new VVUHMSEntities())
                    {
                        model3 = db.PatientVitals.Where(x => x.VitalID == ID).FirstOrDefault();
                        model3.SeenDoctor = "True";

                        try
                        {
                            db.Entry(model3).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString(), "Error");
                        }
                    }

                    txtDate.Clear();
                    txtBP.Clear();
                    txtSugar.Clear();
                    txtTemp.Clear();
                    txtWeight.Clear();
                    txtPreg.Clear();
                    txtReport.Clear();
                    lstPrescription.Items.Clear();
                }
                catch (Exception a)
                {

                    MessageBox.Show(a.Message, "Error");
                }

                removeForwardPats(File.ReadAllText("patientID.txt"));
                allVitals(File.ReadAllText("patientID.txt"));
                ConsultPatients cp = new ConsultPatients();
                cp.allWaitingPatients();
                isDoneConsultation = true;
                viewConsultation.Visible = false;
                materialTabControl1.SelectTab(0);
            }
        }

        //Removes the name of the consulted patient
        public void removeForwardPats(string id)
        {
            string query = @"delete from ForwardRecords where PID = '" + id + "'";

            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(connInfo))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();

                    ConsultPatients cp = new ConsultPatients();
                    cp.allWaitingPatients();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message), "Error");
            }

        }

        #endregion

        #region Consultation form 
        private void viewConsultation_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);
        }

        private void viewHistory_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);

            if (isDoneConsultation == false)
            {
                viewConsultation.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstPrescription.Items.Add(txtPrescription.Text);
            txtPrescription.Clear();
        }

        private void txtPrescription_TextChange(object sender, EventArgs e)
        {
            if (txtPrescription.Text.Length >= 1)
            {
                btnAdd.Visible = true;
                btnRemove.Visible = false;
                 
            }
            else
            {
                btnAdd.Visible = false;
            }

        }

        private void lstPrescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstPrescription.SelectedIndex;

            btnRemove.Visible = true;
            btnAdd.Visible = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                lstPrescription.Items.RemoveAt(index);
                btnRemove.Visible = false;
                btnAdd.Visible = false;
            }
            else
            {
                Noti("Please select an item to delete.", Notification.enmType.Warning);
                btnRemove.Visible = false;
                btnAdd.Visible = false;
            }
        }

        #endregion

        #endregion

        #region Close Window Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConclude_Click(object sender, EventArgs e)
        {
            Close();
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
