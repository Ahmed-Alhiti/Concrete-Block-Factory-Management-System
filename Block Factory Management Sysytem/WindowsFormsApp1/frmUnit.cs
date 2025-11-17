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
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dgvUnit.DataSource = clsUnit.GetAll();
            if (dgvUnit.Rows.Count > 0)
                dgvUnit.Columns[0].Visible = false;
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUnitModule frmUnit = new frmUnitModule(-1);
            frmUnit.ShowDialog();
            _LoadData();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnitModule frmUnit = new frmUnitModule((int)dgvUnit.CurrentRow.Cells[0].Value);
            frmUnit.ShowDialog();
            _LoadData();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Unit [" + dgvUnit.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUnit.Delete((int)dgvUnit.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Employee is not deleted");
                }
            }
            _LoadData();
        }
    }
}
