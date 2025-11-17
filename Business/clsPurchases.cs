using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsPurchases
    {
        public enum enMode { AddNew=0,Update=1}
        public enMode Mode = enMode.AddNew;
        public int _ID { set; get; }
        public int _Sup_ID { set; get; }
        
        public decimal _Price { set; get; }
        public decimal _Total_Mat_Amount { set; get; }
        public int _Create_By { set; get; }
        public DateTime _Create_on { set; get; }
        public int _Update_By { set; get; }
        public DateTime _Update_on { set; get; }
        
        public int _Mat_ID { set; get; }
        public int _Unit_ID { set; get; }

        public clsPurchases()
        {
            this._ID = -1;
            this._Sup_ID  = -1;
            this._Create_By = -1;
            this._Create_on = DateTime.Now;
            
            this._Mat_ID = -1;
            this._Unit_ID = -1;
            this._Total_Mat_Amount = 0;
            this._Price = 0;

            Mode = enMode.AddNew;
        }

        private clsPurchases(int id,int mat_id,int Unit_ID, int sup_id,decimal mat_amount,decimal price , DateTime date)
        {
            this._ID = id;
            this._Create_on = date;
            this._Sup_ID = sup_id;
            this._Mat_ID = mat_id;
            this._Unit_ID = Unit_ID;
            this._Total_Mat_Amount = mat_amount;
            this._Price = price;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._ID = clsPurchasesData.AddNewPurchases(this._Sup_ID, this._Mat_ID,this._Unit_ID ,this._Create_By,this._Create_on, this._Price, this._Total_Mat_Amount);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsPurchasesData.UpdatePurchases(this._ID,this._Sup_ID, this._Mat_ID,this._Unit_ID,this._Update_By,this._Update_on, this._Price, this._Total_Mat_Amount);
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
            return clsPurchasesData.DeletePurchases(id);
        }

        public static DataTable GetAllPurchases()
        {
            return clsPurchasesData.GetAllPurchases();
        }

        public static DataTable GetAllPurchases(DateTime from,DateTime to)
        {
            return clsPurchasesData.GetAllPurchases(from,to);
        }


        public static DataTable GetAllSupplierPurchases(int sup_id)
        {
            return clsPurchasesData.GetAllSupplierPurchases(sup_id);
        }

        public static DataTable GetAllSupplierPurchases(int sup_id,DateTime from ,DateTime to)
        {
            return clsPurchasesData.GetAllSupplierPurchases(sup_id,from,to);
        }
        public static DataTable GetPurchasesD(DateTime from ,DateTime to)
        {
            return clsPurchasesData.GetPurD(from,to);
        }




        public static clsPurchases Find_ByID(int id)
        {
            int Sup_ID = -1;
            int Mat_ID = -1;
            int Unit_id = -1;
            DateTime date = DateTime.Now;
            decimal Total_Mat_Amount = 0;
            decimal Price = 0;

            if (clsPurchasesData.FindByID(id, ref Sup_ID, ref Mat_ID, ref Unit_id, ref Price, ref Total_Mat_Amount,ref date))
            {
                return new clsPurchases(id,Mat_ID,Unit_id,Sup_ID,Total_Mat_Amount,Price,date);
            }
            else
            {
                return null;
            }


        }

         public static clsPurchases Findlast(int mat_id)
         {
            int Sup_ID = -1;
            int id = -1;
            int Unit_id = -1;
            DateTime date = DateTime.Now;
            decimal Total_Mat_Amount = 0;
            decimal Price = 0;

            if (clsPurchasesData.Findlast(ref id, ref Sup_ID, mat_id, ref Unit_id, ref Price, ref Total_Mat_Amount,ref date))
            {
                return new clsPurchases(id, mat_id, Unit_id,Sup_ID,Total_Mat_Amount,Price,date);
            }
            else
            {
                return null;
            }


         }

        public static decimal GetLastPrice(int Mat_id)
        {
            return clsPurchasesData.GetLastPrice(Mat_id);

        }

        public static DataTable Search(string search)
        {
            return clsPurchasesData.SearhPurchases(search);

        }

    }


}
