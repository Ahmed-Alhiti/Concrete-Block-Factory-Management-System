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
    public partial class frmBanks : Form
    {
        public frmBanks()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dgvBanks.DataSource = clsBanks.GetAllBanks();
            if (dgvBanks.Rows.Count > 0)
                dgvBanks.Columns[0].Visible = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBanksModule banksModule = new frmBanksModule(-1);
            banksModule.ShowDialog();
            _LoadData();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanksModule module = new frmBanksModule((int)dgvBanks.CurrentRow.Cells[0].Value);
            module.ShowDialog();
            _LoadData();

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBanks.Rows.Count == 0)
                return;

            if (MessageBox.Show("هل تريد حذف " + dgvBanks.CurrentRow.Cells[1].Value.ToString() + "؟", "حذف بنك", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (clsBanks.Delete((int)dgvBanks.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تم الحذف");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            _LoadData();

        }        private void frmBanks_Load(object sender, EventArgs e)
        {
            _LoadData();

        }
    }
}
