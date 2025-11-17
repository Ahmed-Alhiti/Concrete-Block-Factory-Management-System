using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsExchangeBills
    {
        public int _ID { set; get; }
        public int _RefNo { set; get; }
        public int _Cur_id { set; get; }
        public DateTime _Date { set; get; }
        public decimal _Total { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsExchangeBills()
        {
            _ID = -1;
            _RefNo = 0;
            _Date = DateTime.Now;
            _Total = 0;
            _Cur_id = -1;

            Mode = enMode.AddNew;

        }

        private clsExchangeBills(int id, int refno,DateTime date,decimal total,int cur_id)
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
            this._ID = clsExchangeBillsData.AddNew(this._Cur_id, this._RefNo, this._Date,this._Total);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsExchangeBillsData.Update(this._ID, this._Total);
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

        public static clsExchangeBills Find_ByID(int id)
        {
            int Cur_id = -1;
            int RefNo = 0;
            DateTime Date = DateTime.Now;
            decimal Total = 0;


            if (clsExchangeBillsData.FindExchangeBill(id,ref Cur_id, ref RefNo, ref Date, ref Total))
            {
                return new clsExchangeBills(id,RefNo,Date,Total,Cur_id);
            }
            else
            {
                return null;
            }
        }
         public static clsExchangeBills Find_ByRefNo(int RefNo)
        {
            int Cur_id = -1;
            int id = -1;
            DateTime Date = DateTime.Now;
            decimal Total = 0;


            if (clsExchangeBillsData.FindExchangeBill_RfNo(ref id,ref Cur_id, RefNo, ref Date, ref Total))
            {
                return new clsExchangeBills(id,RefNo,Date,Total,Cur_id);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsExchangeBillsData.Delete(id);
        }
        public static bool DeletByRefNo(int RefNo)
        {
            return clsExchangeBillsData.DeleteByRefNo(RefNo);
        }

        public static DataTable GetAll()
        {
            return clsExchangeBillsData.GetAll();
        }
        public static int GetLastID()
        {
            return clsExchangeBillsData.GetLastID();
        }

        public static DataTable GetAllByRefNo(int refno)
        {
            return clsExchangeBillsData.GetAllByRefNo(refno);
        }

        public static DataTable GetAll(int Cur_id)
        {
            return clsExchangeBillsData.GetAll(Cur_id);
        }
        public static DataTable GetAll(int Cur_id,DateTime time1,DateTime time2)
        {
            return clsExchangeBillsData.GetAll(Cur_id,time1,time2);
        }

    }
}
