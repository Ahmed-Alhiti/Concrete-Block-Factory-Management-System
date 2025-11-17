namespace WindowsFormsApp1
{
    partial class frmExchangeBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchangeBills));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSupCurr = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.chBFilterByDate = new System.Windows.Forms.CheckBox();
            this.btnLoadCsutomerRecord = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtSupplierTo = new System.Windows.Forms.DateTimePicker();
            this.dtSupplierFrom = new System.Windows.Forms.DateTimePicker();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtPdate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chbFillterPay = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReceiptsNo = new System.Windows.Forms.TextBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.txtExchangePrice = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbCurrencies = new System.Windows.Forms.ComboBox();
            this.cbOprations = new System.Windows.Forms.ComboBox();
            this.cbCurrencie = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrintRecord = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblExchangePrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvExchangeBills = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEntry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExchangeBill = new System.Windows.Forms.DataGridView();
            this.RefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sup_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cur_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exchagne_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cur_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exchange_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvSupplierRecord = new System.Windows.Forms.DataGridView();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.DetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPrintTopSell = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeBills)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierRecord)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSupCurr
            // 
            this.cbSupCurr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSupCurr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSupCurr.FormattingEnabled = true;
            this.cbSupCurr.Location = new System.Drawing.Point(580, 25);
            this.cbSupCurr.Name = "cbSupCurr";
            this.cbSupCurr.Size = new System.Drawing.Size(112, 28);
            this.cbSupCurr.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(698, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "العملة :";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(755, 25);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(141, 28);
            this.cbSupplier.TabIndex = 1;
            // 
            // chBFilterByDate
            // 
            this.chBFilterByDate.AutoSize = true;
            this.chBFilterByDate.Location = new System.Drawing.Point(447, 27);
            this.chBFilterByDate.Name = "chBFilterByDate";
            this.chBFilterByDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chBFilterByDate.Size = new System.Drawing.Size(121, 24);
            this.chBFilterByDate.TabIndex = 2;
            this.chBFilterByDate.Text = "فلترة حسب التاريخ";
            this.chBFilterByDate.UseVisualStyleBackColor = true;
            this.chBFilterByDate.CheckedChanged += new System.EventHandler(this.chBFilterByDate_CheckedChanged);
            // 
            // btnLoadCsutomerRecord
            // 
            this.btnLoadCsutomerRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLoadCsutomerRecord.FlatAppearance.BorderSize = 0;
            this.btnLoadCsutomerRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCsutomerRecord.ForeColor = System.Drawing.Color.White;
            this.btnLoadCsutomerRecord.Location = new System.Drawing.Point(89, 27);
            this.btnLoadCsutomerRecord.Name = "btnLoadCsutomerRecord";
            this.btnLoadCsutomerRecord.Size = new System.Drawing.Size(115, 29);
            this.btnLoadCsutomerRecord.TabIndex = 5;
            this.btnLoadCsutomerRecord.Text = "بحث";
            this.btnLoadCsutomerRecord.UseVisualStyleBackColor = false;
            this.btnLoadCsutomerRecord.Click += new System.EventHandler(this.btnLoadCsutomerRecord_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "من تاريخ :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "الى تاريخ :";
            // 
            // dtSupplierTo
            // 
            this.dtSupplierTo.CustomFormat = "dd/MM/yyyy";
            this.dtSupplierTo.Enabled = false;
            this.dtSupplierTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSupplierTo.Location = new System.Drawing.Point(239, 37);
            this.dtSupplierTo.Name = "dtSupplierTo";
            this.dtSupplierTo.Size = new System.Drawing.Size(116, 26);
            this.dtSupplierTo.TabIndex = 4;
            // 
            // dtSupplierFrom
            // 
            this.dtSupplierFrom.CustomFormat = "dd/MM/yyyy";
            this.dtSupplierFrom.Enabled = false;
            this.dtSupplierFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSupplierFrom.Location = new System.Drawing.Point(239, 5);
            this.dtSupplierFrom.Name = "dtSupplierFrom";
            this.dtSupplierFrom.Size = new System.Drawing.Size(116, 26);
            this.dtSupplierFrom.TabIndex = 3;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Location = new System.Drawing.Point(345, 123);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(119, 26);
            this.txtTotalBill.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(470, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 20);
            this.label20.TabIndex = 17;
            this.label20.Text = "الاجمالي  :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(186, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "اضافة  ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtPdate
            // 
            this.dtPdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPdate.Enabled = false;
            this.dtPdate.Location = new System.Drawing.Point(562, 12);
            this.dtPdate.Name = "dtPdate";
            this.dtPdate.Size = new System.Drawing.Size(278, 26);
            this.dtPdate.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(902, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "اسم المورد :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(846, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "التاريخ :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "العملة :";
            // 
            // chbFillterPay
            // 
            this.chbFillterPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFillterPay.AutoSize = true;
            this.chbFillterPay.Location = new System.Drawing.Point(847, 26);
            this.chbFillterPay.Name = "chbFillterPay";
            this.chbFillterPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbFillterPay.Size = new System.Drawing.Size(121, 24);
            this.chbFillterPay.TabIndex = 4;
            this.chbFillterPay.Text = "فلترة حسب التاريخ";
            this.chbFillterPay.UseVisualStyleBackColor = true;
            this.chbFillterPay.CheckedChanged += new System.EventHandler(this.chbFillterPay_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(229, 24);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(115, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "عرض النتائج";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(666, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "الى";
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Enabled = false;
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(544, 25);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(116, 26);
            this.dtTo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(818, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "من";
            // 
            // txtReceiptsNo
            // 
            this.txtReceiptsNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiptsNo.Enabled = false;
            this.txtReceiptsNo.Location = new System.Drawing.Point(562, 44);
            this.txtReceiptsNo.Name = "txtReceiptsNo";
            this.txtReceiptsNo.Size = new System.Drawing.Size(278, 26);
            this.txtReceiptsNo.TabIndex = 2;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(186, 19);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(278, 28);
            this.cbSuppliers.TabIndex = 2;
            // 
            // txtExchangePrice
            // 
            this.txtExchangePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExchangePrice.Enabled = false;
            this.txtExchangePrice.Location = new System.Drawing.Point(51, 80);
            this.txtExchangePrice.Name = "txtExchangePrice";
            this.txtExchangePrice.Size = new System.Drawing.Size(77, 26);
            this.txtExchangePrice.TabIndex = 12;
            this.txtExchangePrice.Visible = false;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Location = new System.Drawing.Point(562, 121);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(278, 26);
            this.txtDetails.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(562, 84);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(278, 26);
            this.txtAmount.TabIndex = 1;
            // 
            // cbCurrencies
            // 
            this.cbCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrencies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrencies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencies.FormattingEnabled = true;
            this.cbCurrencies.Location = new System.Drawing.Point(186, 87);
            this.cbCurrencies.Name = "cbCurrencies";
            this.cbCurrencies.Size = new System.Drawing.Size(278, 28);
            this.cbCurrencies.TabIndex = 4;
            this.cbCurrencies.SelectedValueChanged += new System.EventHandler(this.cbCurrencies_SelectedValueChanged);
            // 
            // cbOprations
            // 
            this.cbOprations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOprations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOprations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOprations.FormattingEnabled = true;
            this.cbOprations.Location = new System.Drawing.Point(186, 53);
            this.cbOprations.Name = "cbOprations";
            this.cbOprations.Size = new System.Drawing.Size(278, 28);
            this.cbOprations.TabIndex = 3;
            // 
            // cbCurrencie
            // 
            this.cbCurrencie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCurrencie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrencie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrencie.FormattingEnabled = true;
            this.cbCurrencie.Location = new System.Drawing.Point(372, 24);
            this.cbCurrencie.Name = "cbCurrencie";
            this.cbCurrencie.Size = new System.Drawing.Size(112, 28);
            this.cbCurrencie.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrintRecord);
            this.panel3.Controls.Add(this.cbCurrencie);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.chbFillterPay);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtTo);
            this.panel3.Controls.Add(this.dtFrom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 72);
            this.panel3.TabIndex = 0;
            // 
            // btnPrintRecord
            // 
            this.btnPrintRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintRecord.FlatAppearance.BorderSize = 0;
            this.btnPrintRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintRecord.Image")));
            this.btnPrintRecord.Location = new System.Drawing.Point(24, 16);
            this.btnPrintRecord.Name = "btnPrintRecord";
            this.btnPrintRecord.Size = new System.Drawing.Size(42, 36);
            this.btnPrintRecord.TabIndex = 17;
            this.btnPrintRecord.UseVisualStyleBackColor = true;
            this.btnPrintRecord.Click += new System.EventHandler(this.btnPrintRecord_Click);
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Enabled = false;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(696, 25);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(116, 26);
            this.dtFrom.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(846, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "تفاصيل اضافيه :";
            // 
            // lblExchangePrice
            // 
            this.lblExchangePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExchangePrice.AutoSize = true;
            this.lblExchangePrice.Location = new System.Drawing.Point(8, 56);
            this.lblExchangePrice.Name = "lblExchangePrice";
            this.lblExchangePrice.Size = new System.Drawing.Size(172, 20);
            this.lblExchangePrice.TabIndex = 9;
            this.lblExchangePrice.Text = "سعر الصرف مقابل الريال اليمني";
            this.lblExchangePrice.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "اسم المورد :";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "العملة :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.dgvExchangeBills);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(976, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سجل الصرف";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 476);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(976, 65);
            this.panel4.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(7, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 43);
            this.label16.TabIndex = 0;
            this.label16.Text = "Sales Module";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvExchangeBills
            // 
            this.dgvExchangeBills.AllowUserToAddRows = false;
            this.dgvExchangeBills.AllowUserToDeleteRows = false;
            this.dgvExchangeBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExchangeBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExchangeBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvExchangeBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExchangeBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvExchangeBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExchangeBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExchangeBills.ColumnHeadersHeight = 30;
            this.dgvExchangeBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExchangeBills.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvExchangeBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExchangeBills.EnableHeadersVisualStyles = false;
            this.dgvExchangeBills.Location = new System.Drawing.Point(0, 72);
            this.dgvExchangeBills.Name = "dgvExchangeBills";
            this.dgvExchangeBills.RowHeadersVisible = false;
            this.dgvExchangeBills.Size = new System.Drawing.Size(976, 401);
            this.dgvExchangeBills.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.DeletetoolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "تفاصيل السند";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // DeletetoolStripMenuItem1
            // 
            this.DeletetoolStripMenuItem1.Name = "DeletetoolStripMenuItem1";
            this.DeletetoolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.DeletetoolStripMenuItem1.Text = "حذف السند";
            this.DeletetoolStripMenuItem1.Click += new System.EventHandler(this.DeletetoolStripMenuItem1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(846, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "المبلغ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "العملية :";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.RightToLeftLayout = true;
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(984, 583);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnEntry);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvExchangeBill);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(976, 541);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة سند صرف";
            // 
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(884, 432);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(83, 36);
            this.btnEntry.TabIndex = 6;
            this.btnEntry.Text = "حفظ السند";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 65);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvExchangeBill
            // 
            this.dgvExchangeBill.AllowUserToAddRows = false;
            this.dgvExchangeBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExchangeBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvExchangeBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExchangeBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvExchangeBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExchangeBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExchangeBill.ColumnHeadersHeight = 30;
            this.dgvExchangeBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExchangeBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefNo,
            this.Sup_Name,
            this.Sup_id,
            this.Cur_id,
            this.Exchagne_id,
            this.Total,
            this.Cur_name,
            this.Exchange_Price,
            this.Details});
            this.dgvExchangeBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExchangeBill.EnableHeadersVisualStyles = false;
            this.dgvExchangeBill.Location = new System.Drawing.Point(0, 158);
            this.dgvExchangeBill.Name = "dgvExchangeBill";
            this.dgvExchangeBill.RowHeadersVisible = false;
            this.dgvExchangeBill.Size = new System.Drawing.Size(976, 267);
            this.dgvExchangeBill.TabIndex = 5;
            // 
            // RefNo
            // 
            this.RefNo.HeaderText = "رقم السند";
            this.RefNo.Name = "RefNo";
            // 
            // Sup_Name
            // 
            this.Sup_Name.HeaderText = "المورد";
            this.Sup_Name.Name = "Sup_Name";
            // 
            // Sup_id
            // 
            this.Sup_id.HeaderText = "Sup_id";
            this.Sup_id.Name = "Sup_id";
            this.Sup_id.Visible = false;
            // 
            // Cur_id
            // 
            this.Cur_id.HeaderText = "Cur_id";
            this.Cur_id.Name = "Cur_id";
            this.Cur_id.Visible = false;
            // 
            // Exchagne_id
            // 
            this.Exchagne_id.HeaderText = "Exchagne_id";
            this.Exchagne_id.Name = "Exchagne_id";
            this.Exchagne_id.Visible = false;
            // 
            // Total
            // 
            this.Total.HeaderText = "المبلغ";
            this.Total.Name = "Total";
            // 
            // Cur_name
            // 
            this.Cur_name.HeaderText = "العملة";
            this.Cur_name.Name = "Cur_name";
            // 
            // Exchange_Price
            // 
            this.Exchange_Price.HeaderText = "سعر الصرف";
            this.Exchange_Price.Name = "Exchange_Price";
            // 
            // Details
            // 
            this.Details.HeaderText = "التفاصيل";
            this.Details.Name = "Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotalBill);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.dtPdate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtReceiptsNo);
            this.panel2.Controls.Add(this.cbSuppliers);
            this.panel2.Controls.Add(this.txtExchangePrice);
            this.panel2.Controls.Add(this.txtDetails);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.Controls.Add(this.cbCurrencies);
            this.panel2.Controls.Add(this.cbOprations);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblExchangePrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 158);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "رقم السند :";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel6);
            this.metroTabPage1.Controls.Add(this.dgvSupplierRecord);
            this.metroTabPage1.Controls.Add(this.panel5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(976, 541);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "كشف حساب مورد";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.label17);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 476);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(976, 65);
            this.panel6.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(7, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 43);
            this.label17.TabIndex = 0;
            this.label17.Text = "Sales Module";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSupplierRecord
            // 
            this.dgvSupplierRecord.AllowUserToAddRows = false;
            this.dgvSupplierRecord.AllowUserToResizeColumns = false;
            this.dgvSupplierRecord.AllowUserToResizeRows = false;
            this.dgvSupplierRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplierRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplierRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSupplierRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSupplierRecord.ColumnHeadersHeight = 30;
            this.dgvSupplierRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSupplierRecord.ContextMenuStrip = this.metroContextMenu1;
            this.dgvSupplierRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSupplierRecord.EnableHeadersVisualStyles = false;
            this.dgvSupplierRecord.Location = new System.Drawing.Point(0, 72);
            this.dgvSupplierRecord.Name = "dgvSupplierRecord";
            this.dgvSupplierRecord.RowHeadersVisible = false;
            this.dgvSupplierRecord.Size = new System.Drawing.Size(976, 376);
            this.dgvSupplierRecord.TabIndex = 15;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DetailsToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroContextMenu1.Size = new System.Drawing.Size(142, 26);
            // 
            // DetailsToolStripMenuItem
            // 
            this.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem";
            this.DetailsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.DetailsToolStripMenuItem.Text = "تفاصيل السند";
            this.DetailsToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnPrintTopSell);
            this.panel5.Controls.Add(this.cbSupCurr);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.cbSupplier);
            this.panel5.Controls.Add(this.chBFilterByDate);
            this.panel5.Controls.Add(this.btnLoadCsutomerRecord);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.dtSupplierTo);
            this.panel5.Controls.Add(this.dtSupplierFrom);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(976, 72);
            this.panel5.TabIndex = 14;
            // 
            // btnPrintTopSell
            // 
            this.btnPrintTopSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintTopSell.FlatAppearance.BorderSize = 0;
            this.btnPrintTopSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTopSell.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintTopSell.Image")));
            this.btnPrintTopSell.Location = new System.Drawing.Point(20, 20);
            this.btnPrintTopSell.Name = "btnPrintTopSell";
            this.btnPrintTopSell.Size = new System.Drawing.Size(42, 36);
            this.btnPrintTopSell.TabIndex = 16;
            this.btnPrintTopSell.UseVisualStyleBackColor = true;
            this.btnPrintTopSell.Click += new System.EventHandler(this.btnPrintTopSell_Click);
            // 
            // frmExchangeBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 583);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExchangeBills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سندات الصرف";
            this.Load += new System.EventHandler(this.frmExchangeBills_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeBills)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExchangeBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierRecord)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cbSupCurr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.CheckBox chBFilterByDate;
        public System.Windows.Forms.Button btnLoadCsutomerRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtSupplierTo;
        private System.Windows.Forms.DateTimePicker dtSupplierFrom;
        public System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DateTimePicker dtPdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbFillterPay;
        public System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReceiptsNo;
        private System.Windows.Forms.ComboBox cbSuppliers;
        public System.Windows.Forms.TextBox txtExchangePrice;
        public System.Windows.Forms.TextBox txtDetails;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.ComboBox cbCurrencies;
        public System.Windows.Forms.ComboBox cbOprations;
        public System.Windows.Forms.ComboBox cbCurrencie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblExchangePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvExchangeBills;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletetoolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExchangeBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvSupplierRecord;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem DetailsToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sup_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cur_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exchagne_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cur_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exchange_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.Button btnPrintTopSell;
        private System.Windows.Forms.Button btnPrintRecord;
    }
}