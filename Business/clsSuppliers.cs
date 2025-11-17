using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsSuppliers
    {
        public int _Sup_ID { set; get; }
        public string _Name { set; get; }
        public string _Phone { set; get; }
        

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsSuppliers()
        {
            _Sup_ID = -1;
            _Name = "";
            _Phone = "";
            

            Mode = enMode.AddNew;

        }

        private clsSuppliers(int id, string Name, string Phone)
        {
            this._Sup_ID = id;
            this._Name = Name;
            this._Phone = Phone;
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Sup_ID = clsSuppliersData.AddNewSupplier(this._Name, this._Phone);

            return (this._Sup_ID > 0);
        }

        private bool _Update()
        {
            return clsSuppliersData.UpdateSupplier(this._Sup_ID, this._Name, this._Phone);
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

        public static clsSuppliers Find_ByID(int id)
        {
            string Name = "";
            string Phone = "";

            if (clsSuppliersData.FindSupplier(id,ref Name,ref Phone))
            {
                return new clsSuppliers(id, Name, Phone);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsSuppliersData.DeleteSupplier(id);
        }

        public static DataTable GetAllSuppliers()
        {
            return clsSuppliersData.GetAllSuppliers();

        }
         public static DataTable GetAllSuppliers(string search)
        {
            return clsSuppliersData.GetAllSuppliers(search);

        }

        public static int GetSupplierID_ByName(string name)
        {
            return clsSuppliersData.GetSupID_ByName(name);


        }
    }
}
