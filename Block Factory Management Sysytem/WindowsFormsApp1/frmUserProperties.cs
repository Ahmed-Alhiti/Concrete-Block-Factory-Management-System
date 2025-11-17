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
    public partial class frmUserProperties : Form
    {
        clsUsers user;
        private int _User_id;
        public frmUserProperties(int id)
        {
            InitializeComponent();
            _User_id = id;
        }

        private void _FillcbEmp()
        {
            cbEmp.DataSource = clsEmployee.GetAllEmps();
            cbEmp.DisplayMember = "Name";
            cbEmp.ValueMember = "Emp_ID";
            cbEmp.SelectedValue = user._Emp_id;
        }
       
        private void _HandelUserPermisson()
        {
            if(user._Per == -1)
            {
                treeUserPermission.Nodes["All"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Sales"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Purch"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Production"].Checked = true;
                return;
            }
            if (user._Per == 1)
            {
                treeUserPermission.Nodes["All"].Nodes["Sales"].Checked = true;
                return;
            }
            if (user._Per == 2)
            {
                treeUserPermission.Nodes["All"].Nodes["Purch"].Checked = true;
                return;
            }
            if (user._Per == 4)
            {
                treeUserPermission.Nodes["All"].Nodes["Production"].Checked = true;
                return;
            }

            if (user._Per == 3)
            {
                treeUserPermission.Nodes["All"].Nodes["Sales"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Purch"].Checked = true;
                return;
            }
            if (user._Per == 5)
            {
                treeUserPermission.Nodes["All"].Nodes["Sales"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Production"].Checked = true;
                return;
            }

            if (user._Per == 6)
            {
                treeUserPermission.Nodes["All"].Nodes["Purch"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Production"].Checked = true;
                return;
            }

            if (user._Per == 7)
            {
                treeUserPermission.Nodes["All"].Nodes["Sales"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Purch"].Checked = true;
                treeUserPermission.Nodes["All"].Nodes["Production"].Checked = true;
                return;
            }
        }

        
        private void _LoadData()
        {
            user = clsUsers.Find_ByID(_User_id);
            txtUsername.Text = user._User_Name;
            is_active.Checked = user._IsActive;
            _FillcbEmp();
            _HandelUserPermisson();
           
        }
        private int _GetUserPer()
        {
            int Per = 0;

            if (treeUserPermission.Nodes["All"].Checked)
            {
                Per = (int)clsUsers.enPermission.All;
                return Per;
            }

            if (treeUserPermission.Nodes["All"].Nodes["Sales"].Checked)
                Per += (int)clsUsers.enPermission.Sales;

            if (treeUserPermission.Nodes["All"].Nodes["Purch"].Checked)
                Per += (int)clsUsers.enPermission.Purch;

            if (treeUserPermission.Nodes["All"].Nodes["Production"].Checked)
                Per += (int)clsUsers.enPermission.Production;

            return Per;
        }
        private void frmUserProperties_Load(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            user._User_Name = txtUsername.Text;
            user._Per = _GetUserPer();
            user._IsActive = is_active.Checked;
            user._Emp_id = (int)cbEmp.SelectedValue;

            if (user.Save())
            {
                MessageBox.Show("Data saved succesfuly");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Data not saved ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Check_allChildren(TreeNode node, Boolean check)
        {
            foreach (TreeNode node1 in node.Nodes)
            {
                node1.Checked = check;
                if (node1.Nodes.Count > 0)
                {
                    this.Check_allChildren(node1, check);

                }
            }
        }

        private void treeUserPermission_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Check_allChildren(e.Node, e.Node.Checked);
        }
    }
}
