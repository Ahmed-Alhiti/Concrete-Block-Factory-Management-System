using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSaleBill : Form
    {
        public frmSaleBill()
        {
            InitializeComponent();
        }

        private void frmSaleBill_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void LoadSaleBill(DataTable table, string Date, string qty , string BillTotal , string UserName , string BillType , string Customer_Name,string Salenum ,string Details)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptSaleBill.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter pDate = new ReportParameter("Date", Date);
                    ReportParameter Qty = new ReportParameter("Qty", qty);
                    ReportParameter username = new ReportParameter("UserName", UserName);
                    ReportParameter billTotal = new ReportParameter("BillTotal", BillTotal);
                    ReportParameter billType = new ReportParameter("BillType", BillType);
                    ReportParameter customer_name = new ReportParameter("Customer_Name", Customer_Name);
                    ReportParameter salnum = new ReportParameter("Salenum", Salenum);
                    ReportParameter details = new ReportParameter("Details", Details);
                    reportViewer1.LocalReport.SetParameters(pDate);
                    reportViewer1.LocalReport.SetParameters(Qty);
                    reportViewer1.LocalReport.SetParameters(username);
                    reportViewer1.LocalReport.SetParameters(billTotal);
                    reportViewer1.LocalReport.SetParameters(billType);
                    reportViewer1.LocalReport.SetParameters(customer_name);
                    reportViewer1.LocalReport.SetParameters(salnum);
                    reportViewer1.LocalReport.SetParameters(details);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }



            }
            else
            {
                MessageBox.Show("no data");
                return;
            }
            reportViewer1.RefreshReport();
        }

    }
}
