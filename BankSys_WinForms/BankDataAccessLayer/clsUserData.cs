using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsUserDataAccess
    {
        public static bool GetUserInfoByID(int UserID, ref string UserName, ref string Password,
            ref string FirstName, ref string LastName, ref string Email, ref string Phone,
            ref DateTime CreateDate, ref int Permissions, ref string Image)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    Phone = (string)reader["Phone"];
                    CreateDate = (DateTime)reader["CreateDate"];
                    Permissions = (int)reader["Permissions"];

                    if (reader["Image"] != DBNull.Value)
                        Image = (string)reader["Image"];
                    else
                        Image = "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetUserInfoByUserName(string UserName, ref int UserID, ref string Password,
            ref string FirstName, ref string LastName, ref string Email, ref string Phone,
            ref DateTime CreateDate, ref int Permissions, ref string Image)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    Phone = (string)reader["Phone"];
                    CreateDate = (DateTime)reader["CreateDate"];
                    Permissions = (int)reader["Permissions"];

                    if (reader["Image"] != DBNull.Value)
                        Image = (string)reader["Image"];
                    else
                        Image = "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewUser(string UserName, string Password, string FirstName,
            string LastName, string Email, string Phone, int Permissions, string Image)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (UserName, Password, FirstName, LastName,
                            Email, Phone, CreateDate, Permissions, Image)
                            VALUES (@UserName, @Password, @FirstName, @LastName,
                            @Email, @Phone, GETDATE(), @Permissions, @Image);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);

            if (!string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            if (!string.IsNullOrEmpty(Image))
                command.Parameters.AddWithValue("@Image", Image);
            else
                command.Parameters.AddWithValue("@Image", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, string FirstName,
            string LastName, string Email, string Phone, int Permissions, string Image)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Users 
                            SET UserName = @UserName,
                                Password = @Password,
                                FirstName = @FirstName,
                                LastName = @LastName,
                                Email = @Email,
                                Phone = @Phone,
                                Permissions = @Permissions,
                                Image = @Image
                            WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);

            if (!string.IsNullOrEmpty(Email))
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            if (!string.IsNullOrEmpty(Image))
                command.Parameters.AddWithValue("@Image", Image);
            else
                command.Parameters.AddWithValue("@Image", DBNull.Value);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, connection);

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
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllCostomUsers()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                [#] = UserID, 
                                [اسم المستخدم] = UserName, 
                                [كلمة المرور] = Password,
                                [الاسم الكامل] = FirstName +' '+ LastName, 
                                [البريد الاكرتوني] = Email, 
                                [رقم التلفون] = Phone,
                                [الاذونات] = Permissions 
                                FROM Users 
                                ORDER BY UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception
                    }
                }
            }
            return dt;
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
