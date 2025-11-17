using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsComponentsData
    {
        public static int AddNewComponent(int Blo_id, int unit_id, decimal unit_value,int mat_id)
        {
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Components (Bloc_id, Unit_id, Unit_value,Mat_id)" +
                "VALUES" +
                "( @Bloc_id,@Unit_id,@Unit_value,@Mat_id); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Bloc_id", Blo_id);
            command.Parameters.AddWithValue("@Unit_id", unit_id);
            command.Parameters.AddWithValue("@Unit_value", unit_value);
            command.Parameters.AddWithValue("@Mat_id", mat_id);

            

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


        public static bool UpdateComponent(int comp_id, int Blo_id, int unit_id, decimal unit_value, int mat_id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Components
                SET Bloc_id = @Bloc_id,
                Unit_id =  @Unit_id,
                Unit_value = @Unit_value,
                Mat_id=@Mat_id
                WHERE Comp_id = @Comp_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Comp_id", comp_id);
            command.Parameters.AddWithValue("@Bloc_id", Blo_id);
            command.Parameters.AddWithValue("@Unit_id", unit_id);
            command.Parameters.AddWithValue("@Unit_value", unit_value);
            command.Parameters.AddWithValue("@Mat_id", mat_id);

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

        public static bool DeleteComponent(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Components WHERE  Comp_id = @Comp_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Comp_id", id);

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

        public static DataTable GetAllComponents()
        {
            DataTable dComponents = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "Select * from Components";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dComponents.Load(reader);
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
            return dComponents;
        }
         public static DataTable GetAllComponents(int Bloc_id)
        {
            DataTable dComponents = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"Select Block_Type.Called as 'الصنف', Materials.Name as 'الخام', Unit.Name as 'وحدة القياس', 
                             Components.Unit_value 'كمية الخام في الصنف'
                             from Components
                             inner join Block_Type on Components.Bloc_id = Block_Type.Blo_ID
                             inner join Materials on Components.Mat_id = Materials.Mat_ID
                             inner join Unit on Components.Unit_id = Unit.Unit_id
                             where Bloc_id = @Bloc_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Bloc_id", Bloc_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dComponents.Load(reader);
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
            return dComponents;
        }


        public static bool FindByID(int comp_id, ref int Blo_id, ref int unit_id, ref decimal unit_value,ref int mat_id)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Components where Comp_id = @Comp_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Comp_id", comp_id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Blo_id = (int)reader["Bloc_id"];
                    unit_id = (int)reader["Unit_id"];
                    unit_value = Convert.ToDecimal(reader["Unit_value"]);
                    mat_id = (int)reader["Mat_id"];
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
         public static bool FindBlockComps(int comp_id, ref int Blo_id, ref int unit_id, ref decimal unit_value,ref int mat_id)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Components where Comp_id = @Comp_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Comp_id", comp_id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Blo_id = (int)reader["Comp_id"];
                    unit_id = (int)reader["Unit_id"];
                    unit_value = Convert.ToDecimal(reader["Unit_value"]);
                    mat_id = (int)reader["Mat_id"];
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


        public static bool IsTypeHasComponents(int id)
        {
            bool isfound = false;
            string query = "select found=1 from Components where Bloc_id = @Bloc_id";
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Bloc_id", id);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if(short.TryParse(result.ToString(),out short found))
                {
                    if (found == 1)
                        isfound = true;
                }

            }
            catch(Exception ex)
            {

            }
            finally
            {

                connection.Close();
            }
            return isfound;
        }
    }
}
