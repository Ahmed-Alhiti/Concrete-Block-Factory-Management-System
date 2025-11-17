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
    public partial class frmMatrials : Form
    {
        private void _LoadMaterials()
        {
            dgvMaterils.DataSource = clsMaterials.GetAll();
            dgvMaterils.Columns[0].Visible = false;
        }
        public frmMatrials()
        {
            InitializeComponent();
        }

        private void frmMatrials_Load(object sender, EventArgs e)
        {
            _LoadMaterials();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMaterialsModule materialsModule = new frmMaterialsModule(-1);
            materialsModule.ShowDialog();
            _LoadMaterials();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialsModule materialsModule = new frmMaterialsModule((int)dgvMaterils.CurrentRow.Cells[0].Value);
            materialsModule.ShowDialog();
            _LoadMaterials();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Material [" + dgvMaterils.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsMaterials.Delete((int)dgvMaterils.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("Customer is not deleted");
                }
            }
            _LoadMaterials();
        }
    }
}
