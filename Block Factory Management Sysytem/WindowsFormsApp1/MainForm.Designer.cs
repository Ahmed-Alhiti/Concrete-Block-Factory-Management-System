namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Production = new System.Windows.Forms.Button();
            this.btnConfgureSys = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelslide = new System.Windows.Forms.Panel();
            this.panelsales = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesManagement = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.panelpruch = new System.Windows.Forms.Panel();
            this.btnExchangeBills = new System.Windows.Forms.Button();
            this.btnPruchManage = new System.Windows.Forms.Button();
            this.supplier = new System.Windows.Forms.Button();
            this.Purchases = new System.Windows.Forms.Button();
            this.panelProduction = new System.Windows.Forms.Panel();
            this.btnProductionManage = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panelsubconfg = new System.Windows.Forms.Panel();
            this.btnFund = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnOpration = new System.Windows.Forms.Button();
            this.btmMaterials = new System.Windows.Forms.Button();
            this.btnExchangePrices = new System.Windows.Forms.Button();
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.btnUsersetteings = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelslide.SuspendLayout();
            this.panelsales.SuspendLayout();
            this.panelpruch.SuspendLayout();
            this.panelProduction.SuspendLayout();
            this.panelsubconfg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Production
            // 
            this.Production.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.Production.Dock = System.Windows.Forms.DockStyle.Top;
            this.Production.FlatAppearance.BorderSize = 0;
            this.Production.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Production.ForeColor = System.Drawing.Color.White;
            this.Production.Location = new System.Drawing.Point(0, 680);
            this.Production.Name = "Production";
            this.Production.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Production.Size = new System.Drawing.Size(177, 45);
            this.Production.TabIndex = 5;
            this.Production.Text = "الانتاج";
            this.Production.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Production.UseVisualStyleBackColor = false;
            this.Production.Click += new System.EventHandler(this.Production_Click);
            // 
            // btnConfgureSys
            // 
            this.btnConfgureSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnConfgureSys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfgureSys.FlatAppearance.BorderSize = 0;
            this.btnConfgureSys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfgureSys.ForeColor = System.Drawing.Color.White;
            this.btnConfgureSys.Location = new System.Drawing.Point(0, 222);
            this.btnConfgureSys.Name = "btnConfgureSys";
            this.btnConfgureSys.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfgureSys.Size = new System.Drawing.Size(177, 45);
            this.btnConfgureSys.TabIndex = 2;
            this.btnConfgureSys.Text = "تهيئة النظام";
            this.btnConfgureSys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfgureSys.UseVisualStyleBackColor = false;
            this.btnConfgureSys.Click += new System.EventHandler(this.btnConfgureSys_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 177);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(177, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "الواجهة الرئيسة";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.labelusername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 177);
            this.panel2.TabIndex = 1;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.ForeColor = System.Drawing.Color.White;
            this.labelusername.Location = new System.Drawing.Point(52, 114);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(81, 20);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelTitle);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(194, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1072, 716);
            this.panelMain.TabIndex = 5;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.label1);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1072, 40);
            this.panelTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "???";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نسبة البطارية :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(399, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(351, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TitleName";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelslide
            // 
            this.panelslide.AutoScroll = true;
            this.panelslide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panelslide.Controls.Add(this.panelsales);
            this.panelslide.Controls.Add(this.Sales);
            this.panelslide.Controls.Add(this.panelpruch);
            this.panelslide.Controls.Add(this.Purchases);
            this.panelslide.Controls.Add(this.panelProduction);
            this.panelslide.Controls.Add(this.logout);
            this.panelslide.Controls.Add(this.Production);
            this.panelslide.Controls.Add(this.panelsubconfg);
            this.panelslide.Controls.Add(this.btnConfgureSys);
            this.panelslide.Controls.Add(this.btnDashboard);
            this.panelslide.Controls.Add(this.panel2);
            this.panelslide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelslide.Location = new System.Drawing.Point(0, 0);
            this.panelslide.Name = "panelslide";
            this.panelslide.Size = new System.Drawing.Size(194, 716);
            this.panelslide.TabIndex = 3;
            // 
            // panelsales
            // 
            this.panelsales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panelsales.Controls.Add(this.button1);
            this.panelsales.Controls.Add(this.btnSalesManagement);
            this.panelsales.Controls.Add(this.btnCustomers);
            this.panelsales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsales.Location = new System.Drawing.Point(0, 1001);
            this.panelsales.Name = "panelsales";
            this.panelsales.Size = new System.Drawing.Size(177, 139);
            this.panelsales.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "سندات القبض";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalesManagement
            // 
            this.btnSalesManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnSalesManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesManagement.FlatAppearance.BorderSize = 0;
            this.btnSalesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesManagement.ForeColor = System.Drawing.Color.White;
            this.btnSalesManagement.Location = new System.Drawing.Point(0, 45);
            this.btnSalesManagement.Name = "btnSalesManagement";
            this.btnSalesManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalesManagement.Size = new System.Drawing.Size(177, 45);
            this.btnSalesManagement.TabIndex = 7;
            this.btnSalesManagement.Text = "ادارة المبيعات";
            this.btnSalesManagement.UseVisualStyleBackColor = false;
            this.btnSalesManagement.Click += new System.EventHandler(this.btnSalesManagement_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(177, 45);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "الزبائن";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // Sales
            // 
            this.Sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.Sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sales.FlatAppearance.BorderSize = 0;
            this.Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales.ForeColor = System.Drawing.Color.White;
            this.Sales.Location = new System.Drawing.Point(0, 956);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Sales.Size = new System.Drawing.Size(177, 45);
            this.Sales.TabIndex = 21;
            this.Sales.Text = "المبيعات";
            this.Sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sales.UseVisualStyleBackColor = false;
            this.Sales.Click += new System.EventHandler(this.Sales_Click_1);
            // 
            // panelpruch
            // 
            this.panelpruch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panelpruch.Controls.Add(this.btnExchangeBills);
            this.panelpruch.Controls.Add(this.btnPruchManage);
            this.panelpruch.Controls.Add(this.supplier);
            this.panelpruch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelpruch.Location = new System.Drawing.Point(0, 818);
            this.panelpruch.Name = "panelpruch";
            this.panelpruch.Size = new System.Drawing.Size(177, 138);
            this.panelpruch.TabIndex = 20;
            // 
            // btnExchangeBills
            // 
            this.btnExchangeBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnExchangeBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExchangeBills.FlatAppearance.BorderSize = 0;
            this.btnExchangeBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchangeBills.ForeColor = System.Drawing.Color.White;
            this.btnExchangeBills.Location = new System.Drawing.Point(0, 90);
            this.btnExchangeBills.Name = "btnExchangeBills";
            this.btnExchangeBills.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExchangeBills.Size = new System.Drawing.Size(177, 45);
            this.btnExchangeBills.TabIndex = 7;
            this.btnExchangeBills.Text = "سندات الصرف";
            this.btnExchangeBills.UseVisualStyleBackColor = false;
            this.btnExchangeBills.Click += new System.EventHandler(this.btnExchangeBills_Click);
            // 
            // btnPruchManage
            // 
            this.btnPruchManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnPruchManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPruchManage.FlatAppearance.BorderSize = 0;
            this.btnPruchManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPruchManage.ForeColor = System.Drawing.Color.White;
            this.btnPruchManage.Location = new System.Drawing.Point(0, 45);
            this.btnPruchManage.Name = "btnPruchManage";
            this.btnPruchManage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPruchManage.Size = new System.Drawing.Size(177, 45);
            this.btnPruchManage.TabIndex = 6;
            this.btnPruchManage.Text = "ادارة المشتريات";
            this.btnPruchManage.UseVisualStyleBackColor = false;
            this.btnPruchManage.Click += new System.EventHandler(this.btnPruchManage_Click);
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.supplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier.FlatAppearance.BorderSize = 0;
            this.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplier.ForeColor = System.Drawing.Color.White;
            this.supplier.Location = new System.Drawing.Point(0, 0);
            this.supplier.Name = "supplier";
            this.supplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.supplier.Size = new System.Drawing.Size(177, 45);
            this.supplier.TabIndex = 5;
            this.supplier.Text = "الموردين";
            this.supplier.UseVisualStyleBackColor = false;
            this.supplier.Click += new System.EventHandler(this.supplier_Click_1);
            // 
            // Purchases
            // 
            this.Purchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.Purchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.Purchases.FlatAppearance.BorderSize = 0;
            this.Purchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchases.ForeColor = System.Drawing.Color.White;
            this.Purchases.Location = new System.Drawing.Point(0, 773);
            this.Purchases.Margin = new System.Windows.Forms.Padding(0);
            this.Purchases.Name = "Purchases";
            this.Purchases.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Purchases.Size = new System.Drawing.Size(177, 45);
            this.Purchases.TabIndex = 19;
            this.Purchases.Text = "المشتريات";
            this.Purchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Purchases.UseVisualStyleBackColor = false;
            this.Purchases.Click += new System.EventHandler(this.Purchases_Click_1);
            // 
            // panelProduction
            // 
            this.panelProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panelProduction.Controls.Add(this.btnProductionManage);
            this.panelProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProduction.Location = new System.Drawing.Point(0, 725);
            this.panelProduction.Name = "panelProduction";
            this.panelProduction.Size = new System.Drawing.Size(177, 48);
            this.panelProduction.TabIndex = 17;
            // 
            // btnProductionManage
            // 
            this.btnProductionManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnProductionManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductionManage.FlatAppearance.BorderSize = 0;
            this.btnProductionManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionManage.ForeColor = System.Drawing.Color.White;
            this.btnProductionManage.Location = new System.Drawing.Point(0, 0);
            this.btnProductionManage.Name = "btnProductionManage";
            this.btnProductionManage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProductionManage.Size = new System.Drawing.Size(177, 45);
            this.btnProductionManage.TabIndex = 6;
            this.btnProductionManage.Text = "ادارة الانتاج";
            this.btnProductionManage.UseVisualStyleBackColor = false;
            this.btnProductionManage.Click += new System.EventHandler(this.btnProductionManage_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(0, 1140);
            this.logout.Name = "logout";
            this.logout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.logout.Size = new System.Drawing.Size(177, 45);
            this.logout.TabIndex = 9;
            this.logout.Text = "Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panelsubconfg
            // 
            this.panelsubconfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.panelsubconfg.Controls.Add(this.btnFund);
            this.panelsubconfg.Controls.Add(this.btnUnits);
            this.panelsubconfg.Controls.Add(this.btnOpration);
            this.panelsubconfg.Controls.Add(this.btmMaterials);
            this.panelsubconfg.Controls.Add(this.btnExchangePrices);
            this.panelsubconfg.Controls.Add(this.btnCurrencies);
            this.panelsubconfg.Controls.Add(this.btnUsersetteings);
            this.panelsubconfg.Controls.Add(this.Employee);
            this.panelsubconfg.Controls.Add(this.ProductList);
            this.panelsubconfg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubconfg.Location = new System.Drawing.Point(0, 267);
            this.panelsubconfg.Name = "panelsubconfg";
            this.panelsubconfg.Size = new System.Drawing.Size(177, 413);
            this.panelsubconfg.TabIndex = 0;
            // 
            // btnFund
            // 
            this.btnFund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnFund.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFund.FlatAppearance.BorderSize = 0;
            this.btnFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFund.ForeColor = System.Drawing.Color.White;
            this.btnFund.Location = new System.Drawing.Point(0, 360);
            this.btnFund.Name = "btnFund";
            this.btnFund.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFund.Size = new System.Drawing.Size(177, 45);
            this.btnFund.TabIndex = 25;
            this.btnFund.Text = "حركة المبيعات و المشتريات";
            this.btnFund.UseVisualStyleBackColor = false;
            this.btnFund.Click += new System.EventHandler(this.btnFund_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnits.FlatAppearance.BorderSize = 0;
            this.btnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUnits.ForeColor = System.Drawing.Color.White;
            this.btnUnits.Location = new System.Drawing.Point(0, 315);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUnits.Size = new System.Drawing.Size(177, 45);
            this.btnUnits.TabIndex = 24;
            this.btnUnits.Text = "الوحدات";
            this.btnUnits.UseVisualStyleBackColor = false;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnOpration
            // 
            this.btnOpration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnOpration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpration.FlatAppearance.BorderSize = 0;
            this.btnOpration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOpration.ForeColor = System.Drawing.Color.White;
            this.btnOpration.Location = new System.Drawing.Point(0, 270);
            this.btnOpration.Name = "btnOpration";
            this.btnOpration.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOpration.Size = new System.Drawing.Size(177, 45);
            this.btnOpration.TabIndex = 23;
            this.btnOpration.Text = "العمليات";
            this.btnOpration.UseVisualStyleBackColor = false;
            this.btnOpration.Click += new System.EventHandler(this.btnOpration_Click);
            // 
            // btmMaterials
            // 
            this.btmMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btmMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmMaterials.FlatAppearance.BorderSize = 0;
            this.btmMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmMaterials.ForeColor = System.Drawing.Color.White;
            this.btmMaterials.Location = new System.Drawing.Point(0, 225);
            this.btmMaterials.Name = "btmMaterials";
            this.btmMaterials.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btmMaterials.Size = new System.Drawing.Size(177, 45);
            this.btmMaterials.TabIndex = 22;
            this.btmMaterials.Text = "المواد الخام";
            this.btmMaterials.UseVisualStyleBackColor = false;
            this.btmMaterials.Click += new System.EventHandler(this.btmMaterials_Click);
            // 
            // btnExchangePrices
            // 
            this.btnExchangePrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnExchangePrices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExchangePrices.FlatAppearance.BorderSize = 0;
            this.btnExchangePrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchangePrices.ForeColor = System.Drawing.Color.White;
            this.btnExchangePrices.Location = new System.Drawing.Point(0, 180);
            this.btnExchangePrices.Name = "btnExchangePrices";
            this.btnExchangePrices.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExchangePrices.Size = new System.Drawing.Size(177, 45);
            this.btnExchangePrices.TabIndex = 21;
            this.btnExchangePrices.Text = "اسعار الصرف ";
            this.btnExchangePrices.UseVisualStyleBackColor = false;
            this.btnExchangePrices.Click += new System.EventHandler(this.btnExchangePrices_Click);
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnCurrencies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrencies.FlatAppearance.BorderSize = 0;
            this.btnCurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencies.ForeColor = System.Drawing.Color.White;
            this.btnCurrencies.Location = new System.Drawing.Point(0, 135);
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCurrencies.Size = new System.Drawing.Size(177, 45);
            this.btnCurrencies.TabIndex = 20;
            this.btnCurrencies.Text = "العملات";
            this.btnCurrencies.UseVisualStyleBackColor = false;
            this.btnCurrencies.Click += new System.EventHandler(this.btnCurrencies_Click);
            // 
            // btnUsersetteings
            // 
            this.btnUsersetteings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnUsersetteings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsersetteings.FlatAppearance.BorderSize = 0;
            this.btnUsersetteings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersetteings.ForeColor = System.Drawing.Color.White;
            this.btnUsersetteings.Location = new System.Drawing.Point(0, 90);
            this.btnUsersetteings.Name = "btnUsersetteings";
            this.btnUsersetteings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsersetteings.Size = new System.Drawing.Size(177, 45);
            this.btnUsersetteings.TabIndex = 19;
            this.btnUsersetteings.Text = "المستخدمين";
            this.btnUsersetteings.UseVisualStyleBackColor = false;
            this.btnUsersetteings.Click += new System.EventHandler(this.btnUsersetteings_Click);
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.Employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employee.FlatAppearance.BorderSize = 0;
            this.Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employee.ForeColor = System.Drawing.Color.White;
            this.Employee.Location = new System.Drawing.Point(0, 45);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Employee.Size = new System.Drawing.Size(177, 45);
            this.Employee.TabIndex = 18;
            this.Employee.Text = "الموظفين";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.Employee_Click_1);
            // 
            // ProductList
            // 
            this.ProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductList.FlatAppearance.BorderSize = 0;
            this.ProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductList.ForeColor = System.Drawing.Color.White;
            this.ProductList.Location = new System.Drawing.Point(0, 0);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(177, 45);
            this.ProductList.TabIndex = 4;
            this.ProductList.Text = "قائمة الاصناف";
            this.ProductList.UseVisualStyleBackColor = true;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 716);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelslide);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelslide.ResumeLayout(false);
            this.panelsales.ResumeLayout(false);
            this.panelpruch.ResumeLayout(false);
            this.panelProduction.ResumeLayout(false);
            this.panelsubconfg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnDashboard;
        public System.Windows.Forms.Label labelusername;
        public System.Windows.Forms.Button Production;
        public System.Windows.Forms.Button btnConfgureSys;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Panel panelslide;
        public System.Windows.Forms.Button logout;
        public System.Windows.Forms.Panel panelsubconfg;
        public System.Windows.Forms.Button ProductList;
        public System.Windows.Forms.Panel panelTitle;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelpruch;
        public System.Windows.Forms.Button Purchases;
        private System.Windows.Forms.Panel panelProduction;
        private System.Windows.Forms.Panel panelsales;
        public System.Windows.Forms.Button Sales;
        public System.Windows.Forms.Button Employee;
        public System.Windows.Forms.Button btnSalesManagement;
        public System.Windows.Forms.Button btnCustomers;
        public System.Windows.Forms.Button btnPruchManage;
        public System.Windows.Forms.Button supplier;
        public System.Windows.Forms.Button btnProductionManage;
        public System.Windows.Forms.Button btnExchangePrices;
        public System.Windows.Forms.Button btnCurrencies;
        public System.Windows.Forms.Button btnUsersetteings;
        public System.Windows.Forms.Button btnOpration;
        public System.Windows.Forms.Button btmMaterials;
        public System.Windows.Forms.Button btnUnits;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnExchangeBills;
        public System.Windows.Forms.Button btnFund;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label2;
    }
}