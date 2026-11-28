

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BrgyInformationSystem
{
    public partial class FrmLogin : Form
    {
        string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=BarangayDB;Integrated Security=True";

        public FrmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT Role FROM Users WHERE Username = admin-peralta AND Password = BIMS";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("admin-peralta", username);
                        cmd.Parameters.AddWithValue("BIMS", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null &&
                            result.ToString() == "Administrator")
                        {
                            MessageBox.Show(
                                "Welcome to Barangay Information Management System!",
                                "Login Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            txtUsername.Clear();
                            txtPassword.Clear();

                            // Open your dashboard here
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid username or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database Connection Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
