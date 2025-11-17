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
    public partial class frmBanksModule : Form
    {
        clsBanks bank;
        int Bank_id;
        enum enMode { AddNew = 0, Update = 1 }
        enMode mode;
        public frmBanksModule(int id)
        {
            InitializeComponent();
            Bank_id = id;
            if (Bank_id == -1)
                mode = enMode.AddNew;
            else
                mode = enMode.Update;
        }
        private void _LoadData()
        {
            if(mode == enMode.AddNew)
            {
                bank = new clsBanks();
                btnUpdate.Enabled = false;
                return;
            }
            lbltxt.Text = "تعدبل بنك";
            btnSave.Enabled = false;
            bank = clsBanks.Find_ByID(Bank_id);
            txtName.Text = bank._Name;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmBanksModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void _Save()
        {
            bank._Name = txtName.Text;
            if (bank.Save())
            {
                MessageBox.Show("Data Saved");
            }
            else
            {
                MessageBox.Show("Can't Saved");
            }
            this.Close();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
