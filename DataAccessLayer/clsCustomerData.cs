using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCustomerData
    {
        public static int AddNewCustomer(string Name, string Phone)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Customer (Name, Phone)" +
                "VALUES" +
                "( @Name,@Phone); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            

            if (Phone != null)
            {
                command.Parameters.AddWithValue("@Phone", Phone);
            }
            else
            {
                command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
            }

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
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return id;

        }


        public static bool UpdateCustomer(int id, string Name, string Phone)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Customer
                SET Name = @Name,
                Phone =  @Phone
                WHERE Cus_ID = @Cus_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cus_ID", id);
            command.Parameters.AddWithValue("@Name", Name);
            

            if (Phone != null)
            {
                command.Parameters.AddWithValue("@Phone", Phone);
            }
            else
            {
                command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
            }

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

        public static bool DeleteCustomer(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Customer WHERE Cus_ID = @Cus_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cus_ID", id);

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

        public static DataTable GetAllCustomers()
        {
            DataTable dtCustomers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"Select Cus_ID,Customer.Name as 'اسم العميل',Customer.Phone as 'رقم الهاتف' from Customer";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCustomers.Load(reader);
                }
                reader.Close();
            }
            catch 
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCustomers;
        }

          public static DataTable GetAllCustomers(string search)
        {
            DataTable dtCustomers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"Select Cus_ID,Customer.Name as 'اسم العميل',Customer.Phone as 'رقم الهاتف' from Customer 
                             where Customer.Name  like '%" + search + "%' ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtCustomers.Load(reader);
                }
                reader.Close();
            }
            catch 
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCustomers;
        }


        public static bool FindCustomer_ByID(int id, ref string Name, ref string Phone)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Customer where Cus_ID = @Cus_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cus_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Name = (string)reader["Name"];
                    

                    if (reader["Phone"] != null)
                        Phone = (string)reader["Phone"];
                    else
                        Phone = "";

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


        public static bool Find_ByName(string name ,ref string Phone,ref int id)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "Select * from Customer where Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Phone = (string)reader["Phone"];
                    id = (int)reader["Cus_ID"];
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


            return isFound;
        }
    }
}
