using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsSale_DetailsData
    {
        public static int AddNewSale(int Sale_Number, int Block_ID, int Block_Amount, float total_price)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Sale_Details (Sale_Number, Block_ID,Block_Amount,total_price)" +
                "VALUES" +
                "( @Sale_Number, @Block_ID,@Block_Amount,@total_price); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);

            command.Parameters.AddWithValue("@Block_ID", Block_ID);
            command.Parameters.AddWithValue("@Block_Amount", Block_Amount);
            command.Parameters.AddWithValue("@total_price", total_price);
            
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
        public static bool Updateitem(int id, int Block_ID, int Block_Amount, float total_price)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Sale_Details
                SET Block_ID = @Block_ID,
                Block_Amount=@Block_Amount,
                total_price=@total_price
                
                WHERE Detail_id = @Detail_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Detail_id", id);
            command.Parameters.AddWithValue("@Block_ID", Block_ID);
            command.Parameters.AddWithValue("@Block_Amount", Block_Amount);
            command.Parameters.AddWithValue("@total_price", total_price);

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

        public static bool Deleteitem(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Sale_Details WHERE Detail_id = @Detail_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Detail_id", id);

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

        
        public static DataTable GetAllItems()
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Sale_Details.Detail_id ,Sale_Details.Sale_Number as 'رقم الفاتوره', Block_Type.Called as 'الصنف' ,
                             Sale_Details.Block_Amount as 'الكمية',(total_price / Block_Amount) as 'سعر الصنف' , 
                             Sale_Details.total_price as 'الاجمالي'
                             from Sale_Details
                             inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSales.Load(reader);
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
            return dtSales;
        }
       
        public static DataTable GetAllItems(int Sal_Number)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Sale_Details.Detail_id ,
                             Sale_Details.Sale_Number as 'رقم الفاتوره', Block_Type.Called as 'الصنف' ,
                             Sale_Details.Block_Amount as 'الكمية',(total_price / Block_Amount) as 'سعر الصنف' , 
                             Sale_Details.total_price as 'الاجمالي'
                             from Sale_Details
                             inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID
                             where Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", Sal_Number);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSales.Load(reader);
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
            return dtSales;
        }
        public static DataTable GetAllItemSales(int Blo_id)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Sale_Details.Detail_id ,
                             Sale_Details.Sale_Number as 'رقم الفاتوره', Block_Type.Called as 'الصنف' ,
                             Sale_Details.Block_Amount as 'الكمية', (Sale_Details.total_price / Sale_Details. Block_Amount) as 'سعر الصنف' , 
                             Sale_Details.total_price as 'الاجمالي',
                             Sale.Craete_on as 'التاريخ'
                             from Sale_Details
                             inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID
                             inner join sales as Sale on Sale_Details.Sale_Number = Sale.Sale_Number
                             where Sale_Details.Block_ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSales.Load(reader);
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
            return dtSales;
        }
        public static int GetSumItemSales(int Blo_id)
        {
            int result = 0;
           

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Sale_Details.Block_Amount)
                             from Sale_Details
                             where Sale_Details.Block_ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);

            try
            {
                connection.Open();

               result = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static int GetSumItemSales(int Blo_id, DateTime From, DateTime To)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Sale_Details.Block_Amount) 
                             from Sale_Details
                             inner join sales as Sale on Sale_Details.Sale_Number = Sale.Sale_Number
                             where Sale_Details.Block_ID = @id and Sale.Craete_on between cast(@From as Date) and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Blo_id);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            try
            {
                connection.Open();

                result = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static DataTable GetAllItemSales(int Blo_id,DateTime From ,DateTime To)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Sale_Details.Detail_id ,
                             Sale_Details.Sale_Number as 'رقم الفاتوره', Block_Type.Called as 'الصنف' ,
                             Sale_Details.Block_Amount as 'الكمية', (Sale_Details.total_price / Sale_Details. Block_Amount) as 'سعر الصنف' , 
                             Sale_Details.total_price as 'الاجمالي',
                             Sale.Craete_on as 'التاريخ'
                             from Sale_Details
                             inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID
                             inner join sales as Sale on Sale_Details.Sale_Number = Sale.Sale_Number
                             where Sale_Details.Block_ID = @id and Sale.Craete_on between cast(@From as Date) and cast(@To as Date)";

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
                    dtSales.Load(reader);
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
            return dtSales;
        }
         public static DataTable GetAllCustomerItemSales(int Cus_id,int Blo_id,DateTime From ,DateTime To)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sale_Number as 'رقم الفاتورة',Customer.Name as 'اسم الزبون' ,Block_Type.Called as 'الصنف' ,
                                    Sale_Details.Block_Amount as 'الكمية',
                                    sales.Craete_on as 'التاريخ' , 
                                    (Sale_Details.total_price/Sale_Details.Block_Amount) as 'سعر الحبه',
                                    Sale_Details.total_price as 'الاجمالي'
                                    
                                    from Sale_Details
                                    inner join sales on Sale_Details.Sale_Number = sales.Sale_Number
                                    inner join Customer on Customer.Cus_ID = sales.Cus_ID
                                    inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID
                                    where sales.Cus_ID = @Cus_id and Sale_Details.Block_ID = @Blo_id
                                    and sales.Craete_on between cast(@From as Date) and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Blo_id", Blo_id);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSales.Load(reader);
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
            return dtSales;
        }
        public static int GetAllSumCustomerItemSales(int Cus_id,int Blo_id,DateTime From ,DateTime To)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Sale_Details.Block_Amount)
                                    from Sale_Details
                                    inner join sales on Sale_Details.Sale_Number = sales.Sale_Number
                                    inner join Customer on Customer.Cus_ID = sales.Cus_ID
                                    where sales.Cus_ID = @Cus_id and Sale_Details.Block_ID = @Blo_id
                                    and sales.Craete_on between cast(@From as Date) and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Blo_id", Blo_id);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", To);

            try
            {
                connection.Open();

                result = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static int GetAllSumCustomerItemSales(int Cus_id,int Blo_id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(Sale_Details.Block_Amount)
                                    from Sale_Details
                                    inner join sales on Sale_Details.Sale_Number = sales.Sale_Number
                                    inner join Customer on Customer.Cus_ID = sales.Cus_ID
                                    where sales.Cus_ID = @Cus_id and Sale_Details.Block_ID = @Blo_id";

            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Blo_id", Blo_id);

            try
            {
                connection.Open();

                result = int.Parse(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static DataTable GetAllCustomerItemSales(int Cus_id,int Blo_id)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sale_Number as 'رقم الفاتورة',Customer.Name as 'اسم الزبون' ,Block_Type.Called as 'الصنف' ,
                                    Sale_Details.Block_Amount as 'الكمية',
                                    sales.Craete_on as 'التاريخ' , 
                                    (Sale_Details.total_price/Sale_Details.Block_Amount) as 'سعر الحبه',
                                    Sale_Details.total_price as 'الاجمالي'
                                    
                                    from Sale_Details
                                    inner join sales on Sale_Details.Sale_Number = sales.Sale_Number
                                    inner join Customer on Customer.Cus_ID = sales.Cus_ID
                                    inner join Block_Type on Sale_Details.Block_ID = Block_Type.Blo_ID
                                    where sales.Cus_ID = @Cus_id and Sale_Details.Block_ID = @Blo_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_id", Cus_id);
            command.Parameters.AddWithValue("@Blo_id", Blo_id);
           

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtSales.Load(reader);
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
            return dtSales;
        }
        
        static public int GetTotal(int sale_number)
        {
            int total = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum (Sale_Details.total_price)
                             from Sale_Details
                             where Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", sale_number);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int Total))
                {
                    total = Total;
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
            
            return total;
        }


        public static bool FindItemByID(int id, ref int Sale_Number, ref int Block_ID, ref short Block_Amount, ref float total_price)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select * from Sale_Details where Sale_Details.Detail_id = @Detail_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Detail_id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Sale_Number = (int)reader["Sale_Number"];
                    Block_ID = (int)reader["Block_ID"];
                    total_price = Convert.ToSingle(reader["total_price"]);
                    Block_Amount = (short)reader["Block_Amount"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //string error = ex.Message;
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
