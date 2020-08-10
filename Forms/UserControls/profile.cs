using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VVUHMS.Properties;
using System.Data.Entity;

namespace VVUHMS.Forms.UserControls.DoctorForms
{
    public partial class profile : UserControl
    {
        #region Global variables
        Staff model = new Staff();
        int val = 0;
        #endregion

        #region Constructor
        public profile()
        {
            InitializeComponent();
            loadProfile();
        }
        #endregion

        #region Load staff Profile

        public void loadProfile()
        {
            try
            {
                model.StaffID = File.ReadAllText("userID.txt");

                using (var db = new VVUHMSEntities())
                {
                    model = db.Staffs.Where(x => x.StaffID == model.StaffID).FirstOrDefault();

                    txtPosition.Text = model.Position;
                    txtFName.Text = model.FirstName;
                    txtOName.Text = model.OtherName;
                    txtLName.Text = model.LastName;
                    txtEmail.Text = model.Email;
                    txtAddress.Text = model.Address;
                    txtPhone.Text = model.Phone;
                    ddSex.Text = model.Gender;
                    txtSalary.Text = model.Salary.ToString();
                    txtPassword.Text = model.Password;
                    txtshowpass.Text = model.Password;
                    txtDOB.Value = model.DOB.Value;

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void picShowHide_Click(object sender, EventArgs e)
        {
            if (val == 0)
            {
                picShowHide.Image = Resources.hidePass;
                txtPassword.Visible = false;
                txtshowpass.Visible = true;
                val = 1;
            }
            else
            {
                picShowHide.Image = Resources.revealPass;
                txtshowpass.Visible = false;
                txtPassword.Visible = true;
                val = 0;
            }
        }

        #endregion

        #region Update profile
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (btnEditUpdate.Text == "Edit Profile")
            {
                txtPassword.Enabled = true;
                txtshowpass.Enabled = true;
                txtFName.Enabled = true;
                txtOName.Enabled = true;
                txtLName.Enabled = true;
                txtEmail.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
                txtDOB.Enabled = true;

                btnEditUpdate.Text = "Update Profile";
            }
            else
            {
                model.StaffID = File.ReadAllText("userID.txt");

                using (var db = new VVUHMSEntities())
                {
                    model = db.Staffs.Where(x => x.StaffID == model.StaffID).FirstOrDefault();

                   
                    if (txtPassword.Text == txtshowpass.Text)
                    {
                        model.Password = txtPassword.Text.Trim();
                        model.FirstName = txtFName.Text.Trim();
                        model.OtherName = txtOName.Text.Trim();
                        model.LastName = txtLName.Text.Trim();
                        model.Email = txtEmail.Text.Trim();
                        model.Address = txtAddress.Text.Trim();
                        model.Phone = txtPhone.Text.Trim();
                        model.DOB = txtDOB.Value;

                        try
                        {
                            db.Entry(model).State = EntityState.Modified;
                            db.SaveChanges();
                            Alert("Your Profile Has Been Updated Successfully.", Notification.enmType.Success);
                            loadProfile();
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString(), "Error");
                        }
                    }
                    else
                    {
                        Alert("Password Error", Notification.enmType.Error);
                    }
                }

                txtPassword.Enabled = false;
                txtshowpass.Enabled = false;
                txtFName.Enabled = false;
                txtOName.Enabled = false;
                txtLName.Enabled = false;
                txtEmail.Enabled = false;
                txtAddress.Enabled = false;
                txtPhone.Enabled = false;
                txtDOB.Enabled = false;

                btnEditUpdate.Text = "Edit Profile";
            }
        }
        #endregion

        #region Text Changed
        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            txtshowpass.Text = txtPassword.Text;
        }

        private void txtshowpass_TextChange(object sender, EventArgs e)
        {
            txtPassword.Text = txtshowpass.Text;
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

       
    }
}
