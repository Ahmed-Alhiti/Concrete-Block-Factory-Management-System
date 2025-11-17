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
    public partial class frmPurchases : Form
    {
        private void _LoadData()
        {
            dgvPurchRecord.DataSource = clsPurchases.GetAllPurchases();
            if (dgvPurchRecord.Rows.Count != 0)
                dgvPurchRecord.Columns[0].Visible = false;
        }
         private void _LoadDailyData()
        {
            dgvPurchases.DataSource = clsPurchases.GetAllPurchases(DateTime.Now,DateTime.Now);
            if (dgvPurchases.Rows.Count != 0)
                dgvPurchases.Columns[0].Visible = false;
        }

        private void _FillcbSupplier()
        {
            cbSupplier.DataSource = clsSuppliers.GetAllSuppliers();
            cbSupplier.DisplayMember = "اسم المورد";
            cbSupplier.ValueMember = "Sup_ID";
            cbSupplier.SelectedValue = -1;
        }

        public frmPurchases()
        {
            InitializeComponent();
        }

        private void frmPurchases_Load(object sender, EventArgs e)
        {
            _LoadDailyData();
            _FillcbSupplier();

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((dtSupplierFrom.Enabled && dtSupplierTo.Enabled) == false)
            {
                dtSupplierFrom.Enabled = true;
                dtSupplierTo.Enabled = true;
            }
            else
            {
                dtSupplierFrom.Enabled = false;
                dtSupplierTo.Enabled = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (chbPurRecord.Checked)
            {
                dgvPurchRecord.DataSource = clsPurchases.GetAllPurchases(dtFrom.Value, dtTo.Value);
                if (dgvPurchRecord.Rows.Count != 0)
                    dgvPurchRecord.Columns[0].Visible = false;
                return;
            }

            _LoadData();

        }

        private void btnLoadSupplierRecord_Click(object sender, EventArgs e)
        {
            if (cbSupplier.Text == string.Empty)
            {
                MessageBox.Show("يرجى تحديد المورد اولا");
                cbSupplier.Focus();
                return;
            }
            if (chBFilterByDate.Checked)
            {
                dgvSupplierRecord.DataSource = clsPurchases.GetAllSupplierPurchases((int)cbSupplier.SelectedValue, dtSupplierFrom.Value,
                    dtSupplierTo.Value);
                dgvSupplierRecord.Columns[0].Visible = false;
            }
            else
            {
                dgvSupplierRecord.DataSource = clsPurchases.GetAllSupplierPurchases((int)cbSupplier.SelectedValue);
                if (dgvSupplierRecord.Rows.Count != 0)
                    dgvSupplierRecord.Columns[0].Visible = false;
                else
                {
                    MessageBox.Show("nothing");

                }
            }
        }

        private void EditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPurchasesModule purchasesModule = new frmPurchasesModule((int)dgvPurchRecord.CurrentRow.Cells[0].Value);
            purchasesModule.ShowDialog();
            _LoadData();
        }

        private void DeleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Purchas [" + dgvPurchRecord.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPurchases.Delete((int)dgvPurchRecord.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Purchas is not deleted");
                }
            }
            _LoadData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmPurchasesModule purchasesModule = new frmPurchasesModule(-1);
            purchasesModule.ShowDialog();
            _LoadDailyData();
        }

      

        private DataTable _LoadSupPurRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Sup_Name", typeof(string));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Unit", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Date", typeof(DateTime));
            


            foreach (DataGridViewRow row in dgvSupplierRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Sup_Name"] = row.Cells["المورد"].Value;
                    dataRow["Item"] = row.Cells["الصنف"].Value;
                    dataRow["Amount"] = row.Cells["الكمية"].Value;
                    dataRow["Unit"] = row.Cells["الوحدة"].Value;
                    dataRow["Price"] = row.Cells["السعر"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    
                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }
    
        private void btnPrintSupRecord_Click(object sender, EventArgs e)
        {
            if(dgvSupplierRecord.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات");
                return;
            }
            BFMSRecord record = new BFMSRecord();
            record.LoadSupPurRecord(_LoadSupPurRecord());
            record.ShowDialog();

        }
        private DataTable _LoadPurRecord()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Sup_Name", typeof(string));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("Unit", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Cur", typeof(string));


            foreach (DataGridViewRow row in dgvPurchRecord.Rows)
            {


                if (!row.IsNewRow)
                {
                    DataRow dataRow = table.NewRow();
                    dataRow["Sup_Name"] = row.Cells["المورد"].Value;
                    dataRow["Item"] = row.Cells["الصنف"].Value;
                    dataRow["Amount"] = row.Cells["الكمية"].Value;
                    dataRow["Unit"] = row.Cells["الوحدة"].Value;
                    dataRow["Price"] = row.Cells["السعر"].Value;
                    dataRow["Date"] = row.Cells["التاريخ"].Value;
                    dataRow["Cur"] = row.Cells["العملة"].Value;
                    table.Rows.Add(dataRow);
                }

            }

            return table;
        }

        private void btnPrintPurRecord_Click(object sender, EventArgs e)
        {
            if (dgvPurchRecord.Rows.Count == 0)
            {
                MessageBox.Show("لا يوجد بيانات");
                return;
            }
            BFMSRecord record = new BFMSRecord();
            string param = " سجل المشتريات من تاريخ  "+ dtFrom.Value.ToShortDateString() +"   الى تاريخ  "+ dtTo.Value.ToShortDateString()+"";
            record.LoadPurRecord(_LoadPurRecord(),param);
            record.ShowDialog();
        }

        private void chbPurRecord_CheckedChanged(object sender, EventArgs e)
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

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

            dgvPurchRecord.DataSource = clsPurchases.Search(txtSearch.Text);
            if (dgvPurchRecord.Rows.Count != 0)
                dgvPurchRecord.Columns[0].Visible = false;
            if (txtSearch.Text == string.Empty)
            {
                dgvPurchRecord.DataSource = null;
                dgvPurchRecord.Refresh();
            }
        }
    }
}
