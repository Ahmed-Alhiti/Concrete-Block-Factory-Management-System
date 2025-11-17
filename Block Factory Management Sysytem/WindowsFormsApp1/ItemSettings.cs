using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace WindowsFormsApp1
{
    public partial class ItemSettings : UserControl
    {
        public enum enUnit { ton = 0,kg = 1, g = 2 }


        private decimal _BlockAmountForCeahMix(TextBox txtnumOfbeats,TextBox txtblockNum)
        {
            decimal BlockAmount = (int.Parse(txtnumOfbeats.Text) * int.Parse(txtblockNum.Text));
            return BlockAmount;
        }
        private void _Calaulate( ComboBox comboBox1 ,TextBox textBox1,TextBox textBox2)
        {
            
            int compAmount = int.Parse(textBox1.Text);
           
            //decimal compAmountinItem = (compAmount /_BlockAmountForCeahMix(txtNumOfbeats, txtBlockNum));
            decimal blocAmount = (_BlockAmountForCeahMix(txtNumOfbeats, txtBlockNum));
            textBox2.Text = (compAmount / blocAmount).ToString("#,##0.00");


            if(decimal.Parse(textBox2.Text) < 1)
                comboBox1.SelectedIndex = 1;
            else
                comboBox1.SelectedIndex = 0;
            
        }
        public ItemSettings()
        {
            InitializeComponent();
        }

        private void _FillComp1()
        {
            cbComp1.DataSource = clsMaterials.GetAll();
            cbComp1.DisplayMember = "الخام";
            cbComp1.ValueMember = "Mat_ID";
            cbComp1.SelectedValue = -1;
        }
        private void _FillComp2()
        {
            cbComp2.DataSource = clsMaterials.GetAll();
            cbComp2.DisplayMember = "الخام";
            cbComp2.ValueMember = "Mat_ID";
            cbComp2.SelectedValue = -1;
        }
        private void _FillComp3()
        {
            cbComp3.DataSource = clsMaterials.GetAll();
            cbComp3.DisplayMember = "الخام";
            cbComp3.ValueMember = "Mat_ID";
            cbComp3.SelectedValue = -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtTotalQty.Text = _BlockAmountForCeahMix(txtNumOfbeats, txtBlockNum).ToString();

            txtLastComp1_price.Text = clsPurchases.GetLastPrice((int)cbComp1.SelectedValue).ToString();
            txtLastComp2_price.Text = clsPurchases.GetLastPrice((int)cbComp2.SelectedValue).ToString();
            txtLastComp3_price.Text = clsPurchases.GetLastPrice((int)cbComp3.SelectedValue).ToString();

            _Calaulate(cbcomp1_unit, txtComp1Qty, txtcomp1_inItem);
            _Calaulate(cbcomp2_unit, txtComp2Qty, txtcomp2_inItem);
            _Calaulate(cbcomp3_unit, txtComp3Qty, txtcomp3_inItem);

            clsPurchases purchases = clsPurchases.Findlast((int)cbComp1.SelectedValue);
            clsPurchases purchases1 = clsPurchases.Findlast((int)cbComp2.SelectedValue);
            clsPurchases purchases2 = clsPurchases.Findlast((int)cbComp3.SelectedValue);

            decimal num1 = purchases._Total_Mat_Amount * 1000;
            decimal num2 = purchases1._Total_Mat_Amount * 1000;
            decimal num3 = purchases2._Total_Mat_Amount * 1000;

            decimal comp1Cost = purchases._Price  /num1;
            decimal comp2Cost = purchases1._Price /num2;
            decimal comp3Cost = purchases2._Price / num3;

            comp1Cost *= decimal.Parse(txtcomp1_inItem.Text);
            comp2Cost *= decimal.Parse(txtcomp2_inItem.Text);
            comp3Cost *= decimal.Parse(txtcomp3_inItem.Text);

            textBox1.Text=comp1Cost.ToString("#,##0.00");
            textBox2.Text=comp2Cost.ToString("#,##0.00");
            textBox3.Text=comp3Cost.ToString("#,##0.00");

            decimal itemCost = comp1Cost + comp2Cost + comp3Cost;
            txtCost.Text= itemCost.ToString("#,##0.00");
            
        }

        private void ItemSettings_Load(object sender, EventArgs e)
        {
            _FillComp1();
            _FillComp2();
            _FillComp3();

           
        }

       
        private void cbComp1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbComp1.Text))
            {
                errorProvider1.SetError(cbComp1, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            if (cbComp1.SelectedIndex == cbComp2.SelectedIndex || cbComp1.SelectedIndex == cbComp3.SelectedIndex)
            {
                MessageBox.Show("لا يمكن اختيار نفس المكون مرتين");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbComp1, "");
            }
        }

        private void cbComp2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbComp2.Text))
            {
                errorProvider1.SetError(cbComp2, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            if(cbComp2.SelectedIndex == cbComp1.SelectedIndex || cbComp2.SelectedIndex == cbComp3.SelectedIndex)
            {
                MessageBox.Show("لا يمكن اختيار نفس المكون مرتين");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbComp2, "");
            }
        }

        private void cbComp3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbComp3.Text))
            {
                errorProvider1.SetError(cbComp3, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            if (cbComp3.SelectedIndex == cbComp1.SelectedIndex || cbComp3.SelectedIndex == cbComp2.SelectedIndex)
            {
                MessageBox.Show("لا يمكن اختيار نفس المكون مرتين");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbComp3, "");
            }
        }

        private void txtComp1Qty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtComp1Qty.Text))
            {
                errorProvider1.SetError(txtComp1Qty, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtComp1Qty, "");
            }
        }

        private void txtComp2Qty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtComp2Qty.Text))
            {
                errorProvider1.SetError(txtComp2Qty, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtComp2Qty, "");
            }
        }

        private void txtComp3Qty_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtComp3Qty.Text))
            {
                errorProvider1.SetError(txtComp3Qty, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtComp3Qty, "");
            }
        }

        private void txtNumOfbeats_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumOfbeats.Text))
            {
                errorProvider1.SetError(txtNumOfbeats, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNumOfbeats, "");
            }
        }

        private void txtBlockNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBlockNum.Text))
            {
                errorProvider1.SetError(txtBlockNum, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBlockNum, "");
            }
        }

        private void txtComp1Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComp2Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComp3Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumOfbeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBlockNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtItemPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemPrice.Text))
            {
                errorProvider1.SetError(txtItemPrice, "هذا الحقل مطلوب");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtItemPrice, "");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal itemcost = decimal.Parse(txtCost.Text);
            decimal profit = (decimal.Parse(numericUpDown1.Value.ToString()) / 100);
            profit *= itemcost;
            decimal itemPrice = Math.Round(itemcost + profit);
            txtItemPrice.Text = itemPrice.ToString("#,##0.00");
        }
    }
}
