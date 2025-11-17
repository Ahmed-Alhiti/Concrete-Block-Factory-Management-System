using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsReceiptsData
    {
        public static int AddNew(int Cur_id, int RefNo, DateTime Date, decimal Total)
        {
            int Bill_Id = -1;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Receipts (RefNo,Date,Total,Cur_id)" +
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


        public static bool Update(int id,int Cur_id, decimal Total)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Receipts
                SET
                Cur_id = @Cur_id,
                Total =  @Total
                WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);
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

            string query = "DELETE FROM Receipts WHERE  ID = @ID";

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

            string query = "DELETE FROM Receipts WHERE  RefNo = @RefNo";

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

            string query = @"select Receipts.ID,Receipts.RefNo as 'رقم السند',Receipts.Date as 'تاريخ السند',
                                Receipts.Total as 'الاجمالي',Currencies.Called
                                from Receipts 
                                inner join Currencies on Currencies.Cur_ID = Receipts.Cur_id ";

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
         public static DataTable GetAll(int Cur_id)
        {
            DataTable dtSuppliers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Receipts.ID,Receipts.RefNo as 'رقم السند',Receipts.Date as 'تاريخ السند',
                                Receipts.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from Receipts 
                                inner join Currencies on Currencies.Cur_ID = Receipts.Cur_id
                                 where Receipts.Cur_id = @Cur_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cur_id", Cur_id);

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
        public static DataTable GetAll(int Cur_id,DateTime time1 , DateTime time2)
        {
            DataTable dtSuppliers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Receipts.ID,Receipts.RefNo as 'رقم السند',Receipts.Date as 'تاريخ السند',
                                Receipts.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from Receipts 
                                inner join Currencies on Currencies.Cur_ID = Receipts.Cur_id
                                where Receipts.Cur_id = @Cur_id and
                                Receipts.Date between cast (@time1 as Date) and cast (@time2 as Date)";

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
         public static DataTable GetAllByRefNo(int refno)
        {
            DataTable dtSuppliers = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Receipts.ID,Receipts.RefNo as 'رقم السند',Receipts.Date as 'تاريخ السند',
                                Receipts.Total as 'الاجمالي',Currencies.Called as 'العمله'
                                from Receipts 
                                inner join Currencies on Currencies.Cur_ID = Receipts.Cur_id
                                where RefNo = @RefNo ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RefNo", refno);
            
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
        public static int GetLastId()
        {
            int id =0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select top 1 Receipts.ID from Receipts order by Receipts.ID DESC";

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


        public static bool FindReceiptsBill(int id, ref int Cur_id, ref int RefNo, ref DateTime Date, ref decimal Total)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Receipts where ID = @ID";

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
        public static bool FindReceiptsBillByRefNo(ref int id, ref int Cur_id, int RefNo, ref DateTime Date, ref decimal Total)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Receipts where RefNo = @RefNo";

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
