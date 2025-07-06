using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectEDforreal
{
    public partial class Login : Form
    {
        private bool _termsBoxShown = false;
        private string connectionString;

        public Login()
        {
            InitializeComponent();
            comboBoxRole.Items.AddRange(new string[] { "Admin", "Customer" });
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\ProjectEDforreal\\ProjectEDforreal\\Database1.mdf;Integrated Security=True";
        }

        

       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxEmailLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string email = textBoxEmailLogin.Text.Trim();
            string password = textBoxPasswordLogin.Text;
            string role = comboBoxRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkBoxIAgree.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "";

            if(role == "Customer")
            {
                 query = "SELECT * FROM Customer WHERE cust_email = @name AND cust_pass = @pass";
            }
            else
            {
                 query = "SELECT * FROM Admin WHERE admin_email = @name AND admin_pass = @pass";

            }

            // Ensure you have a valid connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand comm = new SqlCommand(query, conn))
                    {
                        comm.Parameters.AddWithValue("@name", email);
                        comm.Parameters.AddWithValue("@pass", password);

                        try
                        {
                            conn.Open();
                            SqlDataReader reader = comm.ExecuteReader();

                            if (reader.Read())
                            {
                                int custId = reader.GetInt32(0);
                                // Login successful
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if(role == "Admin")
                            {
                                // For example, open a new form
                                this.Hide();
                                AdminData adminDashboard = new AdminData();
                                adminDashboard.Show();
                            }
                            else
                            {
                                // For example, open a new form
                                this.Hide();
                                BookSelection bookForm = new BookSelection(custId);
                                bookForm.Show();
                            }

                                
                            }
                            else
                            {
                                // Login failed
                                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private bool IsMessageBoxOpen()
        {
            if (_termsBoxShown)
                return true;

            _termsBoxShown = true;
            return false;
        }

        private void linkLabelTermsAndConditions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prevent multiple message boxes
            if (IsMessageBoxOpen())
                return;

            string terms = @"TERMS AND CONDITIONS

1. You must be a registered member to borrow books.
2. Books can be borrowed for one week at a time.
3. Late returns will incur a fine of RM 5 per day.
4. Maximum of 3 books can be borrowed at once.
5. Damaged or lost books must be replaced or paid for.

By checking the 'I agree' box, you accept these terms and conditions.";

            MessageBox.Show(terms, "Terms and Conditions",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset when the message box closes
            _termsBoxShown = false;
        }

        private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                MessageBox.Show("Please contact the administrator to reset your password.",
                    "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
    
}