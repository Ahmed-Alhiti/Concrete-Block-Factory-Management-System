using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsUnit
    {
        public enum enMode { AddNew = 0, Update };

        public enMode mode = enMode.AddNew;

        public int _ID { set; get; }
        public string _Name { set; get; }
        public clsUnit()
        {
            this._ID = -1;
            this._Name = "";

            mode = enMode.AddNew;
        }

        private clsUnit(int id, string name)
        {
            this._ID = id;
            this._Name = name;

            mode = enMode.Update;
        }

        private bool _AddNewUnit()
        {
            this._ID = clsUnitData.AddNewUnit(this._Name);

            return (this._ID > 0);
        }

        private bool _UpdateUnit()
        {
            return clsUnitData.UpdateUnit(this._ID, this._Name);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNewUnit())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUnit();
            }
            return false;
        }

        public static clsUnit FindUnit_ByID(int id)
        {
            string Name = "";


            if (clsUnitData.FindUnit_ByID(id,ref Name))
            {
                return new clsUnit(id, Name);
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetAll()
        {
            return clsUnitData.GetAllTypies();

        }

        public static bool Delete(int id)
        {
            return clsUnitData.Delete(id);
        }

    }
}
