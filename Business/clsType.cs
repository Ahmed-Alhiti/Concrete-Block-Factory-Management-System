using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Business
{
    public class clsType
    {
        public int _ID { set; get; }
        public string _Called { set; get; }
        public int _Size { set; get; }
        public float _Price { set; get; }

        public enum enMode { AddNew=0 , Update=1};
        public enMode Mode = enMode.AddNew;
        public clsType()
        {
            _ID = -1;
            _Called = "";
            _Size = 0;
            _Price = 0;

            Mode = enMode.AddNew;

        }

        private clsType(int id,string called,int size,float price)
        {
            this._ID = id;
            this._Called = called;
            this._Size = size;
            this._Price = price;

            Mode = enMode.Update;
        }

        private bool _AddNewType()
        {
            this._ID = clsTypeData.AddNewType(this._Called, this._Size, this._Price);

            return (this._ID > 0);
        }

        private bool _UpdateType()
        {
            return clsTypeData.UpdateType(this._ID, this._Called, this._Size, this._Price);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateType();
            }
            return false; 
        }

        public static clsType FindType_ByID(int id)
        {
            string called = "";
            int size = 0;
            float price = 0;

            if(clsTypeData.FindType_ByID(id,ref called,ref size,ref price))
            {
                return new clsType(id, called, size, price);
            }
            else
            {
                return null;
            }
        }



        public static int FindType_Bymempervalue(int id)
        {
            string called = "";
            int size = 0;
            float price = 0;

            if (clsTypeData.FindType_ByID(id, ref called, ref size, ref price))
            {
                return id;
            }
            else
            {
                return 0;
            }
        }


        public static bool Delete(int id)
        {
            return clsTypeData.DeleteType(id);
        }

        public static DataTable GetAllTypies()
        {
            return clsTypeData.GetAllTypies();

        }
        public static DataTable search(string Search)
        {
            return clsTypeData.Search(Search);

        }
        
        public static bool Check(string Type_Name)
        {
            return clsTypeData.Check(Type_Name);
        }
        public static float GetPrice(int id)
        {
            return clsTypeData.GetPrice(id);

        }
    }
}
