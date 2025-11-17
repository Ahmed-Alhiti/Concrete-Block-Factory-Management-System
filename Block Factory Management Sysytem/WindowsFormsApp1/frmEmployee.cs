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
    public partial class frmEmployee : Form
    {
        private void _LoadEmployees()
        {
             
            dgvEmployees.DataSource = clsEmployee.GetAllEmployees();
            if(dgvEmployees.Rows.Count>0)
                dgvEmployees.Columns[0].Visible = false;
            
        }
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void FrmWorkers_Load(object sender, EventArgs e)
        {
            _LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeModule emp = new frmEmployeModule(-1);
            emp.ShowDialog();
            _LoadEmployees();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeModule emp = new frmEmployeModule(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value));
            emp.ShowDialog();
            _LoadEmployees();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حذف الوظف [" + dgvEmployees.CurrentRow.Cells[1].Value + "]", "تأكيد الحذف", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsEmployee.DeleteEmployee(Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("تم الحذف بنجاح ");
                }
                else
                {
                    MessageBox.Show("هناك حساب مستخدم مرتبط بهذا الموظف , لا يمكن الحذف");
                }
            }
            _LoadEmployees();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = clsEmployee.GetAllEmployees(txtSearch.Text);
            if (dgvEmployees.Rows.Count > 0)
                dgvEmployees.Columns[0].Visible = false;

            if (string.IsNullOrEmpty(txtSearch.Text))
                _LoadEmployees();

        }
    }
}
