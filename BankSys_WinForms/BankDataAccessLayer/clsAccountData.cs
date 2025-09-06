using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsAccountDataAccess
    {
        public static bool GetAccountInfoByID(int AccountID, ref string AccountName, ref int ClientID, ref int AccountCurrency,
            ref int AccountNumber, ref decimal AccountBalance, ref string Note)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts WHERE AccountID = @AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    AccountName = (string)reader["AccountName"];
                    ClientID = (int)reader["ClientID"];
                    AccountCurrency = (int)reader["AccountCurrency"];
                    AccountNumber = (int)reader["AccountNumber"];
                    AccountBalance = (decimal)reader["AccountBalance"];

                    if (reader["Note"] != DBNull.Value)
                        Note = (string)reader["Note"];
                    else
                        Note = "";
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

        public static int AddNewAccount(string AccountName, int ClientID, int AccountCurrency, int AccountNumber,
            decimal AccountBalance, string Note)
        {
            int AccountID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Accounts (AccountName,ClientID, AccountCurrency, AccountNumber, AccountBalance, Note)
                             VALUES (@AccountName, @ClientID, @AccountCurrency, @AccountNumber, @AccountBalance, @Note);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountName", AccountName);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountCurrency", AccountCurrency);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            if (!string.IsNullOrEmpty(Note))
                command.Parameters.AddWithValue("@Note", Note);
            else
                command.Parameters.AddWithValue("@Note", DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AccountID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return AccountID;
        }

        public static bool UpdateAccount(int AccountID, string AccountName, int ClientID, int AccountCurrency,
            int AccountNumber, decimal AccountBalance, string Note)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Accounts 
                            SET AccountName = @AccountName
                                ClientID = @ClientID,
                                AccountCurrency = @AccountCurrency,
                                AccountNumber = @AccountNumber,
                                AccountBalance = @AccountBalance,
                                Note = @Note
                            WHERE AccountID = @AccountID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@AccountName", AccountName);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AccountCurrency", AccountCurrency);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            if (!string.IsNullOrEmpty(Note))
                command.Parameters.AddWithValue("@Note", Note);
            else
                command.Parameters.AddWithValue("@Note", DBNull.Value);

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

        public static DataTable GetAllAccounts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts";
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

        public static DataTable GetAllAccounts(int ClientID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Accounts Where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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

        public static DataTable GetCostomAccounts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select AccountID as [#], [اسم الحساب] = AccountName,[عملة الحساب] = AccountCurrency, [رقم الحساب] = AccountNumber,
                            [رصيد الحساب] = AccountBalance, [ملاحظات] = Note 
                            from Accounts";
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

        public static bool DeleteAccount(int AccountID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Accounts WHERE AccountID = @AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static bool IsAccountExist(int AccountID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Accounts WHERE AccountID = @AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);

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
