using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
//using System.Drawing.Drawing2D; // used to round edges of forms
using System.Drawing;

namespace POINT_OF_SALE_APPLICATION
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
            LoadUserGroups();
        }
        /// <summary>
        /// ////// so below methode loading category of usergroups like select employ or admin from dropdown
        /// </summary>
        private void LoadUserGroups()
        {
            // Connection string
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetDimDataForDropdown", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DimTable", "UserGroups");
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            comboBoxEdit1.Properties.Items.Clear();
                            while (reader.Read())
                            {
                                // Add each group to the ComboBox
                                comboBoxEdit1.Properties.Items.Add(reader["TB03_Dim_Name"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
         /// <summary>
         /// /////////this below code to add rounder corner of forms  but we now done bu using BunifuEllipse from tool box .
         /// </summary>
       /* private void SetRoundedForm()
        {
            // Set the form's region to a rounded rectangle
            int radius = 30; // Adjust the radius as needed
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }*/


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUserFullname.Text) ||
                string.IsNullOrWhiteSpace(textuserName.Text) || // Password
                string.IsNullOrWhiteSpace(textpassword.Text) || // Full Name
                string.IsNullOrWhiteSpace(textUserEmail.Text) ||
                string.IsNullOrWhiteSpace(textUserPhoneNumber.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Restrict name to letters only (no numbers)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserFullname.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Full name must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!System.Text.RegularExpressions.Regex.IsMatch(textUserEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password: at least 8 characters, 1 uppercase, 1 number, 1 special character
            if (!System.Text.RegularExpressions.Regex.IsMatch(textpassword.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$"))
            {
                MessageBox.Show("Password must be at least 8 characters long, contain at least 1 uppercase letter, 1 number, and 1 special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate phone number: only digits, 10-15 characters (modify based on your requirement)
            if (!System.Text.RegularExpressions.Regex.IsMatch(textUserPhoneNumber.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Please enter a valid phone number with 10 to 15 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve values from form fields
            string username = textuserName.Text;
            string password = textpassword.Text;
            string fullName = txtUserFullname .Text;
            string userGroup = comboBoxEdit1.Text; // Assuming you set the items to "ADM" and "USR"
            string email = textUserEmail.Text;
            string mobileNo = textUserPhoneNumber.Text;

            // Connection string
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("AddUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@UserFullName", fullName);
                    cmd.Parameters.AddWithValue("@UserGroup", userGroup);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MobileNo", mobileNo);
                    cmd.Parameters.AddWithValue("@CreatedBy", 1); // Assuming a default CreatedBy value
                    //as date is coming fro Getdate () function so dont need to pass to AddUser procedure parameeter
                   // cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now); // Set CreatedDate to now

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {
            Login_Form obj_login = new Login_Form();
            obj_login.Show();
            this.Hide();
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void txtUserEmillabel_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
