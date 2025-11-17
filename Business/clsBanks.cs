using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsBanks
    {
        public int _ID { set; get; }
        public string _Name { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsBanks()
        {
            _ID = -1;
            _Name = "";

            Mode = enMode.AddNew;

        }

        private clsBanks(int id, string Name)
        {
            this._ID = id;
            this._Name = Name;
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._ID = clsBanksData.AddNew(this._Name);

            return (this._ID > 0);
        }

        private bool _Update()
        {
            return clsBanksData.Update(this._ID, this._Name);
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

        public static clsBanks Find_ByID(int id)
        {
            string Name = "";
            

            if (clsBanksData.FindBank(id, ref Name))
            {
                return new clsBanks(id, Name);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsBanksData.Delete(id);
        }

        public static DataTable GetAllBanks()
        {
            return clsBanksData.GetAll();

        }

    }
}
