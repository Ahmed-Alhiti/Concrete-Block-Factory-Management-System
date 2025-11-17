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
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvDetails.DataSource = clsSales.GetSalesD(dtFrom.Value, dtTo.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPurchases.GetPurchasesD(dateTimePicker1.Value, dateTimePicker2.Value);

        }

        private void btnPrintSalesHist_Click(object sender, EventArgs e)
        {

        }
    }
}
