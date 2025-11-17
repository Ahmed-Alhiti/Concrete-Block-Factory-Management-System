using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsMaterials
    {
        public enum enMode { AddNew=0,Update};

        public enMode mode = enMode.AddNew;

        public int _ID { set; get; }
        public string _Name { set; get; }
        public clsMaterials()
        {
            this._ID = -1;
            this._Name = "";

            mode = enMode.AddNew;
        }

        private clsMaterials (int id , string name)
        {
            this._ID = id;
            this._Name = name;

            mode = enMode.Update;
        }

        private bool _AddNewMaterial()
        {
            this._ID = clsMaterialsData.AddNewMaterial(this._Name);

            return (this._ID > 0);
        }

        private bool _UpdateMaterial()
        {
            return clsMaterialsData.UpdateMaterial(this._ID, this._Name);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNewMaterial())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateMaterial();
            }
            return false;
        }

        public static clsMaterials FindMat_ByID(int id)
        {
            string Name = "";
            

            if (clsMaterialsData.FindMat_ByID(id,ref Name))
            {
                return new clsMaterials(id, Name);
            }
            else
            {
                return null;
            }
        }




        public static bool Delete(int id)
        {
            return clsMaterialsData.Delete(id);
        }

        public static DataTable GetAll()
        {
            return clsMaterialsData.GetAllMaterials();

        }
    }
}
