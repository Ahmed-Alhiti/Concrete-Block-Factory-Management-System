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
    public partial class frmOprationsModule : Form
    {
        clsOperations operations;
        public enum enMode { Addnew = 0, Update = 1 }
        public enMode mode;
        private int _OpID;

        public frmOprationsModule(int id)
        {
            InitializeComponent();
            _OpID = id;
            if(_OpID==-1)
            {
                mode = enMode.Addnew;
            }
            else
            {
                mode = enMode.Update;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void _LoadData()
        {
            if(mode == enMode.Addnew)
            {
                btnUpdate.Enabled = false;
                operations = new clsOperations();
                return;
            }
            lbltxt.Text = "تعديل عملية";
            btnSave.Enabled = false;
            operations = clsOperations.Find_ByID(_OpID);
            txtName.Text = operations._Name;
        }
        private void frmOprationsModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            operations._Name = txtName.Text;
            if (operations.Save())
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
            operations._Name = txtName.Text;
            if (operations.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
            this.Close();
        }

    }
}
