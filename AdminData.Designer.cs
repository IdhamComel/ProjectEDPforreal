namespace ProjectEDforreal
{
    partial class AdminData
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
            this.label2 = new System.Windows.Forms.Label();
            this.DelAdminBtn = new System.Windows.Forms.Button();
            this.searchAdminBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.delAdminBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.delCustBox = new System.Windows.Forms.TextBox();
            this.searchCustBox = new System.Windows.Forms.TextBox();
            this.DelCustBtn = new System.Windows.Forms.Button();
            this.searchAdminBtn = new System.Windows.Forms.Button();
            this.searchCustBtn = new System.Windows.Forms.Button();
            this.goToStatistics = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Data :";
            // 
            // DelAdminBtn
            // 
            this.DelAdminBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DelAdminBtn.Location = new System.Drawing.Point(676, 187);
            this.DelAdminBtn.Name = "DelAdminBtn";
            this.DelAdminBtn.Size = new System.Drawing.Size(75, 23);
            this.DelAdminBtn.TabIndex = 2;
            this.DelAdminBtn.Text = "Delete";
            this.DelAdminBtn.UseVisualStyleBackColor = false;
            this.DelAdminBtn.Click += new System.EventHandler(this.DelAdminBtn_Click);
            // 
            // searchAdminBox
            // 
            this.searchAdminBox.Location = new System.Drawing.Point(556, 79);
            this.searchAdminBox.Name = "searchAdminBox";
            this.searchAdminBox.Size = new System.Drawing.Size(168, 20);
            this.searchAdminBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 324);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(415, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // delAdminBox
            // 
            this.delAdminBox.Location = new System.Drawing.Point(556, 189);
            this.delAdminBox.Name = "delAdminBox";
            this.delAdminBox.Size = new System.Drawing.Size(114, 20);
            this.delAdminBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Delete Admin ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search Admin Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search Customer Name Or Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Delete Customer ID";
            // 
            // delCustBox
            // 
            this.delCustBox.Location = new System.Drawing.Point(545, 454);
            this.delCustBox.Name = "delCustBox";
            this.delCustBox.Size = new System.Drawing.Size(114, 20);
            this.delCustBox.TabIndex = 13;
            // 
            // searchCustBox
            // 
            this.searchCustBox.Location = new System.Drawing.Point(545, 344);
            this.searchCustBox.Name = "searchCustBox";
            this.searchCustBox.Size = new System.Drawing.Size(168, 20);
            this.searchCustBox.TabIndex = 12;
            // 
            // DelCustBtn
            // 
            this.DelCustBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DelCustBtn.Location = new System.Drawing.Point(665, 452);
            this.DelCustBtn.Name = "DelCustBtn";
            this.DelCustBtn.Size = new System.Drawing.Size(75, 23);
            this.DelCustBtn.TabIndex = 11;
            this.DelCustBtn.Text = "Delete";
            this.DelCustBtn.UseVisualStyleBackColor = false;
            this.DelCustBtn.Click += new System.EventHandler(this.DelCustBtn_Click);
            // 
            // searchAdminBtn
            // 
            this.searchAdminBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchAdminBtn.Location = new System.Drawing.Point(556, 105);
            this.searchAdminBtn.Name = "searchAdminBtn";
            this.searchAdminBtn.Size = new System.Drawing.Size(75, 23);
            this.searchAdminBtn.TabIndex = 16;
            this.searchAdminBtn.Text = "Search";
            this.searchAdminBtn.UseVisualStyleBackColor = false;
            this.searchAdminBtn.Click += new System.EventHandler(this.searchAdminBtn_Click);
            // 
            // searchCustBtn
            // 
            this.searchCustBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchCustBtn.Location = new System.Drawing.Point(545, 370);
            this.searchCustBtn.Name = "searchCustBtn";
            this.searchCustBtn.Size = new System.Drawing.Size(75, 23);
            this.searchCustBtn.TabIndex = 17;
            this.searchCustBtn.Text = "Search";
            this.searchCustBtn.UseVisualStyleBackColor = false;
            this.searchCustBtn.Click += new System.EventHandler(this.searchCustBtn_Click);
            // 
            // goToStatistics
            // 
            this.goToStatistics.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.goToStatistics.Location = new System.Drawing.Point(713, 12);
            this.goToStatistics.Name = "goToStatistics";
            this.goToStatistics.Size = new System.Drawing.Size(75, 23);
            this.goToStatistics.TabIndex = 18;
            this.goToStatistics.Text = "Statistics";
            this.goToStatistics.UseVisualStyleBackColor = false;
            this.goToStatistics.Click += new System.EventHandler(this.goToStatistics_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(32, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.goToStatistics);
            this.Controls.Add(this.searchCustBtn);
            this.Controls.Add(this.searchAdminBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delCustBox);
            this.Controls.Add(this.searchCustBox);
            this.Controls.Add(this.DelCustBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delAdminBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchAdminBox);
            this.Controls.Add(this.DelAdminBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminData";
            this.Text = "AdminData";
            this.Load += new System.EventHandler(this.AdminData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelAdminBtn;
        private System.Windows.Forms.TextBox searchAdminBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox delAdminBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delCustBox;
        private System.Windows.Forms.TextBox searchCustBox;
        private System.Windows.Forms.Button DelCustBtn;
        private System.Windows.Forms.Button searchAdminBtn;
        private System.Windows.Forms.Button searchCustBtn;
        private System.Windows.Forms.Button goToStatistics;
        private System.Windows.Forms.Button button1;
    }
}