using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPaymentData
    {
        public static int AddNewPayment(int Sal_number, int User_ID, int Ope_ID,int Cus_ID, decimal Amount,DateTime Date)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Payment (Sal_number, User_ID, Ope_ID ,Cus_ID,Amount,Date)" +
                "VALUES" +
                "(@Sal_number, @User_ID, @Ope_ID ,@Cus_ID ,@Amount,@Date); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sal_number", Sal_number);
            command.Parameters.AddWithValue("@User_ID", User_ID);
            command.Parameters.AddWithValue("@Ope_ID", Ope_ID);
            command.Parameters.AddWithValue("@Cus_ID", Cus_ID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);



            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    id= InsertedID;
                }
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return id;

        }


        public static bool UpdatePayment(int id,int Sal_number, int User_ID, int Ope_ID,int Cus_ID, decimal Amount, DateTime Date)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Payment
                SET Sal_number = @Sal_number,
                User_ID =  @User_ID,
                Ope_ID = @Ope_ID,
                Cus_ID = @Cus_ID,
                Amount=@Amount,
                Date=@Date
                WHERE Pay_ID = @Pay_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Pay_ID", id);
            command.Parameters.AddWithValue("@Sal_number", Sal_number);
            command.Parameters.AddWithValue("@User_ID", User_ID);
            command.Parameters.AddWithValue("@Ope_ID", Ope_ID);
            command.Parameters.AddWithValue("@Cus_ID", Cus_ID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);


            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowseffected > 0);

        }

        public static bool DeletePayment(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Payment WHERE Pay_ID = @Pay_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Pay_ID", id);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowseffected > 0);
        }

        public static DataTable GetAllPayments()
        {
            DataTable dtPayments = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Payment.Pay_ID , Customer.Name as 'اسم الزبون',Operations.Name as 'العملية',
                               Payment.Amount as 'المبلغ المدفوع',Payment.Date as 'التاريخ',
                               Payment.Sal_number as 'رقم الفاتورة'
                               
                               from Payment inner join Users on Payment.User_ID = Users.User_id
                               inner join Operations on Payment.Ope_ID = Operations.Ope_ID
                               inner join Customer on Payment.Cus_ID = Customer.Cus_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPayments.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtPayments;
        }

        public static DataTable GetAllPayments(int sale_number)
        {
            DataTable dtPayments = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Payment.Pay_ID , Customer.Name as 'اسم الزبون',Operations.Name as 'العملية',
                               Payment.Amount as 'المبلغ المدفوع',Payment.Date as 'التاريخ',
                               Payment.Sal_number as 'رقم الفاتورة'
                               
                               from Payment inner join Users on Payment.User_ID = Users.User_id
                               inner join Operations on Payment.Ope_ID = Operations.Ope_ID
                               inner join Customer on Payment.Cus_ID = Customer.Cus_ID 
                               where Sal_number = @Sal_number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sal_number",sale_number);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPayments.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtPayments;
        }


        public static bool FindPaymentByID(int id,ref int Sal_number,ref int User_ID, ref int Ope_ID,ref int Cus_ID, ref decimal Amount,ref DateTime Date)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Payment where Pay_ID = @Pay_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Pay_ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Sal_number = (int)reader["Sal_number"];
                    User_ID = (int)reader["User_ID"];
                    Ope_ID = (int)reader["Ope_ID"];
                    Cus_ID = (int)reader["Cus_ID"];
                    Amount = (decimal)reader["Amount"];
                    Date= (DateTime)reader["Date"];

                }

                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
                isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

        public static DataTable GetAllCusomer_Payments(int id)
        {
            DataTable Customer_Pays = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Customer.Name as 'اسم الزبون',Operations.Name as 'العملية',
                               Payment.Amount as 'المبلغ المدفوع',Payment.Date as 'التاريخ',
                               Payment.Sal_number as 'رقم الفاتورة'
                               ,Users.User_Name 
                               from Payment inner join Users on Payment.User_ID= Users.User_id
                               inner join Operations on Payment.Ope_ID = Operations.Ope_ID
                               inner join Customer on Payment.Cus_ID = Customer.Cus_ID 
                               where Payment.Cus_ID = @Cus_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Customer_Pays.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Customer_Pays;
        }

        public static bool isBillHasPayments(int sal_number)
        {
            bool haspay = false;
            string query = @"select haspay = 1 from Payment where Sal_number = @Sal_number ";

            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sal_number", sal_number);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result == null)
                    haspay = false;
                else
                    haspay = true;

            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return haspay;
        }

    }
}
