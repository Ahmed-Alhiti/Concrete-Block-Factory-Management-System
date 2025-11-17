using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsStorage_stock
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int _Sto_ID { set; get; }
        public int _Block_id { set; get; }
        public short _Amount { set; get; }
        public DateTime _Date { set; get; }
        

        public clsStorage_stock()
        {
            this._Sto_ID = -1;
            this._Block_id = -1;
            this._Amount = 0;
            this._Date = DateTime.Now;
        
            

            Mode = enMode.AddNew;
        }

        private clsStorage_stock(int id, int Block_id, short Amount,DateTime date)
        {
            this._Sto_ID = id;
            this._Block_id = Block_id;
            this._Amount = Amount;
        
            this._Date = date;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Sto_ID = clsStorage_stockData.AddNewStorage_stock(this._Block_id, this._Amount, this._Date);

            return (this._Sto_ID > 0);
        }

        private bool _Update()
        {
            return clsStorage_stockData.UpdateStorage_stock(this._Sto_ID, this._Block_id, this._Amount, this._Date);
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
            return clsPaymentData.DeletePayment(id);
        }

        public static DataTable GetAllProduction()
        {
            return clsStorage_stockData.GetAllStorage_stock();
        }
        public static DataTable GetAllProduction(int Blo_id)
        {
            return clsStorage_stockData.GetAllStorage_stock(Blo_id);
        }
        public static int GetSum(int Blo_id)
        {
            return clsStorage_stockData.GetSum(Blo_id);
        }
        public static int GetSum()
        {
            return clsStorage_stockData.GetSum();
        }
        public static int GetSum(DateTime From , DateTime To)
        {
            return clsStorage_stockData.GetSum(From,To);
        }

        public static int GetSum(int Blo_id, DateTime From, DateTime To)
        {
            return clsStorage_stockData.GetSum(Blo_id,From,To);
        }

        public static DataTable GetAllProduction(DateTime Today)
        {
            return clsStorage_stockData.GetAllStorage_stock(Today);
        }
        public static DataTable GetAllProduction(int Blo_id,DateTime From , DateTime To)
        {
            return clsStorage_stockData.GetAllStorage_stock(Blo_id,From,To);
        }
         public static DataTable GetAllProduction(DateTime From , DateTime To)
        {
            return clsStorage_stockData.GetAllStorage_stock(From,To);
        }
         public static DataTable GetStockOnHand (int blo_id)
        {
            return clsStorage_stockData.GetStockOnHand(blo_id);
        }

        public static clsStorage_stock Find_ByID(int id)
        {
            int Block_id = -1;
            short Amount = 0;
            
            DateTime Date = DateTime.Now;

            if (clsStorage_stockData.FindStorage_stock(id,ref Block_id,ref Amount,ref Date))
            {
                return new clsStorage_stock(id,Block_id,Amount, Date);
            }
            else
            {
                return null;
            }


        }
    }
}
