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
    public partial class frmOprations : Form
    {
        private void _LoadOprations()
        {
            dgvOprations.DataSource = clsOperations.GetAll();
            dgvOprations.Columns[0].Visible = false;
        }
        public frmOprations()
        {
            InitializeComponent();
        }

        private void frmOprations_Load(object sender, EventArgs e)
        {
            _LoadOprations();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOprationsModule oprationsModule = new frmOprationsModule(-1);
            oprationsModule.ShowDialog();
            _LoadOprations();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOprationsModule oprationsModule = new frmOprationsModule((int)dgvOprations.CurrentRow.Cells[0].Value);
            oprationsModule.ShowDialog();
            _LoadOprations();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Opration [" + dgvOprations.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsOperations.Delete((int)dgvOprations.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Opration is not deleted");
                }
            }
            _LoadOprations();
        }
    }
}
