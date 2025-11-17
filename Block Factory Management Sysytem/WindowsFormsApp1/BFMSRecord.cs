using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class BFMSRecord : Form
    {
        public DataTable table { get; set; }


        public BFMSRecord()
        {
            InitializeComponent();
        }
       

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void LoadSupRecord(DataTable table)
        {
            if (table != null && table.Rows.Count > 0)
            {
                ReportDataSource dataSource = new ReportDataSource();
                dataSource.Name = "DataSet1";
                dataSource.Value = table;


                reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptSupReport.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                reportViewer1.RefreshReport();


            }
            else
            {
                MessageBox.Show("no data");
            }
        }
         public void LoadExchangeBillsRecord(DataTable table)
        {
            if (table != null && table.Rows.Count > 0)
            {
                ReportDataSource dataSource = new ReportDataSource();
                dataSource.Name = "DataSet1";
                dataSource.Value = table;


                reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptExchangeBillsRecord.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                reportViewer1.RefreshReport();


            }
            else
            {
                MessageBox.Show("no data");
            }
        }

         public void LoadSupPurRecord(DataTable table)
        {
            if (table != null && table.Rows.Count > 0)
            {
                ReportDataSource dataSource = new ReportDataSource();
                dataSource.Name = "DataSet1";
                dataSource.Value = table;


                reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptSupPurBillsRecord.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(dataSource);
                reportViewer1.RefreshReport();


            }
            else
            {
                MessageBox.Show("no data");
                return;
            }

        }

         public void LoadPurRecord(DataTable table , string param)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptPurRecord.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter parameter = new ReportParameter("Date", param);
                    reportViewer1.LocalReport.SetParameters(parameter);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
                

                reportViewer1.RefreshReport();


            }
            else
            {
                MessageBox.Show("no data");
            }
        }
         public void LoadReceiptsRecord(DataTable table , string param)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptReceiptsHist.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter parameter = new ReportParameter("Curr", param);
                    reportViewer1.LocalReport.SetParameters(parameter);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
                reportViewer1.RefreshReport();

            }
            else
            {
                MessageBox.Show("no data");
            }
        }
         public void LoadCusReceiptsRecord(DataTable table , string param)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptCusReceiptsHist.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter parameter = new ReportParameter("Cus_Name", param);
                    reportViewer1.LocalReport.SetParameters(parameter);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
                reportViewer1.RefreshReport();

            }
            else
            {
                MessageBox.Show("no data");
                return;
            }
            reportViewer1.RefreshReport();
        }
         public void LoadSalesRecord(DataTable table , string param ,string qty)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptSalesHist.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter parameter = new ReportParameter("Date", param);
                    ReportParameter Qty = new ReportParameter("Qty", qty);
                    reportViewer1.LocalReport.SetParameters(parameter);
                    reportViewer1.LocalReport.SetParameters(Qty);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
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
        public void LoadCustomerSalesRecord(DataTable table , string param)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptCustomerSalesHist.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter parameter = new ReportParameter("Date", param);
                    reportViewer1.LocalReport.SetParameters(parameter);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
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
        public void LoadCustomerItemSalesRecord(DataTable table , string param , string qty)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptCustomerItemSaleHist.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter parameter = new ReportParameter("Date", param);
                    ReportParameter Qty = new ReportParameter("Qty", qty);
                    reportViewer1.LocalReport.SetParameters(parameter);
                    reportViewer1.LocalReport.SetParameters(Qty);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
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

        public void LoadProductionHist(DataTable table , string Date,string Qty)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptProductionHist.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter pDate = new ReportParameter("Date", Date);
                    ReportParameter pQty = new ReportParameter("Qty", Qty);
                    reportViewer1.LocalReport.SetParameters(pDate);
                    reportViewer1.LocalReport.SetParameters(pQty);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
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
        public void LoadItemProductionRecord(DataTable table , string Date , string Qty)
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptItemProduction.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter pDate = new ReportParameter("Date", Date);
                    ReportParameter pQty = new ReportParameter("Qty", Qty);
                    reportViewer1.LocalReport.SetParameters(pDate);
                    reportViewer1.LocalReport.SetParameters(pQty);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
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
        public void LoadItemSalesRecord(DataTable table , string Date ,string qty )
        {
            if (table != null && table.Rows.Count > 0)
            {
                try
                {
                    ReportDataSource dataSource = new ReportDataSource();
                    dataSource.Name = "DataSet1";
                    dataSource.Value = table;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\مشروع التخرج\Block Factory Management Sysytem\WindowsFormsApp1\rptItemSalesRecord.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    ReportParameter pDate = new ReportParameter("Date", Date);
                    ReportParameter Qty = new ReportParameter("Qty", qty);
                    reportViewer1.LocalReport.SetParameters(pDate);
                    reportViewer1.LocalReport.SetParameters(Qty);
                    reportViewer1.LocalReport.DataSources.Add(dataSource);
                
         
                }
                catch(Exception ex)
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

        private void BFMSRecord_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
