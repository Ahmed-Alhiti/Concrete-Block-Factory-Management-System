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
    public partial class frmPurchasesModule : Form
    {
        private int _PurID;
       
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode mode;
        clsPurchases purchases;
        public frmPurchasesModule(int id)
        {
            InitializeComponent();

            _PurID = id;

            if (_PurID == -1)
                mode = enMode.AddNew;
            else
                mode = enMode.Update;

        }

        private void _FillcbSupplier()
        {
            cbSupplier.DataSource = clsSuppliers.GetAllSuppliers();
            cbSupplier.DisplayMember = "اسم المورد";
            cbSupplier.ValueMember = "Sup_ID";
            cbSupplier.SelectedValue = -1;
        }
        
        private void _FillcbMat()
        {
            cbMat.DataSource = clsMaterials.GetAll();
            cbMat.DisplayMember = "الخام";
            cbMat.ValueMember = "Mat_ID";
            cbMat.SelectedValue = -1;
        }
        private void _FillcbMatUnit()
        {
            cbMatUnit.DataSource = clsUnit.GetAll();
            cbMatUnit.DisplayMember = "الوحدة";
            cbMatUnit.ValueMember = "Unit_id";
            cbMatUnit.SelectedValue = -1;
        }

        private void _LoaData()
        {
            _FillcbSupplier();
            _FillcbMat();
            _FillcbMatUnit();


            
            if(mode == enMode.AddNew)
            {
                purchases = new clsPurchases();
                btnUpdate.Enabled = false;
                lblUsername.Text = clsUsers.FindUserNameByID(clsCurrentUser.id);
                return;
            }

            purchases = clsPurchases.Find_ByID(_PurID);
            btnSave.Enabled = false;
            txtMatQty.Text = purchases._Total_Mat_Amount.ToString();
            txtPrice.Text = purchases._Price.ToString();
            cbMat.SelectedValue = purchases._Mat_ID;
            cbMatUnit.SelectedValue = purchases._Unit_ID;
            cbSupplier.SelectedValue = purchases._Sup_ID;
            dtPurchases.Value = purchases._Create_on;
            

            lblUsername.Text = clsUsers.FindUserNameByID(clsCurrentUser.id);

        }

        private void frmPurchasesModule_Load(object sender, EventArgs e)
        {
            _LoaData();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                purchases._Create_on = dtPurchases.Value;
                purchases._Mat_ID = (int)cbMat.SelectedValue;
                purchases._Price = Convert.ToDecimal(txtPrice.Text);
                purchases._Sup_ID = (int)cbSupplier.SelectedValue;
                purchases._Total_Mat_Amount = Convert.ToDecimal(txtMatQty.Text);
                purchases._Unit_ID = (int)cbMatUnit.SelectedValue;
                purchases._Create_By = clsCurrentUser.id;
           
           
           
           if (purchases.Save())
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
            purchases._Update_on = DateTime.Now;
            purchases._Mat_ID = (int)cbMat.SelectedValue;
            purchases._Price = Convert.ToDecimal(txtPrice.Text);
            purchases._Sup_ID = (int)cbSupplier.SelectedValue;
            purchases._Total_Mat_Amount = Convert.ToDecimal(txtMatQty.Text);
            purchases._Unit_ID = (int)cbMatUnit.SelectedValue;
            purchases._Update_By = clsCurrentUser.id;
            if(purchases.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
