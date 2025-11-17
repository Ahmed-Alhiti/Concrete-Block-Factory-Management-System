using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsEmployeeData
    {
        public static int AddNewEmployee(string Name, string Phone,int Manage_By,decimal Salary)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "INSERT INTO Employee (Name, Phone,Manage_By,Salary)" +
                "VALUES" +
                "( @Name,@Phone,@Manage_By,@Salary); " +
                "select scope_identity()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Salary", Salary);

            if (Phone != null)
            {
                command.Parameters.AddWithValue("@Phone", Phone);
            }
            else
            {
                command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
            }

            if (Manage_By != -1)
            {
                command.Parameters.AddWithValue("@Manage_By", Manage_By);
            }
            else
            {

                command.Parameters.AddWithValue("@Manage_By", System.DBNull.Value);
            }



            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    id= InsertedID;
                }
                else
                {
                    id= -1;
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


        public static bool UpdateEmployee(int id, string Name, string Phone, int Manage_By, decimal Salary)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"UPDATE Employee
                SET Name = @Name,
                Phone =  @Phone,
                Manage_By =  @Manage_By,
                Salary =  @Salary
                WHERE Emp_ID = @Emp_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Emp_ID", id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Salary", Salary);

            if (Phone != null)
            {
                command.Parameters.AddWithValue("@Phone", Phone);
            }
            else
            {
                command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
            }

            if (Manage_By != -1)
            {
                command.Parameters.AddWithValue("@Manage_By", Manage_By);
            }
            else
            {
                command.Parameters.AddWithValue("@Manage_By", System.DBNull.Value);
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

        public static bool DeleteEmployee(int id)
        {
            int rowseffected = 0;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"DELETE FROM Employee WHERE Emp_ID = @Emp_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Emp_ID", id);

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

        public static DataTable GetAllEmployies()
        {
            DataTable dtEmploies = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Employee.Emp_ID ,Employee.Name 'اسم الموظف' , Employee.Phone as 'رقم التلفون' , Employee.Salary as 'الراتب'
                            , Man.Name as 'المدير' from Employee left join Employee Man on Man.Emp_ID = Employee.Manage_By";
            //string query = @"select Employee.Emp_ID , Employee.Name ,Employee.Phone , Employee.Salary , Employee.Manage_By
            //                from Employee";

           SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtEmploies.Load(reader);
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
            return dtEmploies;
        }
         public static DataTable GetAllEmployies(string Search)
        {
            DataTable dtEmploies = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = @"select Employee.Emp_ID ,Employee.Name 'اسم الموظف' , Employee.Phone as 'رقم التلفون' , Employee.Salary as 'الراتب'
                            , Man.Name as 'المدير' from Employee left join Employee Man on Man.Emp_ID = Employee.Manage_By where Employee.Name like '%" + Search + "%'  ";
           

           SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtEmploies.Load(reader);
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
            return dtEmploies;
        }



        public static DataTable GetAllEmps()
        {
            DataTable dtEmploies = new DataTable();

            SqlConnection connection = new SqlConnection(clsConnection.connect);


            //string query = @"select Name from Employee";
            string query = @"select * from Employee";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtEmploies.Load(reader);
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
            return dtEmploies;
        }


        public static bool FindEmployee_ByID(int id,ref string Name,ref string Phone,ref int Manage_By,ref decimal Salary)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select * from Employee where Emp_ID = @Emp_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Emp_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;
                    Name = (string)reader["Name"];
                    Salary = (decimal)reader["Salary"];

                    object man_id = reader["Manage_By"];

                    if (man_id != null && int.TryParse(man_id.ToString(),out int manager_id))
                        Manage_By = manager_id;
                    else
                        Manage_By = -1;

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

        public static bool FindEmployee_ByName(string Name,ref int id,ref string phone,ref int Manag_by,ref decimal salary)
        {
            
            bool isFound = false;
            string query = "select Emp_id from Employee where Name = @Name";

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    id = (int)reader["Emp_id"];
                    phone = (string)reader["Phone"];
                    Manag_by = (int)reader["Manage_By"];
                    salary = (decimal)reader["Salary"];

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

            return isFound;
        }


        public static int GetEmpID_ByName(string Name)
        {
            int id = -1;
            string query = "select Emp_ID from Employee where Name =@Name";
            SqlConnection connection = new SqlConnection(clsConnection.connect);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(),out int ID))
                {
                    id = ID;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();

            }



            return id;
        }

        public static string GetManagerName_ByID(int Manager_id)
        {
            string result = "";

            SqlConnection connection = new SqlConnection(clsConnection.connect);

            string query = "select Name from Employee " +
                "where Emp_ID = @Emp_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Emp_ID", Manager_id);
            try
            {
                connection.Open();
                result = command.ExecuteScalar().ToString();
            }
            catch 
            {
                //Console.WriteLine(ex.Message);
                
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
    }
}
