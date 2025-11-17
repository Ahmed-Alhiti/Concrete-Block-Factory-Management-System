using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsUsersData
    {
        public static int AddNewUser(int Emp_id,string User_Name,string Password,int Per ,bool is_active)
        {
            int User_id = -1;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Users (Emp_id,User_Name,Password,Per,Is_active)" +
                "VALUES" +
                "( @Emp_id, @User_Name,@Password,@Per,@Is_active);" +
                "select scope_identity()";

           SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Emp_id", Emp_id);
            command.Parameters.AddWithValue("@User_Name", User_Name);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Per", Per);
            command.Parameters.AddWithValue("@Is_active", is_active);
              
           

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int Inserted_ID))
                {
                    User_id = Inserted_ID;
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

            return User_id;
        }

        public static bool UpdateUser(int User_id,int Emp_id,string User_Name,string Password,int Per,bool is_active)
        {
            int effectedrows = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Users
                            SET Emp_id = @Emp_id,
                            User_Name = @User_Name,
                            Password = @Password,
                            Per=@Per,
                            Is_active = @Is_active
                            WHERE User_id = @User_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_id", User_id);
            command.Parameters.AddWithValue("@Emp_id", Emp_id);
            command.Parameters.AddWithValue("@User_Name", User_Name);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Per", Per);
            command.Parameters.AddWithValue("@Is_active", is_active);
           
            try
            {
                connection.Open();
                effectedrows = command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return effectedrows > 0;
        }


        public static bool DeleteUser(int User_id)
        {
            int effectedrows = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "Delete from Users where User_id = @User_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_id", User_id);

            try
            {
                connection.Open();
                effectedrows = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (effectedrows > 0);

        }

        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            DataTable table = new DataTable();

            string query = @" select Users.User_id , Users.User_Name as 'اسم المستخدم',Users.Password as'كلمة المرور',
                                Employee.Name as 'اسم الموظف',
                                Users.Per as 'الصلاحية',Users.Is_active as 'نشط' from Users
                                inner join Employee on Employee.Emp_ID = Users.Emp_id";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return table;
        }

        public static bool FindUserByID(int User_id,ref int Emp_id,ref string User_Name,ref string Password,ref int Per,ref bool is_active)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "Select * from Users where User_id=@User_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_id", User_id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Emp_id = (int)reader["Emp_id"];
                    User_Name = (string)reader["User_Name"];
                    Password = (string)reader["Password"];
                    Per = (int)reader["Per"];
                    is_active = (bool)reader["Is_active"];

                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool Check_UserName_And_Password(string UserName,string PassWord,ref int User_id, ref int Per, ref bool is_active)
        {
            bool isfound=false;

            string query = "select * from Users where User_Name = @User_Name and Password = @Password";
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_Name", UserName);
            command.Parameters.AddWithValue("@Password", PassWord);


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    User_id = (int)reader["User_id"];
                    Per = (int)reader["Per"];
                    is_active = (bool)reader["Is_active"];

                }

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

        public static bool FindUserByUserName_andPassword(string User_Name,string Password, ref int User_id, ref int Emp_id , ref int Per, ref bool is_active)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Users where User_Name = @User_Name and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_Name", User_Name);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Emp_id = (int)reader["Emp_id"];
                    User_id = (int)reader["User_id"];
                    Per = (int)reader["Per"];
                    is_active = (bool)reader["Is_active"];

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

            return isFound;
        }

        public static bool UpdateUserPassword(int User_id, string Password)
        {
            int effectedrows = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Users
                            SET Password = @Password
                            WHERE User_id = @User_id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_id", User_id);
            command.Parameters.AddWithValue("@Password", Password);
            
            try
            {
                connection.Open();
                effectedrows = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return effectedrows > 0;
        }


        public static string FindUserNameID(int User_id)
        {
            string username = "";


            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "Select User_Name from Users where User_id=@User_id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_id", User_id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    username = (string)reader["User_Name"];
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

            return username;
        }

    }
}
