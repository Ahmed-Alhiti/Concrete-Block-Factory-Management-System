using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsFunds
    {
        public int _ID { set; get; }
        public string _Name { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsFunds()
        {
            _ID = -1;
            _Name = "";

            Mode = enMode.AddNew;

        }

        private clsFunds(int id, string Name)
        {
            this._ID = id;
            this._Name = Name;
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._ID = clsFundsData.AddNew(this._Name);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsFundsData.Update(this._ID, this._Name);
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

        public static clsFunds Find_ByID(int id)
        {
            string Name = "";


            if (clsFundsData.FindFund(id ,ref Name))
            {
                return new clsFunds(id, Name);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsFundsData.Delete(id);
        }

        public static DataTable GetAllFunds()
        {
            return clsFundsData.GetAll();

        }
    }
}
