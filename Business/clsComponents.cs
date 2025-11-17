using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;

namespace Business
{
    public class clsComponents
    {
        public enum enMode { AddNew =0 , Update = 1}

        public enMode mode = enMode.AddNew;

        public int _Comp_ID { set; get; }
        public int _Blo_id { set; get; }
        public int _Unit_id { set; get; }
        public decimal _Unit_value { set; get; }
        public int _Mat_id { set; get; }


        public clsComponents()
        {
            this._Comp_ID = -1;
            this._Blo_id = -1;
            this._Mat_id = -1;
            this._Unit_value = 0.0M;

            mode = enMode.AddNew;
        }

        public clsComponents(int comp_id,int blo_id,int unit_id,int mat_id, decimal unit_value)
        {
            this._Comp_ID = comp_id;
            this._Blo_id = blo_id;
            this._Mat_id = mat_id;
            this._Unit_id = unit_id;
            this._Unit_value = unit_value;

            mode = enMode.Update;
        }

         private bool _AddNewComponent()
        {
            this._Comp_ID = clsComponentsData.AddNewComponent(this._Blo_id, this._Unit_id, this._Unit_value, this._Mat_id);
            return (this._Comp_ID > 0);
        }


        private bool _UpdateComponent()
        {
            return clsComponentsData.UpdateComponent(this._Comp_ID, this._Blo_id, this._Unit_id, this._Unit_value, this._Mat_id);
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.AddNew:
                    if (_AddNewComponent())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateComponent();
            }
            return false;
        }

        public static DataTable GetAllComponents()
        {
            return clsComponentsData.GetAllComponents();
        }
        public static DataTable GetAllComponents(int Bloc_id)
        {
            return clsComponentsData.GetAllComponents(Bloc_id);
        }

        public static clsComponents FindByID(int id)
        {
            int blo_id = -1;
            int mat_id = -1;
            int unit_id = -1;
            decimal unit_value = 0.0M;

            if(clsComponentsData.FindByID(id,ref blo_id,ref unit_id,ref unit_value,ref mat_id))
            {
                return new clsComponents(id, blo_id, unit_id,mat_id ,unit_value );
            }
            else
            {
                return null;
            }

        }


        public static bool IsTypeHasComponents(int id)
        {
            return clsComponentsData.IsTypeHasComponents(id);
        }
        public static bool Delete(int id)
        {
            return clsComponentsData.DeleteComponent(id);
        }

    }
}
