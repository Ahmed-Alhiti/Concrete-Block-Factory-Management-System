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
    public partial class frmExchangeDetails : Form
    {
        clsExchangeDetails _exchangeDetails;
        int RefNo;
        public frmExchangeDetails(int refno)
        {
            InitializeComponent();
            RefNo = refno;
        }

        private void _FillcbSuppliers()
        {
            cbSuppliers.DataSource = clsSuppliers.GetAllSuppliers();

            cbSuppliers.DisplayMember = "اسم المورد";

            cbSuppliers.ValueMember = "Sup_ID";

            cbSuppliers.SelectedValue = -1;

        }
        private void _FillcbCurrencies()
        {
            cbCurrencies.DataSource = clsCurrencies.GetAll();
            cbCurrencies.DisplayMember = "اسم العمله";
            cbCurrencies.ValueMember = "Cur_ID";
            cbCurrencies.SelectedValue = -1;
        }

        private void _Fillcbs()
        {
            _FillcbCurrencies();
            _FillcbSuppliers();
        }

        private void _LoadData()
        {

            dgvExchangeDetails.DataSource = clsExchangeDetails.GetAll(RefNo);
            if (dgvExchangeDetails.Rows.Count > 0)
            {
                dgvExchangeDetails.Columns[0].Visible = false;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvExchangeDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _exchangeDetails = clsExchangeDetails.Find_ByID((int)dgvExchangeDetails.CurrentRow.Cells[0].Value);
            cbSuppliers.SelectedValue = _exchangeDetails._Sup_id;
            cbCurrencies.SelectedValue = _exchangeDetails._Cur_id;
            txtAmount.Text = _exchangeDetails._Total.ToString();
            txtExchangePrice.Text = clsExchangeprices.Find_ByID(_exchangeDetails._Exchagne_id)._Exchange_price.ToString();


            btnSave.Enabled = true;
            btnAccCancel.Enabled = true;
            //cbCurrencies.Enabled = true;
            cbSuppliers.Enabled = true;
            txtAmount.Enabled = true;
        }


        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvExchangeDetails.Rows)
            {
                total += decimal.Parse(row.Cells["المبلغ"].Value.ToString());
            }
            return total;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حفظ التعديلات التي اضفتها مؤخرا؟ ", "تعديل سند صرف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                _exchangeDetails._Sup_id = (int)cbSuppliers.SelectedValue;
                _exchangeDetails._Total = decimal.Parse(txtAmount.Text);





                if (_exchangeDetails.Save())
                {

                    MessageBox.Show("Details Date saved");
                    _LoadData();

                    clsExchangeBills exchangeBills = clsExchangeBills.Find_ByRefNo(int.Parse(txtRefNo.Text));
                    exchangeBills._Total = CalculateTotal();
                    if (exchangeBills.Save())
                    {
                        MessageBox.Show("exchangeBills Date saved");
                    }
                    else
                    {
                        MessageBox.Show("exchangeBills can't save");
                    }

                }
                else
                {
                    MessageBox.Show("can't save");
                }

            }
        }

        private void frmExchangeDetails_Load(object sender, EventArgs e)
        {
            _Fillcbs();
            _LoadData();
            txtRefNo.Text = RefNo.ToString();

        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnAccCancel.Enabled = false;
            // cbCurrencies.Enabled = false;
            cbSuppliers.Enabled = false;
            txtAmount.Enabled = false;
            cbSuppliers.SelectedValue = -1;
            cbCurrencies.SelectedValue = -1;
            txtAmount.Clear();
            txtExchangePrice.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (dgvExchangeDetails.Rows.Count == 1)
            {
                if (MessageBox.Show("هل تريد حذف السند " + txtRefNo.Text + " وجميع البيانات المرتبطه به ", "حذف جميع السجلات", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand) == DialogResult.OK)
                {
                    if (clsExchangeBills.DeletByRefNo(int.Parse(txtRefNo.Text)))
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
            else
            {
                if (MessageBox.Show("هل تريد حذف " + dgvExchangeDetails.CurrentRow.Cells[3].Value.ToString() + "  ", "حذف عنصر", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
                {
                    if (clsExchangeDetails.Delete((int)dgvExchangeDetails.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("تم الحذف بنجاح");

                        _LoadData();

                        clsExchangeBills exchangeBills = clsExchangeBills.Find_ByRefNo(int.Parse(txtRefNo.Text));
                        exchangeBills._Total = CalculateTotal();
                        if (exchangeBills.Save())
                        {
                            MessageBox.Show("exchangeBills Date saved");
                        }
                        else
                        {
                            MessageBox.Show("exchangeBills can't save");
                        }

                    }
                }
            }
            
        }

    }
}
