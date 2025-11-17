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
    
    public partial class frmItemModule : Form
    {
        clsSale_Details sale;
        private int salenum;
        public frmItemModule(int Sal_num)
        {
            InitializeComponent();

            salenum = Sal_num;
        }

       
        private void _Fillcbitem()
        {
            cbitem.DataSource = clsType.GetAllTypies();
            cbitem.DisplayMember = "اسم الصنف";
            cbitem.ValueMember = "Blo_ID";
            cbitem.SelectedValue = -1;
        }

       private void _LoadItems()
       {
            dgvBillDetails.DataSource = clsSale_Details.GetAllItems(salenum);

            if(dgvBillDetails.Rows.Count > 0)
                dgvBillDetails.Columns[0].Visible = false;
       }

        private void _LoadData()
        {
            _Fillcbitem();
            _LoadItems();
            txtBillTotal.Text = clsSales.GetBillTotal(salenum).ToString();
            if (clsSales.CheckPost(salenum))
            {
                dgvBillDetails.Enabled = false;
                btnAccCancel.Enabled = false;
                btnSave.Enabled = false;
            }
             
        }


        private void frmSaleModule_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد تعديل الصنف " + dgvBillDetails.CurrentRow.Cells[2].Value.ToString() + "  ", "تعديل صنف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                sale._Block_Amount = short.Parse(txtQty.Text);
                sale._Block_ID = (int)cbitem.SelectedValue;
                sale._Total_Price = float.Parse(txtTotalBill.Text);

                if (sale.Save())
                {

                    MessageBox.Show("Date saved");
                    clsSales.UpdateQtyAndTotal(sale._Sale_Number);
                    _LoadItems();
                    txtBillTotal.Text = clsSales.GetBillTotal(salenum).ToString();
                }
                else
                {
                    MessageBox.Show("can't save");
                }
            }

        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            txtQty.Clear();
            txtPerPrice.Clear();
           
            txtTotalBill.Clear();
            cbitem.Text = "";
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
       {
            if (txtPerPrice.Text == string.Empty)
                return;

            if (txtQty.Text != string.Empty)
            {
                short num1 = short.Parse(txtQty.Text);
                short num2 = short.Parse(txtPerPrice.Text);
                int result = num1 * num2;

                txtTotalBill.Text = result.ToString();
            }
            else
            {
                txtTotalBill.Clear();
            }
        }

        private void cbitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbitem.Text == string.Empty)
                return;

            string seleted_string = cbitem.SelectedValue.ToString();
            if (int.TryParse(seleted_string, out int selectedint))
                txtPerPrice.Text = clsType.GetPrice(selectedint).ToString();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtPerPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text == string.Empty)
                return;

            if (txtQty.Text != string.Empty)
            {
                short num1 = short.Parse(txtQty.Text);
                short num2 = short.Parse(txtPerPrice.Text);
                int result = num1 * num2;

                txtTotalBill.Text = result.ToString();
            }
            else
            {
                txtTotalBill.Clear();
            }
        }

      

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvBillDetails.Rows.Count == 1)
            {
                if (MessageBox.Show("هل تريد حذف السند " + txtRefNo.Text + " وجميع البيانات المرتبطه به ", "حذف جميع السجلات", MessageBoxButtons.OK, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    if (clsSales.DeleteByRefoNo(int.Parse(txtRefNo.Text)))
                    {
                        MessageBox.Show("تم حذف جميع البيانات");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                    
                }
                return;
            }
               
                if (MessageBox.Show("هل تريد حذف الصنف "+ dgvBillDetails.CurrentRow.Cells[2].Value.ToString() +"  "   , "حذف صنف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsSale_Details.Delete((int)dgvBillDetails.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم حذف الصنف بنجاح");
                    clsSales.UpdateQtyAndTotal(sale._Sale_Number);
                    _LoadItems();
                }
            }
        }

        private void dgvBillDetails_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            sale = clsSale_Details.Find_ByID((int)dgvBillDetails.CurrentRow.Cells[0].Value);
            txtRefNo.Text = sale._Sale_Number.ToString();
            cbitem.SelectedValue = sale._Block_ID;
            txtQty.Text = sale._Block_Amount.ToString();
            txtTotalBill.Text = sale._Total_Price.ToString();
            txtPerPrice.Text = clsType.GetPrice((int)cbitem.SelectedValue).ToString();
            cbitem.Enabled = true;
            txtQty.Enabled = true;
        }
    }
}
