namespace WindowsFormsApp1
{
    partial class frmItemModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemModule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lbltxt = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtPerPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtSdate = new System.Windows.Forms.DateTimePicker();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(156, 173);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 54;
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
            this.panel1.Size = new System.Drawing.Size(820, 60);
            this.panel1.TabIndex = 56;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(792, 0);
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
            this.lbltxt.Size = new System.Drawing.Size(101, 18);
            this.lbltxt.TabIndex = 0;
            this.lbltxt.Text = "تفاصيل الفاتورة";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Location = new System.Drawing.Point(435, 162);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalBill.Size = new System.Drawing.Size(130, 26);
            this.txtTotalBill.TabIndex = 74;
            // 
            // txtPerPrice
            // 
            this.txtPerPrice.Enabled = false;
            this.txtPerPrice.Location = new System.Drawing.Point(636, 161);
            this.txtPerPrice.Name = "txtPerPrice";
            this.txtPerPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPerPrice.Size = new System.Drawing.Size(77, 26);
            this.txtPerPrice.TabIndex = 73;
            this.txtPerPrice.TextChanged += new System.EventHandler(this.txtPerPrice_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(50, 123);
            this.txtQty.Name = "txtQty";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(278, 26);
            this.txtQty.TabIndex = 72;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // cbitem
            // 
            this.cbitem.Enabled = false;
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(435, 126);
            this.cbitem.Name = "cbitem";
            this.cbitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbitem.Size = new System.Drawing.Size(278, 28);
            this.cbitem.TabIndex = 70;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(571, 166);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 67;
            this.label14.Text = "الاجمالي :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(720, 165);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 66;
            this.label13.Text = "سعر الحبة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 125);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "الكمية المطلوبة :";
            // 
            // dtSdate
            // 
            this.dtSdate.Enabled = false;
            this.dtSdate.Location = new System.Drawing.Point(435, 82);
            this.dtSdate.Name = "dtSdate";
            this.dtSdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtSdate.Size = new System.Drawing.Size(278, 26);
            this.dtSdate.TabIndex = 62;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Enabled = false;
            this.txtRefNo.Location = new System.Drawing.Point(50, 84);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRefNo.Size = new System.Drawing.Size(278, 26);
            this.txtRefNo.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 84);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "التاريخ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "الصنف المطلوب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 83);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "رقم الفاتورة :";
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.FlatAppearance.BorderSize = 0;
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.Location = new System.Drawing.Point(50, 173);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAccCancel.Size = new System.Drawing.Size(99, 34);
            this.btnAccCancel.TabIndex = 76;
            this.btnAccCancel.Text = "الغاء";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 22);
            this.Delete.Text = "حذف صنف";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.AllowUserToAddRows = false;
            this.dgvBillDetails.AllowUserToDeleteRows = false;
            this.dgvBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBillDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBillDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillDetails.ColumnHeadersHeight = 30;
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillDetails.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBillDetails.EnableHeadersVisualStyles = false;
            this.dgvBillDetails.Location = new System.Drawing.Point(0, 234);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBillDetails.RowHeadersVisible = false;
            this.dgvBillDetails.Size = new System.Drawing.Size(820, 285);
            this.dgvBillDetails.TabIndex = 79;
            this.dgvBillDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetails_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 206);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "اجمالي الفاتورة :";
            // 
            // txtBillTotal
            // 
            this.txtBillTotal.Enabled = false;
            this.txtBillTotal.Location = new System.Drawing.Point(592, 202);
            this.txtBillTotal.Name = "txtBillTotal";
            this.txtBillTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBillTotal.Size = new System.Drawing.Size(121, 26);
            this.txtBillTotal.TabIndex = 74;
            // 
            // frmItemModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 519);
            this.Controls.Add(this.dgvBillDetails);
            this.Controls.Add(this.btnAccCancel);
            this.Controls.Add(this.txtBillTotal);
            this.Controls.Add(this.txtTotalBill);
            this.Controls.Add(this.txtPerPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbitem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtSdate);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmItemModule";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaleModule";
            this.Load += new System.EventHandler(this.frmSaleModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lbltxt;
        public System.Windows.Forms.TextBox txtTotalBill;
        public System.Windows.Forms.TextBox txtPerPrice;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtSdate;
        public System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBillTotal;
        public System.Windows.Forms.DataGridView dgvBillDetails;
    }
}