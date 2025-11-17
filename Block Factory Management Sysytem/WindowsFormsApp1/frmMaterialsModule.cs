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
    public partial class frmMaterialsModule : Form
    {
        clsMaterials _material;
        private int _MatID;
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode mode;
        public frmMaterialsModule(int id)
        {
            InitializeComponent();
            _MatID = id;
            if(_MatID == -1)
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
                lbltxt.Text = "اضافة مادة خام";
                btnUpdate.Enabled = false;
                _material = new clsMaterials();
                return;
            }

            lbltxt.Text = "تعديل بيانات";
            btnSave.Enabled = false;
            _material = clsMaterials.FindMat_ByID(_MatID);
            txtName.Text = _material._Name;
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaterialsModule_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _material._Name = txtName.Text;
            if(_material.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _material._Name = txtName.Text;
            if (_material.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
        }
    }
}
