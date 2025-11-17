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
    public partial class frmProduction : Form
    {
        private void _LoadProduction()
        {
            dgvDailyProduction.DataSource = clsStorage_stock.GetAllProduction(dtSdate.Value);
            if(dgvDailyProduction.Rows.Count>0)
                 dgvDailyProduction.Columns[0].Visible = false;
        }
       

        private void _FillcbItems()
        {
            cbitems.DataSource = clsType.GetAllTypies();
            cbitems.DisplayMember = "اسم الصنف";
            cbitems.ValueMember = "Blo_ID";
            cbitems.SelectedValue = -1;
        }
        private void _FillcbItemStock()
        {
            cbItemStock.DataSource = clsType.GetAllTypies();
            cbItemStock.DisplayMember = "اسم الصنف";
            cbItemStock.ValueMember = "Blo_ID";
            cbItemStock.SelectedValue = -1;
        }

        private void _FillcbItem()
        {
            cbItem.DataSource = clsType.GetAllTypies();
            cbItem.DisplayMember = "اسم الصنف";
            cbItem.ValueMember = "Blo_ID";
            cbItem.SelectedValue = -1;
        }

        public frmProduction()
        {
            InitializeComponent();
        }

        private void _FillallCBs()
        {
            _LoadProduction();
            _FillcbItem();
            _FillcbItems();
            _FillcbItemStock();

        }
        private void frmProduction_Load(object sender, EventArgs e)
        {
            _FillallCBs();

        }

       

        

        private void نعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductionModule productionModule = new frmProductionModule(Convert.ToInt32(dgvProductionHistory.CurrentRow.Cells[0].Value));
            productionModule.ShowDialog();
            _LoadProduction();
            _LoadProductionHist();

        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete [" + dgvProductionHistory.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsStorage_stock.Delete((int)dgvDailyProduction.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Deleted Successfuly");
                else
                    MessageBox.Show("not Deleted");
            }
            _LoadProduction();
            _LoadProductionHist();
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            clsStorage_stock stock = new clsStorage_stock();
            stock._Amount = short.Parse(txtQty.Text);
            stock._Block_id = (int)cbitems.SelectedValue;
            stock._Date = dtSdate.Value;

            if (stock.Save())
                MessageBox.Show("تم الحفظ");
            else
                MessageBox.Show("لم يتم الحفظ");

            _LoadProduction();

        }

      
        private void _LoadItemRecord()
        {
            if(cbItem.Text == string.Empty)
            {
                MessageBox.Show("اختار صنف اولا");
                cbItem.Focus();
                return;
            }

            if (chBFilterByDate.Checked)
            {
                dgvItemRecord.DataSource = clsStorage_stock.GetAllProduction((int)cbItem.SelectedValue, dtItemFrom.Value, dtItemTo.Value);
                txtTotalQty.Text = clsStorage_stock.GetSum((int)cbItem.SelectedValue, dtItemFrom.Value, dtItemTo.Value).ToString();

                if (dgvItemRecord.Rows.Count > 0)
                    dgvItemRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لايوجد بيانات لعرضها");

                return;
            }
            else
            {
                dgvItemRecord.DataSource = clsStorage_stock.GetAllProduction((int)cbItem.SelectedValue);
                txtTotalQty.Text = clsStorage_stock.GetSum((int)cbItem.SelectedValue).ToString();
                if (dgvItemRecord.Rows.Count > 0)
                    dgvItemRecord.Columns[0].Visible = false;
                else
                    MessageBox.Show("لايوجد بيانات لعرضها");

                return;
            }


        }
        private void btnLoaditemProd_Click(object sender, EventArgs e)
        {
            _LoadItemRecord();

        }

        private void chBFilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (dtItemFrom.Enabled)
            {
                dtItemFrom.Enabled = false;
                dtItemTo.Enabled = false;
                return;
            }
            dtItemFrom.Enabled = true;
            dtItemTo.Enabled = true;
            
        }

        private void chbFillterSales_CheckedChanged(object sender, EventArgs e)
        {
            if (dtFrom.Enabled)
            {
                dtFrom.Enabled = false;
                dtTo.Enabled = false;
                return;
            }
            dtFrom.Enabled = true;
            dtTo.Enabled = true;

        }

        private void _LoadProductionHist()
        {
            if (chbFillter.Checked)
            {
                dgvProductionHistory.DataSource = clsStorage_stock.GetAllProduction(dtFrom.Value, dtTo.Value);
                txtTotal.Text = clsStorage_stock.GetSum(dtFrom.Value, dtTo.Value).ToString();

                if (dgvProductionHistory.Rows.Count > 0)
                    dgvProductionHistory.Columns[0].Visible = false;
                else
                    MessageBox.Show("لايوجد بيانات لعرضها");

                return;
            }

            dgvProductionHistory.DataSource = clsStorage_stock.GetAllProduction();
            txtTotal.Text = clsStorage_stock.GetSum().ToString();
            if (dgvProductionHistory.Rows.Count > 0)
                dgvProductionHistory.Columns[0].Visible = false;
            else
                MessageBox.Show("لايوجد بيانات لعرضها");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            _LoadProductionHist();
        }

        private DataTable _LoadItemProductionRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            


            foreach (DataGridViewRow row in dgvItemRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Item"] = row.Cells["الصنف المنتج"].Value;
                    dataRow["Size"] = row.Cells["المقاس"].Value;
                    dataRow["Qty"] = row.Cells["الكمية"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }
        private DataTable _LoadProductionRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Size", typeof(int));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("Date", typeof(DateTime));
            


            foreach (DataGridViewRow row in dgvProductionHistory.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Item"] = row.Cells["الصنف المنتج"].Value;
                    dataRow["Size"] = row.Cells["المقاس"].Value;
                    dataRow["Qty"] = row.Cells["الكمية"].Value;
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
                MessageBox.Show("لايوجد بيانات");
                return;
            }

            string param = "";

            if (chBFilterByDate.Checked)
                param = " سجل الانتاج من تاريخ  " + dtItemFrom.Value.ToShortDateString() + "   الى تاريخ  " + dtItemTo.Value.ToShortDateString() + "";
            else
                param = "كل السجل";

            string Qty = "الكمية المنتجة : " + txtTotalQty.Text + "";


            BFMSRecord record = new BFMSRecord();
            record.LoadItemProductionRecord(_LoadItemProductionRecord(), param,Qty);
            record.ShowDialog();


        }

        private void btnPrintSalesHist_Click(object sender, EventArgs e)
        {
            if (dgvProductionHistory.Rows.Count == 0)
            {
                MessageBox.Show("لايوجد بيانات");
                return;
            }

            string param = "";

            if (chbFillter.Checked)
                param = " سجل الانتاج من تاريخ  " + dtFrom.Value.ToShortDateString() + "   الى تاريخ  " + dtTo.Value.ToShortDateString() + "";
            else
                param = "كل السجل";
            string Qty = "الكمية المنتجة : " + txtTotal.Text + "";
            BFMSRecord record = new BFMSRecord();
            record.LoadProductionHist(_LoadProductionRecord(), param,Qty);
            record.ShowDialog();

        }

        private void _LoadItemStock()
        {
            if(cbItemStock.Text == string.Empty)
            {
                MessageBox.Show("يرجى تحديد الصنف اولا");
                return;
            }
            if (cbFilterItemStock.Checked)
            {
                dgvItemStock.DataSource = clsStorage_stock.GetAllProduction((int)cbItemStock.SelectedValue, dtItemStockFrom.Value, dtItemStockTo.Value);
                dgvItemSales.DataSource = clsSale_Details.GetAllItemSales((int)cbItemStock.SelectedValue,dtItemStockFrom.Value,dtItemStockTo.Value);
                if (dgvItemStock.Rows.Count > 0)
                {
                    dgvItemStock.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("لا يوجد انتاج لهذا الصنف");
                }
                if (dgvItemSales.Rows.Count > 0)
                {
                    dgvItemStock.Columns[0].Visible = false;
                }
                else
                {
                    MessageBox.Show("لا يوجد مبيعات لهذا الصنف");
                }
                txtItemProud.Text = clsStorage_stock.GetSum((int)cbItemStock.SelectedValue, dtItemStockFrom.Value, dtItemStockTo.Value).ToString();
                txtItemSales.Text = clsSale_Details.GetSumItemSales((int)cbItemStock.SelectedValue, dtItemStockFrom.Value, dtItemStockTo.Value).ToString();
                
                return;
                
            }

            dgvItemStock.DataSource = clsStorage_stock.GetAllProduction((int)cbItemStock.SelectedValue);
            dgvItemSales.DataSource = clsSale_Details.GetAllItemSales((int)cbItemStock.SelectedValue);

            if (dgvItemStock.Rows.Count > 0)
            {
                dgvItemStock.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("لا يوجد انتاج لهذا الصنف");
            }
            if (dgvItemSales.Rows.Count > 0)
            {
                dgvItemStock.Columns[0].Visible = false;
            }
            else
            {
                MessageBox.Show("لا يوجد مبيعات لهذا الصنف");
            }
            txtItemProud.Text = clsStorage_stock.GetSum((int)cbItemStock.SelectedValue).ToString();
            txtItemSales.Text = clsSale_Details.GetSumItemSales((int)cbItemStock.SelectedValue).ToString();
            
        }
        private void btnLoadItemStock_Click(object sender, EventArgs e)
        {

            _LoadItemStock();

           

        }

        private void cbFilterItemStock_CheckedChanged(object sender, EventArgs e)
        {
            if (dtItemStockFrom.Enabled)
            {
                dtItemStockFrom.Enabled = false;
                dtItemStockTo.Enabled = false;
                return;
            }
            dtItemStockFrom.Enabled = true;
            dtItemStockTo.Enabled = true;

        }

        private void ItemStock_Click(object sender, EventArgs e)
        {
            if(dgvItemStock.Rows.Count > 0 )
            {
                int stock = (clsStorage_stock.GetSum((int)cbItemStock.SelectedValue) - clsSale_Details.GetSumItemSales((int)cbItemStock.SelectedValue));
                MessageBox.Show("" + stock.ToString() + "");
            }
            
        }

        private void cbitems_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbitems.Text))
            {
                errorProvider1.SetError(cbitems, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbitems, "");
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
    }
}
