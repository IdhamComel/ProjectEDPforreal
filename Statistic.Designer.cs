namespace ProjectEDforreal
{
    partial class Statistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTop1Book = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTotalCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotalSales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalBookSold = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order\'s Details :";
            // 
            // textBoxTop1Book
            // 
            this.textBoxTop1Book.Location = new System.Drawing.Point(676, 90);
            this.textBoxTop1Book.Multiline = true;
            this.textBoxTop1Book.Name = "textBoxTop1Book";
            this.textBoxTop1Book.ReadOnly = true;
            this.textBoxTop1Book.Size = new System.Drawing.Size(68, 54);
            this.textBoxTop1Book.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Top 1 Book :";
            // 
            // textBoxTotalCustomer
            // 
            this.textBoxTotalCustomer.Location = new System.Drawing.Point(676, 190);
            this.textBoxTotalCustomer.Multiline = true;
            this.textBoxTotalCustomer.Name = "textBoxTotalCustomer";
            this.textBoxTotalCustomer.ReadOnly = true;
            this.textBoxTotalCustomer.Size = new System.Drawing.Size(68, 54);
            this.textBoxTotalCustomer.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Customer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "RM";
            // 
            // textBoxTotalSales
            // 
            this.textBoxTotalSales.Location = new System.Drawing.Point(676, 372);
            this.textBoxTotalSales.Multiline = true;
            this.textBoxTotalSales.Name = "textBoxTotalSales";
            this.textBoxTotalSales.ReadOnly = true;
            this.textBoxTotalSales.Size = new System.Drawing.Size(68, 54);
            this.textBoxTotalSales.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Sales :";
            // 
            // textBoxTotalBookSold
            // 
            this.textBoxTotalBookSold.Location = new System.Drawing.Point(676, 278);
            this.textBoxTotalBookSold.Multiline = true;
            this.textBoxTotalBookSold.Name = "textBoxTotalBookSold";
            this.textBoxTotalBookSold.ReadOnly = true;
            this.textBoxTotalBookSold.Size = new System.Drawing.Size(68, 54);
            this.textBoxTotalBookSold.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Book Sold :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 355);
            this.dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Admin Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxTotalBookSold);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTotalSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotalCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTop1Book);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTop1Book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotalSales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalBookSold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}