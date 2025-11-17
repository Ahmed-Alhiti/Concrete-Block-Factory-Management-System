using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Business;

namespace WindowsFormsApp1
{
    public partial class frmExchangeBills : Form
    {
        bool three = false;
        public int lastid = clsExchangeBills.GetLastID();
        public enum enBillType { قبض = 5, صرف = 6 }
        public enBillType billType = enBillType.صرف;
        public frmExchangeBills()
        {
            InitializeComponent();
        }
        private void _FillcbSuppliers()
        {
            cbSuppliers.DataSource = clsSuppliers.GetAllSuppliers();

            cbSuppliers.DisplayMember = "اسم المورد";

            cbSuppliers.ValueMember = "Sup_ID";

            cbSuppliers.SelectedValue = -1;

        }
        private void _FillcbSupplier()
        {
            cbSupplier.DataSource = clsSuppliers.GetAllSuppliers();

            cbSupplier.DisplayMember = "اسم المورد";

            cbSupplier.ValueMember = "Sup_ID";

            cbSupplier.SelectedValue = -1;

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
            cbSupCurr.DataSource = clsCurrencies.GetAll();
            cbSupCurr.DisplayMember = "اسم العمله";
            cbSupCurr.ValueMember = "Cur_ID";
            cbSupCurr.SelectedValue = -1;

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
            _FillcbSupplier();
            _FillcbSuppliers();
            _FillcbCurrencies();
            _FillcbCusCur();
            _FillcbCurrencie();
            _FillcbOprations();
        }

        private void frmExchangeBills_Load(object sender, EventArgs e)
        {
            _FillComboBoxses();
            GetRef(ref lastid);

        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            clsExchangeBills exchangeBills = new clsExchangeBills();
            exchangeBills._Cur_id = (int)cbCurrencies.SelectedValue;
            exchangeBills._Date = dtPdate.Value;
            exchangeBills._RefNo = int.Parse(txtReceiptsNo.Text);
            if(txtTotalBill.Text == null)
            {
                exchangeBills._Total = decimal.Parse(txtAmount.Text);
            }
            if (!exchangeBills.Save())
            {
                MessageBox.Show("can't save");
                return;
            }
            else
            {
                lastid = clsExchangeBills.GetLastID();

                foreach (DataGridViewRow row in dgvExchangeBill.Rows)
                {
                    clsExchangeDetails exchangeDetails = new clsExchangeDetails();
                    exchangeDetails._Cur_id = int.Parse(row.Cells["Cur_id"].Value.ToString());
                    exchangeDetails._Sup_id = int.Parse(row.Cells["Sup_id"].Value.ToString());
                    exchangeDetails._Details = row.Cells["Details"].Value.ToString();
                    exchangeDetails._Exchagne_id = int.Parse(row.Cells["Exchagne_id"].Value.ToString());
                    exchangeDetails._RefNo = int.Parse(row.Cells["RefNo"].Value.ToString());
                    exchangeDetails._Total = decimal.Parse(row.Cells["Total"].Value.ToString());

                    if (!exchangeDetails.Save())
                    {
                        MessageBox.Show("Can't save details");
                        return;
                    }

                }
            }

            MessageBox.Show("تم الحفظ بنجاح");
            dgvExchangeBill.Rows.Clear();
            txtAmount.Clear();
            txtDetails.Clear();
            txtExchangePrice.Clear();
            txtExchangePrice.Visible = false;
            lblExchangePrice.Visible = false;
            txtReceiptsNo.Clear();
            txtTotalBill.Clear();
            cbCurrencies.SelectedValue = -1;
            cbSuppliers.SelectedValue = -1;
            cbOprations.SelectedValue = -1;
            cbCurrencies.Enabled = true;
            cbSuppliers.Enabled = true;
            cbOprations.Enabled = true;
            txtAmount.Enabled = true;
            txtDetails.Enabled = true;
            GetRef(ref lastid);


        }

        private decimal calculateTotalBill()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvExchangeBill.Rows)
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

