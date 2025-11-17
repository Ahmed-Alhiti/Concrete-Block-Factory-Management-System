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
    public partial class frmSupplier : Form
    {
        private void _LoadSuppliers()
        {
            dgvSuppliers.DataSource = clsSuppliers.GetAllSuppliers();
            if(dgvSuppliers.Rows.Count > 0)
                dgvSuppliers.Columns[0].Visible = false;

        }
        private void _SearchSuppliers()
        {
            dgvSuppliers.DataSource = clsSuppliers.GetAllSuppliers(txtSearch.Text);
            if(dgvSuppliers.Rows.Count > 0)
                dgvSuppliers.Columns[0].Visible = false;
        }

        public frmSupplier()
        {
            InitializeComponent();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            _LoadSuppliers();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplierModule supplierModule = new frmSupplierModule(-1);
            supplierModule.ShowDialog();
            _LoadSuppliers();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierModule supplierModule = new frmSupplierModule(Convert.ToInt32(dgvSuppliers.CurrentRow.Cells[0].Value));
            supplierModule.ShowDialog();
            _LoadSuppliers();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete [" + dgvSuppliers.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsSuppliers.Delete((int)dgvSuppliers.CurrentRow.Cells[0].Value))
                    MessageBox.Show("Deleted Successfuly");
                else
                    MessageBox.Show("not Deleted");
            }
            _LoadSuppliers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchSuppliers();

            if(string.IsNullOrEmpty(txtSearch.Text))
                _LoadSuppliers();

        }
    }
}
