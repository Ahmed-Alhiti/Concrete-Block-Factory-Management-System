using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsExchangeprices_Data
    {

        public static int AddNew(int Cur_id, decimal Exchange_price, DateTime Date)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Exchange_prices (Cur_id,Exchange_price,Date)" +
                "VALUES" +
                "(@Cur_id,@Exchange_price,@Date); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
            command.Parameters.AddWithValue("@Exchange_price", Exchange_price);
            command.Parameters.AddWithValue("@Date", Date);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    id = InsertedID;
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


        public static bool Update(int id, int Cur_id, decimal Exchange_price)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Exchange_prices
                SET Cur_id = @Cur_id,
                Exchange_price = @Exchange_price
                WHERE Ex_id = @Ex_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Ex_id", id);
            command.Parameters.AddWithValue("@Cur_id",Cur_id);
            command.Parameters.AddWithValue("@Exchange_price", Exchange_price);

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

        public static bool Delete(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Exchange_prices WHERE  Ex_id = @Ex_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ex_id", id);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowseffected > 0);
        }

        public static DataTable GetAll()
        {
            DataTable dtMats = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Exchange_prices.Ex_id , Currencies.Called as 'العملة' , 
                             Exchange_prices.Exchange_price as 'سعر الصرف' ,Exchange_prices.Date as 'التاريخ' 
                             from Exchange_prices
                             inner join Currencies on Exchange_prices.Cur_id = Currencies.Cur_ID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtMats.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtMats;
        }


        public static bool Find_ByID(int id, ref int Cur_id, ref decimal Exchange_price,ref DateTime Date)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Exchange_prices where Ex_id = @Ex_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Ex_id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Cur_id = (int)reader["Cur_id"];
                    Exchange_price = (decimal)reader["Exchange_price"];
                    Date = (DateTime)reader["Date"];


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
        public static bool Get_LastExchangePrice(ref int id, int Cur_id, ref decimal Exchange_price,ref DateTime Date)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select top 1* from Exchange_prices where Cur_id = @Cur_id Order by Ex_id Desc ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cur_id", Cur_id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    id = (int)reader["Ex_id"];
                    Exchange_price = (decimal)reader["Exchange_price"];
                    Date = (DateTime)reader["Date"];
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
