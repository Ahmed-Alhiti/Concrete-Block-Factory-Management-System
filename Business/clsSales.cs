using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsSales
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int _Sal_ID { set; get; }
        public int _Cus_ID { set; get; }
        
        public int _Create_By { set; get; }
        public DateTime _Craete_on { set; get; }
        public int _Update_By { set; get; }
        public DateTime _Update_on { set; get; }
        public int _Sale_Number { set; get; }
        public decimal _Total_Price { set; get; }
        public int _Block_Amount { set; get; }
        public string _Detailes { set; get; }





        public clsSales()
        {
            this._Sal_ID = -1;
            this._Cus_ID = -1;
            
            this._Create_By = -1;
            this._Craete_on = DateTime.Now;
            this._Sale_Number = 0;
            this._Total_Price = 0;
            this._Block_Amount = 0;
            this._Detailes = "";

            Mode = enMode.AddNew;
        }

        private clsSales(int id, int Cus_ID ,DateTime Craete_on ,int Sale_Number, decimal Total_Price, int Block_Amount,string Detailes)
        {
            this._Sal_ID = id;
            this._Cus_ID = Cus_ID;
            this._Craete_on = Craete_on;
            this._Sale_Number = Sale_Number;
            this._Total_Price = Total_Price;
            this._Block_Amount = Block_Amount;
            this._Detailes = Detailes;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Sal_ID = clsSalesData.AddNewSale(this._Cus_ID, this._Create_By,this._Craete_on, this._Sale_Number, this._Total_Price, this._Block_Amount,this._Detailes);

            return (this._Sal_ID > 0);
        }

        private bool _Update()
        {
            return clsSalesData.UpdateSale(this._Sal_ID,this._Cus_ID, this._Update_By,this._Update_on, this._Sale_Number, this._Total_Price, this._Block_Amount,this._Detailes);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        Mode = enMode.Update;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static bool Delete(int id)
        {
            return clsSalesData.DeleteSale(id);
        }
        public static bool DeleteByRefoNo(int RefNo)
        {
            return clsSalesData.DeleteSaleByRefNo(RefNo);
        }

        public static DataTable GetAllPostedSales()
        {
            return clsSalesData.GetAllPostedSales();
        }
        public static DataTable GetAllUnPostedSales()
        {
            return clsSalesData.GetAllUnPostSales();
        }
         public static DataTable GetAllSales()
        {
            return clsSalesData.GetAllSales();
        }

        public static int GetSumAllSales(DateTime from , DateTime to)
        {   
           return clsSalesData.GetSumAllSales(from,to);
        }
         public static int GetSumAllSales()
        {   
           return clsSalesData.GetSumAllSales();
        }
         public static DataTable GetAllPostedSales(DateTime from , DateTime to)
        {   
           return clsSalesData.GetAllPostedSales(from,to);
        }
         public static DataTable GetAllSales(DateTime from , DateTime to)
        {   
           return clsSalesData.GetAllSales(from,to);
        }

        public static DataTable GetAllUnPostedSales(DateTime from , DateTime to)
        {   
           return clsSalesData.GetAllUnPostedSales(from,to);
        }

        public static clsSales Find_ByID(int id)
        {
            int Cus_ID = -1;
            DateTime Sal_Date = DateTime.Now;
            int Sale_Number = 0;
            decimal Total_Price = 0;            
            short Block_Amount = 0;
            string Detailes = "";


            if (clsSalesData.FindSaleByID(id,ref Cus_ID,ref Sal_Date,ref Sale_Number,ref Total_Price,ref Block_Amount,ref Detailes))
            {
                return new clsSales(id,Cus_ID ,Sal_Date,Sale_Number,Total_Price,Block_Amount,Detailes);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetCustomerPostedSales(int id)
        {
            return clsSalesData.GetCustomerPostedSales(id);
        }
        public static DataTable GetCustomerUnPostedSales(int id)
        {
            return clsSalesData.GetCustomerUnPostedSales(id);
        }

        //public static DataTable GetCustomerPostedSales(int id,DateTime from,DateTime to)
        //{
        //    return clsSalesData.GetCustomerPostedSales(id,from,to);
        //}
        public static DataTable GetCustomerUnPostedSales(int id,DateTime from,DateTime to)
        {
            return clsSalesData.GetCustomerUnPostedSales(id,from,to);
        }

         public static int GetSumCustomerSales(int id)
        {
            return clsSalesData.GetSumCustomerSales(id);
        }
         public static int GetSumCustomerSales(int id,DateTime from,DateTime to)
        {
            return clsSalesData.GetSumCustomerSales(id,from,to);
        }

        public static DataTable GetAllSale_BySaleNumber(int sales_Number)
        {
            return clsSalesData.GetAllSaleBySaleNumber(sales_Number);

        }
        public static DataTable GetAllSales_BySaleNumber(int sales_Number)
        {
            return clsSalesData.GetAllSalesBySaleNumber(sales_Number);

        }
        public static DataTable Search(string search)
        {
            return clsSalesData.Search(search);
        }

        public static bool UpdateBill(int sal_num,int cust_id)
        {
            return clsSalesData.UpdateBill(cust_id, sal_num);

        }

        public static bool DeleteBill(int sal_num)
        {
            return clsSalesData.DeleteBill(sal_num);

        }

        public static DataTable GetSalesNumbers()
        {
            return clsSalesData.GetAllSalesNumbers();
        }
        public static DataTable GetSalesD(DateTime time1,DateTime time2)
        {
            return clsSalesData.GetSalesD(time1,time2);
        }

        public static DataTable GetSales()
        {
            return clsSalesData.GetSales();
        }
        public static DataTable GetTotalPrice(int sale_number)
        {
            return clsSalesData.GetTotalPrice(sale_number);
        }

        public static decimal GetBillTotal(int sal_num)
        {
            return clsSalesData.GetBillTotal(sal_num);

        }

        public static bool UpdateQtyAndTotal(int sal_num)
        {
            return clsSalesData.UpdateQtyAndTotalPrice(sal_num);

        }

        public static int GetLastID()
        {
            return clsSalesData.GetLastID();
        }
        public static int GetCustomer_id(int sale_number)
        {
            return clsSalesData.FindCustomerId_BySaleNumber(sale_number);
        }

        public static bool CheckPost(int Sale_num)
        {
            return clsSalesData.CheckPosted(Sale_num);
        }
         public static bool PostingBill(int Sale_num)
        {
            return clsSalesData.PostingBill(Sale_num);
        }
         public static bool UnPostingBill(int Sale_num)
        {
            return clsSalesData.UnPostBill(Sale_num);
        }


    }
}
