using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsReceipts
    {
        public int _ID { set; get; }
        public int _RefNo { set; get; }
        public int _Cur_id { set; get; }
        public DateTime _Date { set; get; }
        public decimal _Total { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsReceipts()
        {
            _ID = -1;
            _RefNo = 0;
            _Date = DateTime.Now;
            _Total = 0;
            _Cur_id = -1;

            Mode = enMode.AddNew;

        }

        private clsReceipts(int id, int refno, DateTime date, decimal total, int cur_id)
        {
            this._ID = id;
            this._RefNo = refno;
            this._Date = date;
            this._Total = total;
            this._Cur_id = cur_id;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._ID = clsReceiptsData.AddNew(this._Cur_id, this._RefNo, this._Date, this._Total);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsReceiptsData.Update(this._ID, this._Cur_id ,this._Total);
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

        public static clsReceipts Find_ByID(int id)
        {
            int Cur_id = -1;
            int RefNo = 0;
            DateTime Date = DateTime.Now;
            decimal Total = 0;


            if (clsReceiptsData.FindReceiptsBill(id, ref Cur_id, ref RefNo, ref Date, ref Total))
            {
                return new clsReceipts(id, RefNo, Date, Total, Cur_id);
            }
            else
            {
                return null;
            }
        }
         public static clsReceipts Find_ByRefNo(int RefNo)
        {
            int Cur_id = -1;
            int id = -1;
            DateTime Date = DateTime.Now;
            decimal Total = 0;


            if (clsReceiptsData.FindReceiptsBillByRefNo(ref id, ref Cur_id, RefNo, ref Date, ref Total))
            {
                return new clsReceipts(id, RefNo, Date, Total, Cur_id);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsReceiptsData.Delete(id);
        }

        public static bool DeleteBy_RefNo(int RefNo)
        {
            return clsReceiptsData.DeleteByRefNo(RefNo);
        }

        public static DataTable GetAll()
        {
            return clsReceiptsData.GetAll();

        }
        public static int GetLastID()
        {
            return clsReceiptsData.GetLastId();
        }

        public static DataTable GetAll(int Cur_id)
        {
            return clsReceiptsData.GetAll(Cur_id);
        }
        public static DataTable GetAllByRefNo(int RefNo)
        {
            return clsReceiptsData.GetAllByRefNo(RefNo);
        }

        public static DataTable GetAll(int Cur_id,DateTime time1,DateTime time2)
        {
            return clsReceiptsData.GetAll(Cur_id,time1,time2);
        }

    }
}
