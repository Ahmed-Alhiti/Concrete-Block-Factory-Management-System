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
    public partial class frmCustomer : Form
    {
        private void _LoadCustomers()
        {
            dgvCustomer.DataSource = clsCustomer.GetAllCustomers();
            if(dgvCustomer.Rows.Count > 0 )
                dgvCustomer.Columns[0].Visible = false;
        }
        private void _Search()
        {
            dgvCustomer.DataSource = clsCustomer.GetAllCustomers(txtSearch.Text);
            if(dgvCustomer.Rows.Count > 0 )
                dgvCustomer.Columns[0].Visible = false;
        }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            _LoadCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomerModule frmCustomer = new frmCustomerModule(-1);
            frmCustomer.ShowDialog();
            _LoadCustomers();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerModule frmCustomer = new frmCustomerModule((int)dgvCustomer.CurrentRow.Cells[0].Value);
            frmCustomer.ShowDialog();
            _LoadCustomers();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Customer [" + dgvCustomer.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsCustomer.Delete((int)dgvCustomer.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Customer is not deleted");
                }
            }
            _LoadCustomers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text == string.Empty)
            {
                _LoadCustomers();
                return;
            }
            _Search();

        }
    }
}
