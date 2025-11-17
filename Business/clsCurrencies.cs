using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsCurrencies
    {
        public enum enMode { AddNew = 0, Update = 1};

        public enMode mode = enMode.AddNew;

        public int _Cur_ID { set; get; }
        
        public string _Called { set; get; }
        public string _Code { set; get; }
        

        public clsCurrencies()
        {
            this._Cur_ID = -1;
            
            this._Called = "";
            this._Code = "";

            mode = enMode.AddNew;
        }

        private clsCurrencies(int id,string called,string code)
        {
            this._Cur_ID = id;
            this._Called = called;
            this._Code = code;

            mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Cur_ID = clsCurrenciesData.AddNewCurrencie(this._Called, this._Code);

            return (this._Cur_ID > 0);
        }

        private bool _Update()
        {
            return clsCurrenciesData.UpdateCurrencie(this._Cur_ID, this._Called, this._Code);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNew())
                    {
                        mode = enMode.Update;
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

        public static clsCurrencies Find_ByID(int id)
        {
            
            string called = "";
            string code = "";
            


            if (clsCurrenciesData.FindCurrencies_ByID(id,ref called,ref code))
            {
                return new clsCurrencies(id,called,code);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsCurrenciesData.DeleteCurrencie(id);
        }

        public static DataTable GetAll()
        {
            return clsCurrenciesData.GetAllCurrencies();

        }
        public static bool Check(string Called)
        {
            return clsCurrenciesData.Check(Called);
        }
    }
}
