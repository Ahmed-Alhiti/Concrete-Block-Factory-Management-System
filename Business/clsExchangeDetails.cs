using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsExchangeDetails
    {
        public int _ID { set; get; }
        public int _RefNo { set; get; }
        public int _Sup_id { set; get; }
        public int _Cur_id { set; get; }
        public int _Exchagne_id { set; get; }
        public decimal _Total { set; get; }
        public string _Details { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsExchangeDetails()
        {
            _ID = -1;
            _Sup_id = -1;
            _Cur_id = -1;
            _RefNo = 0;
            _Exchagne_id = -1;
            _Details = "";
            _Total = 0;
            

            Mode = enMode.AddNew;

        }

        private clsExchangeDetails(int id, int refno,int Sup_id,int Exchagne_id,string Details, decimal total, int cur_id)
        {
            this._ID = id;
            this._Sup_id = Sup_id;
            this._Cur_id = cur_id;
            this._RefNo = refno;
            this._Exchagne_id = Exchagne_id;
            this._Details = Details;
            this._Total = total;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._ID = clsExchangeDetailsData.AddNew(this._RefNo, this._Sup_id, this._Cur_id, this._Exchagne_id, this._Total, this._Details);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsExchangeDetailsData.Update(this._ID, this._Sup_id, this._Cur_id, this._Total, this._Exchagne_id, this._Details);
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

        public static clsExchangeDetails Find_ByID(int id)
        {
            int Cur_id = -1;
            int Sup_id = -1;
            int Exch_id = -1;
            int RefNo = 0;
            string Details = "";
            decimal Total = 0;


            if (clsExchangeDetailsData.FindByID(id,ref RefNo,ref Sup_id,ref Cur_id,ref Total,ref Exch_id,ref Details))
            {
                return new clsExchangeDetails(id,RefNo,Sup_id,Exch_id,Details,Total,Cur_id);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsExchangeDetailsData.Delete(id);
        }

        public static DataTable GetAll()
        {
            return clsExchangeDetailsData.GetAll();
        }
        public static DataTable GetAll(int RefNo)
        {
            return clsExchangeDetailsData.GetAll(RefNo);
        }

        public static DataTable GetAll(int Sup_id,int Cur_id)
        {
            return clsExchangeDetailsData.GetAll(Sup_id,Cur_id);
        }
        public static DataTable GetAll(int Sup_id,int Cur_id,DateTime time1,DateTime time2)
        {
            return clsExchangeDetailsData.GetAll(Sup_id,Cur_id,time1,time2);
        }
        public static DataTable GetAll(int Sup_id,DateTime time1,DateTime time2)
        {
            return clsExchangeDetailsData.GetAll(Sup_id,time1,time2);
        }

        public static DataTable GetAllSupExchBills(int Sup_id)
        {
            return clsExchangeDetailsData.GetAllSupExchBills(Sup_id);
        }
        public static DataTable GetAllSupExchBillsRe(int Sup_id)
        {
            return clsExchangeDetailsData.GetAllSupExchBillsRep(Sup_id);
        }

    }
}
