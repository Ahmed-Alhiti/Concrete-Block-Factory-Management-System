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
    public partial class frmSupplierModule : Form
    {
        clsSuppliers _Supplier;

        private int _SupplierID;
        public enum enMode { AddNew=0,Update=1}
        public enMode mode= enMode.AddNew;
        public frmSupplierModule(int id)
        {
            InitializeComponent();

            _SupplierID = id;
            if (_SupplierID == -1)
            {
                mode = enMode.AddNew;
            }
            else
                mode = enMode.Update;
        }

        private void _LoadData()
        {
            if(mode == enMode.AddNew)
            {
                lbltxt.Text = "اضافة مورد جديد";
                btnUpdate.Enabled = false;
                _Supplier = new clsSuppliers();
                return;
            }

            lbltxt.Text = "تعديل بيانات مورد";
            btnSave.Enabled = false;
            _Supplier = clsSuppliers.Find_ByID(_SupplierID);
            textBox1.Text = _Supplier._Name;
            txtPhone.Text = _Supplier._Phone;
        }

       
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            _Supplier._Name = textBox1.Text.ToString();
            _Supplier._Phone = txtPhone.Text.ToString();
           

            if (_Supplier.Save())
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
            _Supplier._Name = textBox1.Text;
            _Supplier._Phone = txtPhone.Text;

            if (_Supplier.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
            this.Close();

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmSupplierModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
