namespace WindowsFormsApp1
{
    partial class frmEditCustomerOrCurreinse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSalesBill = new System.Windows.Forms.DataGridView();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalesBill
            // 
            this.dgvSalesBill.AllowUserToAddRows = false;
            this.dgvSalesBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalesBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesBill.ColumnHeadersHeight = 30;
            this.dgvSalesBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSalesBill.EnableHeadersVisualStyles = false;
            this.dgvSalesBill.Location = new System.Drawing.Point(0, 161);
            this.dgvSalesBill.Name = "dgvSalesBill";
            this.dgvSalesBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSalesBill.RowHeadersVisible = false;
            this.dgvSalesBill.Size = new System.Drawing.Size(856, 267);
            this.dgvSalesBill.TabIndex = 6;
            // 
            // cbCustomers
            // 
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(471, 49);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCustomers.Size = new System.Drawing.Size(278, 28);
            this.cbCustomers.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(755, 54);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "اسم الزبون :";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Enabled = false;
            this.txtRefNo.Location = new System.Drawing.Point(471, 17);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRefNo.Size = new System.Drawing.Size(278, 26);
            this.txtRefNo.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 17);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "رقم الفاتورة :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(101, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "التفاصيل :";
            // 
            // txtDetails
            // 
            this.txtDetails.Enabled = false;
            this.txtDetails.Location = new System.Drawing.Point(101, 17);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.Size = new System.Drawing.Size(278, 26);
            this.txtDetails.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 89);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "الكمية المطلوبة :";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(471, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(82, 26);
            this.txtAmount.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 89);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "اجمالي الفاتورة :";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Location = new System.Drawing.Point(656, 86);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBill.Size = new System.Drawing.Size(93, 26);
            this.txtTotalBill.TabIndex = 71;
            // 
            // frmEditCustomerOrCurreinse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 428);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSalesBill);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditCustomerOrCurreinse";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditCustomerOrCurreinse";
            this.Load += new System.EventHandler(this.frmEditCustomerOrCurreinse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesBill;
        public System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTotalBill;
    }
}