using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsStorage_stockData
    {
        public static int AddNewStorage_stock(int Blo_ID, int Amount, DateTime Date)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Storage_stock (Block_id,Amount, Date)" +
                "VALUES" +
                "( @Block_id,@Amount, @Date); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@Block_id", Blo_ID);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Date", Date);
            
            

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
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return id;

        }


        public static bool UpdateStorage_stock(int id,int Blo_ID, int Amount, DateTime Date)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Storage_stock SET
                Block_id =  @Block_id,
                Date = @Date,
                Amount=@Amount
                WHERE Sto_ID = @Sto_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sto_ID", id);
            command.Parameters.AddWithValue("@Block_id", Blo_ID);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@Amount", Amount);


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

        public static bool DeleteStorage_stock(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Storage_stock WHERE  Sto_ID = @Sto_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sto_ID", id);

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

        public static DataTable GetAllStorage_stock()
        {
            DataTable dtStock = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Storage_stock.Sto_ID as 'id',Block_Type.Called as 'الصنف المنتج',Block_Type.Size as 'المقاس'
                                , Storage_stock.Amount as
                                'الكمية',Storage_stock.Date as 'التاريخ' from Storage_stock
                                inner join Block_Type on Storage_stock.Block_id = Block_Type.Blo_ID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStock.Load(reader);
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
            return dtStock;
        }
        public static DataTable GetAllStorage_stock(DateTime today)
        {
            DataTable dtStock = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Storage_stock.Sto_ID ,Block_Type.Called as 'الصنف المنتج',Block_Type.Size as 'المقاس'
                                , Storage_stock.Amount as
                                'الكمية',Storage_stock.Date as 'التاريخ' from Storage_stock
                                inner join Block_Type on Storage_stock.Block_id = Block_Type.Blo_ID
                                where Storage_stock.Date = cast(@Today as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Today", today);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStock.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtStock;
        }
        public static DataTable GetAllStorage_stock(int Blo_id)
        {
            DataTable dtStock = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Storage_stock.Sto_ID as 'id',Block_Type.Called as 'الصنف المنتج',Block_Type.Size as 'المقاس'
                                , Storage_stock.Amount as
                                'الكمية',Storage_stock.Date as 'التاريخ' from Storage_stock
                                inner join Block_Type on Storage_stock.Block_id = Block_Type.Blo_ID
                                where Storage_stock.Block_id = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStock.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtStock;
        }
         public static DataTable GetStockOnHand(int Blo_id)
        {
            DataTable dtStock = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Block_Type.Called as 'الصنف المنتج',Block_Type.Size as 'المقاس'
                                , Storage_stock.Amount as
                                'الكمية',Storage_stock.Date as 'التاريخ' from Storage_stock
                                inner join Block_Type on Storage_stock.Block_id = Block_Type.Blo_ID
                                where Storage_stock.Block_id = @id

                             select Sale_Details.Sale_Number as 'رقم الفاتوره', Block_Type.Called as 'الصنف' ,
                             Sale_Details.Block_Amount as 'الكمية المباعه', (Sale_Details.total_price / Sale_Details. Block_Amount) as 'سعر الصنف' , 
                             Sale_Details.total_price as 'الاجمالي',
                             Sale.Craete_on as 'التاريخ'
                             from Sale_Details
                             inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID
                             inner join sales as Sale on Sale_Details.Sale_Number = Sale.Sale_Number
                             where Sale_Details.Block_ID = @id1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);
            command.Parameters.AddWithValue("@id1", Blo_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStock.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtStock;
        }

        public static int GetSum(int Blo_id)
        {
            

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Storage_stock.Amount) from Storage_stock
                                where Storage_stock.Block_id = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);

            int Total=0;
            try
            {
                connection.Open();

                Total = int.Parse(command.ExecuteScalar().ToString());
                
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Total ;
        }
        public static int GetSum()
        {
            

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Storage_stock.Amount) from Storage_stock";

            SqlCommand command = new SqlCommand(query, connection);
            

            int Total=0;
            try
            {
                connection.Open();

                Total = int.Parse(command.ExecuteScalar().ToString());
                
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Total ;
        }
       
        public static int GetSum(int Blo_id, DateTime From, DateTime To)
        {
            

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Storage_stock.Amount) from Storage_stock
                             where Storage_stock.Block_id = @id
                             and Storage_stock.Date between cast(@From as Date)
                             and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            int Total=0;
            try
            {
                connection.Open();

                Total = int.Parse(command.ExecuteScalar().ToString());
                
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Total ;
        }
         public static int GetSum(DateTime From, DateTime To)
        {
            

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Storage_stock.Amount) from Storage_stock
                             where 
                             Storage_stock.Date between cast(@From as Date)
                             and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            int Total=0;
            try
            {
                connection.Open();

                Total = int.Parse(command.ExecuteScalar().ToString());
                
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Total ;
        }


        public static DataTable GetAllStorage_stock(int Blo_id,DateTime From,DateTime To)
        {
            DataTable dtStock = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Storage_stock.Sto_ID as 'id',Block_Type.Called as 'الصنف المنتج',Block_Type.Size as 'المقاس'
                                , Storage_stock.Amount as
                                'الكمية',Storage_stock.Date as 'التاريخ' from Storage_stock
                                inner join Block_Type on Storage_stock.Block_id = Block_Type.Blo_ID
                                where Storage_stock.Block_id = @id and Storage_stock.Date between cast(@From as Date)
                                and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStock.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtStock;
        }
        public static DataTable GetAllStorage_stock(DateTime From,DateTime To)
        {
            DataTable dtStock = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Storage_stock.Sto_ID ,Block_Type.Called as 'الصنف المنتج',Block_Type.Size as 'المقاس'
                                , Storage_stock.Amount as
                                'الكمية',Storage_stock.Date as 'التاريخ' from Storage_stock
                                inner join Block_Type on Storage_stock.Block_id = Block_Type.Blo_ID
                                where Storage_stock.Date between cast(@From as Date)
                                and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtStock.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtStock;
        }


        public static bool FindStorage_stock(int id,ref int Blo_ID,ref short Amount,ref DateTime Date)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Storage_stock where Sto_ID = @Sto_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sto_ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    
                    Blo_ID = (int)reader["Block_id"];
                    Amount = short.Parse(reader["Amount"].ToString());
                    Date = (DateTime)reader["Date"];
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
