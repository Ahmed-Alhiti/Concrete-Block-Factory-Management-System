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
    public partial class frmUserAccount : Form
    {
        clsUsers user;
        public frmUserAccount()
        {
            InitializeComponent();
        }
        private void  Check_allChildren(TreeNode node , Boolean check)
        {
            foreach(TreeNode node1 in node.Nodes)
            {
                node1.Checked = check;
                if(node1.Nodes.Count > 0)
                {
                    this.Check_allChildren(node1, check);

                }
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Check_allChildren(e.Node, e.Node.Checked);
        }
        private void _FillcbEmp()
        {
            cbEmp.DataSource = clsEmployee.GetAllEmployees();
            cbEmp.DisplayMember = "اسم الموظف";
            cbEmp.ValueMember = "Emp_id";
            cbEmp.SelectedValue = -1;
        }

        private void _LoadUsers()
        {
            dgvUser.DataSource = clsUsers.GetAllUsers();
            if(dgvUser.Rows.Count>0)
                dgvUser.Columns[0].Visible = false;
        }


        private void frmUserAccount_Load(object sender, EventArgs e)
        {
            _FillcbEmp();
            _LoadUsers();
            lblUsername.Text = clsUsers.FindUserNameByID(clsCurrentUser.id);
            txtCurPass.Text = clsUsers.Find_ByID(clsCurrentUser.id)._Password;
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            cbEmp.SelectedValue = -1;
        }

        private int _GetUserPer()
        {
            int Per=0;

            if (treeView1.Nodes["All"].Checked)
            {
                Per = (int)clsUsers.enPermission.All;
                return Per;
            }

            if(treeView1.Nodes["All"].Nodes["Sales"].Checked)
                Per += (int)clsUsers.enPermission.Sales;

            if (treeView1.Nodes["All"].Nodes["Purch"].Checked)
                Per += (int)clsUsers.enPermission.Purch;

            if (treeView1.Nodes["All"].Nodes["Production"].Checked)
                Per += (int)clsUsers.enPermission.Production;

            return Per;
        }

        private void btnAccSave_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("Password and retype password isn't the same ");
                return;
            }

            clsUsers user = new clsUsers();
            user._Emp_id = (int)cbEmp.SelectedValue;
            user._IsActive = is_active.Checked;
            user._Password = txtRePass.Text;
            user._User_Name = txtUsername.Text;
            user._Per = _GetUserPer();
            
            if (user.Save())
            {
                MessageBox.Show("new account created succesfuly");
            }
            _LoadUsers();

        }

        

       

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            frmRestPassword restPassword = new frmRestPassword(user._User_id);
            restPassword.ShowDialog();
            _LoadUsers();

        }

        private void Propertise_Click(object sender, EventArgs e)
        {
            frmUserProperties userProperties = new frmUserProperties((int)dgvUser.CurrentRow.Cells[0].Value);
            userProperties.ShowDialog();
            _LoadUsers();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + dgvUser.CurrentRow.Cells[1].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsEmployee.DeleteEmployee((int)dgvUser.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfuly");
                }
                else
                {
                    MessageBox.Show("User is not deleted");
                }
            }
            _LoadUsers();
        }

        private void btnPassSave_Click(object sender, EventArgs e)
        {
            if (txtNPass.Text != txtRePass2.Text)
            {
                MessageBox.Show("The password you typed do not match. Type the password for this account in both text boxes.", "Add User Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Reset password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                user = clsUsers.Find_ByID(clsCurrentUser.id);
                user._Password = txtRePass2.Text;
                if (user.Save())
                {
                    MessageBox.Show("Password has been successfully reset", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Can't change password ", "Reset Password");

                }
                _LoadUsers();

            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbUser.Enabled = true;
            user = clsUsers.Find_ByID((int)dgvUser.CurrentRow.Cells[0].Value);

            if (lblUsername.Text == user._User_Name)
            {
                btnResetPass.Enabled = false;
                lblAccNote.Text = "لتغيير كلمة المرور الخاصة بك يرجى الانتقال الى صفحة 'اعادة تعيين كلمة المرور'";
            }
            else
            {
                btnResetPass.Enabled = true;
                lblAccNote.Text = "لتغيير كلمة المرور الخاصة بـ" + user._User_Name + " , اضغط على تغيير كلمة المرور";
            }
            gbUser.Text = "كلمة المرور الخاصة بـ " + user._User_Name + " ";
        }
    }
}
