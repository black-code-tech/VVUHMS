using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VVUHMS.Forms
{
    public partial class PatientPrescription : Form
    {

        #region Global variables
        Consultation model1 = new Consultation();
        Prescription model2 = new Prescription();
        PatientVital model3 = new PatientVital();
        Dictionary<string, string> patientMeds = new Dictionary<string, string>();
        int index, num1, vid = 0;
        int isReturn = 0;
        double totalPrice = 0;
        string med, num = "";
        #endregion

        #region Constructor
        public PatientPrescription()
        {
            InitializeComponent();
            vid = Convert.ToInt32(File.ReadAllText("Vital_ID.txt"));
            fillData(vid);
        }
        
        public PatientPrescription(int id)
        {
            InitializeComponent();
            fillData(id);
        }
        #endregion

        #region filling the list of meds
        public void fillData(int id)
        {
            if (id != -1)
            {
                //Loading Prescriptions
                txtOVC.Visible = false;
                lstPrescription.DataSource = GetData(id);
                lstPrescription.DisplayMember = "value";
            }
            else
            {
                txtOVC.Visible = true;
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

        #region Fill The combo box with med data
        private void PatientPrescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vVUHMSDataSet.Drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.vVUHMSDataSet.Drugs);

        }
        #endregion

        #region Close
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region dispensing meds
        private void cbxMeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMeds.SelectedIndex != -1)
            {
                txtNum.Enabled = true;
            }
            else
            {
                txtNum.Enabled = false;
                btnAddToCart.Visible = false;

            }
        }

        private void txtNum_TextChange(object sender, EventArgs e)
        {
            if (txtNum.Text.Length >= 1)
            {
                btnAddToCart.Visible = true;
            }
            else
            {
                btnAddToCart.Visible = false;
            }
        }

        /// <summary>
        /// This button adds medication along with the quantity to a 
        /// temporary dictionary for calculation of total price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            med = cbxMeds.Text;
            num = txtNum.Text;


            if (!patientMeds.ContainsKey(med))
            {
                if (!int.TryParse(num, out num1))
                {
                    Noti("Incorrect input, No letters or words allowed.",
                    Notification.enmType.Warning);

                    txtNum.Text = "";

                    cbxMeds.SelectedIndex = -1;
                }
                else
                {
                    chlstCart.Items.Add("Med: " + med + ", Number: " + num);

                    txtNum.Text = "";

                    cbxMeds.SelectedIndex = -1;

                    patientMeds.Add(med, num);
                }

            }

            else
            {
                Noti("Sorry the medicine has been selected " +
                    "remove the old one, to add a new value.",
                    Notification.enmType.Info);

                txtNum.Text = "";

                cbxMeds.SelectedIndex = -1;
            }

            btnDone.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnDone.Visible = false;

            btnPricing.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (index >= 0)
            {
                string[] separatingStrings = { "Med: ", ", Number: " };
                string text = chlstCart.Items[index].ToString();
                string[] words = text.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);

                patientMeds.Remove(words[0]);
                chlstCart.Items.RemoveAt(index);

                btnRemove.Visible = false;
            }
            else
            {
                Noti("Make sure you have selected an item",Notification.enmType.Warning);
            }

            btnRemove.Visible = false;
        }

        private void chlstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = chlstCart.SelectedIndex;
            btnRemove.Visible = true;
        }


        #endregion

        #region Checking Out

        private void btnReturn_Click(object sender, EventArgs e)
        {
            patientMeds.Clear();
            chlstCart.Items.Clear();
            totalPrice = 0;
            isReturn = 1;
            materialTabControl1.SelectTab(0);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                materialTabControl1.SelectTab(3);
            }
            else
            {
                materialTabControl1.SelectTab(2);
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ///Creating a connection string
            string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";
            string query = @"delete from PharmacyPatientPrescriptions
                            where VitalID ="+ vid +";";

            using (SqlConnection connection = new SqlConnection(connInfo))
            {
                SqlCommand command = new SqlCommand(query, connection);
                //connection.Open();
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            Close();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(3);
        }

        private void btnReturn1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);
        }

        private void btnConCash_Click(object sender, EventArgs e)
        {
            btnPaid.Visible = true;
        }

        private void btnConMomo_Click(object sender, EventArgs e)
        {
            btnPaid.Visible = true;
        }

        private void btnConVisa_Click(object sender, EventArgs e)
        {
            btnPaid.Visible = true;
        }

        /// <summary>
        /// This button takes you to the check out page
        /// It also calculates the total price before it moves to the
        /// next page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPricing_Click(object sender, EventArgs e)
        {
            btnDone.Visible = true;

            btnPricing.Visible = false;

            //if (isReturn == 1)
            //{
            //    int count = chlstCart.Items.Count;
            //    for (int i = 0; i < count; i++)
            //    {
            //        string[] separatingStrings = { "Med: ", ", Number: " };

            //        string text = chlstCart.Items[i].ToString();

            //        string[] words = text.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);

            //        patientMeds.Add(words[0],words[1]);

            //    }
            //}

            foreach (KeyValuePair<string, string> kvp in patientMeds)
            {
                string query = "";

                if (vid == 0)
                {
                    query = @"select cost * " + Convert.ToInt32(kvp.Value) +
                        " as cost from Drugs where DrugName = '" + kvp.Key +"'";
                }
                else
                {
                    query = @"select cost * " + 0 + "" +
                    " as cost from Drugs where NHIS = 'True'" +
                    "and DrugName = '" + kvp.Key + "' union select cost * "
                    + Convert.ToInt32(kvp.Value) + "" +
                    " as cost from Drugs where NHIS = 'False'" +
                    "and DrugName = '" + kvp.Key + "';";
                }

                ///Creating a connection string
                string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";

                using (var conn = new SqlConnection(connInfo))
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            lsvMeds.Items.Add(kvp.Key + "  ×" + kvp.Value);
                            lsvPrice.Items.Add(reader.GetDouble(0).ToString());
                            totalPrice += reader.GetDouble(0);
                        }
                    }
                }

                txtTotal.Text = "¢" + totalPrice;
            }
            materialTabControl1.SelectTab(1);
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
