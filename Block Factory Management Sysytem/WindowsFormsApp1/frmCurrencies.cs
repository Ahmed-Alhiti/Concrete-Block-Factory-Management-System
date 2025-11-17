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
    public partial class frmCurrencies : Form
    {
        private void _LoadFunds()
        {
            dgvCurrencies.DataSource = clsCurrencies.GetAll();
            dgvCurrencies.Columns[0].Visible = false;
        }
        public frmCurrencies()
        {
            InitializeComponent();
        }

        private void frmFunds_Load(object sender, EventArgs e)
        {
            _LoadFunds();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCurrenciesmodule fundModule = new frmCurrenciesmodule(-1);
            fundModule.ShowDialog();
            _LoadFunds();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrenciesmodule fundModule = new frmCurrenciesmodule((int)dgvCurrencies.CurrentRow.Cells[0].Value);
            fundModule.ShowDialog();
            _LoadFunds();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Fund [" + dgvCurrencies.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsCurrencies.Delete((int)dgvCurrencies.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Fund is not deleted");
                }
            }
            _LoadFunds();
        }
    }
}
