using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
//using System.Drawing.Drawing2D; // used to round edges of forms
using System.Drawing;

namespace POINT_OF_SALE_APPLICATION
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            

           
        }
         
        // to round the edge of form used these below code and call it above for loading
       
        private void txtUserPasswordLoginField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginButton.PerformClick();
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Retrieve input from the login form fields
            string username = txtUserNameLoginField.Text;
            string password = txtUserPasswordLoginField.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string
            string connectionString = ConfigurationManager.ConnectionStrings["PointOfSalesDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Use the GetUser stored procedure to verify credentials
                    using (SqlCommand cmd = new SqlCommand("GetUserAuth_Login", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            // User authenticated
                            reader.Read();
                            int userId = (int)reader["TB02_UserId"]; // Get the user ID

                            string userName = reader["TB02_UserName"].ToString();
                            string userGroup = reader["TB02_UserGroup"].ToString();

                            //MessageBox.Show($"Login successful! Welcome {userName} ({userGroup})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to the main menu and pass the user ID
                            MainMenuForm mainMenuForm = new MainMenuForm(userId , userName); // Pass the user ID
                            mainMenuForm.ShowDialog();
                            this.Hide(); ;
                        }
                        else
                        {
                            // Authentication failed
                            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            // Redirect to register page
            Register_Form registerForm = new Register_Form();
            registerForm.Show();
            this.Hide();
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {

        }

        private void logintxtUserName_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void txtUserPasswordLoginField_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
