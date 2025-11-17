using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsMaterialsData
    {
        public static int AddNewMaterial(string Name)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Materials (Name)" +
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


        public static bool UpdateMaterial(int id, string Name)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Materials
                SET Name = @Name
                WHERE Mat_ID = @Mat_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Mat_ID", id);
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

            string query = @"DELETE FROM Materials WHERE  Mat_ID = @Mat_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Mat_ID", id);

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

        public static DataTable GetAllMaterials()
        {
            DataTable dtMats = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Materials.Mat_ID , Materials.Name as 'الخام' from Materials";

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


        public static bool FindMat_ByID(int id, ref string Name)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Materials where Mat_ID = @Mat_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Mat_ID", id);
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
