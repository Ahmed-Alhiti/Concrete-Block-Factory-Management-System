using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsReceiptsDetails
    {
        public int _ID { set; get; }
        public int _RefNo { set; get; }
        public int _Cus_id { set; get; }
        public int _Cur_id { set; get; }
        public int _Exchagne_id { set; get; }
        public decimal _Total { set; get; }
        public string _Details { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsReceiptsDetails()
        {
            _ID = -1;
            _Cus_id = -1;
            _Cur_id = -1;
            _RefNo = 0;
            _Exchagne_id = -1;
            _Details = "";
            _Total = 0;


            Mode = enMode.AddNew;

        }

        private clsReceiptsDetails(int id, int refno, int Cus_id, int Exchagne_id, string Details, decimal total, int cur_id)
        {
            this._ID = id;
            this._Cus_id = Cus_id;
            this._Cur_id = cur_id;
            this._RefNo = refno;
            this._Exchagne_id = Exchagne_id;
            this._Details = Details;
            this._Total = total;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._ID = clsReceiptsDetailsData.AddNew(this._RefNo, this._Cus_id, this._Cur_id, this._Exchagne_id, this._Total, this._Details);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsReceiptsDetailsData.Update(this._ID, this._Cus_id, this._Cur_id, this._Total, this._Exchagne_id, this._Details);
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

        public static clsReceiptsDetails Find_ByID(int id)
        {
            int Cur_id = -1;
            int Cus_id = -1;
            int Exch_id = -1;
            int RefNo = 0;
            string Details = "";
            decimal Total = 0;


            if (clsReceiptsDetailsData.FindByID(id, ref RefNo, ref Cus_id, ref Cur_id, ref Total, ref Exch_id, ref Details))
            {
                return new clsReceiptsDetails(id, RefNo, Cus_id, Exch_id, Details, Total, Cur_id);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsReceiptsDetailsData.Delete(id);
        }
         public static bool DeleteByRefNo(int RefNo)
        {
            return clsReceiptsDetailsData.DeleteByRefNo(RefNo);
        }

        public static DataTable GetAll()
        {
            return clsReceiptsDetailsData.GetAll();

        }

        public static DataTable GetAll(int RefNo)
        {
            return clsReceiptsDetailsData.GetAll(RefNo);
        }

        public static DataTable GetAll(int Cus_id,int Cur_id,DateTime time1,DateTime time2)
        {
            return clsReceiptsDetailsData.GetAll(Cus_id,Cur_id,time1,time2);
        }

        public static DataTable GetAll(int Cus_id,DateTime time1,DateTime time2)
        {
            return clsReceiptsDetailsData.GetAll(Cus_id,time1,time2);
        }
        public static DataTable GetAllCutomerPay(int Cus_id)
        {
            return clsReceiptsDetailsData.GetAllCustomerPay(Cus_id);
        }
         public static DataTable GetAllCutomerPay(int Cus_id,int Cur_id)
        {
            return clsReceiptsDetailsData.GetAllCustomerPay(Cus_id,Cur_id);
        }




         public static DataTable GetAll(DateTime time1,DateTime time2)
        {
            return clsReceiptsDetailsData.GetAll(time1,time2);
        }

    }
}
