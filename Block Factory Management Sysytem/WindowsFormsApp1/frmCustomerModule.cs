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
    public partial class frmCustomerModule : Form
    {
        clsCustomer _Customer;
        private int _CustomerID;
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode mode;
        public frmCustomerModule(int id)
        {
            InitializeComponent();
            _CustomerID = id;
            if (_CustomerID == -1)
            {
                mode = enMode.AddNew;
            }
            else
            {
                mode = enMode.Update;
            }
        }

        private void _LoadData()
        {
            if(mode == enMode.AddNew)
            {
                lbltxt.Text = "اضافة عميل جديد";
                btnUpdate.Enabled = false;
                _Customer = new clsCustomer();
                return;
            }

            lbltxt.Text = "تعديل بيانات عميل";
            btnSave.Enabled = false;
            _Customer = clsCustomer.FindCustomer_ByID(_CustomerID);
            txtName.Text = _Customer._Name;
            txtPhone.Text = _Customer._Phone;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Customer._Name = txtName.Text;
            _Customer._Phone = txtPhone.Text;

            if (_Customer.Save())
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
            _Customer._Name = txtName.Text;
            _Customer._Phone = txtPhone.Text;

            if (_Customer.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
            this.Close();

        }

        private void frmCustomerModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
