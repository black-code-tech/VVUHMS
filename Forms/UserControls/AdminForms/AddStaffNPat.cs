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

namespace VVUHMS.Forms.UserControls.AdminForms
{
    public partial class AddStaffNPat : UserControl
    {
        #region Global variable
        Staff model = new Staff();

        int randNum;
        #endregion

        #region Constructor
        public AddStaffNPat()
        {
            InitializeComponent();
            fillcombo();
        }
        #endregion

        #region Fill Combobox Positions
        private void fillcombo()
        {
            try
            {
                ///Creating a connection string
                string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";
                string query = @"select * from Position;";

                using (SqlConnection connection = new SqlConnection(connInfo))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ddPosition.DataSource = dt;
                    ddPosition.DisplayMember = "Position";
                    ddPosition.ValueMember = "Position";
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }
        #endregion

        #region Clear fields
        /// <summary>
        /// This is the method to clear the fields and rename button save
        /// </summary>
        public void clear()
        {
            //Setting the value of the fields to null;
            txtAddress.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtOName.Text = "";
            ddSex.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtAddress.Text = "";
            ddPosition.Text = "";
            txtPhone.Text = "";
            txtDOB.Value = DateTime.Now.Date;
        }
        #endregion

        #region Random Numbers
        /// <summary>
        /// This method will generate random numbers for the patient id
        /// </summary>
        public void GenerateRandomNumber()
        {
            Random r = new Random();
            randNum = r.Next(1000, 9999);
        }
        #endregion

        #region Check Email
        public bool emailcheck()
        {
            bool isEmail = false;
            int num = 0;
            try
            {
                ///Creating a connection string
                string connInfo = @"Data Source=DEADEND\SQLEXPRESS;Initial Catalog=VVUHMS;Integrated Security=True";
                string query = @"select count(Email) as" +
                " num from Staff where Email = '" + txtEmail.Text + "';";

                using (SqlConnection connection = new SqlConnection(connInfo))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    //connection.Open();
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    var reader = command.ExecuteReader();

                    while (reader.HasRows)
                    {
                        num = Convert.ToInt32(reader["num"]);
                    }

                }
            }
            catch (Exception a)
            {
                Alert(a.Message, Notification.enmType.Error);
            }

            if (num == 0)
            {
                isEmail = false;
            }
            else
            {
                isEmail = true;
            }
            return isEmail;
        }
        #endregion

        #region Add Record

        /// <summary>
        /// This method checks if the not null fields to be passed to the db
        /// contains values if not requests the user to pass in values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ///Checking if the nescessary fields are filled
            if (txtEmail.Text == "" || txtSalary.Text == "" || txtFName.Text == "" || txtLName.Text == ""
                || txtAddress.Text == "" || txtPhone.Text == "" || ddPosition.Text == ""
                || ddSex.Text == "" || txtDOB.Text == DateTime.Now.Date.ToLongDateString())
            {
                Alert("Make sure all fields are filled properly", Notification.enmType.Warning);
            }
            else
            {
                try
                {
                    GenerateRandomNumber();

                    ///Inserting trimmed values into their respective columns
                    model.FirstName = txtFName.Text.Trim();
                    model.OtherName = txtOName.Text.Trim();
                    model.LastName = txtLName.Text.Trim();
                    model.Email = txtEmail.Text.Trim();
                    model.Salary = Convert.ToDouble(txtSalary.Text.Trim());
                    model.Address = txtAddress.Text.Trim();
                    model.Phone = txtPhone.Text.Trim();
                    model.Password = "1234";
                    model.Gender = ddSex.Text.Trim();
                    model.Position = ddPosition.Text.Trim();
                    model.DOB = txtDOB.Value;
                    model.StaffID = "STF" + randNum;


                    using (var db = new VVUHMSEntities())
                    {
                        //Adding to the db
                        db.Staffs.Add(model);

                        //Saving to the database
                        db.SaveChanges();
                    }

                    //Calling clear method
                    clear();

                    //Displaying a success message
                    Alert("Staff Added Successfully", Notification.enmType.Success);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
            }
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

    }
}
