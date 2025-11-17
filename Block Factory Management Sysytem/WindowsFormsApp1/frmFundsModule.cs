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
    public partial class frmFundsModule : Form
    {
        clsFunds funds;
        int Fun_id;
        enum enMode { AddNew = 0, Update = 1 }
        enMode mode;
        public frmFundsModule(int id)
        {
            InitializeComponent();
            Fun_id = id;
            if (Fun_id == -1)
            
                mode = enMode.AddNew;
            
            else
                mode = enMode.Update;
        }

        private void _LoadData()
        {
            if(mode == enMode.AddNew)
            {
                funds = new clsFunds();
                btnUpdate.Enabled = false;
                return;
            }
            btnSave.Enabled = false;
            lbltxt.Text = "تعديل صندوق";

            funds = clsFunds.Find_ByID(Fun_id);
            txtName.Text = funds._Name;
        }

        private void frmFundsModule_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            funds._Name = txtName.Text;
            if (funds.Save())
                MessageBox.Show("Data Saved");
            else
                MessageBox.Show("Can't save");
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            funds._Name = txtName.Text;
            if (funds.Save())
                MessageBox.Show("Data Saved");
            else 
                MessageBox.Show("Can't save");
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
