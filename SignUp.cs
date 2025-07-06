using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectEDforreal
{
    public partial class SignUp : Form
    {
        private string connectionString;
        public SignUp()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\ProjectEDforreal\\ProjectEDforreal\\Database1.mdf;Integrated Security=True";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            textBoxPasswordSignUp.PasswordChar = '•';
            textBoxConfirmPassword.PasswordChar = '•';
        }

      

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = textBoxFullname.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your full name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string email = textBoxEmailSignUp.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pass = textBoxPasswordSignUp.Text.Trim();
            if (pass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pass != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Customer (cust_name,cust_email,cust_pass) VALUES (@name,@email,@pass)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }

            MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}