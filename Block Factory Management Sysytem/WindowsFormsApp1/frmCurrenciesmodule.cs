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
    public partial class frmCurrenciesmodule : Form
    {
        clsCurrencies _Currencie;
        private int _CurrencieID;
        public enum enMode { AddNew = 0, update = 1 }
        public enMode mode;

        public frmCurrenciesmodule(int id)
        {
            InitializeComponent();
            _CurrencieID = id;
            if (_CurrencieID == -1)
            {
                mode = enMode.AddNew;
            }
            else
            {
                mode = enMode.update;
            }
        }

        private void _LoadData()
        {


            if (mode == enMode.AddNew)
            {
                lbltxt.Text = "اضافة عمله";
                btnUpdate.Enabled = false;
                _Currencie = new clsCurrencies();
                return;
            }

            lbltxt.Text = "تعديل عمله";
            btnSave.Enabled = false;
            _Currencie = clsCurrencies.Find_ByID(_CurrencieID);
            txtName.Text = _Currencie._Called;
            txtcode.Text = _Currencie._Code;


        }

        private void frmFundModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsCurrencies.Check(txtName.Text))
            {
                MessageBox.Show("هذا العملة تم تسجيلها مسبقا");
                return;
            }
            _Currencie._Called = txtName.Text;
            _Currencie._Code = txtcode.Text;
            if (_Currencie.Save())
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
            if (clsCurrencies.Check(txtName.Text))
            {
                MessageBox.Show("هذا العملة تم تسجيلها مسبقا");
                return;
            }
            _Currencie._Called = txtName.Text;
            _Currencie._Code = txtcode.Text;


            if (_Currencie.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
