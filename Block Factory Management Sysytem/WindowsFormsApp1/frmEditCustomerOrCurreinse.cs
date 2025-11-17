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
    public partial class frmEditCustomerOrCurreinse : Form
    {
        
        clsSales sales;
        public frmEditCustomerOrCurreinse(int id)
        {
            InitializeComponent();
            sales = clsSales.Find_ByID(id);

        }

        
        private void _FillcbCustomers()
        {
            cbCustomers.DataSource = clsCustomer.GetAllCustomers();
            cbCustomers.DisplayMember = "اسم العميل";
            cbCustomers.ValueMember = "Cus_ID";
            cbCustomers.SelectedValue = sales._Cus_ID;
        }

        private void _LoadRecord()
        {
            dgvSalesBill.DataSource = clsSales.GetAllSales_BySaleNumber(int.Parse(txtRefNo.Text));
            dgvSalesBill.Columns[0].Visible = false;
        }
        private void _LoadData()
        {

            _FillcbCustomers();
            txtRefNo.Text = sales._Sale_Number.ToString();
            txtDetails.Text = sales._Detailes;
            txtAmount.Text = sales._Block_Amount.ToString();
            txtTotalBill.Text = sales._Total_Price.ToString();

            _LoadRecord();


        }
        private void frmEditCustomerOrCurreinse_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("سيتم تعديل اسم العميل  في جميع السجلات التي تحمل الرقم "+txtRefNo.Text+" الى " +
                ""+cbCustomers.Text+"  ","edit",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                sales._Cus_ID = (int)cbCustomers.SelectedValue;
                sales._Detailes = txtDetails.Text;
                sales._Update_By = clsCurrentUser.id;
                sales._Update_on = DateTime.Now;

                if (sales.Save())
                {
                    _LoadRecord();
                    MessageBox.Show("data saved");
                }
            }

        }
    }
}
