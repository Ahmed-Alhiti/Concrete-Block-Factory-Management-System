using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsOperations
    {
        public enum enMode { AddNew = 0, Update };

        public enMode mode = enMode.AddNew;

        public int _Ope_ID { set; get; }
        public string _Name { set; get; }
        public clsOperations()
        {
            this._Ope_ID = -1;
            this._Name = "";

            mode = enMode.AddNew;
        }

        private clsOperations(int id, string name)
        {
            this._Ope_ID = id;
            this._Name = name;

            mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Ope_ID = clsOperationsData.AddNewOpration(this._Name);

            return (this._Ope_ID > 0);
        }

        private bool _Update()
        {
            return clsOperationsData.UpdateOpration(this._Ope_ID, this._Name);
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

        public static clsOperations Find_ByID(int id)
        {
            string Name = "";


            if (clsOperationsData.FindOpration_ByID(id,ref Name))
            {
                return new clsOperations(id, Name);
            }
            else
            {
                return null;
            }
        }

        public static bool Delete(int id)
        {
            return clsOperationsData.Delete(id);
        }

        public static DataTable GetAll()
        {
            return clsOperationsData.GetAllOperations();

        }
    }
}
