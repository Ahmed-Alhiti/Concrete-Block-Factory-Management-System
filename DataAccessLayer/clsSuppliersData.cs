using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsSuppliersData
    {
        public static int AddNewSupplier(string Name, string Phone)
        {
            int Suplier_Id = -1;
            
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Suppliers (Name, Phone)" +
                "VALUES" +
                "( @Name,@Phone); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);
            

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Suplier_Id = InsertedID;
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
            return Suplier_Id;

        }


        public static bool UpdateSupplier(int id, string Name, string Phone)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Suppliers
                SET
                Name =  @Name,
                Phone = @Phone
                WHERE Sup_ID = @Sup_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sup_ID", id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Phone", Phone);

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

        public static bool DeleteSupplier(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "DELETE FROM Suppliers WHERE  Sup_ID = @Sup_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sup_ID", id);

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

        public static DataTable GetAllSuppliers()
        {
            DataTable dtSuppliers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Suppliers.Sup_ID,Suppliers.Name as 'اسم المورد',Suppliers.Phone as 'التلفون' from Suppliers";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSuppliers.Load(reader);
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
            return dtSuppliers;
        }
         public static DataTable GetAllSuppliers(string search)
        {
            DataTable dtSuppliers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Suppliers.Sup_ID,Suppliers.Name as 'اسم المورد',Suppliers.Phone as 'التلفون' from Suppliers where Suppliers.Name like '%" + search + "%'";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSuppliers.Load(reader);
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
            return dtSuppliers;
        }


        public static bool FindSupplier(int id, ref string Name, ref string Phone)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Suppliers where Sup_ID = @Sup_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sup_ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    Name = (string)reader["Name"];
                    Phone = (string)reader["Phone"];
                    
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

        public static int GetSupID_ByName(string name)
        {
            int id = -1;

            string query = "select Sup_ID from Suppliers where Name = @Name";
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            try
            {
                connection.Open();
                id = (int)command.ExecuteScalar();
            }
            catch
            {

            }
            finally
            {
                connection.Close();

            }
            return id;

        }
    }
}
