namespace ProjectEDforreal
{
    partial class OrderPayment
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
            this.buttonEdit1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPay1 = new System.Windows.Forms.Button();
            this.radioButtonCard1 = new System.Windows.Forms.RadioButton();
            this.radioButtonQr1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTotalBook1 = new System.Windows.Forms.TextBox();
            this.textBoxAmount1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Order :";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEdit1.Location = new System.Drawing.Point(365, 219);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit1.TabIndex = 1;
            this.buttonEdit1.Text = "Delete";
            this.buttonEdit1.UseVisualStyleBackColor = false;
            this.buttonEdit1.Click += new System.EventHandler(this.buttonEdit1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.buttonPay1);
            this.groupBox1.Controls.Add(this.radioButtonCard1);
            this.groupBox1.Controls.Add(this.radioButtonQr1);
            this.groupBox1.Location = new System.Drawing.Point(526, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // buttonPay1
            // 
            this.buttonPay1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPay1.Location = new System.Drawing.Point(141, 112);
            this.buttonPay1.Name = "buttonPay1";
            this.buttonPay1.Size = new System.Drawing.Size(75, 23);
            this.buttonPay1.TabIndex = 3;
            this.buttonPay1.Text = "Pay";
            this.buttonPay1.UseVisualStyleBackColor = false;
            this.buttonPay1.Click += new System.EventHandler(this.buttonPay1_Click);
            // 
            // radioButtonCard1
            // 
            this.radioButtonCard1.AutoSize = true;
            this.radioButtonCard1.Location = new System.Drawing.Point(40, 60);
            this.radioButtonCard1.Name = "radioButtonCard1";
            this.radioButtonCard1.Size = new System.Drawing.Size(106, 17);
            this.radioButtonCard1.TabIndex = 1;
            this.radioButtonCard1.TabStop = true;
            this.radioButtonCard1.Text = "Credit/Debit card";
            this.radioButtonCard1.UseVisualStyleBackColor = true;
            // 
            // radioButtonQr1
            // 
            this.radioButtonQr1.AutoSize = true;
            this.radioButtonQr1.Location = new System.Drawing.Point(40, 37);
            this.radioButtonQr1.Name = "radioButtonQr1";
            this.radioButtonQr1.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQr1.TabIndex = 0;
            this.radioButtonQr1.TabStop = true;
            this.radioButtonQr1.Text = "QR Pay";
            this.radioButtonQr1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Book :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Amount :";
            // 
            // textBoxTotalBook1
            // 
            this.textBoxTotalBook1.Location = new System.Drawing.Point(100, 286);
            this.textBoxTotalBook1.Multiline = true;
            this.textBoxTotalBook1.Name = "textBoxTotalBook1";
            this.textBoxTotalBook1.Size = new System.Drawing.Size(68, 54);
            this.textBoxTotalBook1.TabIndex = 5;
            // 
            // textBoxAmount1
            // 
            this.textBoxAmount1.Location = new System.Drawing.Point(372, 283);
            this.textBoxAmount1.Multiline = true;
            this.textBoxAmount1.Name = "textBoxAmount1";
            this.textBoxAmount1.Size = new System.Drawing.Size(68, 54);
            this.textBoxAmount1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order ID :";
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Location = new System.Drawing.Point(296, 224);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(0, 13);
            this.orderIDLabel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(19, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "<- Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAmount1);
            this.Controls.Add(this.textBoxTotalBook1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.label1);
            this.Name = "OrderPayment";
            this.Text = "OrderPayment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCard1;
        private System.Windows.Forms.RadioButton radioButtonQr1;
        private System.Windows.Forms.Button buttonPay1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTotalBook1;
        private System.Windows.Forms.TextBox textBoxAmount1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Button button1;
    }
}