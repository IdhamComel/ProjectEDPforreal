using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectEDforreal
{
    public partial class OrderPayment : Form
    {
        private int CustomerId;
        private string connectionString;
        public int bookCount;
        public OrderPayment(int custId)
        {
            InitializeComponent();
            CustomerId = custId;
            loadData();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\EDP_Project\\WinFormsApp1\\Database1.mdf;Integrated Security=True;";
        }

        private void loadData()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\EDP_Project\\WinFormsApp1\\Database1.mdf;Integrated Security=True;";

            string query = "SELECT * FROM Customer_Book WHERE cust_id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", CustomerId);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "Customer_Book");

                        dataGridView1.DataSource = dataSet.Tables["Customer_Book"];
                    }
                }
            }

            checkBookCount();
            int total = bookCount * 10;
            textBoxTotalBook1.Text = bookCount.ToString();
            textBoxAmount1.Text = total.ToString();

            
        }

        private void buttonPay1_Click(object sender, EventArgs e)
        {
            string paymentMethod = "";

            if (radioButtonQr1.Checked)
            {
                paymentMethod = "QR Pay";
            }
            else if (radioButtonCard1.Checked)
            {
                paymentMethod = "Credit/Debit Card";
            }

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxAmount1.Text == "0")
            {
                MessageBox.Show("Unable to pay, no order made.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Payment (cust_id,amount,payment_method,status,count) VALUES (@id,@amount,@method,@status,@count)";
            string update = "UPDATE Customer_Book SET status = 'Ongoing' WHERE cust_id = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", CustomerId);
                    cmd.Parameters.AddWithValue("@amount", textBoxAmount1.Text.Trim());
                    cmd.Parameters.AddWithValue("@method", paymentMethod);
                    cmd.Parameters.AddWithValue("@status", "Completed");
                    cmd.Parameters.AddWithValue("@count", bookCount);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                using (SqlCommand command = new SqlCommand(update,conn))
                {
                    command.Parameters.AddWithValue("@id", CustomerId);

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }


            

            MessageBox.Show("Payment completed.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BookSelection form = new BookSelection(CustomerId);
            form.ShowDialog();
            this.Close();


        }

        private void checkBookCount()
        {
            string bookTotal = "SELECT COUNT(*) FROM Customer_Book WHERE cust_id = @id AND status = 'In Order'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(bookTotal, conn))
                {
                    cmd.Parameters.AddWithValue("@id", CustomerId);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    bookCount = count;
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not header row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                orderIDLabel.Text = row.Cells[0].Value.ToString();

                // You can also store primary key if needed
                // int customerId = Convert.ToInt32(row.Cells["cust_id"].Value);
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            //string query = "DELETE FROM Customer_Book WHERE order_id = @id AND status = 'In Order'";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@id", orderIDLabel.Text.Trim());
            //    }
            //}

            //MessageBox.Show("Your order is deleted");
            //loadData();

            string query = "DELETE FROM Customer_Book WHERE order_id = @id AND status = 'In Order'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", orderIDLabel.Text.Trim());

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your order is deleted.");
                        loadData(); // Refresh your data
                    }
                    else
                    {
                        MessageBox.Show("No matching order found or order already processed.");
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
            BookSelection page = new BookSelection(CustomerId);
            page.ShowDialog();
            this.Close();
        }
    }
}
