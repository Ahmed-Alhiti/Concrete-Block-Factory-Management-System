using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsExchangeprices
    {
        public int _Ex_id { set; get; }
        public int _Cur_id { set; get; }
        public decimal _Exchange_price { set; get; }
        public DateTime _Date { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsExchangeprices()
        {
            _Ex_id = -1;
            _Cur_id = -1;
            _Exchange_price = 0;
            _Date = DateTime.Now;


            Mode = enMode.AddNew;

        }

        private clsExchangeprices(int id, int Cur_id, decimal Exchange_price,DateTime Date)
        {
            this._Ex_id = id;
            this._Cur_id = Cur_id;
            this._Exchange_price = Exchange_price;
            this._Date = Date;
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Ex_id = clsExchangeprices_Data.AddNew(this._Cur_id, this._Exchange_price,this._Date);

            return (this._Ex_id > 0);
        }

        private bool _Update()
        {
            return clsExchangeprices_Data.Update(this._Ex_id, this._Cur_id, this._Exchange_price);
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

        public static clsExchangeprices Find_ByID(int id)
        {
            int Cur_id = -1;
            decimal Exchange_price = 0;
            DateTime Date = DateTime.Now;
            if (clsExchangeprices_Data.Find_ByID(id, ref Cur_id, ref Exchange_price,ref Date))
            {
                return new clsExchangeprices(id, Cur_id, Exchange_price,Date);
            }
            else
            {
                return null;
            }
        }
        public static clsExchangeprices Get_LastExchPrice(int Cur_id)
        {
            int id = -1;
            decimal Exchange_price = 0;
            DateTime Date = DateTime.Now;
            if (clsExchangeprices_Data.Get_LastExchangePrice(ref id,  Cur_id, ref Exchange_price,ref Date))
            {
                return new clsExchangeprices(id, Cur_id, Exchange_price,Date);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsExchangeprices_Data.Delete(id);
        }

        public static DataTable GetAll()
        {
            return clsExchangeprices_Data.GetAll();
        }
    }
}
