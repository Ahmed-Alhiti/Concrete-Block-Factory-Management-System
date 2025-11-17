namespace WindowsFormsApp1
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.txtSumAllSales = new System.Windows.Forms.TextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvSalesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditCustOrCur = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Post = new System.Windows.Forms.ToolStripMenuItem();
            this.UnPost = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPosted = new System.Windows.Forms.ComboBox();
            this.btnPrintSalesHist = new System.Windows.Forms.Button();
            this.chbFillterSales = new System.Windows.Forms.CheckBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtSdate = new System.Windows.Forms.DateTimePicker();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEntry = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSalesBill = new System.Windows.Forms.DataGridView();
            this.Sale_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.txtPerPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.cbBilltype = new System.Windows.Forms.ComboBox();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCustomrQty = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvCustomerRecord = new System.Windows.Forms.DataGridView();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.BillDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbCusItem = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnPrintCustomerRecord = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.chBFilterByDate = new System.Windows.Forms.CheckBox();
            this.btnLoadCsutomerRecord = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtCustomerTo = new System.Windows.Forms.DateTimePicker();
            this.dtCustomerFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.txtItemQty = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvItemRecord = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnPrintItemRecord = new System.Windows.Forms.Button();
            this.cbChooseItem = new System.Windows.Forms.ComboBox();
            this.chbItemFilter = new System.Windows.Forms.CheckBox();
            this.btnLoadItemRecord = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtItemTo = new System.Windows.Forms.DateTimePicker();
            this.dtItemFrom = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecord)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemRecord)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.dgvSalesHistory);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(953, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سجل المبيعات";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.txtSumAllSales);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 105);
            this.panel4.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(832, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 20);
            this.label25.TabIndex = 7;
            this.label25.Text = "اجمالي الكمية المباعه";
            // 
            // txtSumAllSales
            // 
            this.txtSumAllSales.Enabled = false;
            this.txtSumAllSales.Location = new System.Drawing.Point(586, 60);
            this.txtSumAllSales.Name = "txtSumAllSales";
            this.txtSumAllSales.Size = new System.Drawing.Size(240, 26);
            this.txtSumAllSales.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(415, 2);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(381, 21);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search here ...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(445, 32);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here ...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(8, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 43);
            this.label16.TabIndex = 0;
            this.label16.Text = "Sales Module";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSalesHistory
            // 
            this.dgvSalesHistory.AllowUserToAddRows = false;
            this.dgvSalesHistory.AllowUserToDeleteRows = false;
            this.dgvSalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalesHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesHistory.ColumnHeadersHeight = 30;
            this.dgvSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesHistory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSalesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesHistory.EnableHeadersVisualStyles = false;
            this.dgvSalesHistory.Location = new System.Drawing.Point(0, 72);
            this.dgvSalesHistory.Name = "dgvSalesHistory";
            this.dgvSalesHistory.RowHeadersVisible = false;
            this.dgvSalesHistory.Size = new System.Drawing.Size(953, 534);
            this.dgvSalesHistory.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCustOrCur,
            this.edit,
            this.Delete,
            this.Post,
            this.UnPost});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // EditCustOrCur
            // 
            this.EditCustOrCur.Name = "EditCustOrCur";
            this.EditCustOrCur.Size = new System.Drawing.Size(205, 22);
            this.EditCustOrCur.Text = "تعديل اسم الزبون او العملة";
            this.EditCustOrCur.Click += new System.EventHandler(this.EditCustOrCurStripMenuItem1_Click);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(205, 22);
            this.edit.Text = "تفاصيل الفاتورة";
            this.edit.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(205, 22);
            this.Delete.Text = "حذف الفاتورة";
            this.Delete.Click += new System.EventHandler(this.DeletetoolStripMenuItem1_Click);
            // 
            // Post
            // 
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(205, 22);
            this.Post.Text = "ترحيل";
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // UnPost
            // 
            this.UnPost.Name = "UnPost";
            this.UnPost.Size = new System.Drawing.Size(205, 22);
            this.UnPost.Text = "الغاء الترحيل";
            this.UnPost.Click += new System.EventHandler(this.UnPost_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbPosted);
            this.panel3.Controls.Add(this.btnPrintSalesHist);
            this.panel3.Controls.Add(this.chbFillterSales);
            this.panel3.Controls.Add(this.btnPost);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtTo);
            this.panel3.Controls.Add(this.dtFrom);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 72);
            this.panel3.TabIndex = 0;
            // 
            // cbPosted
            // 
            this.cbPosted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPosted.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPosted.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPosted.FormattingEnabled = true;
            this.cbPosted.Items.AddRange(new object[] {
            "مرحل",
            "غير مرحل",
            "الكل"});
            this.cbPosted.Location = new System.Drawing.Point(847, 20);
            this.cbPosted.Name = "cbPosted";
            this.cbPosted.Size = new System.Drawing.Size(85, 28);
            this.cbPosted.TabIndex = 25;
            this.cbPosted.SelectedIndexChanged += new System.EventHandler(this.cbPosted_SelectedIndexChanged);
            // 
            // btnPrintSalesHist
            // 
            this.btnPrintSalesHist.FlatAppearance.BorderSize = 0;
            this.btnPrintSalesHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSalesHist.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintSalesHist.Image")));
            this.btnPrintSalesHist.Location = new System.Drawing.Point(37, 17);
            this.btnPrintSalesHist.Name = "btnPrintSalesHist";
            this.btnPrintSalesHist.Size = new System.Drawing.Size(42, 36);
            this.btnPrintSalesHist.TabIndex = 20;
            this.btnPrintSalesHist.UseVisualStyleBackColor = true;
            this.btnPrintSalesHist.Click += new System.EventHandler(this.btnSalesReceipts_Click);
            // 
            // chbFillterSales
            // 
            this.chbFillterSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFillterSales.AutoSize = true;
            this.chbFillterSales.Location = new System.Drawing.Point(713, 20);
            this.chbFillterSales.Name = "chbFillterSales";
            this.chbFillterSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbFillterSales.Size = new System.Drawing.Size(121, 24);
            this.chbFillterSales.TabIndex = 4;
            this.chbFillterSales.Text = "فلترة حسب التاريخ";
            this.chbFillterSales.UseVisualStyleBackColor = true;
            this.chbFillterSales.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(149, 17);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(115, 29);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "ترحيل الكل";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Visible = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(270, 17);
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
            this.label9.Location = new System.Drawing.Point(532, 21);
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
            this.dtTo.Location = new System.Drawing.Point(410, 19);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(116, 26);
            this.dtTo.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Enabled = false;
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(562, 19);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(116, 26);
            this.dtFrom.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "من";
            // 
            // dtSdate
            // 
            this.dtSdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtSdate.Enabled = false;
            this.dtSdate.Location = new System.Drawing.Point(542, 113);
            this.dtSdate.Name = "dtSdate";
            this.dtSdate.Size = new System.Drawing.Size(278, 26);
            this.dtSdate.TabIndex = 3;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRefNo.Enabled = false;
            this.txtRefNo.Location = new System.Drawing.Point(542, 48);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(126, 26);
            this.txtRefNo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnEntry);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvSalesBill);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(953, 606);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة فاتورة مبيعات";
            // 
            // btnEntry
            // 
            this.btnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnEntry.Enabled = false;
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.ForeColor = System.Drawing.Color.White;
            this.btnEntry.Location = new System.Drawing.Point(860, 498);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(83, 36);
            this.btnEntry.TabIndex = 8;
            this.btnEntry.Text = "حفظ الفاتورة";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 65);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Module";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSalesBill
            // 
            this.dgvSalesBill.AllowUserToAddRows = false;
            this.dgvSalesBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSalesBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesBill.ColumnHeadersHeight = 30;
            this.dgvSalesBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sale_number,
            this.Block_name,
            this.Block_id,
            this.ItemPrice,
            this.Block_amount,
            this.total});
            this.dgvSalesBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSalesBill.EnableHeadersVisualStyles = false;
            this.dgvSalesBill.Location = new System.Drawing.Point(0, 228);
            this.dgvSalesBill.Name = "dgvSalesBill";
            this.dgvSalesBill.RowHeadersVisible = false;
            this.dgvSalesBill.Size = new System.Drawing.Size(953, 267);
            this.dgvSalesBill.TabIndex = 14;
            // 
            // Sale_number
            // 
            this.Sale_number.HeaderText = "رقم الفاتورة";
            this.Sale_number.Name = "Sale_number";
            // 
            // Block_name
            // 
            this.Block_name.HeaderText = "الصنف";
            this.Block_name.Name = "Block_name";
            // 
            // Block_id
            // 
            this.Block_id.HeaderText = "Block_id";
            this.Block_id.Name = "Block_id";
            this.Block_id.Visible = false;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "سعر الحبة";
            this.ItemPrice.Name = "ItemPrice";
            // 
            // Block_amount
            // 
            this.Block_amount.HeaderText = "الكمية";
            this.Block_amount.Name = "Block_amount";
            // 
            // total
            // 
            this.total.HeaderText = "الاجمالي";
            this.total.Name = "total";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotalBill);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.txtDetails);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtTotalQty);
            this.panel2.Controls.Add(this.txtPerPrice);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.cbitem);
            this.panel2.Controls.Add(this.cbBilltype);
            this.panel2.Controls.Add(this.cbCustomers);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtSdate);
            this.panel2.Controls.Add(this.txtRefNo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 228);
            this.panel2.TabIndex = 0;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Location = new System.Drawing.Point(274, 146);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(108, 26);
            this.txtTotalBill.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(388, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 20);
            this.label20.TabIndex = 13;
            this.label20.Text = "اجمالي الفاتوره :";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(104, 179);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(95, 29);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "اضافة صنف";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDetails.Location = new System.Drawing.Point(104, 113);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(278, 26);
            this.txtDetails.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(542, 145);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(124, 26);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalBill_KeyPress);
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalQty.Enabled = false;
            this.txtTotalQty.Location = new System.Drawing.Point(104, 146);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(74, 26);
            this.txtTotalQty.TabIndex = 12;
            // 
            // txtPerPrice
            // 
            this.txtPerPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPerPrice.Enabled = false;
            this.txtPerPrice.Location = new System.Drawing.Point(754, 145);
            this.txtPerPrice.Name = "txtPerPrice";
            this.txtPerPrice.Size = new System.Drawing.Size(66, 26);
            this.txtPerPrice.TabIndex = 12;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQty.Location = new System.Drawing.Point(104, 79);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(278, 26);
            this.txtQty.TabIndex = 4;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Validating += new System.ComponentModel.CancelEventHandler(this.txtQty_Validating);
            // 
            // cbitem
            // 
            this.cbitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbitem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbitem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(542, 80);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(278, 28);
            this.cbitem.TabIndex = 2;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            this.cbitem.TextChanged += new System.EventHandler(this.cbitem_TextChanged);
            this.cbitem.Validating += new System.ComponentModel.CancelEventHandler(this.cbitem_Validating);
            // 
            // cbBilltype
            // 
            this.cbBilltype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBilltype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBilltype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBilltype.FormattingEnabled = true;
            this.cbBilltype.Items.AddRange(new object[] {
            "نقد",
            "آجل",
            "دين"});
            this.cbBilltype.Location = new System.Drawing.Point(754, 44);
            this.cbBilltype.Name = "cbBilltype";
            this.cbBilltype.Size = new System.Drawing.Size(66, 28);
            this.cbBilltype.TabIndex = 1;
            this.cbBilltype.SelectedIndexChanged += new System.EventHandler(this.cbBilltype_SelectedIndexChanged);
            this.cbBilltype.TextChanged += new System.EventHandler(this.cbBilltype_TextChanged);
            this.cbBilltype.Validating += new System.ComponentModel.CancelEventHandler(this.cbBilltype_Validating);
            // 
            // cbCustomers
            // 
            this.cbCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(104, 44);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(278, 28);
            this.cbCustomers.TabIndex = 3;
            this.cbCustomers.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomers_Validating);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(672, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "الاجمالي :";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(184, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 20);
            this.label21.TabIndex = 9;
            this.label21.Text = "اجمالي الكمية :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "تفاصيل الفاتورة :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(827, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "سعر الحبة :";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(827, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "نوع الفاتورة :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "الكمية المطلوبة :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "اسم الزبون :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "التاريخ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "الصنف المطلوب :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "رقم الفاتورة :";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.RightToLeftLayout = true;
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(961, 648);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel6);
            this.metroTabPage1.Controls.Add(this.dgvCustomerRecord);
            this.metroTabPage1.Controls.Add(this.panel5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 1;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(953, 606);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "كشف حساب زبون";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.txtCustomrQty);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(953, 65);
            this.panel6.TabIndex = 16;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(817, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 20);
            this.label27.TabIndex = 6;
            this.label27.Text = "اجمالي الكمية المباعه";
            // 
            // txtCustomrQty
            // 
            this.txtCustomrQty.Enabled = false;
            this.txtCustomrQty.Location = new System.Drawing.Point(571, 19);
            this.txtCustomrQty.Name = "txtCustomrQty";
            this.txtCustomrQty.Size = new System.Drawing.Size(240, 26);
            this.txtCustomrQty.TabIndex = 5;
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
            // dgvCustomerRecord
            // 
            this.dgvCustomerRecord.AllowUserToAddRows = false;
            this.dgvCustomerRecord.AllowUserToResizeColumns = false;
            this.dgvCustomerRecord.AllowUserToResizeRows = false;
            this.dgvCustomerRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCustomerRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerRecord.ColumnHeadersHeight = 30;
            this.dgvCustomerRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerRecord.ContextMenuStrip = this.metroContextMenu1;
            this.dgvCustomerRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomerRecord.EnableHeadersVisualStyles = false;
            this.dgvCustomerRecord.Location = new System.Drawing.Point(0, 72);
            this.dgvCustomerRecord.Name = "dgvCustomerRecord";
            this.dgvCustomerRecord.RowHeadersVisible = false;
            this.dgvCustomerRecord.Size = new System.Drawing.Size(953, 376);
            this.dgvCustomerRecord.TabIndex = 15;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BillDetailsToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(151, 26);
            // 
            // BillDetailsToolStripMenuItem
            // 
            this.BillDetailsToolStripMenuItem.Name = "BillDetailsToolStripMenuItem";
            this.BillDetailsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.BillDetailsToolStripMenuItem.Text = "تفاصيل الفاتورة";
            this.BillDetailsToolStripMenuItem.Click += new System.EventHandler(this.BillDetailsToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.cbCusItem);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.btnPrintCustomerRecord);
            this.panel5.Controls.Add(this.cbCustomer);
            this.panel5.Controls.Add(this.chBFilterByDate);
            this.panel5.Controls.Add(this.btnLoadCsutomerRecord);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.dtCustomerTo);
            this.panel5.Controls.Add(this.dtCustomerFrom);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 72);
            this.panel5.TabIndex = 14;
            // 
            // cbCusItem
            // 
            this.cbCusItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCusItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCusItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCusItem.FormattingEnabled = true;
            this.cbCusItem.Location = new System.Drawing.Point(718, 39);
            this.cbCusItem.Name = "cbCusItem";
            this.cbCusItem.Size = new System.Drawing.Size(141, 28);
            this.cbCusItem.TabIndex = 23;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(865, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 20);
            this.label26.TabIndex = 22;
            this.label26.Text = "اسم الصنف :";
            // 
            // btnPrintCustomerRecord
            // 
            this.btnPrintCustomerRecord.FlatAppearance.BorderSize = 0;
            this.btnPrintCustomerRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintCustomerRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCustomerRecord.Image")));
            this.btnPrintCustomerRecord.Location = new System.Drawing.Point(19, 15);
            this.btnPrintCustomerRecord.Name = "btnPrintCustomerRecord";
            this.btnPrintCustomerRecord.Size = new System.Drawing.Size(42, 36);
            this.btnPrintCustomerRecord.TabIndex = 21;
            this.btnPrintCustomerRecord.UseVisualStyleBackColor = true;
            this.btnPrintCustomerRecord.Click += new System.EventHandler(this.btnPrintCustomerRecord_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(718, 6);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(141, 28);
            this.cbCustomer.TabIndex = 1;
            // 
            // chBFilterByDate
            // 
            this.chBFilterByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chBFilterByDate.AutoSize = true;
            this.chBFilterByDate.Location = new System.Drawing.Point(571, 27);
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
            this.btnLoadCsutomerRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadCsutomerRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLoadCsutomerRecord.FlatAppearance.BorderSize = 0;
            this.btnLoadCsutomerRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadCsutomerRecord.ForeColor = System.Drawing.Color.White;
            this.btnLoadCsutomerRecord.Location = new System.Drawing.Point(198, 24);
            this.btnLoadCsutomerRecord.Name = "btnLoadCsutomerRecord";
            this.btnLoadCsutomerRecord.Size = new System.Drawing.Size(115, 29);
            this.btnLoadCsutomerRecord.TabIndex = 5;
            this.btnLoadCsutomerRecord.Text = "بحث";
            this.btnLoadCsutomerRecord.UseVisualStyleBackColor = false;
            this.btnLoadCsutomerRecord.Click += new System.EventHandler(this.btnLoadCsutomerRecord_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(485, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "من تاريخ :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "الى تاريخ :";
            // 
            // dtCustomerTo
            // 
            this.dtCustomerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCustomerTo.CustomFormat = "dd/MM/yyyy";
            this.dtCustomerTo.Enabled = false;
            this.dtCustomerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCustomerTo.Location = new System.Drawing.Point(363, 37);
            this.dtCustomerTo.Name = "dtCustomerTo";
            this.dtCustomerTo.Size = new System.Drawing.Size(116, 26);
            this.dtCustomerTo.TabIndex = 4;
            // 
            // dtCustomerFrom
            // 
            this.dtCustomerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtCustomerFrom.CustomFormat = "dd/MM/yyyy";
            this.dtCustomerFrom.Enabled = false;
            this.dtCustomerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCustomerFrom.Location = new System.Drawing.Point(363, 4);
            this.dtCustomerFrom.Name = "dtCustomerFrom";
            this.dtCustomerFrom.Size = new System.Drawing.Size(116, 26);
            this.dtCustomerFrom.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(865, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "اسم الزبون :";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel8);
            this.metroTabPage2.Controls.Add(this.dgvItemRecord);
            this.metroTabPage2.Controls.Add(this.panel7);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 1;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(953, 606);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "مبيعات الاصناف";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel8.Controls.Add(this.label24);
            this.panel8.Controls.Add(this.txtItemQty);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 541);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 65);
            this.panel8.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(829, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 20);
            this.label24.TabIndex = 4;
            this.label24.Text = "اجمالي الكمية المباعه";
            // 
            // txtItemQty
            // 
            this.txtItemQty.Enabled = false;
            this.txtItemQty.Location = new System.Drawing.Point(583, 19);
            this.txtItemQty.Name = "txtItemQty";
            this.txtItemQty.Size = new System.Drawing.Size(240, 26);
            this.txtItemQty.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Location = new System.Drawing.Point(7, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(95, 43);
            this.label23.TabIndex = 0;
            this.label23.Text = "Sales Module";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvItemRecord
            // 
            this.dgvItemRecord.AllowUserToAddRows = false;
            this.dgvItemRecord.AllowUserToResizeColumns = false;
            this.dgvItemRecord.AllowUserToResizeRows = false;
            this.dgvItemRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItemRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItemRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemRecord.ColumnHeadersHeight = 30;
            this.dgvItemRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItemRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemRecord.EnableHeadersVisualStyles = false;
            this.dgvItemRecord.Location = new System.Drawing.Point(0, 72);
            this.dgvItemRecord.Name = "dgvItemRecord";
            this.dgvItemRecord.RowHeadersVisible = false;
            this.dgvItemRecord.Size = new System.Drawing.Size(953, 534);
            this.dgvItemRecord.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnPrintItemRecord);
            this.panel7.Controls.Add(this.cbChooseItem);
            this.panel7.Controls.Add(this.chbItemFilter);
            this.panel7.Controls.Add(this.btnLoadItemRecord);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.dtItemTo);
            this.panel7.Controls.Add(this.dtItemFrom);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(953, 72);
            this.panel7.TabIndex = 15;
            // 
            // btnPrintItemRecord
            // 
            this.btnPrintItemRecord.FlatAppearance.BorderSize = 0;
            this.btnPrintItemRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintItemRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintItemRecord.Image")));
            this.btnPrintItemRecord.Location = new System.Drawing.Point(19, 15);
            this.btnPrintItemRecord.Name = "btnPrintItemRecord";
            this.btnPrintItemRecord.Size = new System.Drawing.Size(42, 36);
            this.btnPrintItemRecord.TabIndex = 21;
            this.btnPrintItemRecord.UseVisualStyleBackColor = true;
            this.btnPrintItemRecord.Click += new System.EventHandler(this.btnPrintItemRecord_Click);
            // 
            // cbChooseItem
            // 
            this.cbChooseItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChooseItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChooseItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChooseItem.FormattingEnabled = true;
            this.cbChooseItem.Location = new System.Drawing.Point(723, 25);
            this.cbChooseItem.Name = "cbChooseItem";
            this.cbChooseItem.Size = new System.Drawing.Size(141, 28);
            this.cbChooseItem.TabIndex = 1;
            // 
            // chbItemFilter
            // 
            this.chbItemFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbItemFilter.AutoSize = true;
            this.chbItemFilter.Location = new System.Drawing.Point(556, 27);
            this.chbItemFilter.Name = "chbItemFilter";
            this.chbItemFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbItemFilter.Size = new System.Drawing.Size(121, 24);
            this.chbItemFilter.TabIndex = 2;
            this.chbItemFilter.Text = "فلترة حسب التاريخ";
            this.chbItemFilter.UseVisualStyleBackColor = true;
            this.chbItemFilter.CheckedChanged += new System.EventHandler(this.chbItemFilter_CheckedChanged);
            // 
            // btnLoadItemRecord
            // 
            this.btnLoadItemRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadItemRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnLoadItemRecord.FlatAppearance.BorderSize = 0;
            this.btnLoadItemRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadItemRecord.ForeColor = System.Drawing.Color.White;
            this.btnLoadItemRecord.Location = new System.Drawing.Point(183, 24);
            this.btnLoadItemRecord.Name = "btnLoadItemRecord";
            this.btnLoadItemRecord.Size = new System.Drawing.Size(115, 29);
            this.btnLoadItemRecord.TabIndex = 5;
            this.btnLoadItemRecord.Text = "بحث";
            this.btnLoadItemRecord.UseVisualStyleBackColor = false;
            this.btnLoadItemRecord.Click += new System.EventHandler(this.btnLoadItemRecord_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "من تاريخ :";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(470, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "الى تاريخ :";
            // 
            // dtItemTo
            // 
            this.dtItemTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtItemTo.CustomFormat = "dd/MM/yyyy";
            this.dtItemTo.Enabled = false;
            this.dtItemTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtItemTo.Location = new System.Drawing.Point(348, 37);
            this.dtItemTo.Name = "dtItemTo";
            this.dtItemTo.Size = new System.Drawing.Size(116, 26);
            this.dtItemTo.TabIndex = 4;
            // 
            // dtItemFrom
            // 
            this.dtItemFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtItemFrom.CustomFormat = "dd/MM/yyyy";
            this.dtItemFrom.Enabled = false;
            this.dtItemFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtItemFrom.Location = new System.Drawing.Point(348, 5);
            this.dtItemFrom.Name = "dtItemFrom";
            this.dtItemFrom.Size = new System.Drawing.Size(116, 26);
            this.dtItemFrom.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(870, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "اسم الصنف :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 648);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبيعات";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesHistory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecord)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemRecord)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSalesHistory;
        public System.Windows.Forms.DateTimePicker dtSdate;
        public System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvSalesBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        public System.Windows.Forms.TextBox txtDetails;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbFillterSales;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.CheckBox chBFilterByDate;
        public System.Windows.Forms.Button btnLoadCsutomerRecord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtCustomerTo;
        private System.Windows.Forms.DateTimePicker dtCustomerFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvCustomerRecord;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtPerPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem EditCustOrCur;
        public System.Windows.Forms.Button btnEntry;
        public System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.ComboBox cbBilltype;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label label21;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem BillDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnPrintSalesHist;
        private System.Windows.Forms.Button btnPrintCustomerRecord;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvItemRecord;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPrintItemRecord;
        private System.Windows.Forms.ComboBox cbChooseItem;
        private System.Windows.Forms.CheckBox chbItemFilter;
        public System.Windows.Forms.Button btnLoadItemRecord;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtItemTo;
        private System.Windows.Forms.DateTimePicker dtItemFrom;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtItemQty;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtSumAllSales;
        private System.Windows.Forms.ComboBox cbCusItem;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtCustomrQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Block_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem Post;
        private System.Windows.Forms.ToolStripMenuItem UnPost;
        private System.Windows.Forms.ComboBox cbPosted;
        public System.Windows.Forms.Button btnPost;
    }
}