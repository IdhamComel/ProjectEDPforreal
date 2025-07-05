using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDforreal
{
    public partial class AdminData : Form
    {
        private string connectionString;
        

        public AdminData()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\EDP_Project\\WinFormsApp1\\Database1.mdf;Integrated Security=True;";
        }

        private void AdminData_Load(object sender, EventArgs e)
        {

            loadData();

        }

        void loadData()
        {
            string Aquery = "SELECT admin_id,admin_email FROM Admin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Aquery, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Admin");

                dataGridView1.DataSource = dataSet.Tables["Admin"];
            }

            string Cquery = "SELECT cust_id,cust_name,cust_email FROM Customer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Cquery, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Customer");

                dataGridView2.DataSource = dataSet.Tables["Customer"];
            }
        }

      

        private void searchAdminBtn_Click(object sender, EventArgs e)
        {
            string textAdmin = searchAdminBox.Text.Trim();
            string query = "SELECT admin_id,admin_email FROM Admin WHERE admin_email LIKE @text";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@text", "%" + textAdmin + "%");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset, "Admin");

                dataGridView1.DataSource = dataset.Tables["Admin"];

            }
        }

        private void DelAdminBtn_Click(object sender, EventArgs e)
        {
            string adminText = delAdminBox.Text.Trim();
            string query = "DELETE FROM Admin WHERE admin_id = @id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", adminText);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin record is deleted.");
                            loadData(); // Refresh your data
                        }
                        else
                        {
                            MessageBox.Show("No matching order found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }


        }

        private void searchCustBtn_Click(object sender, EventArgs e)
        {
            string custText = searchCustBox.Text.Trim();
            string query = "SELECT cust_id,cust_name,cust_email FROM Customer WHERE cust_name LIKE @text OR cust_email LIKE @text";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@text", "%" + custText + "%");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset, "Customer");

                dataGridView2.DataSource = dataset.Tables["Customer"];

            }
        }
        

        private void DelCustBtn_Click(object sender, EventArgs e)
        {
            string CustText = delCustBox.Text.Trim();
            string query = "DELETE FROM Customer WHERE cust_id = @id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", CustText);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            MessageBox.Show("Customer record deleted");
            loadData();

        }

        private void goToStatistics_Click(object sender, EventArgs e)
        {
            Statistic page = new Statistic();
            page.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
