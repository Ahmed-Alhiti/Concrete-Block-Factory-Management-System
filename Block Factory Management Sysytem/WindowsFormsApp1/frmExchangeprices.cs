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
    public partial class frmExchangeprices : Form
    {
        public frmExchangeprices()
        {
            InitializeComponent();
        }
        
        private void _LoadData()
        {
            dgvExchangePrices.DataSource = clsExchangeprices.GetAll();
            if (dgvExchangePrices.Rows.Count > 0)
                dgvExchangePrices.Columns[0].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmExchangeprices_Module module = new frmExchangeprices_Module(-1);
            module.ShowDialog();
            _LoadData();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchangeprices_Module module = new frmExchangeprices_Module((int)dgvExchangePrices.CurrentRow.Cells[0].Value);
            module.ShowDialog();
            _LoadData();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsExchangeprices.Delete((int)dgvExchangePrices.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Deleted Succesfuly");
            }
            else
            {
                MessageBox.Show("يوجد بيانات مرتبطة بهذا السجل");
            }
            _LoadData();

        }

        private void frmExchangeprices_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
