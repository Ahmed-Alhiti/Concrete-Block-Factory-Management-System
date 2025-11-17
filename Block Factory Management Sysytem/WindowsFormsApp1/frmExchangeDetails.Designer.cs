namespace WindowsFormsApp1
{
    partial class frmExchangeDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchangeDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.dgvExchangeDetails = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtExchangePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtSdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbCurrencies = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeDetails)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(817, 0);
            this.picClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(29, 36);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lbltxt
            // 
            this.lbltxt.AutoSize = true;
            this.lbltxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxt.ForeColor = System.Drawing.Color.White;
            this.lbltxt.Location = new System.Drawing.Point(4, 18);
            this.lbltxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltxt.Name = "lbltxt";
            this.lbltxt.Size = new System.Drawing.Size(86, 18);
            this.lbltxt.TabIndex = 0;
            this.lbltxt.Text = "تفاصيل السند";
            // 
            // dgvExchangeDetails
            // 
            this.dgvExchangeDetails.AllowUserToAddRows = false;
            this.dgvExchangeDetails.AllowUserToDeleteRows = false;
            this.dgvExchangeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExchangeDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExchangeDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvExchangeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExchangeDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvExchangeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExchangeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExchangeDetails.ColumnHeadersHeight = 30;
            this.dgvExchangeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExchangeDetails.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvExchangeDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvExchangeDetails.EnableHeadersVisualStyles = false;
            this.dgvExchangeDetails.Location = new System.Drawing.Point(0, 239);
            this.dgvExchangeDetails.Name = "dgvExchangeDetails";
            this.dgvExchangeDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvExchangeDetails.RowHeadersVisible = false;
            this.dgvExchangeDetails.Size = new System.Drawing.Size(845, 285);
            this.dgvExchangeDetails.TabIndex = 113;
            this.dgvExchangeDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExchangeDetails_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(180, 22);
            this.Delete.Text = "حذف ";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtExchangePrice
            // 
            this.txtExchangePrice.Enabled = false;
            this.txtExchangePrice.Location = new System.Drawing.Point(592, 191);
            this.txtExchangePrice.Name = "txtExchangePrice";
            this.txtExchangePrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtExchangePrice.Size = new System.Drawing.Size(121, 26);
            this.txtExchangePrice.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 195);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "سعر الصرف :";
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.Enabled = false;
            this.btnAccCancel.FlatAppearance.BorderSize = 0;
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.Location = new System.Drawing.Point(50, 173);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAccCancel.Size = new System.Drawing.Size(99, 34);
            this.btnAccCancel.TabIndex = 112;
            this.btnAccCancel.Text = "الغاء";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 163);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "المبلغ المدفوع :";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.Enabled = false;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(435, 125);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSuppliers.Size = new System.Drawing.Size(278, 28);
            this.cbSuppliers.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 128);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 105;
            this.label6.Text = " العملة :";
            // 
            // dtSdate
            // 
            this.dtSdate.Enabled = false;
            this.dtSdate.Location = new System.Drawing.Point(435, 82);
            this.dtSdate.Name = "dtSdate";
            this.dtSdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtSdate.Size = new System.Drawing.Size(278, 26);
            this.dtSdate.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "اسم الزبون :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "رقم السند :";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(591, 159);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(121, 26);
            this.txtAmount.TabIndex = 110;
            // 
            // cbCurrencies
            // 
            this.cbCurrencies.Enabled = false;
            this.cbCurrencies.FormattingEnabled = true;
            this.cbCurrencies.Location = new System.Drawing.Point(50, 125);
            this.cbCurrencies.Name = "cbCurrencies";
            this.cbCurrencies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCurrencies.Size = new System.Drawing.Size(278, 28);
            this.cbCurrencies.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 101;
            this.label4.Text = "التاريخ :";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Enabled = false;
            this.txtRefNo.Location = new System.Drawing.Point(50, 84);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRefNo.Size = new System.Drawing.Size(278, 26);
            this.txtRefNo.TabIndex = 103;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(156, 173);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 98;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.lbltxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 60);
            this.panel1.TabIndex = 99;
            // 
            // frmExchangeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 524);
            this.Controls.Add(this.dgvExchangeDetails);
            this.Controls.Add(this.txtExchangePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAccCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtSdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cbCurrencies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExchangeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExchangeDetails";
            this.Load += new System.EventHandler(this.frmExchangeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeDetails)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbltxt;
        public System.Windows.Forms.DataGridView dgvExchangeDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        public System.Windows.Forms.TextBox txtExchangePrice;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtSdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.ComboBox cbCurrencies;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRefNo;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
    }
}