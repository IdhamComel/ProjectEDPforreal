namespace ProjectEDforreal
{
    partial class OverduePenalty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxOverdue1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalBook2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmount2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelOverduePolicy = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPay2 = new System.Windows.Forms.Button();
            this.radioButtonCard2 = new System.Windows.Forms.RadioButton();
            this.radioButtonQr2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxTotalBook2);
            this.groupBox1.Controls.Add(this.textBoxAmount2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxOverdue1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overdue Penalty !";
            // 
            // textBoxOverdue1
            // 
            this.textBoxOverdue1.Location = new System.Drawing.Point(123, 42);
            this.textBoxOverdue1.Multiline = true;
            this.textBoxOverdue1.Name = "textBoxOverdue1";
            this.textBoxOverdue1.Size = new System.Drawing.Size(68, 54);
            this.textBoxOverdue1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Overdue :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "days";
            // 
            // textBoxTotalBook2
            // 
            this.textBoxTotalBook2.Location = new System.Drawing.Point(123, 125);
            this.textBoxTotalBook2.Multiline = true;
            this.textBoxTotalBook2.Name = "textBoxTotalBook2";
            this.textBoxTotalBook2.Size = new System.Drawing.Size(68, 54);
            this.textBoxTotalBook2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Book :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RM";
            // 
            // textBoxAmount2
            // 
            this.textBoxAmount2.Location = new System.Drawing.Point(348, 125);
            this.textBoxAmount2.Multiline = true;
            this.textBoxAmount2.Name = "textBoxAmount2";
            this.textBoxAmount2.Size = new System.Drawing.Size(68, 54);
            this.textBoxAmount2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Amount :";
            // 
            // linkLabelOverduePolicy
            // 
            this.linkLabelOverduePolicy.AutoSize = true;
            this.linkLabelOverduePolicy.Location = new System.Drawing.Point(28, 254);
            this.linkLabelOverduePolicy.Name = "linkLabelOverduePolicy";
            this.linkLabelOverduePolicy.Size = new System.Drawing.Size(79, 13);
            this.linkLabelOverduePolicy.TabIndex = 11;
            this.linkLabelOverduePolicy.TabStop = true;
            this.linkLabelOverduePolicy.Text = "Overdue Policy";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.buttonPay2);
            this.groupBox2.Controls.Add(this.radioButtonCard2);
            this.groupBox2.Controls.Add(this.radioButtonQr2);
            this.groupBox2.Location = new System.Drawing.Point(547, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 141);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Method";
            // 
            // buttonPay2
            // 
            this.buttonPay2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPay2.Location = new System.Drawing.Point(141, 112);
            this.buttonPay2.Name = "buttonPay2";
            this.buttonPay2.Size = new System.Drawing.Size(75, 23);
            this.buttonPay2.TabIndex = 3;
            this.buttonPay2.Text = "Pay";
            this.buttonPay2.UseVisualStyleBackColor = false;
            // 
            // radioButtonCard2
            // 
            this.radioButtonCard2.AutoSize = true;
            this.radioButtonCard2.Location = new System.Drawing.Point(40, 60);
            this.radioButtonCard2.Name = "radioButtonCard2";
            this.radioButtonCard2.Size = new System.Drawing.Size(106, 17);
            this.radioButtonCard2.TabIndex = 1;
            this.radioButtonCard2.TabStop = true;
            this.radioButtonCard2.Text = "Credit/Debit card";
            this.radioButtonCard2.UseVisualStyleBackColor = true;
            // 
            // radioButtonQr2
            // 
            this.radioButtonQr2.AutoSize = true;
            this.radioButtonQr2.Location = new System.Drawing.Point(40, 37);
            this.radioButtonQr2.Name = "radioButtonQr2";
            this.radioButtonQr2.Size = new System.Drawing.Size(62, 17);
            this.radioButtonQr2.TabIndex = 0;
            this.radioButtonQr2.TabStop = true;
            this.radioButtonQr2.Text = "QR Pay";
            this.radioButtonQr2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Overdue Book :";
            // 
            // OverduePenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkLabelOverduePolicy);
            this.Controls.Add(this.groupBox1);
            this.Name = "OverduePenalty";
            this.Text = "OverduePenalty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOverdue1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTotalBook2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmount2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelOverduePolicy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPay2;
        private System.Windows.Forms.RadioButton radioButtonCard2;
        private System.Windows.Forms.RadioButton radioButtonQr2;
        private System.Windows.Forms.Label label6;
    }
}