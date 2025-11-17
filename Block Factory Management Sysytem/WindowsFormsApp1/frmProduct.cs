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
    public partial class frmProduct : Form
    {
        private void _LoadProducts()
        {
            dgvProduct.DataSource = clsType.GetAllTypies();
            dgvProduct.Columns[0].Visible = false;
        }
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductModule product = new frmProductModule(-1);
            product.ShowDialog();

            _LoadProducts();


        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmProductModule productModule = new frmProductModule(Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value.ToString()));
            productModule.ShowDialog();
            _LoadProducts();

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            _LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = clsType.search(txtSearch.Text);
            if (dgvProduct.Rows.Count > 0)
                dgvProduct.Columns[0].Visible = false;

            if (txtSearch.Text == string.Empty)
                _LoadProducts();

        }

       
        private void تهيئةالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemSettings settings = new frmItemSettings((int)dgvProduct.CurrentRow.Cells[0].Value);
            settings.ShowDialog();
            _LoadProducts();

        }

        private void مخزونالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int stock =(clsStorage_stock.GetSum((int)dgvProduct.CurrentRow.Cells[0].Value)-
                       clsSale_Details.GetSumItemSales((int)dgvProduct.CurrentRow.Cells[0].Value));
            
            MessageBox.Show(""+ stock .ToString()+ "");
        }

      

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الصنف [" + dgvProduct.CurrentRow.Cells[1].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsType.Delete((int)dgvProduct.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("يوجد بيانات مرتبطة بهذا الصنف لايمكن الحذف");
                }
            }
            _LoadProducts();

        }
    }
}
