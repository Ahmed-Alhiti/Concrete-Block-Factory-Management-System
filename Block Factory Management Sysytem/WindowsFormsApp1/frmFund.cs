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
    public partial class frmFund : Form
    {
        public frmFund()
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            dgvFunds.DataSource = clsFunds.GetAllFunds();
            if(dgvFunds.Rows.Count > 0)
            {
                dgvFunds.Columns[0].Visible = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmFundsModule module = new frmFundsModule(-1);
            module.ShowDialog();
            _LoadData();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFundsModule module = new frmFundsModule((int)dgvFunds.CurrentRow.Cells[0].Value);
            module.ShowDialog();
            _LoadData();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFunds.Rows.Count == 0)
                return;

            if(MessageBox.Show("هل تريد حذف "+ dgvFunds.CurrentRow.Cells[1].Value.ToString() + "؟","حذف صندوف",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                if (clsFunds.Delete((int)dgvFunds.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم الحذف");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                
            }
            _LoadData();

        }

        private void frmFund_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