                dgvExchangeBill.Rows.Add(txtReceiptsNo.Text, cbSuppliers.Text, cbSuppliers.SelectedValue, cbCurrencies.SelectedValue, _exchangeprices._Ex_id
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
                cbSuppliers.SelectedValue = -1;
                cbOprations.SelectedValue = -1;
                cbSuppliers.Focus();

                return;
            }
            else
            {
                txtAmount.Enabled = false;
                txtDetails.Enabled = false;
                cbOprations.SelectedValue = -1;
                cbSuppliers.SelectedValue = -1;
                cbCurrencies.Enabled = false;
                cbSuppliers.Enabled = false;
                cbOprations.Enabled = false;
                btnEntry.Focus();

            }
        }

        clsExchangeprices _exchangeprices;
        private void cbCurrencies_SelectedValueChanged(object sender, EventArgs e)
        {
            if (three != true)
                return;
            if (cbCurrencies.Text == string.Empty)
                return;



            _exchangeprices = clsExchangeprices.Get_LastExchPrice((int)cbCurrencies.SelectedValue);
            if (_exchangeprices == null)
            {
                if (MessageBox.Show("يجب عليك اولا اضافة سعر صرف للعمله " + cbCurrencies.Text + " لكي تستطيع اتمام هذا الاجراء ", "اضافة سعر صرف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {

                    frmExchangeprices_Module _Module = new frmExchangeprices_Module(-1);
                    _Module.ShowDialog();


                }


            }

            if (cbCurrencies.Text != "ريال يمني")
            {
                lblExchangePrice.Visible = true;
                txtExchangePrice.Visible = true;
                txtExchangePrice.Text = _exchangeprices._Exchange_price.ToString();
            }


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
                dgvExchangeBills.DataSource = clsExchangeBills.GetAll((int)cbCurrencie.SelectedValue, dtFrom.Value, dtTo.Value);
                if (dgvExchangeBills.Rows.Count > 0)
                    dgvExchangeBills.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            else
            {
                dgvExchangeBills.DataSource = clsExchangeBills.GetAll((int)cbCurrencie.SelectedValue);
                if (dgvExchangeBills.Rows.Count > 0)
                    dgvExchangeBills.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد سندات صرف بالعمله " + cbCurrencie.Text + " ", "صرف بـ(" + cbCurrencie.Text + ")", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadSupplierRecord()
        {
            if (cbSupplier.Text == string.Empty)
            {
                MessageBox.Show("يرجى تحديد اسم المورد اولا");
                cbSupplier.Focus();
                return;
            }
            if (cbSupplier.Text != string.Empty && !chBFilterByDate.Checked  && cbSupCurr.Text == string.Empty)
            {
                dgvSupplierRecord.DataSource = clsExchangeDetails.GetAllSupExchBills((int)cbSupplier.SelectedValue);

                if (dgvSupplierRecord.Rows.Count > 0)
                    dgvSupplierRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            

            if (chBFilterByDate.Checked && cbSupCurr.Text == string.Empty)
            {
                dgvSupplierRecord.DataSource = clsExchangeDetails.GetAll((int)cbSupplier.SelectedValue, dtSupplierFrom.Value, dtSupplierTo.Value);
                if (dgvSupplierRecord.Rows.Count > 0)
                    dgvSupplierRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            else if (chBFilterByDate.Checked == false && cbSupCurr.Text != string.Empty)
            {
                dgvSupplierRecord.DataSource = clsExchangeDetails.GetAll((int)cbSupplier.SelectedValue,(int)cbSupCurr.SelectedValue);
                if (dgvSupplierRecord.Rows.Count > 0)
                    dgvSupplierRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
            else
            {
                dgvSupplierRecord.DataSource = clsExchangeDetails.GetAll((int)cbSupplier.SelectedValue, (int)cbSupCurr.SelectedValue,dtSupplierFrom.Value,dtSupplierTo.Value);
                if (dgvSupplierRecord.Rows.Count > 0)
                    dgvSupplierRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات لعرضها");

                return;
            }
           
        }

        public DataTable _LoadSupplierRecord1()
        {
            DataTable table = new DataTable();

            table.Columns.Add("رقمالسند", typeof(int));
            table.Columns.Add("المورد", typeof(string));
            table.Columns.Add("المبلغ", typeof(decimal));
            table.Columns.Add("العمله", typeof(string));
            table.Columns.Add("سعرالصرف", typeof(decimal));
            table.Columns.Add("التفاصيل", typeof(string));
            table.Columns.Add("التاريخ", typeof(DateTime));


            foreach (DataGridViewRow row in dgvSupplierRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["رقمالسند"] = row.Cells["رقم السند"].Value;
                    dataRow["المورد"] = row.Cells["المورد"].Value;
                    dataRow["المبلغ"] = row.Cells["المبلغ"].Value;
                    dataRow["العمله"] = row.Cells["العمله"].Value;
                    dataRow["سعرالصرف"] = row.Cells["سعر الصرف"].Value;
                    dataRow["التفاصيل"] = row.Cells["التفاصيل"].Value;
                    dataRow["التاريخ"] = row.Cells["التاريخ"].Value;

                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }
        public void GetRef(ref int lastid)
        {
            int year = DateTime.Now.Year - 2000;

            if (lastid > 9999)
            {

                lastid -= 9999;
                GetRef(ref lastid);
            }
            else
            {
                txtReceiptsNo.Text = ((int)billType).ToString() + year.ToString() + lastid.ToString("####0000");
            }



        }
        private void btnLoadCsutomerRecord_Click(object sender, EventArgs e)
        {
            _LoadSupplierRecord();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchangeDetails exchangeDetails = new frmExchangeDetails((int)dgvExchangeBills.CurrentRow.Cells[1].Value);
            exchangeDetails.ShowDialog();
            dgvExchangeBills.DataSource = clsExchangeBills.GetAllByRefNo((int)dgvExchangeBills.CurrentRow.Cells[1].Value);
        }

        private void DetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchangeDetails exchangeDetails = new frmExchangeDetails((int)dgvSupplierRecord.CurrentRow.Cells[1].Value);
            exchangeDetails.ShowDialog();
            _LoadSupplierRecord();

        }

        private void DeletetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف جميع السجلات التي تحمل الرقم " + dgvExchangeBills.CurrentRow.Cells[1].Value.ToString() + "?", "حذف فاتورة", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if (clsReceipts.Delete((int)dgvExchangeBills.CurrentRow.Cells[0].Value))
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

        
        private void btnPrintTopSell_Click(object sender, EventArgs e)
        {

            DataTable table = _LoadSupplierRecord1();
            BFMSRecord record = new BFMSRecord();
            record.LoadSupRecord (table);
            record.Show();

        }

        private DataTable _LoadExchangeBillsRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("RefNo", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Cur", typeof(string));
            

            foreach (DataGridViewRow row in dgvExchangeBills.Rows)
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

        private void btnPrintRecord_Click(object sender, EventArgs e)
        {
            DataTable table = _LoadExchangeBillsRecord();
            BFMSRecord record = new BFMSRecord();
            record.LoadExchangeBillsRecord(table);
            record.Show();

            
        }

        private void chBFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            if(dtSupplierFrom.Enabled && dtSupplierTo.Enabled)
            {
                dtSupplierFrom.Enabled = false;
                dtSupplierTo.Enabled = false;
                return;
            }
            dtSupplierFrom.Enabled = true;
            dtSupplierTo.Enabled = true;

        }

        private void chbFillterPay_CheckedChanged(object sender, EventArgs e)
        {
            if (dtFrom.Enabled && dtTo.Enabled)
            {
                dtFrom.Enabled = false;
                dtTo.Enabled = false;
                return;
            }
            dtFrom.Enabled = true;
            dtTo.Enabled = true;
        }
    }

}
