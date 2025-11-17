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
    public partial class frmProductionModule : Form
    {
        clsStorage_stock _Prod;
        clsType _type;

        private int _PordID;
        private int _TypID;
        
        
        public frmProductionModule(int id)
        {
            InitializeComponent();
            _PordID = id;
            
        }

        private void _FillcbTypes()
        {
            cbTypes.DataSource = clsType.GetAllTypies();
            cbTypes.DisplayMember = "اسم الصنف";
            cbTypes.ValueMember = "Blo_ID";
            cbTypes.SelectedValue = -1;
        }
        private void _LoadData()
        {
            _FillcbTypes();

            
            
            lbltxt.Text = "تعديل بيانات";
            _Prod = clsStorage_stock.Find_ByID(_PordID);
            txtQty.Text = _Prod._Amount.ToString();
            DTProduction.Value = _Prod._Date;
            cbTypes.SelectedValue = _Prod._Block_id;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmProductionModule_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _Prod._Amount =short.Parse(txtQty.Text);
            _Prod._Block_id = (int)cbTypes.SelectedValue;
            _Prod._Date = DTProduction.Value;
           
            if (_Prod.Save())
            {
                MessageBox.Show("Data saved");
            }
            else
            {
                MessageBox.Show("Data unsaved");
            }
            this.Close();
        }

      
    }
}
