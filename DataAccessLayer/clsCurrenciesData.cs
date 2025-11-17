using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class clsCurrenciesData
    {

        public static int AddNewCurrencie(string Called,string code)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            string query = "INSERT INTO Currencies " +
                "(Called,Code)" +
                "VALUES" +
                "(@Called,@Code);" +
                "select scope_identity()";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Called", Called);
            command.Parameters.AddWithValue("@Code", code);
            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    id = InsertedID;
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return id;

        }

        public static bool UpdateCurrencie(int id,string Called, string Code)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Currencies
                SET Called = @Called,
                Code =  @Code
                WHERE Cur_ID = @Cur_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cur_ID", id);
            command.Parameters.AddWithValue("@Called", Called);
            command.Parameters.AddWithValue("@Code", Code);
            
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


        public static bool DeleteCurrencie(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Currencies WHERE Cur_ID = @Cur_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cur_ID", id);

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


        public static DataTable GetAllCurrencies()
        {
            DataTable dtCurrencies = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Currencies.Cur_ID,Currencies.Called as 'اسم العمله',Currencies.Code as 'رمز العمله'
                                from Currencies";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCurrencies.Load(reader);
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
            return dtCurrencies;
        }


        public static bool FindCurrencies_ByID(int id, ref string Called, ref string Code)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Currencies where Cur_ID = @Cur_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cur_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Called = (string)reader["Called"];
                    Code = (string)reader["Code"];
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                isfound = false;
            }
            finally
            {
                connection.Close();
            }

            return isfound;
        }

        public static bool Check(string Called)
        {
            bool isFound = false;
            string query = "select Found = 1  from Currencies where Called = @Called ";
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Called", Called);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
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
            return isFound;
        }

    }
}
