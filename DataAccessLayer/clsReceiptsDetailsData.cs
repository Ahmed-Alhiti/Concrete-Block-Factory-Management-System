
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsReceiptsDetailsData
    {
        public static int AddNew(int RefNo, int Cus_id, int Cur_id, int Exchagne_id, decimal Total, string Details)
        {
            int Id = -1;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO ReceiptsDetails (RefNo,Cus_id,Cur_id,Total,Exchagne_id,Details)" +
                "VALUES" +
                "( @RefNo,@Cus_id,@Cur_id,@Total,@Exchagne_id,@Details); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RefNo", RefNo);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
            command.Parameters.AddWithValue("@Total", Total);
            if (Exchagne_id == null)
            {
                command.Parameters.AddWithValue("@Exchagne_id", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Exchagne_id", Exchagne_id);
            }
            if (Details == null)
            {
                command.Parameters.AddWithValue("@Details", System.DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@Details", Details);
            }



            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Id = InsertedID;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return Id;

        }


        public static bool Update(int id, int Cus_id, int Cur_id, decimal Total, int Exchagne_id, string Details)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE ReceiptsDetails
                SET
                Cus_id =  @Cus_id,
                Cur_id = @Cur_id,
                Total = @Total,
                Exchagne_id = @Exchagne_id,
                Details = @Details
                WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
            command.Parameters.AddWithValue("@Total", Total);
            command.Parameters.AddWithValue("@Exchagne_id", Exchagne_id);
            command.Parameters.AddWithValue("@Details", Details);

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

        public static bool Delete(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "DELETE FROM ReceiptsDetails WHERE  ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();
            }
            catch
            {
                // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowseffected > 0);
        }
         public static bool DeleteByRefNo(int RefNo)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "DELETE FROM ReceiptsDetails WHERE  RefNo = @RefNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RefNo", RefNo);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowseffected > 0);
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAll(int RefNo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id 
                             where RefNo = @RefNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RefNo", RefNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAll(int Cus_id,DateTime time1,DateTime time2)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل',
                             vouchers.Date as 'التاريخ'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id 
                             inner join Receipts as vouchers on ReceiptsDetails.RefNo = vouchers.RefNo 
                             where ReceiptsDetails.Cus_id = @Cus_id and vouchers.Date between cast(@time1 as Date) and cast(@time2 as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@time1", time1);
            command.Parameters.AddWithValue("@time2", time2);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
       

         public static DataTable GetAllCustomerPay(int Cus_id)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل',
                             vouchers.Date as 'التاريخ'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id 
                             inner join Receipts as vouchers on ReceiptsDetails.RefNo = vouchers.RefNo 
                             where ReceiptsDetails.Cus_id = @Cus_id ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
         public static DataTable GetAllCustomerPay(int Cus_id,int Cur_id)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل',
                             vouchers.Date as 'التاريخ'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id 
                             inner join Receipts as vouchers on ReceiptsDetails.RefNo = vouchers.RefNo 
                             where ReceiptsDetails.Cus_id = @Cus_id and ReceiptsDetails.Cur_id = @Cur_id ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static DataTable GetAll(int cus_id,int Cur_id,DateTime time1,DateTime time2)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل',
                             vouchers.Date as 'التاريخ'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id 
                             inner join Receipts as vouchers on ReceiptsDetails.RefNo = vouchers.RefNo 

                             where ReceiptsDetails.Cur_id = @Cur_id and ReceiptsDetails.Cus_id = @Cus_id and
                             vouchers.Date between cast(@time1 as Date) and cast(@time2 as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
            command.Parameters.AddWithValue("@Cus_id", cus_id);
            command.Parameters.AddWithValue("@time1", time1);
            command.Parameters.AddWithValue("@time2", time2);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static DataTable GetAll(DateTime time1,DateTime time2)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ReceiptsDetails.ID,ReceiptsDetails.RefNo as 'رقم السند', Customer.Name as 'الزبون'
                             ,ReceiptsDetails.Total as 'المبلغ', Currencies.Called as 'العمله',
                             Exchange_prices.Exchange_price as 'سعر الصرف',
                             ReceiptsDetails.Details as 'التفاصيل',
                             vouchers.Date as 'التاريخ'
                             from ReceiptsDetails
                             inner join Customer on ReceiptsDetails.Cus_id = Customer.Cus_ID
                             inner join Currencies on ReceiptsDetails.Cur_id = Currencies.Cur_ID 
                             inner join Exchange_prices on ReceiptsDetails.Exchagne_id = Exchange_prices.Ex_id 
                             inner join Receipts as vouchers on ReceiptsDetails.RefNo = vouchers.RefNo 
                             where 
                             vouchers.Date between cast(@time1 as Date) and cast(@time2 as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@time1", time1);
            command.Parameters.AddWithValue("@time2", time2);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool FindByID(int id, ref int RefNo, ref int Cus_id, ref int Cur_id, ref decimal Total, ref int Exchagne_id, ref string Details)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from ReceiptsDetails where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    RefNo = (int)reader["RefNo"];
                    Cus_id = (int)reader["Cus_id"];
                    Cur_id = (int)reader["Cur_id"];
                    Exchagne_id = (int)reader["Exchagne_id"];
                    Total = Convert.ToDecimal(reader["Total"]);
                    Details = (string)reader["Details"];

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

    }
}
