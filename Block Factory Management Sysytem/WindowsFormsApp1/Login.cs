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
    public partial class Login : Form
    {
        clsUsers user;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //int id = -1, per = -2;
            //bool is_active = false;
            //clsUsers users = new clsUsers( id,per, is_active);

            user = clsUsers.Find_ByUserName_andPassword(txtName.Text, txtPass.Text);
            if ( user == null )
           {
                MessageBox.Show("invalid UserName and password or your acount is unactive");
                return;
           }

            if (user._IsActive == false)
            {
                MessageBox.Show("your account is not active");
                return;
            }

           

            clsCurrentUser.id = user._User_id;
            clsCurrentUser.is_active = user._IsActive;
            clsCurrentUser.per = user._Per;

            MessageBox.Show("Log in succesfully");
            MainForm main = new MainForm();
            
            main.labelusername.Text = user._User_Name;
            this.Hide();
            main.ShowDialog();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
