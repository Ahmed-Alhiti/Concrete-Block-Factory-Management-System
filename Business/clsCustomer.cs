using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsCustomer
    {
        public int _ID { set; get; }
        public string _Name { set; get; }
        public string _Phone { set; get; }
        

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsCustomer()
        {
            _ID = -1;
            _Name = "";
            _Phone = "";
            

            Mode = enMode.AddNew;

        }

        private clsCustomer(int id, string Name, string Phone)
        {
            this._ID = id;
            this._Name = Name;
            this._Phone = Phone;
            Mode = enMode.Update;
        }

        private bool _AddNewCustomer()
        {
            this._ID = clsCustomerData.AddNewCustomer(this._Name, this._Phone);

            return (this._ID > 0);
        }

        private bool _UpdateCustomer()
        {
            return clsCustomerData.UpdateCustomer(this._ID, this._Name, this._Phone);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCustomer();
            }
            return false;
        }

        public static clsCustomer FindCustomer_ByID(int id)
        {
            string Name = "";
            string Phone = "";

            if (clsCustomerData.FindCustomer_ByID(id, ref Name, ref Phone))
            {
                return new clsCustomer(id, Name, Phone);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsCustomerData.DeleteCustomer(id);
        }

        public static clsCustomer Find_ByName(string name)
        {
            int id = -1;
            string phone = "";

            if(clsCustomerData.Find_ByName(name,ref phone,ref id))
            {
                return new clsCustomer(id, name, phone);
            }
            return null;

        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerData.GetAllCustomers();

        }
        public static DataTable GetAllCustomers(string search)
        {
            return clsCustomerData.GetAllCustomers(search);

        }

    }
}
