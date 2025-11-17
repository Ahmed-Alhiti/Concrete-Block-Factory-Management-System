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
    public partial class frmReceiptsDetails : Form
    {

        clsReceiptsDetails details;
        int refno;
        public frmReceiptsDetails(int refnumber)
        {
            InitializeComponent();
            refno = refnumber;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillcbCustomer()
        {
            cbCustomer.DataSource = clsCustomer.GetAllCustomers();

            cbCustomer.DisplayMember = "اسم العميل";

            cbCustomer.ValueMember = "Cus_ID";

            cbCustomer.SelectedValue = -1;

        }
        private void _FillcbCurrencies()
        {
            cbCurrencies.DataSource = clsCurrencies.GetAll();
            cbCurrencies.DisplayMember = "اسم العمله";
            cbCurrencies.ValueMember = "Cur_ID";
            cbCurrencies.SelectedValue = -1;
        }

        private void _Fillcbs()
        {
            _FillcbCurrencies();
            _FillcbCustomer();
        }

        private void _LoadData()
        {
            dgvReceiptsDetails.DataSource = clsReceiptsDetails.GetAll(refno);
            if (dgvReceiptsDetails.Rows.Count > 0)
            {
                dgvReceiptsDetails.Columns[0].Visible = false;
            }
        }
        private void frmReceiptsDetails_Load(object sender, EventArgs e)
        {
            _Fillcbs();
            _LoadData();
            txtRefNo.Text = refno.ToString();
            dtSdate.Value = clsReceipts.Find_ByRefNo(refno)._Date;

        }

        private void dgvReceiptsDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            details = clsReceiptsDetails.Find_ByID((int)dgvReceiptsDetails.CurrentRow.Cells[0].Value);
            cbCustomer.SelectedValue = details._Cus_id;
            cbCurrencies.SelectedValue = details._Cur_id;
            txtAmount.Text = details._Total.ToString();
            txtExchangePrice.Text = clsExchangeprices.Find_ByID(details._Exchagne_id)._Exchange_price.ToString();
            

            btnSave.Enabled = true;
            btnAccCancel.Enabled = true;
            //cbCurrencies.Enabled = true;
            cbCustomer.Enabled = true;
            txtAmount.Enabled = true;
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnAccCancel.Enabled = false;
           // cbCurrencies.Enabled = false;
            cbCustomer.Enabled = false;
            txtAmount.Enabled = false;
            cbCustomer.SelectedValue = -1;
            cbCurrencies.SelectedValue = -1;
            txtAmount.Clear();
            txtExchangePrice.Clear();

        }

        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dgvReceiptsDetails.Rows)
            {
                total += decimal.Parse(row.Cells["المبلغ"].Value.ToString());
            }
            return total;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حفظ التعديلات التي اضفتها مؤخرا؟ ", "تعديل سند قبض", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               
                details._Cus_id = (int)cbCustomer.SelectedValue;
                details._Total = decimal.Parse(txtAmount.Text);
               




                if (details.Save())
                {

                    MessageBox.Show("Details Date saved");
                    _LoadData();

                    clsReceipts receipts = clsReceipts.Find_ByRefNo(int.Parse(txtRefNo.Text));
                    receipts._Total = CalculateTotal();
                    if (receipts.Save())
                    {
                        MessageBox.Show("Receipts Date saved");
                    }
                    else
                    {
                        MessageBox.Show("Receipts can't save");
                    }

                }
                else
                {
                    MessageBox.Show("can't save");
                }

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if(dgvReceiptsDetails.Rows.Count == 1)
            {
                if (MessageBox.Show("هل تريد حذف السند " + txtRefNo.Text + " وجميع البيانات المرتبطه به ", "حذف جميع السجلات", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    if (clsReceipts.DeleteBy_RefNo(int.Parse(txtRefNo.Text)))
                    {
                        MessageBox.Show("تم حذف جميع البيانات");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                return;
            }
            else
            {
                if (MessageBox.Show("هل تريد حذف الدفع " + dgvReceiptsDetails.CurrentRow.Cells[3].Value.ToString() + "  ", "حذف دفع", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    if (clsReceiptsDetails.Delete((int)dgvReceiptsDetails.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                        _LoadData();

                        clsReceipts receipts = clsReceipts.Find_ByRefNo(int.Parse(txtRefNo.Text));
                        receipts._Total = CalculateTotal();
                        if (receipts.Save())
                        {
                            MessageBox.Show("Receipts Date saved");
                        }
                        else
                        {
                            MessageBox.Show("Receipts can't save");
                        }

                    }
                }
            }
            
        }

    }
}
