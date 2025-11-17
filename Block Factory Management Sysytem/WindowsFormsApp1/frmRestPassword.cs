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
    public partial class frmRestPassword : Form
    {
        clsUsers user;
        private int _User_id;
        public frmRestPassword(int id)
        {
            InitializeComponent();
            _User_id = id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtNpass.Text != txtResPass.Text)
            {
                  MessageBox.Show("The password you typed do not match. Type the password for this account in both text boxes.", "Add User Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
            }
            if (MessageBox.Show("Reset password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                user = clsUsers.Find_ByID(_User_id);
                user._Password = txtResPass.Text;
                if (user.Save())
                {
                    MessageBox.Show("Password has been successfully reset", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Can't change password ", "Reset Password");
                    this.Dispose();
                }
                
            }
        }

        private void frmRestPassword_Load(object sender, EventArgs e)
        {
            user = clsUsers.Find_ByID(_User_id);
            txtOldPass.Text = user._Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
