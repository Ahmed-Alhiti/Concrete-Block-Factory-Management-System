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
    public partial class frmSales : Form
    {

        public enum enBillType { نقد = 1, آجل = 2, دين = 3 }
        public int lastid = clsSales.GetLastID();
        public enBillType billType;
        public frmSales()
        {
            InitializeComponent();
        }

        
        private void _Fillcbitem()
        {
            cbitem.DataSource = clsType.GetAllTypies();
            cbitem.DisplayMember = "اسم الصنف";
            cbitem.ValueMember = "Blo_ID";
            cbitem.SelectedValue = -1;
        }
        private void _FillcbChoosenitem()
        {
            cbChooseItem.DataSource = clsType.GetAllTypies();
            cbChooseItem.DisplayMember = "اسم الصنف";
            cbChooseItem.ValueMember = "Blo_ID";
            cbChooseItem.SelectedValue = -1;
        }
        private void _FillcbCustomerItem()
        {
            cbCusItem.DataSource = clsType.GetAllTypies();
            cbCusItem.DisplayMember = "اسم الصنف";
            cbCusItem.ValueMember = "Blo_ID";
            cbCusItem.SelectedValue = -1;
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

       
        public void GetRef(ref int lastid)
        {
            int year = DateTime.Now.Year - 2000;
            
            if(lastid > 9999)
            {
                
                lastid -= 9999;
                GetRef(ref lastid);
            }
            else
            {
                txtRefNo.Text = ((int)billType).ToString() + year.ToString() + lastid.ToString("####0000");
            }
            


        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            _FillcbCustomers();
            _FillcbCustomer();
            _Fillcbitem();
            _FillcbChoosenitem();
            _FillcbCustomerItem();
            cbBilltype.SelectedIndex = 0;
            cbPosted.SelectedIndex = 0;
            GetRef(ref lastid);
        }

        
        private void cbitem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbitem.Text == string.Empty)
                return;

            string seleted_string = cbitem.SelectedValue.ToString();
            if (int.TryParse(seleted_string, out int selectedint))
                txtPerPrice.Text = clsType.GetPrice(selectedint).ToString();
        }

        private void cbitem_TextChanged(object sender, EventArgs e)
        {
            if (cbitem.Text == string.Empty)
                txtPerPrice.Clear();

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTotalBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
           
            if(txtPerPrice.Text == string.Empty)
                return;

            if (txtQty.Text != string.Empty)
            {
                int num1 = int.Parse(txtQty.Text);
                int num2 = int.Parse(txtPerPrice.Text);
                int result = num1 * num2;

                txtTotal.Text = result.ToString();
            }
            else
            {
                txtTotal.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!dtFrom.Enabled && !dtTo.Enabled)
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

        private void chBFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (dtCustomerFrom.Enabled && dtCustomerTo.Enabled)
            {
                dtCustomerFrom.Enabled = false;
                dtCustomerTo.Enabled = false;
            }
            else
            {
                dtCustomerFrom.Enabled = true;
                dtCustomerTo.Enabled = true;
            }
        }

       
        private void _LoadCustomerRecord()
        {
            if (cbCustomer.Text == string.Empty)
            {
                MessageBox.Show("يرجى اختيار اسم الربون اولا");
                cbCustomer.Focus();
                return;

            }
           
            
            if (chBFilterByDate.Checked && cbCusItem.Text == string.Empty)
            {
                dgvCustomerRecord.DataSource = clsSales.GetCustomerUnPostedSales((int)cbCustomer.SelectedValue, dtCustomerFrom.Value, dtCustomerTo.Value);
                txtCustomrQty.Text = clsSales.GetSumCustomerSales((int)cbCustomer.SelectedValue, dtCustomerFrom.Value, dtCustomerTo.Value).ToString();

                if (dgvCustomerRecord.Rows.Count > 0)
                    dgvCustomerRecord.Columns[0].Visible = false;
                return;
            }  
            else if (!chBFilterByDate.Checked && cbCusItem.Text == string.Empty)
            {
                dgvCustomerRecord.DataSource = clsSales.GetCustomerUnPostedSales((int)cbCustomer.SelectedValue);
                txtCustomrQty.Text = clsSales.GetSumCustomerSales((int)cbCustomer.SelectedValue).ToString();
                if (dgvCustomerRecord.Rows.Count > 0)
                        dgvCustomerRecord.Columns[0].Visible = false;
                return;
            }
            else if(chBFilterByDate.Checked && cbCusItem.Text != string.Empty)
            {
                dgvCustomerRecord.DataSource = clsSale_Details.GetAllCustomerItemSales((int)cbCustomer.SelectedValue, (int)cbCusItem.SelectedValue, dtCustomerFrom.Value, dtCustomerTo.Value);
                txtCustomrQty.Text = clsSale_Details.GetAllSumCustomerItemSales((int)cbCustomer.SelectedValue,(int)cbCusItem.SelectedValue , dtCustomerFrom.Value, dtCustomerTo.Value).ToString();
                return;
            }
            else if(!chBFilterByDate.Checked && cbCusItem.Text != string.Empty)
            {
                dgvCustomerRecord.DataSource = clsSale_Details.GetAllCustomerItemSales((int)cbCustomer.SelectedValue, (int)cbCusItem.SelectedValue);
                txtCustomrQty.Text = clsSale_Details.GetAllSumCustomerItemSales((int)cbCustomer.SelectedValue, (int)cbCusItem.SelectedValue).ToString();
                return;
            }
                
            
           
        }
        private void btnLoadCsutomerRecord_Click(object sender, EventArgs e)
        {
            _LoadCustomerRecord();
        }
        private decimal _CalculateSum(DataGridView dataGrid, string cellname)
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                sum += decimal.Parse(row.Cells[cellname].Value.ToString());
            }
            return sum;
        }
        private void HideId()
        {
            if (dgvSalesHistory.Rows.Count > 0)
                dgvSalesHistory.Columns[0].Visible = false;
        }
        private void _LoadSaleHistory()
        {
            if (!string.IsNullOrEmpty(cbPosted.Text))
            {
                if(cbPosted.Text == "مرحل")
                {
                    btnPost.Visible =  false;
                    if (chbFillterSales.Checked)
                    {
                        dgvSalesHistory.DataSource = clsSales.GetAllPostedSales(dtFrom.Value, dtTo.Value);
                    }
                    else
                    {
                        dgvSalesHistory.DataSource = clsSales.GetAllPostedSales();
                    }
                    HideId();
                    txtSumAllSales.Text = _CalculateSum(dgvSalesHistory, "الكمية").ToString();
                    return;
                }
                else if (cbPosted.Text == "غير مرحل")
                {
                    
                    if (chbFillterSales.Checked)
                    {
                        dgvSalesHistory.DataSource = clsSales.GetAllUnPostedSales(dtFrom.Value, dtTo.Value);
                    }
                    else
                    {
                        dgvSalesHistory.DataSource = clsSales.GetAllUnPostedSales();
                    }
                    HideId();
                    btnPost.Visible = (dgvSalesHistory.Rows.Count>0)? true : false;
                    txtSumAllSales.Text = _CalculateSum(dgvSalesHistory, "الكمية").ToString();
                    return;
                }

                if (chbFillterSales.Checked)
                {
                    dgvSalesHistory.DataSource = clsSales.GetAllSales(dtFrom.Value, dtTo.Value);
                }
                else
                {
                    dgvSalesHistory.DataSource = clsSales.GetAllSales();
                }
                HideId();
                txtSumAllSales.Text = _CalculateSum(dgvSalesHistory, "الكمية").ToString();
                btnPost.Visible = false;
            }

            if (chbFillterSales.Checked)
            {
                dgvSalesHistory.DataSource = clsSales.GetAllSales(dtFrom.Value, dtTo.Value);
            }
            else
            {
                dgvSalesHistory.DataSource = clsSales.GetAllSales();
            }



        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            _LoadSaleHistory();
        }


        private void _LoadSaleBill()
        {
            dgvSalesHistory.DataSource = clsSales.GetAllPostedSales();
            if (dgvSalesHistory.Rows.Count > 0)
                dgvSalesHistory.Columns[0].Visible = false;
        }
     

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemModule saleModule = new frmItemModule((int)dgvSalesHistory.CurrentRow.Cells[1].Value);
            saleModule.ShowDialog();
            dgvSalesHistory.DataSource = clsSales.GetAllSales_BySaleNumber((int)dgvSalesHistory.CurrentRow.Cells[1].Value);
        }

        private void EditCustOrCurStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditCustomerOrCurreinse frmEdit = new frmEditCustomerOrCurreinse((int)dgvSalesHistory.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();
            dgvSalesBill.DataSource = clsSales.GetAllSales_BySaleNumber((int)dgvSalesHistory.CurrentRow.Cells[1].Value);
        }

        private void txtsearchForDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }





        private DataTable _LoadBillSale()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("ItemPrice", typeof(int));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Total", typeof(float));




            foreach (DataGridViewRow row in dgvSalesBill.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Item"] = row.Cells["Block_name"].Value;
                    dataRow["ItemPrice"] = row.Cells["ItemPrice"].Value;
                    dataRow["Amount"] = row.Cells["Block_amount"].Value;
                    dataRow["Total"] = row.Cells["total"].Value;
                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }

        private void btnEntry_Click_1(object sender, EventArgs e)
        {
            clsSales sales = new clsSales();
            sales._Block_Amount = int.Parse(txtTotalQty.Text);
            sales._Craete_on = dtSdate.Value;
            sales._Create_By = clsCurrentUser.id;
            sales._Cus_ID = (int)cbCustomers.SelectedValue;
            sales._Detailes = txtDetails.Text;
            sales._Sale_Number = int.Parse(txtRefNo.Text);
            sales._Total_Price = decimal.Parse(txtTotalBill.Text);
            //sales._Sal_ID
            if (sales.Save())
                lastid = clsSales.GetLastID();
            else
            {
                MessageBox.Show("Somthing is wrong");
                return;
            }

            foreach (DataGridViewRow row in dgvSalesBill.Rows)
            {
                clsSale_Details details = new clsSale_Details();
                details._Sale_Number = int.Parse(row.Cells["Sale_number"].Value.ToString());
                details._Block_ID = int.Parse(row.Cells["Block_id"].Value.ToString());
                details._Block_Amount = short.Parse(row.Cells["Block_amount"].Value.ToString());
                details._Total_Price = float.Parse(row.Cells["total"].Value.ToString());

                if (!details.Save())
                {
                    MessageBox.Show("something went wrong");
                    return;
                }

            }



            MessageBox.Show("تم حفظ الفاتورة بنجاح");

            frmSaleBill saleBill = new frmSaleBill();
            saleBill.LoadSaleBill(_LoadBillSale(), dtSdate.Value.ToShortDateString(), txtTotalQty.Text, txtTotalBill.Text, clsUsers.FindUserNameByID(clsCurrentUser.id),
                cbBilltype.Text, cbCustomers.Text, txtRefNo.Text, (string.IsNullOrEmpty(txtDetails.Text))? "ما من تفاصيل" : txtDetails.Text);
            saleBill.ShowDialog();

            dgvSalesBill.Rows.Clear();
            cbBilltype.Enabled = true;
            cbCustomers.Enabled = true;
            cbBilltype.Enabled = true;

            cbBilltype.SelectedValue = -1;
            cbCustomers.SelectedValue = -1;
            cbitem.SelectedValue = -1;
            cbBilltype.SelectedIndex = 0;
            txtDetails.Clear();
            txtQty.Clear();
            txtTotal.Clear();
            txtTotalBill.Clear();
            txtTotalQty.Clear();

            GetRef(ref lastid);
            btnEntry.Enabled = false;
            btnAddItem.Enabled = true;
        }

       

        private void cbBilltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            billType = (enBillType)cbBilltype.SelectedIndex + 1;
            GetRef(ref lastid);
        }

        private void cbBilltype_TextChanged(object sender, EventArgs e)
        {
            if(cbBilltype.Text==string.Empty)
                txtRefNo.Clear();
        }

        private int calculateTotalBill()
        {
            int total = 0;
            foreach(DataGridViewRow row in dgvSalesBill.Rows)
            {

                if(int.TryParse(row.Cells["total"].Value.ToString(),out int price))
                total += price;

            }
            return total;
        }
        private int calculateTotalQty()
        {
            int total = 0;
            foreach(DataGridViewRow row in dgvSalesBill.Rows)
            {

                //if(int.TryParse(row.Cells["Block_amount"].Value.ToString(),out int price))
                total += int.Parse(row.Cells["Block_amount"].Value.ToString());

            }
            return total;
        }

        
        
        //private bool Validate()
        //{
        //    short block_amount = short.Parse(txtQty.Text);
        //    int stock_Amount = clsStorage_stock.GetSum((int)cbitem.SelectedValue) - clsSale_Details.GetSumItemSales((int)cbitem.SelectedValue);
        //    if(block_amount > stock_Amount)
        //    {
        //        MessageBox.Show("الكمية المتبقيه في المخزون " + stock_Amount.ToString() + " ");
        //        return false;
        //    }

        //    foreach (DataGridViewRow row in dgvSalesBill.Rows)
        //    {
        //        int Amount = 0;
        //        if ((int)row.Cells["Block_id"].Value == (int)cbitem.SelectedValue)
        //        {
        //            Amount += int.Parse(row.Cells[3].Value.ToString());

        //            stock_Amount -= Amount;
        //            if (Amount > stock_Amount)
        //            {
        //                MessageBox.Show("الكمية المتبقيه في المخزون " + stock_Amount.ToString() + " ");
        //                return false;
        //            }
        //        }
        //    }
        //}

         


        private bool _Validation()
        {
            int Orderdblock_Amount = int.Parse(txtQty.Text);
            int stock_Amount = clsStorage_stock.GetSum((int)cbitem.SelectedValue) - clsSale_Details.GetSumItemSales((int)cbitem.SelectedValue);

            if (dgvSalesBill.Rows.Count == 0)
            {
                if(Orderdblock_Amount > stock_Amount)
                {
                    MessageBox.Show("الكمية المتبقية في المخزون = " + stock_Amount.ToString() + "");
                    return false;
                }
            }
            else
            {
                
                foreach(DataGridViewRow row in dgvSalesBill.Rows)
                {
                    if(int.Parse(row.Cells["Block_id"].Value.ToString()) == (int)cbitem.SelectedValue)
                    {
                        Orderdblock_Amount += int.Parse(row.Cells["Block_amount"].Value.ToString());
                        if(Orderdblock_Amount > stock_Amount)
                        {
                            MessageBox.Show("الكمية المطلوبه من الصنف " + cbitem.Text + " = " + Orderdblock_Amount.ToString() +  " , \n  " +
                                "الكمية المتبقية في المخزون = " + stock_Amount.ToString() + "", "مخزون غير كافي",  MessageBoxButtons.OKCancel,MessageBoxIcon.Stop );
                            return false;
                        }
                    }
                    
                }

            }
            return true;

        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(cbitem.Text == string.Empty || txtRefNo.Text == string.Empty || txtQty.Text==string.Empty)
            {
                MessageBox.Show("يوجد نقص في البيانات");
                return;
            }

            if (_Validation())
            {
                int sal_num = int.Parse(txtRefNo.Text);
                string Block_Name = cbitem.Text;
                int block_id = (int)cbitem.SelectedValue;
                short block_amount = short.Parse(txtQty.Text);
                float total = float.Parse(txtTotal.Text);
                short ItemPrice = short.Parse(txtPerPrice.Text);

                dgvSalesBill.Rows.Add(sal_num, Block_Name, block_id,ItemPrice,block_amount, total);
                txtTotalBill.Text = calculateTotalBill().ToString();
                txtTotalQty.Text = calculateTotalQty().ToString();
            }
            else
            {
                return;
            }



            if (MessageBox.Show("هل تريد اضافة صنف جديد بنفس رقم الفاتوره " + txtRefNo.Text + "?", "اضافة صنف بنفس رقم الفاتورة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                
                txtPerPrice.Clear();
                txtQty.Clear();
                txtTotal.Clear();
                //cbCurrencies.SelectedValue = -1;
                //cbCustomers.SelectedValue = -1;
                cbitem.SelectedValue = -1;
                cbitem.Focus();
                cbBilltype.Enabled = false;
                cbCustomers.Enabled = false;
                

                return;
            }
            else
            {
                btnAddItem.Enabled = false;
                btnEntry.Enabled = true;
            }
            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                dgvSalesHistory.DataSource = clsSales.Search(txtSearch.Text);
                if (dgvSalesHistory.Rows.Count > 0)
                    dgvSalesHistory.Columns[0].Visible = false;
            }
            else
            {

                ((DataTable)dgvSalesHistory.DataSource)?.Clear();
            }

            
        }

        private void DeletetoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف جميع السجلات التي تحمل الرقم " + dgvSalesHistory.CurrentRow.Cells[1].Value.ToString() + "?", "حذف فاتورة", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                if (clsSales.Delete((int)dgvSalesHistory.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم الحذف بنجاح");
                    _LoadSaleBill();
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف ");
                }
            }
        }

        private void BillDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvCustomerRecord.Columns[0].Visible)
            {
                frmItemModule saleModule1 = new frmItemModule((int)dgvCustomerRecord.CurrentRow.Cells[0].Value);
                saleModule1.ShowDialog();
                _LoadCustomerRecord();
                return;
            }
            frmItemModule saleModule = new frmItemModule((int)dgvCustomerRecord.CurrentRow.Cells[1].Value);
            saleModule.ShowDialog();
            dgvCustomerRecord.DataSource = clsSales.GetAllSales_BySaleNumber((int)dgvCustomerRecord.CurrentRow.Cells[1].Value);
        }



        private DataTable _LoadSaleHistRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("RefNo", typeof(int));
            table.Columns.Add("Cus_Name", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Total", typeof(decimal));
            table.Columns.Add("Details", typeof(string));


            foreach (DataGridViewRow row in dgvSalesHistory.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["RefNo"] = row.Cells["رقم الفاتورة"].Value;
                    dataRow["Cus_Name"] = row.Cells["اسم الزبون"].Value;
                    dataRow["Amount"] = row.Cells["الكمية"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    dataRow["Total"] = row.Cells["الاجمالي"].Value;
                    dataRow["Details"] = row.Cells["التفاصيل"].Value;
                    

                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }
        private DataTable _LoadCustomerSaleHistRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("RefNo", typeof(int));
            table.Columns.Add("Cus_Name", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Total", typeof(decimal));
            table.Columns.Add("Details", typeof(string));


            foreach (DataGridViewRow row in dgvCustomerRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["RefNo"] = row.Cells["رقم الفاتورة"].Value;
                    dataRow["Cus_Name"] = row.Cells["اسم الزبون"].Value;
                    dataRow["Amount"] = row.Cells["الكمية"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    dataRow["Total"] = row.Cells["الاجمالي"].Value;
                    dataRow["Details"] = row.Cells["التفاصيل"].Value;
                    

                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }
         private DataTable _LoadCustomerItemSaleHistRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Sale_number", typeof(int));
            table.Columns.Add("Customer_Name", typeof(string));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("TotalPrice", typeof(decimal));
            table.Columns.Add("ItemPrice", typeof(int));


            foreach (DataGridViewRow row in dgvCustomerRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Sale_number"] = row.Cells["رقم الفاتورة"].Value;
                    dataRow["Customer_Name"] = row.Cells["اسم الزبون"].Value;
                    dataRow["Item"] = row.Cells["الصنف"].Value;
                    dataRow["Amount"] = row.Cells["الكمية"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    dataRow["TotalPrice"] = row.Cells["الاجمالي"].Value;
                    dataRow["ItemPrice"] = row.Cells["سعر الحبه"].Value;
                    

                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }

        private void btnSalesReceipts_Click(object sender, EventArgs e)
        {
            if(dgvSalesHistory.Rows.Count == 0)
            {
                MessageBox.Show("no data");
                return;
            }
            BFMSRecord record = new BFMSRecord();
            string param;

            if (chbFillterSales.Checked)
                param = " سجل المبيعات من تاريخ  " + dtFrom.Value.ToShortDateString() + "   الى تاريخ  " + dtTo.Value.ToShortDateString() + "";
            else
                param = "كل السجل";

            record.LoadSalesRecord(_LoadSaleHistRecord(), param, txtSumAllSales.Text);
            record.ShowDialog();

        }

        private void btnPrintCustomerRecord_Click(object sender, EventArgs e)
        {
            if (dgvCustomerRecord.Rows.Count == 0)
            {
                MessageBox.Show("no data");
                return;
            }

            BFMSRecord record = new BFMSRecord();
            if(cbCusItem.Text == string.Empty)
            {
                string param;
                if (chBFilterByDate.Checked)
                    param = " سجل المبيعات من تاريخ  " + dtCustomerFrom.Value.ToShortDateString() + "   الى تاريخ  " + dtCustomerTo.Value.ToShortDateString() + "";
                else
                    param = "كل السجل";

                record.LoadCustomerSalesRecord(_LoadCustomerSaleHistRecord(), param);
            }
            else
            {
                string param;
                if (chBFilterByDate.Checked)
                    param = " سجل المبيعات من تاريخ  " + dtCustomerFrom.Value.ToShortDateString() + "   الى تاريخ  " + dtCustomerTo.Value.ToShortDateString() + "";
                else
                    param = "كل السجل";

                record.LoadCustomerItemSalesRecord(_LoadCustomerItemSaleHistRecord(), param,txtCustomrQty.Text);
            }
            
            record.ShowDialog();

        }

        private void chbItemFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (dtItemFrom.Enabled )
            {
                dtItemFrom.Enabled = false;
                dtItemTo.Enabled = false;
                return;
            }
            
                dtItemFrom.Enabled = true;
                dtItemTo.Enabled = true;
        }

        private void btnLoadItemRecord_Click(object sender, EventArgs e)
        {
            if(cbChooseItem.Text == string.Empty)
            {
                MessageBox.Show("اختار الصنف اولا");
                cbChooseItem.Focus();

                return;
            }

            if (chbItemFilter.Checked)
            {
                dgvItemRecord.DataSource = clsSale_Details.GetAllItemSales((int)cbChooseItem.SelectedValue, dtItemFrom.Value, dtItemTo.Value);
                txtItemQty.Text = clsSale_Details.GetSumItemSales((int)cbChooseItem.SelectedValue, dtItemFrom.Value, dtItemTo.Value).ToString();

                if (dgvItemRecord.Rows.Count > 0)
                    dgvItemRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لا يوجد بيانات");
                return;
            }

            dgvItemRecord.DataSource= clsSale_Details.GetAllItemSales((int)cbChooseItem.SelectedValue);
            txtItemQty.Text = clsSale_Details.GetSumItemSales((int)cbChooseItem.SelectedValue).ToString();
            if (dgvItemRecord.Rows.Count > 0)
                dgvItemRecord.Columns[0].Visible = false;
            else
                MessageBox.Show("لا يوجد بيانات");
            

        }

        private DataTable _LoadItemSaleRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Sale_no", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("ItemPrice", typeof(decimal));
            table.Columns.Add("TotalPrice", typeof(decimal));
            table.Columns.Add("Date", typeof(DateTime));


            foreach (DataGridViewRow row in dgvItemRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Sale_no"] = row.Cells["رقم الفاتوره"].Value;
                    dataRow["Item"] = row.Cells["الصنف"].Value;
                    dataRow["Amount"] = row.Cells["الكمية"].Value;
                    dataRow["ItemPrice"] = row.Cells["سعر الصنف"].Value;
                    dataRow["TotalPrice"] = row.Cells["الاجمالي"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }


        private void btnPrintItemRecord_Click(object sender, EventArgs e)
        {
            if(dgvItemRecord.Rows.Count == 0)
            {
                MessageBox.Show("no data");
                return;
            }

            string param = "";

            if (chbItemFilter.Checked)
                param = " سجل المبيعات من تاريخ  " + dtItemFrom.Value.ToShortDateString() + "   الى تاريخ  " + dtItemTo.Value.ToShortDateString() + "";
            else
                param = "كل السجل";
            BFMSRecord record = new BFMSRecord();
            record.LoadItemSalesRecord(_LoadItemSaleRecord(), param,txtItemQty.Text);
            record.ShowDialog();


        }

       

        private void cbBilltype_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbBilltype.Text))
            {
                errorProvider1.SetError(cbBilltype, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbBilltype, "");
            }
        }

        private void cbitem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbitem.Text))
            {
                errorProvider1.SetError(cbitem, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbitem, "");
            }
        }

        private void cbCustomers_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbCustomers.Text))
            {
                errorProvider1.SetError(cbCustomers, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbCustomers, "");
            }
        }

        private void txtQty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                errorProvider1.SetError(txtQty, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtQty, "");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void cbPosted_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnPost.Visible = (cbPosted.SelectedIndex == 0 || cbPosted.SelectedIndex == 2) ? false : true;
        }

        private void Post_Click(object sender, EventArgs e)
        {
            if (clsSales.PostingBill((int)dgvSalesHistory.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("تم الترحيل بنجاح");
            }
            btnLoad.PerformClick();
        }

        private void UnPost_Click(object sender, EventArgs e)
        {
            if (clsSales.UnPostingBill((int)dgvSalesHistory.CurrentRow.Cells[1].Value))
            {
                MessageBox.Show("تم الغاء الترحيل بنجاح");
            }
            btnLoad.PerformClick();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvSalesHistory.Rows.Count; i++)
            {
                DataGridViewRow row = dgvSalesHistory.Rows[i];
                if (!row.IsNewRow)
                {
                    if (int.TryParse(row.Cells[1].Value.ToString(), out int sal_num))
                    {
                        if (!clsSales.PostingBill(sal_num))
                        {
                            MessageBox.Show("Error");
                            return;
                        }
                    }
                }
               
            }
            MessageBox.Show("تم الترحيل بنجاح");
            btnLoad.PerformClick();


            //foreach(DataGridViewRow row in dgvSalesHistory.Rows)
            //{
            //    if
            //    if (clsSales.PostingBill(row.Cells[1].Value))
            //    {

            //    }

        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if(clsSales.CheckPost((int)dgvSalesHistory.CurrentRow.Cells[1].Value))
            {
                contextMenuStrip1.Items["Post"].Enabled = false;
                contextMenuStrip1.Items["edit"].Enabled = false;
                contextMenuStrip1.Items["EditCustOrCur"].Enabled = false;
                contextMenuStrip1.Items["Delete"].Enabled = false;
                contextMenuStrip1.Items["UnPost"].Enabled = true;
                return;
            }
            contextMenuStrip1.Items["UnPost"].Enabled = false;
            contextMenuStrip1.Items["Post"].Enabled = true;
            contextMenuStrip1.Items["edit"].Enabled = true;
            contextMenuStrip1.Items["EditCustOrCur"].Enabled = true;
            contextMenuStrip1.Items["Delete"].Enabled = true;
        }
    }
}
