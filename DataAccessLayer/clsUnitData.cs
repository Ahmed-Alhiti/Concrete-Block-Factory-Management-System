using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUnitData
    {
        public static int AddNewUnit(string Name)
        {
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Unit (Name)" +
                "VALUES" +
                "(@Name); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    return InsertedID;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return -1;

        }


        public static bool UpdateUnit(int id, string Name)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Unit
                SET Name = @Name
                WHERE Unit_id = @Unit_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Unit_id", id);
            command.Parameters.AddWithValue("@Name", Name);

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

        public static bool Delete(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Unit WHERE  Unit_id = @Unit_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Unit_id", id);

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

        public static DataTable GetAllTypies()
        {
            DataTable dtUnits = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Unit.Unit_id , Unit.Name as 'الوحدة' from Unit";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtUnits.Load(reader);
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
            return dtUnits;
        }


        public static bool FindUnit_ByID(int id, ref string Name)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Unit where Unit_id = @Unit_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Unit_id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Name = (string)reader["Name"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
