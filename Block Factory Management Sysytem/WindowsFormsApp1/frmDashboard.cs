using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace WindowsFormsApp1
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblDalySale.Text = clsSales.GetSumAllSales(DateTime.Now, DateTime.Now).ToString();
            lblStockOnHand.Text = (clsStorage_stock.GetSum() - clsSales.GetSumAllSales()).ToString();

            lblTotalProduct.Text=clsStorage_stock.GetSum(DateTime.Now, DateTime.Now).ToString();
        }
    }
}
