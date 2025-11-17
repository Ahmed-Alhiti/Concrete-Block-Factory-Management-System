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
    public partial class frmProductModule : Form
    {
        private int _typID;
        public enum enMode  {AddNew = 0 ,update = 1}

        public enMode _mode;

        private clsType _type;
    public frmProductModule(int id)
        {
            InitializeComponent();

            _typID = id;
            if(_typID == -1)
            {
                _mode = enMode.AddNew;
            }
            else
            {
                _mode = enMode.update;
            }
        }

        private void _LoadData()
        {
            if(_mode == enMode.AddNew)
            {
                lbltext.Text = "اضافة صنف";
                _type = new clsType();
                btnUpdate.Enabled = false;
                return;
            }

            btnSave.Enabled = false;

            _type = clsType.FindType_ByID(_typID);
            lbltext.Text = "تعديل صنف";
            txtName.Text = _type._Called;
            txtPrice.Text = _type._Price.ToString();
            txtSize.Text = _type._Size.ToString();

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsType.Check(txtName.Text))
            {
                MessageBox.Show("هذا الصنف تم تسجيله مسبقا");
                return;
            }
            _type._Called = txtName.Text.ToString();
            if (string.IsNullOrEmpty(txtPrice.Text))
                _type._Price = 0;
            else
                _type._Price = float.Parse(txtPrice.Text);
            _type._Size = int.Parse(txtSize.Text);

            if (_type.Save())
            {
                MessageBox.Show("added");
            }
            else
            {
                MessageBox.Show("faild");
            }
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (clsType.Check(txtName.Text))
            //{
            //    MessageBox.Show("هذا الصنف تم تسجيله مسبقا");
            //    return;
            //}
            _type._Called = txtName.Text;
            if (string.IsNullOrEmpty(txtPrice.Text))
                _type._Price = 0;
            else
                _type._Price = float.Parse(txtPrice.Text);
            _type._Size = Convert.ToInt32(txtSize.Text);

            if (_type.Save())
            {
                MessageBox.Show("updated");
            }
            else
            {
                MessageBox.Show("faild to update");
            }
            this.Close();
        }

        private void frmProductModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
