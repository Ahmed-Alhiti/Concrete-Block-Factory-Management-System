using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsSale_Details
    {
        public int _id { set; get; }
        public int _Sale_Number { set; get; }
        public int _Block_ID { set; get; }
        public short _Block_Amount { set; get; }
        public float _Total_Price { set; get; }

        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public clsSale_Details()
        {
            this._id = -1;
            this._Sale_Number = 0;
            this._Block_ID = -1;
            this._Block_Amount = 0;
            this._Total_Price = 0;
            
            Mode = enMode.AddNew;
        }

        private clsSale_Details(int id, int Sale_Number, int Block_ID, short Block_Amount, float total_price)
        {
            this._id = id;
            this._Sale_Number = Sale_Number;
            this._Block_ID = Block_ID;
            this._Block_Amount = Block_Amount;
            this._Total_Price = total_price;
            
            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._id = clsSale_DetailsData.AddNewSale(this._Sale_Number,this._Block_ID,this._Block_Amount,this._Total_Price);

            return (this._id > 0);
        }

        private bool _Update()
        {
            return clsSale_DetailsData.Updateitem(this._id,this._Block_ID, this._Block_Amount, this._Total_Price);
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

        public static bool Delete(int id)
        {
            return clsSale_DetailsData.Deleteitem(id);
        }

        public static DataTable GetAllItems()
        {
            return clsSale_DetailsData.GetAllItems();
        }
        public static DataTable GetAllItems(int sal_num)
        {
            return clsSale_DetailsData.GetAllItems(sal_num);
        }
        public static DataTable GetAllItemSales(int blo_id)
        {
            return clsSale_DetailsData.GetAllItemSales(blo_id);
        }
        public static DataTable GetAllItemSales(int Blo_id,DateTime From , DateTime To)
        {
            return clsSale_DetailsData.GetAllItemSales(Blo_id,From,To);
        }
        public static DataTable GetAllCustomerItemSales(int Cus_id,int Blo_id,DateTime From , DateTime To)
        {
            return clsSale_DetailsData.GetAllCustomerItemSales(Cus_id,Blo_id,From,To);
        }
        public static DataTable GetAllCustomerItemSales(int Cus_id, int Blo_id)
        {
            return clsSale_DetailsData.GetAllCustomerItemSales(Cus_id, Blo_id);
        }

        public static int GetSumItemSales(int blo_id)
        {
            return clsSale_DetailsData.GetSumItemSales(blo_id);
        }
        public static int GetSumItemSales(int blo_id,DateTime From , DateTime To)
        {
            return clsSale_DetailsData.GetSumItemSales(blo_id,From,To);
        }
        public static int GetAllSumCustomerItemSales(int Cus_id,int blo_id,DateTime From , DateTime To)
        {
            return clsSale_DetailsData.GetAllSumCustomerItemSales(Cus_id,blo_id,From,To);
        }
        public static int GetAllSumCustomerItemSales(int Cus_id,int blo_id)
        {
            return clsSale_DetailsData.GetAllSumCustomerItemSales(Cus_id,blo_id);
        }

        public static clsSale_Details Find_ByID(int id)
        {
            int Sale_Number = 0;
            int Block_ID = -1;
            short Block_Amount = 0;
            float Total_Price = 0;
            
            if (clsSale_DetailsData.FindItemByID(id,ref Sale_Number,ref Block_ID,ref Block_Amount,ref Total_Price))
            {
                return new clsSale_Details(id,Sale_Number,Block_ID,Block_Amount,Total_Price);
            }
            else
            {
                return null;
            }
        }
    }
}
