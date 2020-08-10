using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VVUHMS.Forms.UserControls.Nurse;
using System.IO;
using System.Data.Entity;

namespace VVUHMS.Forms.UserControls
{
    public partial class VitalsPage : UserControl
    {

        #region Global Variables
        string MSG = "";
        public string ID;
        PatientVital model = new PatientVital();
        #endregion

        #region Constructor
        public VitalsPage()
        {
            InitializeComponent();
        }
        #endregion

        #region Save Vitals
        private void btnSaveVitals_Click(object sender, EventArgs e)
        {
            using (var db = new VVUHMSEntities())
            {
                if (txtTemp.Text == "" || txtWeight.Text == "" || txtBP.Text == ""
                    || isPreg.SelectedIndex == -1 || isPreg.SelectedItem == null)
                {
                    Alert("Make sure all fields are filled properly"
                        ,Notification.enmType.Warning);
                }
                else
                {
                    try
                    {
                        ID = File.ReadAllText("patID.txt");
                        Console.WriteLine(ID);
                        
                        model.Patient_ID = ID;
                        model.Temperature = Convert.ToDouble(txtTemp.Text);
                        model.Weight = Convert.ToDouble(txtWeight.Text);
                        model.BloodPressure = txtBP.Text;
                        if (txtBS.Text == "")
                        {
                            model.SugarLevel = null;
                        }
                        else
                        {
                            model.SugarLevel = Convert.ToDouble(txtBS.Text);
                        }
                        
                        model.PregnancyTest = isPreg.Text;
                        model.Date = DateTime.Now.Date;
                        model.SeenDoctor = "False";
                        model.isCheckUp = "False";

                        db.PatientVitals.Add(model);
                        db.SaveChanges();
                        MSG = "Vitals Added Successfully.";
                        Alert(MSG, Notification.enmType.Success);

                        txtBP.Clear();
                        txtBS.Clear();
                        txtTemp.Clear();
                        txtWeight.Clear();
                        isPreg.Text = "";

                        pages.SetPage(1);

                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString(), "Error");
                    }
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pages.SelectTab(0);
        }
        #endregion

        #region Close window
        private void btnCancel_Click(object sender, EventArgs e)
        {
         
            txtBP.Text = "";
            txtBS.Text = "";
            txtWeight.Text = "";
            isPreg.Text = "";
            txtTemp.Clear();

            ParentForm.Close();

        }
        #endregion

        #region Notificaition
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

        #region Yes or No
        private void btnYes_Click(object sender, EventArgs e)
        {
            ForwardToDoctor ftd = new ForwardToDoctor();
            ftd.Show();

            ParentForm.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            model.Patient_ID = File.ReadAllText("patID.txt");

            using (var db = new VVUHMSEntities())
            {
                model = db.PatientVitals.Where(x => x.Patient_ID == model.Patient_ID).FirstOrDefault();
                model.isCheckUp = "True";

                try
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString(), "Error");
                }
            }

            ParentForm.Close();
        }
        #endregion

    }
}
