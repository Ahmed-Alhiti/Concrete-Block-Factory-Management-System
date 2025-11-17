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
    public partial class frmUnitModule : Form
    {
        clsUnit unit;
        int _unit_id;
        public enum enMode{ AddNew = 0, Update=1}
        public enMode mode;
        public frmUnitModule(int id)
        {
            InitializeComponent();
            _unit_id = id;
            if (_unit_id == -1)
                mode = enMode.AddNew;
            else
                mode = enMode.Update;
        }

        private void _LoadData()
        {
            if (mode == enMode.AddNew)
            {
                unit = new clsUnit();
                btnUpdate.Enabled = false;
                return;
            }
            btnSave.Enabled = false;
            lbltxt.Text = "تعديل وحده";

            unit = clsUnit.FindUnit_ByID(_unit_id);
            txtName.Text = unit._Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            unit._Name = txtName.Text;
            if (unit.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unit._Name = txtName.Text;
            if (unit.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
        }

        private void frmUnitModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
