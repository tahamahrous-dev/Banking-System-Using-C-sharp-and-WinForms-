using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsCurrencyDataAccess
    {
        public static bool GetCurrencyInfoByID(int CurrencyID, ref string Country,
            ref string Code, ref string Name, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencies WHERE CurrencyID = @CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    Name = (string)reader["Name"];
                    Rate = (double)reader["Rate/(15)"];
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

        public static bool GetCurrencyInfoByCode(string Code, ref int CurrencyID,
            ref string Country, ref string Name, ref double Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencies WHERE Code = @Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", Code);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CurrencyID = (int)reader["CurrencyID"];
                    Country = (string)reader["Country"];
                    Name = (string)reader["Name"];
                    Rate = (double)reader["Rate/(15)"];
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

        public static int AddNewCurrency(string Country, string Code, string Name, double Rate)
        {
            int CurrencyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Currencies (Country, Code, Name, [Rate/(1$)])
                            VALUES (@Country, @Code, @Name, @Rate);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CurrencyID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return CurrencyID;
        }

        public static bool UpdateCurrency(int CurrencyID, string Country, string Code,
            string Name, double Rate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Currencies 
                            SET Country = @Country,
                                Code = @Code,
                                Name = @Name,
                                [Rate/(15)] = @Rate
                            WHERE CurrencyID = @CurrencyID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);

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

        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Currencies";
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

        public static DataTable GetCostomCurrencies()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                [#] = CurrencyID, 
                                [اسم الدولة] = Country, 
                                [رمز عملة الدول] = Code,
                                [اسم العملة] = Name, 
                                [قيمة العملة مقابل 1 دولار] = [Rate/(1$)]
                                FROM Currencies 
                                ORDER BY CurrencyID";

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


        public static bool DeleteCurrency(int CurrencyID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Currencies WHERE CurrencyID = @CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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

        public static bool IsCurrencyExist(int CurrencyID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Currencies WHERE CurrencyID = @CurrencyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrencyID", CurrencyID);

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

        public static bool IsCurrencyExist(string Code)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Currencies WHERE Code = @Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", Code);

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
