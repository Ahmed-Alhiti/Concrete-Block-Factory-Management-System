using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsEmployee
    {
        public int _ID { set; get; }
        public string _Name { set; get; }
        public string _Phone { set; get; }
        public int _Manage_By { set; get; }
        public decimal _Salary { set; get; }


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsEmployee()
        {
            _ID = -1;
            _Name = "";
            _Phone = "";
            _Manage_By = -1;
            _Salary = 0;


            Mode = enMode.AddNew;

        }

        private clsEmployee(int id, string Name, string Phone,int Manage_By,decimal Salary)
        {
            this._ID = id;
            this._Name = Name;
            this._Phone = Phone;
            this._Manage_By = Manage_By;
            this._Salary = Salary;

            Mode = enMode.Update;
        }

        private bool _AddNewEmployee()
        {
            this._ID = clsEmployeeData.AddNewEmployee(this._Name, this._Phone,this._Manage_By,this._Salary);

            return (this._ID > 0);
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeeData.UpdateEmployee(this._ID, this._Name, this._Phone,this._Manage_By,this._Salary);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateEmployee();
            }
            return false;
        }

        public static clsEmployee FindEmployee_ByID(int id)
        {
            string Name = "";
            string Phone = "";
            int Manage_By =
                -1;
            decimal Salary = 0;

            if (clsEmployeeData.FindEmployee_ByID(id, ref Name, ref Phone,ref Manage_By,ref Salary))
            {
                return new clsEmployee(id, Name, Phone,Manage_By,Salary);
            }
            else
            {
                return null;
            }
        }

        public static int FindManegar_ByID(int id)
        {
            string Name = "";
            string Phone = "";
            int Manage_By =
                -1;
            decimal Salary = 0;

            if (clsEmployeeData.FindEmployee_ByID(id, ref Name, ref Phone, ref Manage_By, ref Salary))
            {
                return id;
            }
            else
            {
                return 0;
            }


        }

        public static bool DeleteEmployee(int id)
        {
            return clsEmployeeData.DeleteEmployee(id);
        }

        public static DataTable GetAllEmployees()
        {
            return clsEmployeeData.GetAllEmployies();

        }
        public static DataTable GetAllEmployees(string search)
        {
            return clsEmployeeData.GetAllEmployies(search);
        }

        public static clsEmployee FindEmployee_ByName(string name)
        {
            int id = -1;
            int manage_id = -1;
            decimal salary = 0;
            string phone = "";
            if(clsEmployeeData.FindEmployee_ByName(name,ref id,ref phone,ref manage_id,ref salary))
            {
                return new clsEmployee(id, name, phone, manage_id, salary);
            }
            return null;
        }

        public static DataTable GetAllEmps()
        {
            return clsEmployeeData.GetAllEmps();

        }

        public static int GetEmpID_byName(string name)
        {
            return clsEmployeeData.GetEmpID_ByName(name);

        }

        public static string GetManagerName_ByID(int id)
        {
            return clsEmployeeData.GetManagerName_ByID(id);

        }
    }
}
