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
    public partial class frmExchangeprices_Module : Form
    {
        int Ex_id;
        clsExchangeprices exchangeprices ;
        public enum enMode { AddNew = 0, Update = 1 }
        enMode mode;
        public frmExchangeprices_Module(int id)
        {
            InitializeComponent();

            Ex_id = id;
            if (Ex_id == -1)
                mode = enMode.AddNew;
            else
                mode = enMode.Update;
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void _FillCurr()
        {
            cbCurr.DataSource = clsCurrencies.GetAll();
            cbCurr.ValueMember = "Cur_ID";
            cbCurr.DisplayMember = "اسم العمله";
            cbCurr.SelectedValue = -1;
        }
        private void _LoadData()
        {
            _FillCurr();

            if(mode == enMode.AddNew)
            {
                exchangeprices = new clsExchangeprices();
                btnUpdate.Enabled = false;
                lbltxt.Text = "اضافة سعر صرف";
                return;
            }
            lbltxt.Text = "تعديل سعر صرف";
            btnSave.Enabled = false;
            exchangeprices = clsExchangeprices.Find_ByID(Ex_id);
            cbCurr.SelectedValue = exchangeprices._Cur_id;
            dt.Value = exchangeprices._Date;
            txtPrice.Text = exchangeprices._Exchange_price.ToString();
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExchangeprices_Module_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            exchangeprices._Cur_id = (int)cbCurr.SelectedValue;
            exchangeprices._Date = dt.Value;
            exchangeprices._Exchange_price = Convert.ToDecimal(txtPrice.Text);

            if (exchangeprices.Save())
            {
                MessageBox.Show("Data Saved");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Data UnSaved");
                this.Dispose();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            exchangeprices._Cur_id = (int)cbCurr.SelectedValue;
            exchangeprices._Date = dt.Value;
            exchangeprices._Exchange_price = Convert.ToDecimal(txtPrice.Text);

            if (exchangeprices.Save())
            {
                MessageBox.Show("Data Saved");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Data UnSaved");
                this.Dispose();
            }
        }
    }
}
