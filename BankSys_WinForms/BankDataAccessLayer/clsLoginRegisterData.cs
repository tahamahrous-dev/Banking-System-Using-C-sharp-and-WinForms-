using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsLoginRegisterDataAccess
    {
        public static DataTable GetAllLoginRegisters()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                    L.LoginID as #,
                                    L.UserID as [معرف المستخدم],
                                    U.UserName as [اسم المستخدم],
                                    L.LoginDate as [تاريخ و وقت الدخول],
                                    L.IsSuccess as [نجاح / فشل تسجيل الدخول],
                                    L.ClientMachine as [اسم الجهاز]
                                 FROM LoginRegisters L
                                 INNER JOIN Users U ON U.UserID = L.UserID
                                 ORDER BY L.LoginDate DESC";

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
                        // TODO: log exception
                    }
                }
            }
            return dt;
        }

        public static int AddNewLoginRegister(int UserID, bool IsSuccess, string ClientMachine)
        {
            int LoginID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
                string query = @"INSERT INTO LoginRegisters (UserID, LoginDate, IsSuccess, ClientMachine)
                                 VALUES (@UserID, GETDATE(), @IsSuccess, @ClientMachine);
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@IsSuccess", IsSuccess);

                if (!string.IsNullOrEmpty(ClientMachine))
                    command.Parameters.AddWithValue("@ClientMachine", ClientMachine);
                else
                    command.Parameters.AddWithValue("@ClientMachine", DBNull.Value);

                try
                {
                     connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    {
                        LoginID = insertedID;
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                connection.Close();
                }
            
            return LoginID;
        }

        public static DataTable GetLoginRegistersByUserID(int UserID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                    L.LoginID,
                                    L.UserID,
                                    U.UserName,
                                    L.LoginDate,
                                    L.IsSuccess,
                                    L.ClientMachine
                                 FROM LoginRegisters L
                                 INNER JOIN Users U ON U.UserID = L.UserID
                                 WHERE L.UserID = @UserID
                                 ORDER BY L.LoginDate DESC";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", UserID);

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
                    // TODO: log exception
                }
            }
            return dt;
        }
    }
}