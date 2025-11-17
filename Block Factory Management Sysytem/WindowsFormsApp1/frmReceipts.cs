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
    public partial class frmReceipts : Form
    {
        bool three = false;
        public int lastid = clsReceipts.GetLastID();
        public enum enBillType { قبض = 5, صرف = 6}
        public enBillType billType= enBillType.قبض;
        
        public frmReceipts()
        {
            InitializeComponent();
        }

        private void _FillcbCustomers()
        {
            cbCustomers.DataSource = clsCustomer.GetAllCustomers();

            cbCustomers.DisplayMember = "اسم العميل";

            cbCustomers.ValueMember = "Cus_ID";

            cbCustomers.SelectedValue = -1;
            
        }
        private void _FillcbCustomer()
        {
            cbCustomer.DataSource = clsCustomer.GetAllCustomers();

            cbCustomer.DisplayMember = "اسم العميل";

            cbCustomer.ValueMember = "Cus_ID";

            cbCustomer.SelectedValue = -1;
            
        }
        private void _FillcbOprations()
        {
            cbOprations.DataSource = clsOperations.GetAll();
            cbOprations.DisplayMember = "اسم العملية";
            cbOprations.ValueMember = "Ope_ID";
            cbOprations.SelectedValue = -1;
        }
        private void _FillcbCurrencies()
        {
            cbCurrencies.DataSource = clsCurrencies.GetAll();
            cbCurrencies.DisplayMember = "اسم العمله";
            cbCurrencies.ValueMember = "Cur_ID";
            cbCurrencies.SelectedValue = -1;
            three = true;
        }
        private void _FillcbCusCur()
        {
            cbCusCurr.DataSource = clsCurrencies.GetAll();
            cbCusCurr.DisplayMember = "اسم العمله";
            cbCusCurr.ValueMember = "Cur_ID";
            cbCusCurr.SelectedValue = -1;
            
        }

         private void _FillcbCurrencie()
        {
            cbCurrencie.DataSource = clsCurrencies.GetAll();
            cbCurrencie.DisplayMember = "اسم العمله";
            cbCurrencie.ValueMember = "Cur_ID";
            cbCurrencie.SelectedValue = -1;
            
        }

        private void _FillComboBoxses()
        {
            _FillcbCustomer();
            _FillcbCustomers();
            _FillcbCurrencies();
            _FillcbCusCur();
            _FillcbCurrencie();
            _FillcbOprations();
        }
        private void frmPayment_Load(object sender, EventArgs e)
        {
            _FillComboBoxses();
            _GetRef(ref lastid);

        }

       

        //private bool Check_TotalBillAndamount()
        //{
        //    bool isPass = true;
        //    int amount = int.Parse(txtAmount.Text);
        //    int billtotal = int.Parse(txtBillTotal.Text);
        //    int Total_payed = int.Parse(txtPayed.Text);

        //    if(amount > billtotal)
        //    {
        //        MessageBox.Show("المبلغ الذي تحاول ادخالة اكبر من اجمالي الفاتورة , اجمالي الفاتورة = " + billtotal.ToString() + " المبلغ الذي تريد ادخالة = " + amount.ToString() + " ");
        //        isPass = false;
        //        return isPass;
        //    }

        //    else if (amount+Total_payed > billtotal)
        //    {
        //        MessageBox.Show("المبلغ الذي تحاول ادخالة اكبر من اجمالي الفاتورة , اجمالي الفاتورة = " + billtotal.ToString() + "  المبلغ الذي تريد ادخالة مع المبلغ المدفوع مسبقا = " + Total_payed.ToString() + " ");
        //        isPass = false;
        //        return isPass;
        //    }
        //    else if (amount+Total_payed == billtotal)
        //    {
        //        MessageBox.Show("المبلغ الذي تحاول ادخالة اكبر من اجمالي الفاتورة , اجمالي الفاتورة = " + billtotal.ToString() + "  المبلغ الذي تريد ادخالة مع المبلغ المدفوع مسبقا = " + Total_payed.ToString() + " ");
        //        isPass = true;
        //        return isPass;
        //    }
        //    return isPass;

        //}

        private void btnEntry_Click(object sender, EventArgs e)
        {

            clsReceipts receipts = new clsReceipts();
            receipts._Cur_id = (int)cbCurrencies.SelectedValue;
            receipts._Date = dtPdate.Value;
            receipts._RefNo = int.Parse(txtReceiptsNo.Text);
            receipts._Total = decimal.Parse(txtTotalBill.Text);
            if (!receipts.Save())
            {
                MessageBox.Show("can't save");
                return;
            }
            else
            {
                lastid = clsReceipts.GetLastID();

                foreach(DataGridViewRow row in dgvPayed.Rows)
                {
                    clsReceiptsDetails receiptsDetails = new clsReceiptsDetails();
                    receiptsDetails._Cur_id = int.Parse(row.Cells["Cur_id"].Value.ToString());
                    receiptsDetails._Cus_id = int.Parse(row.Cells["Customer_id"].Value.ToString());
                    receiptsDetails._Details = row.Cells["Details"].Value.ToString();
                    receiptsDetails._Exchagne_id = int.Parse(row.Cells["Exchagne_id"].Value.ToString());
                    receiptsDetails._RefNo = int.Parse(row.Cells["RefNo"].Value.ToString());
                    receiptsDetails._Total = decimal.Parse(row.Cells["Total"].Value.ToString());

                    if (!receiptsDetails.Save())
                    {
                        MessageBox.Show("Can't save details");
                        return;
                    }
                   
                }
            }

            MessageBox.Show("تم الحفظ بنجاح");
            dgvPayed.Rows.Clear();
            txtAmount.Clear();
            txtDetails.Clear();
            txtExchangePrice.Clear();
            txtExchangePrice.Visible = false;
            lblExchangePrice.Visible = false;
            txtReceiptsNo.Clear();
            txtTotalBill.Clear();
            cbCurrencies.SelectedValue = -1;
            cbCustomers.SelectedValue = -1;
            cbOprations.SelectedValue = -1;
            cbCurrencies.Enabled = true;
            cbCustomers.Enabled = true;
            cbOprations.Enabled = true;
            txtAmount.Enabled = true;
            txtDetails.Enabled = true;
            _GetRef(ref lastid);

        }


        private void _LoadData()
        {
            if (cbCurrencie.Text == string.Empty)
            {
                MessageBox.Show("يرجى تحديد العملة اولا");
                cbCurrencie.Focus();
                return;
            }

            if (chbFillterPay.Checked)
            {
                dgvPayHistory.DataSource = clsReceipts.GetAll((int)cbCurrencie.SelectedValue, dtFrom.Value, dtTo.Value);
                if (dgvPayHistory.Rows.Count > 0)
                    dgvPayHistory.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            else
            {
                dgvPayHistory.DataSource = clsReceipts.GetAll((int)cbCurrencie.SelectedValue);
                if (dgvPayHistory.Rows.Count > 0)
                    dgvPayHistory.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد سندات قبض بالعمله " + cbCurrencie.Text + " ", "قبض بـ(" + cbCurrencie.Text + ")", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

            _LoadData();

        }
        clsExchangeprices _exchangeprices;
        private void cbCurrencies_SelectedValueChanged(object sender, EventArgs e)
        {
            if (three != true)
                return;
            if (cbCurrencies.Text == string.Empty)
                return;


           
                _exchangeprices = clsExchangeprices.Get_LastExchPrice((int)cbCurrencies.SelectedValue);
                if(_exchangeprices == null)
                {
                   if(MessageBox.Show("يجب عليك اولا اضافة سعر صرف للعمله "+cbCurrencies.Text+" لكي تستطيع اتمام هذا الاجراء ", "اضافة سعر صرف", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK) 
                   {

                     frmExchangeprices_Module _Module = new frmExchangeprices_Module(-1);
                    _Module.ShowDialog();
                    
                     
                   }
                   
                    
                }

                if(cbCurrencies.Text!="ريال يمني")
                {
                    lblExchangePrice.Visible = true;
                    txtExchangePrice.Visible = true;
                    txtExchangePrice.Text = _exchangeprices._Exchange_price.ToString();
                }

                   
            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private decimal calculateTotalBill()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvPayed.Rows)
            {

                if (decimal.TryParse(row.Cells["total"].Value.ToString(), out decimal price))
                    total += price;

            }
            return total;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(cbOprations.Text) || string.IsNullOrEmpty(cbCurrencies.Text))
            {
                MessageBox.Show("يرجى ادخال البيانات بشكل صحيح , تأكد من انك ادخلت المبلغ او العملية او العملة");
                return;
            }
            else
            {
                
                dgvPayed.Rows.Add(txtReceiptsNo.Text, cbCustomers.Text, cbCustomers.SelectedValue, cbCurrencies.SelectedValue, _exchangeprices._Ex_id
                , txtAmount.Text, cbCurrencies.Text, _exchangeprices._Exchange_price, txtDetails.Text);
                
                txtTotalBill.Text = calculateTotalBill().ToString();

            }

            if (MessageBox.Show("هل تريد اضافة بيانات جديده بنفس رقم السند " + txtReceiptsNo.Text + "?", "اضافة بيانات بنفس رقم السند", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                txtAmount.Clear();
                txtDetails.Clear();
                //txtExchangePrice.Clear();
                //cbCurrencies.SelectedValue = -1;
                cbCurrencies.Enabled = false;
                cbCustomers.SelectedValue = -1;
                cbOprations.SelectedValue = -1;
                cbCustomers.Focus();
                
                return;
            }
            else
            {
                txtAmount.Enabled=false;
                txtDetails.Enabled=false;
                cbOprations.SelectedValue = -1;
                cbCustomers.SelectedValue = -1;
                cbCurrencies.Enabled = false;
                cbCustomers.Enabled = false;
                cbOprations.Enabled = false;
                btnEntry.Focus();

            }

        }

        private void chbFillterPay_CheckedChanged(object sender, EventArgs e)
        {
            if (!dtFrom.Enabled && !dtTo.Enabled)
            {
                dtFrom.Enabled = true;
                dtTo.Enabled = true;
            }
            else
            {
                dtFrom.Enabled = false;
                dtTo.Enabled = false;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiptsDetails receiptsDetails = new frmReceiptsDetails((int)dgvPayHistory.CurrentRow.Cells[1].Value);
            receiptsDetails.ShowDialog();
            dgvPayHistory.DataSource=clsReceipts.GetAllByRefNo((int)dgvPayHistory.CurrentRow.Cells[1].Value);
        }

        private void DeletetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف جميع السجلات التي تحمل الرقم " + dgvPayHistory.CurrentRow.Cells[1].Value.ToString() + "?", "حذف فاتورة", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if (clsReceipts.Delete((int)dgvPayHistory.CurrentRow.Cells[0].Value))
                {


                    MessageBox.Show("تم الحذف بنجاح");

                    _LoadData();
                }

            }
            else
            {
                MessageBox.Show("لم يتم الحذف بنجاح");
            }
        }

        private void _LoadCustomerRecord()
        {
            if (cbCustomer.Text == string.Empty)
            {
                MessageBox.Show("يرجى تحديد اسم الزبون اولا");
                cbCustomer.Focus();
                return;
            }
            if (cbCustomer.Text != string.Empty && !chBFilterByDate.Checked && cbCusCurr.Text == string.Empty)
            {
                dgvCustomerRecord.DataSource = clsReceiptsDetails.GetAllCutomerPay((int)cbCustomer.SelectedValue);
                if (dgvCustomerRecord.Rows.Count > 0)
                    dgvCustomerRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            
            if (chBFilterByDate.Checked && cbCusCurr.Text == string.Empty)
            {
                dgvCustomerRecord.DataSource = clsReceiptsDetails.GetAll((int)cbCustomer.SelectedValue, dtCustomerFrom.Value, dtCustomerTo.Value);
                if (dgvCustomerRecord.Rows.Count > 0)
                    dgvCustomerRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            else if (chBFilterByDate.Checked == false && cbCusCurr.Text != string.Empty)
            {
                dgvCustomerRecord.DataSource = clsReceiptsDetails.GetAllCutomerPay((int)cbCustomer.SelectedValue, (int)cbCusCurr.SelectedValue);
                if (dgvCustomerRecord.Rows.Count > 0)
                    dgvCustomerRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            else
            {
                dgvCustomerRecord.DataSource = clsReceiptsDetails.GetAll((int)cbCustomer.SelectedValue,(int)cbCusCurr.SelectedValue,dtCustomerFrom.Value,dtCustomerTo.Value);
                if (dgvCustomerRecord.Rows.Count > 0)
                    dgvCustomerRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
           
        }
        public void _GetRef(ref int lastid)
        {
            int year = DateTime.Now.Year - 2000;

            if (lastid > 9999)
            {

                lastid -= 9999;
                _GetRef(ref lastid);
            }
            else
            {
                txtReceiptsNo.Text = ((int)billType).ToString() + year.ToString() + lastid.ToString("####0000");
            }



        }
        private void btnLoadCsutomerRecord_Click(object sender, EventArgs e)
        {
            _LoadCustomerRecord();
        }

        private void chBFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!dtCustomerFrom.Enabled && !dtCustomerTo.Enabled)
            {
                dtCustomerFrom.Enabled = true;
                dtCustomerTo.Enabled = true;
            }
            else
            {
                dtCustomerFrom.Enabled = false;
                dtCustomerTo.Enabled = false;
            }
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiptsDetails receiptsDetails = new frmReceiptsDetails((int)dgvCustomerRecord.CurrentRow.Cells[1].Value);
            receiptsDetails.ShowDialog();
            _LoadCustomerRecord();

        }

        private DataTable _LoadReceiptsBillsRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("RefNo", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Cur", typeof(string));


            foreach (DataGridViewRow row in dgvPayHistory.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["RefNo"] = row.Cells["رقم السند"].Value;
                    dataRow["Date"] = row.Cells["تاريخ السند"].Value;
                    dataRow["Amount"] = row.Cells["الاجمالي"].Value;
                    dataRow["Cur"] = row.Cells["العمله"].Value;
                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }

        private void btnPrintReceiptsRecord_Click(object sender, EventArgs e)
        {
            BFMSRecord record = new BFMSRecord();
            string param = " العمله : " + cbCurrencie.Text + "";
            record.LoadReceiptsRecord(_LoadReceiptsBillsRecord(), param);
            record.ShowDialog();

        }

        private DataTable _LoadCustomerReceiptsRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("RefNo", typeof(int));
            table.Columns.Add("Cus_Name", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Cur", typeof(string));
            table.Columns.Add("Exch_Price", typeof(decimal));
            table.Columns.Add("Details", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));


            foreach (DataGridViewRow row in dgvCustomerRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["RefNo"] = row.Cells["رقم السند"].Value;
                    dataRow["Cus_Name"] = row.Cells["الزبون"].Value;
                    dataRow["Amount"] = row.Cells["المبلغ"].Value;
                    dataRow["Cur"] = row.Cells["العمله"].Value;
                    dataRow["Exch_Price"] = row.Cells["سعر الصرف"].Value;
                    dataRow["Details"] = row.Cells["التفاصيل"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;

                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }
        private void btnPrintCusReceipts_Click(object sender, EventArgs e)
        {
            BFMSRecord record = new BFMSRecord();
            string param = "الاسم :  " +cbCustomer.Text+" ";
            record.LoadCusReceiptsRecord(_LoadCustomerReceiptsRecord(), param);
            record.ShowDialog();
        }
    }
}
