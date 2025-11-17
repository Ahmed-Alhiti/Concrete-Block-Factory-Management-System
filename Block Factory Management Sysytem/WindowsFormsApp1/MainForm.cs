using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesing();

        }

        #region panelSlide
        private void customizeDesing()
        {
            panelsubconfg.Visible = false;           
            panelProduction.Visible = false;
            panelsales.Visible = false;
            panelpruch.Visible = false;
        }

        private void hidSubmenu()
        {
            if (panelsubconfg.Visible == true)
                panelsubconfg.Visible = false;           
            if (panelpruch.Visible == true)
                panelpruch.Visible = false;
            if (panelsales.Visible == true)
                panelsales.Visible = false;
            if (panelProduction.Visible == true)
                panelProduction.Visible = false;
        }

        private void ShowSupmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        #endregion panelSlide;
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            lblTitle.Text = activeForm.Text;
            //_Clear_MainPanel();
            panelMain.Controls.Add(activeForm);
            panelMain.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void _Clear_MainPanel()
        {
            foreach (Control control in panelMain.Controls)
            {
              if(control is Form)
                   control.Dispose();
            }
            //panelMain.Controls.Clear();
        }
        

        private void ProductList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProduct());
            //hidSubmenu();

        }

        

        private void Production_Click(object sender, EventArgs e)
        {
            if (clsUsers.Check_Access(clsCurrentUser.per, clsUsers.enPermission.Production))
            {
            ShowSupmenu(panelProduction);

            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحيات ");
                return;
            }

        }

        private void Customer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());
            hidSubmenu();

        }

        

        private void Operation_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOprations());
            hidSubmenu();
        }

       

        private void Purchases_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPurchases());
            hidSubmenu();

        }

        private void Sales_Click(object sender, EventArgs e)
        {
            
            openChildForm(new frmSales());
            hidSubmenu();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void supplier_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmSupplier());
           // hidSubmenu();
        }

        private void Employee_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee());
           // hidSubmenu();
        }

        private void btnConfgureSys_Click(object sender, EventArgs e)
        {
            if (clsUsers.Check_Access(clsCurrentUser.per, clsUsers.enPermission.All))
            {
                ShowSupmenu(panelsubconfg);
            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحيات ");
                return;
            }
            
        }

        private void Purchases_Click_1(object sender, EventArgs e)
        {
            if (clsUsers.Check_Access(clsCurrentUser.per, clsUsers.enPermission.Purch))
            {
                ShowSupmenu(panelpruch);
            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحيات ");
                return;
            }

        }

        private void Sales_Click_1(object sender, EventArgs e)
        {

            if (clsUsers.Check_Access(clsCurrentUser.per, clsUsers.enPermission.Sales ))
            {
                ShowSupmenu(panelsales);
            }
            else
            {
                MessageBox.Show("ليس لديك الصلاحيات ");
                return;
            }
        }

        private void btnUsersetteings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserAccount());
           // hidSubmenu();
        }

        private void btnCurrencies_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCurrencies());
           // hidSubmenu();
        }

        private void btmMaterials_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMatrials());
            //hidSubmenu();
        }

        private void btnProductionManage_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProduction());
            //hidSubmenu();

        }

        private void btnPruchManage_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPurchases());
            //hidSubmenu();

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());
            //hidSubmenu();

        }

        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            //sw.Start();
            openChildForm(new frmSales());
            //sw.Stop();
           // MessageBox.Show(sw.ElapsedMilliseconds.ToString());
            hidSubmenu();

        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUnit());
           // hidSubmenu();
        }

        private void btnOpration_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOprations());
           // hidSubmenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReceipts());
            //hidSubmenu();
        }

        private void ProductSetteings_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExchangePrices_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExchangeprices());
            //hidSubmenu();
        }

        private void btnExchangeBills_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExchangeBills());
           // hidSubmenu();

        }

        private void btnFund_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDetails());
            //hidSubmenu();

        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBanks());
            //hidSubmenu();
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnDashboard.PerformClick();
            timer1.Start();

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmDashboard());
            hidSubmenu();
        }


        //Getting Battery info using win32 API
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEM_POWER_STATUS
        {
            public byte ACLineStatus;
            public byte BatteryFlag;
            public byte BatteryLifePercent;
            public byte Reserved1;
            public int BatteryLifeTime;
            public int BatteryFullLifeTime;
        }

        // Import the GetSystemPowerStatus API from kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps);
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetSystemPowerStatus(out SYSTEM_POWER_STATUS sps))
            {
                label2.Text = sps.BatteryLifePercent.ToString() + "%";
            }
        }
    }
}