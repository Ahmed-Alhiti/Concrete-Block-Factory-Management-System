using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsUsers
    {
        public int _User_id { set; get; }
        public int _Emp_id { set; get; }
        public string _User_Name { set; get; }
        public string _Password { set; get; }
        public int _Per { set; get; }

        public bool _IsActive { set; get; }


        public enum enMode { AddNew=0,Update=1};

        public enMode Mode = enMode.AddNew;
        public enum enPermission { All =-1,Sales=1,Purch=2,Production=4}

        public clsUsers()
        {
            this._User_id = -1;
            this._Emp_id = -1;
            this._User_Name = "";
            this._Password = "";
            this._Per = 0;
            this._IsActive = false;
            Mode = enMode.AddNew;
        }

        private clsUsers(int id,int emp_id,string user_name,string password,int Per,bool isActive)
        {
            this._User_id = id;
            this._Emp_id = emp_id;
            this._User_Name = user_name;
            this._Password = password;
            this._Per = Per;
            this._IsActive = isActive;
            Mode = enMode.Update;
        }

      

        private bool _AddNew()
        {
            this._User_id = clsUsersData.AddNewUser(this._Emp_id, this._User_Name, this._Password,this._Per,this._IsActive);
            return (_User_id > 0);
        }

        private bool _Update()
        {
            return clsUsersData.UpdateUser(this._User_id, this._Emp_id, this._User_Name, this._Password,this._Per,this._IsActive);
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


        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static clsUsers Find_ByID(int id)
        {
            int emp_id = -1;
            string user_name = "";
            string password = "";
            int Per = 0;
            bool is_active = false;

            if(clsUsersData.FindUserByID(id,ref emp_id,ref user_name,ref password,ref Per,ref is_active))
            {
                return new clsUsers(id, emp_id, user_name, password,Per,is_active);
            }
            else
            {
                return null;
            }
        }

       

        public static clsUsers Find_ByUserName_andPassword(string User_name , string Password)
        {
            int id = -1;
            int emp_id = -1;
            int Per = 0;
            bool is_active = false;

            if (clsUsersData.FindUserByUserName_andPassword(User_name,Password,ref id,ref emp_id,ref Per,ref is_active))
            {
                if (is_active == false)
                    return null;

                return new clsUsers(id, emp_id, User_name, Password, Per, is_active);
            }
            else
            {
                return null;
            }
        }


        public static bool Check_Access(int per , enPermission permission)
        {
            if (per == (int)enPermission.All)
                return true;
            if (((int)permission & per) == (int)permission)
                return true;
            return false;
        }

        public static bool UpdateUserPassword(int id,string Password)
        {
            return clsUsersData.UpdateUserPassword(id, Password);

        }

        public static string FindUserNameByID(int id)
        {
            return clsUsersData.FindUserNameID(id);

        }
    }
}
