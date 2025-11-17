using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsSalesData
    {
        public static int AddNewSale(int Cus_ID ,int Create_By, DateTime Craete_on, int Sale_Number, decimal Total_Price, int Block_Amount,string Detailes)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO sales (Cus_ID,Create_By,Craete_on,Sale_Number,Total_Price,Block_Amount,Detailes)" +
                "VALUES" +
                "( @Cus_ID,@Create_By,@Craete_on,@Sale_Number,@Total_Price,@Block_Amount,@Detailes); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", Cus_ID);
            
            command.Parameters.AddWithValue("@Create_By", Create_By);
            command.Parameters.AddWithValue("@Craete_on", Craete_on);
            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);
            command.Parameters.AddWithValue("@Total_Price", Total_Price);
            command.Parameters.AddWithValue("@Block_Amount", Block_Amount);

            if (Detailes != null)
                command.Parameters.AddWithValue("@Detailes", Detailes);
            else
                command.Parameters.AddWithValue("@Detailes", System.DBNull.Value);

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
                //Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return id;

        }


        public static bool UpdateSale(int id, int Cus_ID,int Update_By, DateTime Update_on, int Sale_Number, decimal Total_Price, int Block_Amount,string Detailes)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE sales
                SET Cus_ID = @Cus_ID,
                Update_By=@Update_By,
                Update_on = @Update_on,
                Sale_Number = @Sale_Number,
                Total_Price=@Total_Price,
                Block_Amount=@Block_Amount,
                Detailes=@Detailes
                WHERE Sal_ID = @Sal_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sal_ID", id);
            command.Parameters.AddWithValue("@Cus_ID", Cus_ID);
            command.Parameters.AddWithValue("@Update_By", Update_By);
            command.Parameters.AddWithValue("@Update_on", Update_on);
            command.Parameters.AddWithValue("@Total_Price", Total_Price);
            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);
            command.Parameters.AddWithValue("@Block_Amount", Block_Amount);

            if (Detailes != null)
                command.Parameters.AddWithValue("@Detailes", Detailes);
            else
                command.Parameters.AddWithValue("@Detailes", System.DBNull.Value);

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
        public static bool UpdateBill(int Cus_ID, int Sale_Number)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE sales
                SET Cus_ID = @Cus_ID
                WHERE Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Cus_ID", Cus_ID);
            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);
           
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

        //ترحيل الفاتورة
        public static bool PostingBill(int Sale_Number)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE sales
                SET Posted = 1
                WHERE Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);

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

        public static bool UnPostBill(int Sale_Number)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE sales
                SET Posted = 0
                WHERE Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);

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

        public static bool DeleteBill(int sal_num)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM sales WHERE Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", sal_num);

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
        
        public static bool DeleteSale(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM sales WHERE  Sal_ID = @Sal_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sal_ID", id);

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
        public static bool DeleteSaleByRefNo(int RefNo)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM sales WHERE  Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", RefNo);

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

        public static DataTable GetAllPostedSales()
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
                              where Posted = 1";

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
        //        Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtSales;
        }
        public static DataTable GetAllUnPostSales()
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
                              where Posted = 0";

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
        public static DataTable GetAllSales()
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID";

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
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtSales;
        }

        public static DataTable GetAllSalesNumbers()
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select distinct sales.Sale_Number from sales";

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
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtSales;
        }

        public static DataTable GetAllPostedSales(DateTime from , DateTime to)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
                             

                             where sales.Craete_on between cast(@From as Date) and cast(@To as Date) and Posted = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
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
        public static DataTable GetAllSales(DateTime from , DateTime to)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
                             

                             where sales.Craete_on between cast(@From as Date) and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
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


        public static DataTable GetAllUnPostedSales(DateTime from , DateTime to)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
                             

                             where sales.Craete_on between cast(@From as Date) and cast(@To as Date) and Posted = 0";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
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

        public static int GetSumAllSales(DateTime from , DateTime to)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(sales.Block_Amount)
                              from sales 
                             where sales.Craete_on between cast(@From as Date) and cast(@To as Date)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
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
        
        public static int GetSumAllSales()
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(sales.Block_Amount) from sales";

            SqlCommand command = new SqlCommand(query, connection);
          
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
        


        public static bool FindSaleByID(int id,ref int Cus_ID,ref DateTime Craete_on,ref int Sale_Number,ref decimal Total_Price,ref short Block_Amount,ref string Detailes)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select * from sales where sales.Sal_ID = @Sal_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sal_ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Cus_ID = (int)reader["Cus_ID"];
                    Craete_on = (DateTime)reader["Craete_on"];
                    Sale_Number = (int)reader["Sale_Number"];
                    Total_Price = Convert.ToDecimal(reader["Total_Price"]);
                    Block_Amount = (short)reader["Block_Amount"];
                    Detailes = (string)reader["Detailes"];

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



        public static DataTable GetAllSaleBySaleNumber(int Sale_Number)
        {
            
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
                              where sales.Sale_Number like '%" + Sale_Number+"%'";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);

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
            return table;
        }

        public static DataTable GetAllSalesBySaleNumber(int Sale_Number)
        {
            
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                              Customer.Name as 'اسم الزبون',
                              sales.Block_Amount as 'الكمية',
                              sales.Craete_on as 'التاريخ',
                              sales.Total_Price as 'الاجمالي' , 
                              sales.Detailes as 'التفاصيل' 
                              
                              from sales 
                              inner join Customer on Customer.Cus_ID = sales.Cus_ID
							  where sales.Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);

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
            return table;
        }
         public static decimal GetBillTotal(int Sale_Number)
        {

            decimal total = 0; 

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select SUM(sales.Total_Price) as 'اجمالي الفاتورة' from sales 
                              where sales.Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", Sale_Number);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(),out decimal tot))
                {
                    total = tot;
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

        public static DataTable GetCustomerPostedSales(int id)
        {
            DataTable Cus_sales = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                             Customer.Name as 'اسم الزبون',
                             sales.Block_Amount as 'الكمية',
                             sales.Craete_on as 'التاريخ',
                             sales.Total_Price as 'الاجمالي' , 
                             sales.Detailes as 'التفاصيل'
                             
                             
                             from sales 
                             inner join Customer on Customer.Cus_ID = sales.Cus_ID

                             where sales.Cus_ID = @Cus_ID and Posted = 1";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                

                if (reader.HasRows)
                {
                    Cus_sales.Load(reader);
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

            return Cus_sales;
        }
        public static DataTable GetCustomerUnPostedSales(int id)
        {
            DataTable Cus_sales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                             Customer.Name as 'اسم الزبون',
                             sales.Block_Amount as 'الكمية',
                             sales.Craete_on as 'التاريخ',
                             sales.Total_Price as 'الاجمالي' , 
                             sales.Detailes as 'التفاصيل'
                             
                             
                             from sales 
                             inner join Customer on Customer.Cus_ID = sales.Cus_ID

                             where sales.Cus_ID = @Cus_ID and Posted = 0";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                

                if (reader.HasRows)
                {
                    Cus_sales.Load(reader);
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

            return Cus_sales;
        }


         public static int GetSumCustomerSales(int id)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(sales.Block_Amount)
                             from sales 
                             where sales.Cus_ID = @Cus_ID";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", id);
            try
            {
                connection.Open();
                result = int.Parse(command.ExecuteScalar().ToString());
                
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return result;
        }
        public static int GetSumCustomerSales(int id, DateTime from, DateTime to)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sum(sales.Block_Amount)
                             from sales 
                             where sales.Cus_ID = @Cus_ID and sales.Craete_on between cast(@From as Date) and cast(@To as Date) and Posted = 1";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", id);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
            try
            {
                connection.Open();
                result = int.Parse(command.ExecuteScalar().ToString());
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        public static DataTable GetSalesD(DateTime from , DateTime to)
        {
            DataTable Cus_sales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                             Customer.Name as 'اسم الزبون',
                             sales.Block_Amount as 'الكمية',
                             sales.Craete_on as 'التاريخ',
                             sales.Total_Price as 'الاجمالي' , 
                             sales.Detailes as 'التفاصيل' ,
							 u1.User_Name  as 'تم الانشاء بواسطة المستخدم',
							 u2.User_Name  as 'تم العديل بواسطة المتخدم' ,
							 sales.Update_on as 'تاريخ التعديل'
                             from sales 
                             
                             inner join Customer on Customer.Cus_ID = sales.Cus_ID
							 inner join Users u1 on sales.Create_By = u1.User_id
							 left join Users u2 on sales.Update_By = u2.User_id
                            where sales.Craete_on between cast(@From as Date) and cast(@To as Date)";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                

                if (reader.HasRows)
                {
                    Cus_sales.Load(reader);
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

            return Cus_sales;
        }
        public static DataTable GetSales(DateTime from , DateTime to)
        {
            DataTable Cus_sales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                             Customer.Name as 'اسم الزبون',
                             sales.Block_Amount as 'الكمية',
                             sales.Craete_on as 'التاريخ',
                             sales.Total_Price as 'الاجمالي' , 
                             sales.Detailes as 'التفاصيل' 
                             
                             from sales 
                             inner join Customer on Customer.Cus_ID = sales.Cus_ID
                             
                            where sales.Cus_ID = @Cus_ID
                            and sales.Craete_on between cast(@From as Date) and cast(@To as Date)
                            and Posted = 1";
            
            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                

                if (reader.HasRows)
                {
                    Cus_sales.Load(reader);
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

            return Cus_sales;
        }

        public static DataTable GetCustomerUnPostedSales(int id,DateTime from , DateTime to)
        {
            DataTable Cus_sales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                             Customer.Name as 'اسم الزبون',
                             sales.Block_Amount as 'الكمية',
                             sales.Craete_on as 'التاريخ',
                             sales.Total_Price as 'الاجمالي' , 
                             sales.Detailes as 'التفاصيل' 
                             
                             from sales 
                             inner join Customer on Customer.Cus_ID = sales.Cus_ID
                             
                            where sales.Cus_ID = @Cus_ID
                            and sales.Craete_on between cast(@From as Date) and cast(@To as Date)
                            and Posted = 0";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Cus_ID", id);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                

                if (reader.HasRows)
                {
                    Cus_sales.Load(reader);
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

            return Cus_sales;
        }

        

        public static DataTable Search(string search)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sal_ID,sales.Sale_Number as 'رقم الفاتورة',
                             Customer.Name as 'اسم الزبون',
                             sales.Block_Amount as 'الكمية',
                             sales.Craete_on as 'التاريخ',
                             sales.Total_Price as 'الاجمالي' , 
                             sales.Detailes as 'التفاصيل'
                             from sales 
                             inner join Customer on Customer.Cus_ID = sales.Cus_ID
                             where concat (Customer.Name,sales.Craete_on,sales.Sale_Number,sales.Detailes) like '%" + search+"%'";

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

        public static int GetLastID()
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select top 1 sales.Sal_ID from sales order by Sal_ID DESC";
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

        public static bool UpdateQtyAndTotalPrice(int sal_num)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"update sales set Block_Amount = 
                             (select sum(Sale_Details.Block_Amount) from Sale_Details 
                             where Sale_Details.Sale_Number = @Sale_Number),
                             Total_Price = (select sum(Sale_Details.total_price) from Sale_Details 
                             where Sale_Details.Sale_Number = @Sale_Number)
                             where sales.Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", sal_num);

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


        public static DataTable GetSales()
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Sale_Number from sales 
                             where Sale_Number like '2%' or Sale_Number like '3%'";

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
        public static DataTable GetTotalPrice(int sal_number)
        {
            DataTable dtSales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Total_Price from sales
                             where Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sale_Number", sal_number);


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



        public static int FindCustomerId_BySaleNumber(int sale_number)
        {
            bool isfound = false;
            int customer_id = -1;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Cus_ID from sales 
                             where sales.Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", sale_number);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    customer_id = (int)reader["Cus_ID"];
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
            return customer_id;
        }
        public static bool CheckPosted(int sale_number)
        {
            bool isfound = false;
            

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select sales.Posted from sales 
                             where sales.Sale_Number = @Sale_Number";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Sale_Number", sale_number);

            try
            {
                connection.Open();
                short b = short.Parse(command.ExecuteScalar().ToString());
                isfound = (b==1)? true:false;
            }
            catch (Exception ex)
            {
                //string error = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

    }
}
