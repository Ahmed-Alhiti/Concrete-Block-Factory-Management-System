using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace Business
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;
        public int _Pay_ID { set; get; }
        public int _Sal_Number { set; get; }
        public int _User_ID { set; get; }
        public int _Ope_ID { set; get; }
        public int _Cus_ID { set; get; }
        public decimal _Amount { set; get; }
        public DateTime _Date { set; get; }

        public clsPayment()
        {
            this._Pay_ID = -1;
            this._Sal_Number = -1;
            this._User_ID = -1;
            this._Ope_ID = -1;
            this._Cus_ID = -1;
            this._Amount = 0;
            this._Date = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsPayment(int id, int Sal_ID,int User_ID, int Ope_ID,int Cus_ID, decimal Amount, DateTime date)
        {
            this._Pay_ID = id;
            this._Sal_Number = Sal_ID;
            this._User_ID = User_ID;
            this._Ope_ID = Ope_ID;
            this._Cus_ID = Cus_ID;
            this._Amount = Amount;
            this._Date = date;

            Mode = enMode.Update;
        }

        private bool _AddNew()
        {
            this._Pay_ID = clsPaymentData.AddNewPayment(this._Sal_Number, this._User_ID, this._Ope_ID, this._Cus_ID,this._Amount, this._Date);

            return (this._Pay_ID > 0);
        }

        private bool _Update()
        {
            return clsPaymentData.UpdatePayment(this._Pay_ID, this._Sal_Number, this._User_ID, this._Ope_ID,this._Cus_ID,this._Amount, this._Date);
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
            return clsPaymentData.DeletePayment(id);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }
        public static DataTable GetAllPayments(int Sale_number)
        {
            return clsPaymentData.GetAllPayments(Sale_number);
        }

        public static clsPayment Find_ByID(int id)
        {
            int Sal_ID = -1;
            int User_ID = -1;
            int Ope_ID = -1;
            int Cus_ID = -1;
            decimal Amount = 0;
            DateTime Date = DateTime.Now;

            if (clsPaymentData.FindPaymentByID(id,ref Sal_ID,ref User_ID,ref Ope_ID,ref Cus_ID, ref Amount,ref Date))
            {
                return new clsPayment(id,Sal_ID, User_ID, Ope_ID, Cus_ID, Amount, Date);
            }
            else
            {
                return null;
            }
        }

        public static bool IsBillHasPayment(int sal_num)
        {
            return clsPaymentData.isBillHasPayments(sal_num);
        }
        public static DataTable GetCustomer_Payments(int id)
        {
            return clsPaymentData.GetAllCusomer_Payments(id);
        }

    }
}
