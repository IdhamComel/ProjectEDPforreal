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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectEDforreal
{
    public partial class Statistic : Form
    {
        private string connectionString;
        public Statistic()
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\EDP_Project\\WinFormsApp1\\Database1.mdf;Integrated Security=True;";
        }

        private void Statistic_Load(object sender, EventArgs e)
        {

            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\EDP_Project\\WinFormsApp1\\Database1.mdf;Integrated Security=True;";

            string query = "SELECT * FROM Customer_Book";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query,connection);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "Customer_Book");

                        dataGridView1.DataSource = dataSet.Tables["Customer_Book"];

            }

            string multiQuery = @"
    SELECT TOP 1 b.book_title 
    FROM book b 
    JOIN customer_book cb ON b.isbn = cb.isbn 
    GROUP BY b.book_title 
    ORDER BY COUNT(cb.isbn) DESC;

    SELECT COUNT(*) FROM customer;

    SELECT COUNT(*) FROM customer_book;

    SELECT SUM(amount) FROM payment WHERE status = 'Completed';
";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(multiQuery, conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Result 1: Top book title
                        if (reader.Read())
                            textBoxTop1Book.Text = reader[0].ToString();
                        else
                            textBoxTop1Book.Text = "Not found";

                        // Move to Result 2: Customer count
                        if (reader.NextResult() && reader.Read())
                            textBoxTotalCustomer.Text = reader[0].ToString();

                        // Move to Result 3: Customer_book count
                        if (reader.NextResult() && reader.Read())
                            textBoxTotalBookSold.Text = reader[0].ToString();

                        // Move to Result 4: Total Completed Payment
                        if (reader.NextResult() && reader.Read())
                            textBoxTotalSales.Text = reader[0]?.ToString() ?? "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminData page = new AdminData();
            page.Show();
            this.Close();
        }
    }
}


    

