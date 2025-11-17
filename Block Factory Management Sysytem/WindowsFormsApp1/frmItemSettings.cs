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
    public partial class frmItemSettings : Form
    {
        
        
        //clsComponents components;
        private int _TypeID;
        private clsType type;
        public frmItemSettings(int id)
        {
            InitializeComponent();
            _TypeID = id;
            type = clsType.FindType_ByID(id);
        }


        private void _Fillcbitem()
        {
            cbItem.DataSource = clsType.GetAllTypies();
            cbItem.DisplayMember = "اسم الصنف";
            cbItem.ValueMember = "Blo_ID";
            cbItem.SelectedValue = -1;
        }

        private void _LoadData()
        {
            _Fillcbitem();
            itemSettings1.lblTypeName.Text = type._Called;

        }
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
      
            clsComponents components = new clsComponents();
            components._Blo_id = _TypeID;
            components._Mat_id = (int)itemSettings1.cbComp1.SelectedValue;
            if (itemSettings1.cbcomp1_unit.SelectedIndex == 0)
                components._Unit_id = 1;
            else
                components._Unit_id = 3;

            components._Unit_value = decimal.Parse(itemSettings1.txtcomp1_inItem.Text);

            if (components.Save())
            {
                clsComponents components1 = new clsComponents();
                components1._Blo_id = _TypeID;
                components1._Mat_id = (int)itemSettings1.cbComp2.SelectedValue;
                if (itemSettings1.cbcomp2_unit.SelectedIndex == 0)
                    components1._Unit_id = 1;
                else
                    components1._Unit_id = 3;

                components1._Unit_value = decimal.Parse(itemSettings1.txtcomp2_inItem.Text);

                if (components1.Save())
                {
                    clsComponents components2 = new clsComponents();
                    components2._Blo_id = _TypeID;
                    components2._Mat_id = (int)itemSettings1.cbComp3.SelectedValue;
                    if (itemSettings1.cbcomp3_unit.SelectedIndex == 0)
                        components2._Unit_id = 1;
                    else
                        components2._Unit_id = 3;

                    components2._Unit_value = decimal.Parse(itemSettings1.txtcomp3_inItem.Text);
                    if (components2.Save())
                    {
                        MessageBox.Show("Data Saved");
                    }
                }
            }
            else
            {
                MessageBox.Show("Data ain't Saved");
            }

            if((MessageBox.Show("سيتم تعديل سعر الصنف "+type._Called+" من "+type._Price.ToString()+" الى "+itemSettings1.txtItemPrice.Text+"" , "تعديل سعر الصنف", MessageBoxButtons.OK,MessageBoxIcon.Information)== DialogResult.OK))
            {
                type._Price = float.Parse(itemSettings1.txtItemPrice.Text);

                if (type.Save())
                {
                    MessageBox.Show("تم الحفظ");
                }
                else
                {
                    MessageBox.Show("لم بتم الحفظ");
                }
            }
                return;
        }

        private void _LoadItemComponents()
        {
            dgvItemRecord.DataSource = clsComponents.GetAllComponents((int)cbItem.SelectedValue);

            if (dgvItemRecord.Rows.Count == 0)
                MessageBox.Show("لا توجد بيانات");
        }
        private void btnLoadItemRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbItem.Text))
            {
                MessageBox.Show("قم باختيار الصنف اولا");
                cbItem.Focus();
                return;
            }
            _LoadItemComponents();
        }

        private void frmItemSettings_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
