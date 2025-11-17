using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsFundsData
    {

        public static int AddNew(string Name)
        {
            int Bank_Id = -1;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Funds (Name)" +
                "VALUES" +
                "( @Name); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Bank_Id = InsertedID;
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
            return Bank_Id;

        }


        public static bool Update(int id, string Name)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Funds
                SET
                Name =  @Name
                WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Name", Name);

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

            string query = "DELETE FROM Funds WHERE  ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);

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

        public static DataTable GetAll()
        {
            DataTable dtFunds = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Funds.ID,Funds.Name as 'اسم الصندوق' from Funds";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtFunds.Load(reader);
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
            return dtFunds;
        }


        public static bool FindFund(int id, ref string Name)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Funds where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

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
