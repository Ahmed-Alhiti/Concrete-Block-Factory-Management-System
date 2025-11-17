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
    public partial class frmEmployeModule : Form
    {
        private int _EmployeeID;
        public enum enMode { AddNew=0 , Update =1}

        public enMode mode = enMode.AddNew;

        clsEmployee _Employee;

        public frmEmployeModule(int id)
        {
            InitializeComponent();

            _EmployeeID = id;
            if(_EmployeeID == -1)
            {
                mode = enMode.AddNew;
            }
            else
            {
                mode = enMode.Update;
            }
        }

        private void _FillcbManager()
        {
            DataTable table = clsEmployee.GetAllEmps();
            cbManager.DataSource = table;
            cbManager.DisplayMember = "NAME";
            cbManager.ValueMember = "Emp_ID";
            cbManager.SelectedValue = -1;
        }
        private void _LoadData()
        {
            _FillcbManager();
            if(mode == enMode.AddNew)
            {
                _Employee = new clsEmployee();
                lbltext.Text = "اضافة موظف";
                btnUpdate.Enabled = false;
                return;
            }

            btnSave.Enabled = false;
            lbltext.Text = "تعديل بيانات موظف";

            _Employee = clsEmployee.FindEmployee_ByID(_EmployeeID);
            txtName.Text = _Employee._Name;
            txtPhone.Text = _Employee._Phone;
            txtSalary.Text = _Employee._Salary.ToString();
            cbManager.SelectedValue = _Employee._Manage_By;


        }


        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmEmployeModule_Load(object sender, EventArgs e)
        {

            _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(clsEmployee.FindEmployee_ByName(cbManager.Text)._ID);
            //int manag_id = clsEmployee.FindManegar_ByID(ID);
            _Employee._Name = txtName.Text;
            _Employee._Phone = txtPhone.Text;
            _Employee._Salary = Convert.ToDecimal(txtSalary.Text);
            _Employee._Manage_By = ID;

            if (_Employee.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
            this.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbManager.SelectedValue == null)
                _Employee._Manage_By = -1;
            else
                _Employee._Manage_By = (int)cbManager.SelectedValue;
            _Employee._Name = txtName.Text;
            _Employee._Phone = txtPhone.Text;
            _Employee._Salary = Convert.ToDecimal(txtSalary.Text);
            

            if (_Employee.Save())
            {
                MessageBox.Show("تم الحفظ");
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ");
            }
            this.Close();

        }
    }
}
