using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectEDforreal
{
    public partial class BookSelection : Form
    {
        string[] bookTypes = { "Comic", "Education", "Novel", "History" , "Fairy Tale" , "Poetry" , "Cook Book" , "Science Fiction" , "Magazine"};
        string[] bookImages = { "Resources/Images/wanda.jpg", "Resources/Images/preview-page0.jpg", "Resources/Images/novel.jpg", "Resources/Images/history.jpg",
        "Resources/Images/fairy-tale.jpg","Resources/Images/poetry.jpg","Resources/Images/cookbook.jpg","Resources/Images/science-fiction.jpg","Resources/Images/magazine.png",};
        private int currentBookTypeIndex = 0;
        private int booksAdded = 0;
        private int customerId;
        private string connectionString;

        public BookSelection(int custId)
        {
            InitializeComponent();
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\source\\repos\\ProjectEDforreal\\ProjectEDforreal\\Database1.mdf;Integrated Security=True";
            customerId = custId;
            dateTimePickerDS1.Value = DateTime.Today;
            dateTimePickerDR1.Value = DateTime.Today.AddDays(7);
            updateBookGenre();
            LoadData();
           
            
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Customer_Book WHERE cust_id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "Customer_Book");

                        dataGridView1.DataSource = dataSet.Tables["Customer_Book"];
                    }
                }
            }

            string bookQuery = "SELECT * FROM Book WHERE genre = @genre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(bookQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@genre", labelBook.Text.Trim());

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "Book");

                        dataGridView2.DataSource = dataSet.Tables["Book"];
                    }
                }
            }
        }

        private void BookSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updateBookGenre()
        {
            pictureBoxBook.Image = Image.FromFile(bookImages[currentBookTypeIndex]);
            labelBook.Text = bookTypes[currentBookTypeIndex];

            string bookQuery = "SELECT * FROM Book WHERE genre = @genre";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(bookQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@genre", labelBook.Text.Trim());

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet, "Book");

                        dataGridView2.DataSource = dataSet.Tables["Book"];
                    }
                }
            }
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            int id = customerId;
            string title = textBoxTitle1.Text.Trim();
            string author = textBoxAuthor1.Text.Trim();
            string isbn = textBoxISBN1.Text.Trim();
            string dateStart = dateTimePickerDS1.Value.ToString();
            string dateEnd = dateTimePickerDR1.Value.ToString();
            string dateCreated = DateTime.Now.ToString();
            string genre = labelBook.Text.Trim();

            checkBookCount();
            if (booksAdded >= 3)
            {
                MessageBox.Show("Maximum of 3 books per person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTitle1.Text) || string.IsNullOrWhiteSpace(textBoxAuthor1.Text) ||
                string.IsNullOrWhiteSpace(textBoxISBN1.Text))
            {
                MessageBox.Show("Please fill in all book details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string findBook = "SELECT COUNT(ISBN) FROM Book WHERE ISBN = @isbn";
            bool bookExists = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(findBook, conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", isbn);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    bookExists = count > 0;
                    conn.Close();
                }
            }

            // Step 2: Insert into Book table if it doesn't exist
            if (!bookExists)
            {
                string insertBook = "INSERT INTO Book (ISBN, book_title, genre, book_author) VALUES (@isbn, @title, @genre, @author)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(insertBook, conn))
                    {
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@title", title);      // Make sure to define bookTitle
                        cmd.Parameters.AddWithValue("@genre", genre);       // Define titleType
                        cmd.Parameters.AddWithValue("@author", author);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        //bookBindingSource1.ResetBindings(false);
                        LoadData();
                    }
                }

                

            }

            // Step 3: Insert into Customer_Book table
            string insertCustomerBook = "INSERT INTO Customer_Book (cust_id, ISBN, created_at, start_date, return_date, status) VALUES (@id,@isbn,@createDate,@startDate,@returnDate,@status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertCustomerBook, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@createDate", dateCreated);
                    cmd.Parameters.AddWithValue("@startDate", dateStart);
                    cmd.Parameters.AddWithValue("@returnDate", dateEnd);
                    cmd.Parameters.AddWithValue("@status", "In Order");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //customerBookBindingSource1.ResetBindings(false);
                    LoadData();
                }
            }



            booksAdded++;
            MessageBox.Show("Book added to order", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

       

        

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentBookTypeIndex > 0)
            {
                currentBookTypeIndex--;
                updateBookGenre();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentBookTypeIndex < bookImages.Length - 1)
            {
                currentBookTypeIndex++;
                updateBookGenre();
            }
        }

        private void buttonProceed1_Click(object sender, EventArgs e)
        {
            checkBookCount();

            if (booksAdded == 0)
            {
                MessageBox.Show("Please add at least one book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrderPayment paymentForm = new OrderPayment(customerId);
            paymentForm.Show();
            this.Hide();
        }

        private void linkLabelPriceDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("1 book = RM10.");
        }

        private void checkBookCount()
        {
            string bookTotal = "SELECT COUNT(*) FROM Customer_Book WHERE cust_id = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(bookTotal, conn))
                {
                    cmd.Parameters.AddWithValue("@id", customerId);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    booksAdded = count;
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not header row
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                textBoxTitle1.Text = row.Cells[1].Value.ToString();
                textBoxISBN1.Text = row.Cells[0].Value.ToString();
                textBoxAuthor1.Text = row.Cells[3].Value.ToString();

                // You can also store primary key if needed
                // int customerId = Convert.ToInt32(row.Cells["cust_id"].Value);
            }
        }
    }
}