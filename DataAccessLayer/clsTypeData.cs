using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsTypeData
    {
        public static int AddNewType(string called , int size , float price)
        {
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Block_Type (Called, Size, Price)" +
                "VALUES" +
                "( @called,@size,@Price); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@called", called);
            command.Parameters.AddWithValue("@size", size);

            if (price != null)
            {
                command.Parameters.AddWithValue("@Price", price);
            }
            else
            {
                command.Parameters.AddWithValue("@Price", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    return InsertedID;
                }
                else
                {
                    return -1;
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
            return -1;

        }


        public static bool UpdateType(int id, string called, int size, float price)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Block_Type
                SET Called = @Called,
                Size =  @Size,
                Price = @Price
                WHERE Blo_ID = @Blo_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Blo_ID", id);
            command.Parameters.AddWithValue("@Called", called);
            command.Parameters.AddWithValue("@Size", size);

            if(price != null)
            {
                command.Parameters.AddWithValue("@Price", price);
            }
            else
            {
                command.Parameters.AddWithValue("@Price", System.DBNull.Value);
            }
            
            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowseffected > 0);

        }

        public static bool DeleteType (int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Block_Type WHERE  Blo_ID = @Blo_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Blo_ID", id);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return (rowseffected > 0);
        }
        
        public static DataTable GetAllTypies()
        {
            DataTable dtTypies = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Block_Type.Blo_ID,Block_Type.Called as 'اسم الصنف',Block_Type.Price as 'سعر الصنف',
                             Block_Type.Size as 'المقاس' from Block_Type";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtTypies.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtTypies;
        }
        
        public static DataTable Search(string search)
        {
            DataTable dtTypies = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select * from Block_Type where CONCAT(Block_Type.Called,Block_Type.Price,Block_Type.Size)
                              like '%"+search+"%'";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtTypies.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtTypies;
        }
        

        public static bool FindType_ByID(int id ,ref string called ,ref int size ,ref float price)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Block_Type where Blo_ID = @Blo_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Blo_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    isfound = true;
                    called = (string)reader["Called"];
                    size = (int)reader["Size"];

                    if (reader["Price"] != null)
                        price = Convert.ToSingle(reader["Price"]);
                    else
                        price = 0;
                   
                }
                reader.Close();
            }
            catch(Exception ex)
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

        public static float GetPrice(int id)
        {
            float Price = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Price from Block_Type where Blo_ID = @Blo_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Blo_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    
                    if (reader["Price"] != null)
                        Price = Convert.ToSingle(reader["Price"]);
                    
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return Price;
        }

        public static bool Check(string Name)
        {
            bool isFound = false;
            string query = "select Found = 1  from Block_Type where Block_Type.Called = @Called ";
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Called", Name);
            
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
