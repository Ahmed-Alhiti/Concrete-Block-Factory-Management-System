using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsPurchasesData
    {
        public static int AddNewPurchases(int Sup_ID, int Mat_ID,int Unit_ID,int Create_By, DateTime Create_on ,decimal Price,decimal Total_Mat_Amount)
        {
            int id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Purchases (Sup_ID, Mat_ID,Unit_ID, Create_By,Create_on,Price,Total_Mat_Amount)" +
                "VALUES" +
                "( @Sup_ID, @Mat_ID, @Unit_ID,@Create_By,@Create_on,@Price,@Total_Mat_Amount); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sup_ID", Sup_ID);
            command.Parameters.AddWithValue("@Mat_ID", Mat_ID);
            command.Parameters.AddWithValue("@Unit_ID", Unit_ID);
            command.Parameters.AddWithValue("@Create_By", Create_By);
            command.Parameters.AddWithValue("@Create_on", Create_on);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@Total_Mat_Amount", Total_Mat_Amount);

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
              // string error= ex.Message.ToString();


            }
            finally
            {
                connection.Close();
            }
            return id;

        }


        public static bool UpdatePurchases(int id, int Sup_ID, int Mat_ID,int Unit_ID,int Update_By, DateTime Update_on, decimal Price, decimal Total_Mat_Amount)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Purchases
                SET Sup_ID = @Sup_ID,
                Mat_ID =  @Mat_ID,
                Unit_ID =  @Unit_ID,
                Update_By =  @Update_By,
                Update_on = @Update_on,
                Price=@Price,
                Total_Mat_Amount=@Total_Mat_Amount
                WHERE Pur_ID = @Pur_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Pur_ID", id);
            command.Parameters.AddWithValue("@Sup_ID", Sup_ID);
            command.Parameters.AddWithValue("@Mat_ID", Mat_ID);
            command.Parameters.AddWithValue("@Unit_ID", Unit_ID);
            command.Parameters.AddWithValue("@Update_on", Update_on);
            command.Parameters.AddWithValue("@Update_By", Update_By);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@Total_Mat_Amount", Total_Mat_Amount);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();

            }
            catch 
            {
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowseffected > 0);

        }

        public static bool DeletePurchases(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Purchases WHERE  Pur_ID = @Pur_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Pur_ID", id);

            try
            {
                connection.Open();
                rowseffected = command.ExecuteNonQuery();
            }
            catch 
            {
                
            }
            finally
            {
                connection.Close();
            }


            return (rowseffected > 0);
        }

        public static DataTable GetAllPurchases()
        {
            DataTable dtPurchases = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Purchases.Pur_ID as 'id',Suppliers.Name as 'المورد',Materials.Name as 'الصنف',
                                Purchases.Total_Mat_Amount as 'الكمبة',Unit.Name as 'الوحدة',
                                Purchases.Create_on as 'التاريخ',Purchases.Price as 'السعر',
                                Users.User_Name as 'المستخدم'
                                from Purchases
                                inner join Suppliers on Suppliers.Sup_ID = Purchases.Sup_ID
                                inner join Materials on Materials.Mat_ID = Purchases.Mat_ID
                                inner join Unit on Unit.Unit_id = Purchases.Unit_ID
								inner join Users on Users.User_id = Purchases.Create_By";
                               

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPurchases.Load(reader);
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
            return dtPurchases;
        }


        public static DataTable GetAllPurchases(DateTime from, DateTime to)
        {
            DataTable dtPurchases = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Purchases.Pur_ID as 'id',Suppliers.Name as 'المورد',Materials.Name as 'الصنف',
                                Purchases.Total_Mat_Amount as 'الكمية',Unit.Name as 'الوحدة',
                                Purchases.Create_on as 'التاريخ',Purchases.Price as 'السعر'
                                
                                from Purchases
                                inner join Suppliers on Suppliers.Sup_ID = Purchases.Sup_ID
                                inner join Materials on Materials.Mat_ID = Purchases.Mat_ID
                                inner join Unit on Unit.Unit_id = Purchases.Unit_ID
								where Purchases.Create_on between cast(@From as Date) and  cast(@To as Date) ";

            

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@From", from);
            command.Parameters.AddWithValue("@To", to);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPurchases.Load(reader);
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
            return dtPurchases;
        }

        public static DataTable GetAllSupplierPurchases(int sup_id)
        {
            DataTable dtPurchases = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Purchases.Pur_ID as 'id',Suppliers.Name as 'المورد',Materials.Name as 'الصنف',
                                Purchases.Total_Mat_Amount as 'الكمية',Unit.Name as 'الوحدة',
                                Purchases.Price as 'السعر',Purchases.Create_on as 'التاريخ'
                                
                                from Purchases
                                inner join Suppliers on Suppliers.Sup_ID = Purchases.Sup_ID
                                inner join Materials on Materials.Mat_ID = Purchases.Mat_ID
                                inner join Unit on Unit.Unit_id = Purchases.Unit_ID
                                
                                where  Purchases.Sup_ID = @Sup_ID ";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sup_ID", sup_id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPurchases.Load(reader);
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
            return dtPurchases;
        }



        public static DataTable GetAllSupplierPurchases(int sup_id,DateTime From,DateTime to)
        {
            DataTable dtPurchases = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Purchases.Pur_ID as 'id',Suppliers.Name as 'المورد',Materials.Name as 'الصنف',
                                Purchases.Total_Mat_Amount as 'الكمبة',Unit.Name as 'الوحدة',
                                Purchases.Price as 'السعر',Purchases.Create_on as 'التاريخ'
                                
                                from Purchases
                                inner join Suppliers on Suppliers.Sup_ID = Purchases.Sup_ID
                                inner join Materials on Materials.Mat_ID = Purchases.Mat_ID
                                inner join Unit on Unit.Unit_id = Purchases.Unit_ID
                                
                                where  Purchases.Sup_ID = @Sup_ID 
                                And Purchases.Create_on between cast(@From as Date) and cast(@To as Date)";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Sup_ID", sup_id);
            command.Parameters.AddWithValue("@From", From);
            command.Parameters.AddWithValue("@To", to);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPurchases.Load(reader);
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
            return dtPurchases;
        }


        public static bool FindByID(int id,ref int Sup_ID,ref int Mat_ID,ref int Unit_ID,ref decimal Price,
            ref decimal Total_Mat_Amount,ref DateTime date)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Purchases where Pur_ID = @Pur_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Pur_ID", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Sup_ID = (int)reader["Sup_ID"];
                    Mat_ID = (int)reader["Mat_ID"];
                    Unit_ID = (int)reader["Unit_ID"];
                    Total_Mat_Amount = (decimal)reader["Total_Mat_Amount"];
                    Price = (decimal)reader["Price"];
                    date = (DateTime)reader["Create_on"];

                }

                reader.Close();
            }
            catch 
            {
                
                
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

        public static decimal GetLastPrice(int Mat_id)
        {
            decimal last_price = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select top 1 Price from Purchases where Mat_id = @Mat_id order by Pur_ID DESC ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Mat_id", Mat_id);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal price))
                {
                    last_price = price;
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

            return last_price;
        }

         public static bool Findlast(ref int id, ref int Sup_ID, int Mat_ID, ref int Unit_ID, ref decimal Price,
            ref decimal Total_Mat_Amount, ref DateTime date)
         {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Purchases where Mat_id = @Mat_id order by Pur_ID DESC ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Mat_id", Mat_ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Sup_ID = (int)reader["Sup_ID"];
                    id = (int)reader["Pur_ID"];
                    Unit_ID = (int)reader["Unit_ID"];
                    Total_Mat_Amount = (decimal)reader["Total_Mat_Amount"];
                    Price = (decimal)reader["Price"];
                    date = (DateTime)reader["Create_on"];

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

            return isfound; 
        }


        public static DataTable SearhPurchases(string search)
        {
            DataTable dtPurchases = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Purchases.Pur_ID as 'id',Suppliers.Name as 'المورد',Materials.Name as 'الصنف',
                                Purchases.Total_Mat_Amount as 'الكمبة',Unit.Name as 'الوحدة',
                                Purchases.Create_on as 'التاريخ',Purchases.Price as 'السعر'
                                
                                from Purchases
                                inner join Suppliers on Suppliers.Sup_ID = Purchases.Sup_ID
                                inner join Materials on Materials.Mat_ID = Purchases.Mat_ID
                                inner join Unit on Unit.Unit_id = Purchases.Unit_ID
								where concat(Materials.Name , Suppliers.Name ,Purchases.Create_on) like '%" + search+"%' ";


            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@Search", search);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtPurchases.Load(reader);
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
            return dtPurchases;
        }


        public static DataTable GetPurD(DateTime from, DateTime to)
        {
            DataTable Cus_sales = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Purchases.Pur_ID as 'id',Suppliers.Name as 'المورد',Materials.Name as 'الصنف',
                             Purchases.Total_Mat_Amount as 'الكمبة',Unit.Name as 'الوحدة',
                             Purchases.Price as 'السعر',Purchases.Create_on as 'التاريخ',
                             u1.User_Name  as 'تم الانشاء بواسطة المستخدم',
							 u2.User_Name  as 'تم العديل بواسطة المتخدم' ,
							 Purchases.Update_on as 'تاريخ التعديل'   
                             from Purchases
							 inner join Suppliers on Suppliers.Sup_ID = Purchases.Sup_ID
                             inner join Materials on Materials.Mat_ID = Purchases.Mat_ID
                             inner join Unit on Unit.Unit_id = Purchases.Unit_ID
							 inner join Users u1 on Purchases.Create_By = u1.User_id
							 left join Users u2 on Purchases.Update_By = u2.User_id
                            where Purchases.Create_on between cast(@From as Date) and cast(@To as Date)";

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
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return Cus_sales;
        }
    }
}


    

