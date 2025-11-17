using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsExchangeBillsData
    {
        public static int AddNew(int Cur_id, int RefNo,DateTime Date,decimal Total)
        {
            int Bill_Id = -1;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO ExchangeBills (RefNo,Date,Total,Cur_id)" +
                "VALUES" +
                "(@RefNo,@Date,@Total,@Cur_id); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@RefNo", RefNo);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Total", Total);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Bill_Id = InsertedID;
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
            return Bill_Id;

        }


        public static bool Update(int id, decimal Total)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE ExchangeBills
                SET
                Total =  @Total
                WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Total", Total);

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

            string query = "DELETE FROM ExchangeBills WHERE  ID = @ID";

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
        public static bool DeleteByRefNo(int RefNo)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "DELETE FROM ExchangeBills WHERE  RefNo = @RefNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RefNo", RefNo);

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
            DataTable dtSuppliers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ExchangeBills.ID,ExchangeBills.RefNo as 'رقم السند',ExchangeBills.Date as 'تاريخ السند',
                                ExchangeBills.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from ExchangeBills 
                                inner join Currencies on Currencies.Cur_ID = ExchangeBills.Cur_id ";

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
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtSuppliers;
        }
        public static int GetLastID()
        {
            int id = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select top 1 ExchangeBills.ID from ExchangeBills order by ExchangeBills.ID DESC ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int returnedID))
                {
                    id = returnedID;
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

        public static DataTable GetAll(int Cur_id , DateTime time1,DateTime time2)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ExchangeBills.ID,ExchangeBills.RefNo as 'رقم السند',ExchangeBills.Date as 'تاريخ السند',
                                ExchangeBills.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from ExchangeBills 
                                inner join Currencies on Currencies.Cur_ID = ExchangeBills.Cur_id
                                where ExchangeBills.Cur_id = @Cur_id and ExchangeBills.Date between cast(@time1 as Date) and cast(@time2 as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
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
        public static DataTable GetAll(int Cur_id )
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ExchangeBills.ID,ExchangeBills.RefNo as 'رقم السند',ExchangeBills.Date as 'تاريخ السند',
                                ExchangeBills.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from ExchangeBills 
                                inner join Currencies on Currencies.Cur_ID = ExchangeBills.Cur_id
                                where  ExchangeBills.Cur_id = @Cur_id ";

            SqlCommand command = new SqlCommand(query, connection);
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
         public static DataTable GetAllByRefNo(int RefNo )
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select ExchangeBills.ID,ExchangeBills.RefNo as 'رقم السند',ExchangeBills.Date as 'تاريخ السند',
                                ExchangeBills.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from ExchangeBills 
                                inner join Currencies on Currencies.Cur_ID = ExchangeBills.Cur_id
                                where ExchangeBills.RefNo = @RefNo ";

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


        public static bool FindExchangeBill(int id, ref int Cur_id, ref int RefNo, ref DateTime Date, ref decimal Total)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from ExchangeBills where ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    Cur_id = (int)reader["Cur_id"];
                    RefNo = (int)reader["RefNo"];
                    Date = (DateTime)reader["Date"];
                    Total = Convert.ToDecimal(reader["Total"]);

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
        public static bool FindExchangeBill_RfNo(ref int id, ref int Cur_id,  int RefNo, ref DateTime Date, ref decimal Total)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from ExchangeBills where RefNo = @RefNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@RefNo", RefNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    Cur_id = (int)reader["Cur_id"];
                    id = (int)reader["ID"];
                    Date = (DateTime)reader["Date"];
                    Total = Convert.ToDecimal(reader["Total"]);

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
    }
}
