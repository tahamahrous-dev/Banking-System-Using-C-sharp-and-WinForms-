using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccessLayer
{
    public class clsTransactionDataAccess
    {
        public static bool GetTransactionInfoByID(int TransactionID, ref int AccountID,
            ref int TransactionRefNum, ref string TransactionType, ref decimal Amount,
            ref DateTime TransactionDate, ref string TransferFrom, ref string TransferTo,
            ref decimal? Commission, ref int CreatedByUserID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT AccountID, TransactionRefNum, TransactionType, Amount, 
                                TransactionDate, TransferFrom, TransferTo, Commission, CreatedByUserID 
                                FROM AccountTransactions WHERE TransactionID = @TransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", TransactionID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                AccountID = (int)reader["AccountID"];
                                TransactionRefNum = (int)reader["TransactionRefNum"];
                                TransactionType = (string)reader["TransactionType"];
                                Amount = (decimal)reader["Amount"];
                                TransactionDate = (DateTime)reader["TransactionDate"];

                                TransferFrom = reader["TransferFrom"] == DBNull.Value ? "" : (string)reader["TransferFrom"];
                                TransferTo = reader["TransferTo"] == DBNull.Value ? "" : (string)reader["TransferTo"];
                                Commission = reader["Commission"] == DBNull.Value ? null : (decimal?)reader["Commission"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                        // Log exception
                    }
                }
            }
            return isFound;
        }

        public static int AddNewTransaction(int AccountID, int TransactionRefNum,
            string TransactionType, decimal Amount, DateTime TransactionDate,
            string TransferFrom, string TransferTo, decimal? Commission, int CreatedByUserID)
        {
            int TransactionID = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO AccountTransactions 
                                (AccountID, TransactionRefNum, TransactionType, Amount, 
                                 TransactionDate, TransferFrom, TransferTo, Commission, CreatedByUserID)
                                OUTPUT INSERTED.TransactionID
                                VALUES (@AccountID, @TransactionRefNum, @TransactionType, @Amount, 
                                        @TransactionDate, @TransferFrom, @TransferTo, @Commission, @CreatedByUserID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@TransactionRefNum", TransactionRefNum);
                    command.Parameters.AddWithValue("@TransactionType", TransactionType);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    command.Parameters.AddWithValue("@TransferFrom", string.IsNullOrEmpty(TransferFrom) ? (object)DBNull.Value : TransferFrom);
                    command.Parameters.AddWithValue("@TransferTo", string.IsNullOrEmpty(TransferTo) ? (object)DBNull.Value : TransferTo);
                    command.Parameters.AddWithValue("@Commission", Commission.HasValue ? (object)Commission.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            TransactionID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log exception
                    }
                }
            }
            return TransactionID;
        }

        public static bool UpdateTransaction(int TransactionID, int AccountID, int TransactionRefNum,
            string TransactionType, decimal Amount, DateTime TransactionDate,
            string TransferFrom, string TransferTo, decimal? Commission, int CreatedByUserID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE AccountTransactions 
                                SET AccountID = @AccountID,
                                    TransactionRefNum = @TransactionRefNum,
                                    TransactionType = @TransactionType,
                                    Amount = @Amount,
                                    TransactionDate = @TransactionDate,
                                    TransferFrom = @TransferFrom,
                                    TransferTo = @TransferTo,
                                    Commission = @Commission,
                                    CreatedByUserID = @CreatedByUserID
                                WHERE TransactionID = @TransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", TransactionID);
                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@TransactionRefNum", TransactionRefNum);
                    command.Parameters.AddWithValue("@TransactionType", TransactionType);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    command.Parameters.AddWithValue("@TransferFrom", string.IsNullOrEmpty(TransferFrom) ? (object)DBNull.Value : TransferFrom);
                    command.Parameters.AddWithValue("@TransferTo", string.IsNullOrEmpty(TransferTo) ? (object)DBNull.Value : TransferTo);
                    command.Parameters.AddWithValue("@Commission", Commission.HasValue ? (object)Commission.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log exception
                        return false;
                    }
                }
            }
            return rowsAffected > 0;
        }

        public static DataTable GetAllTransactions()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM AccountTransactions ORDER BY TransactionDate DESC";
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

        public static DataTable GetAllCostomTransactions()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT 
                                [معرف العملية] = TransactionID, 
                                [معرف الحساب] = AccountID, 
                                [نوع العملية] = TransactionType,
                                [مبلغ العملية] = Amount, 
                                [رقم مرجع العملية] = TransactionRefNum, 
                                [تاريخ ووقت العملية] = TransactionDate,
                                [التحويل من] = ISNULL(TransferFrom, ''), 
                                [التحويل إلى] = ISNULL(TransferTo, ''), 
                                [العمولة] = ISNULL(Commission, 0)
                                FROM AccountTransactions 
                                ORDER BY TransactionDate DESC";

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

        public static int GenerateTransactionRefNum()
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT ISNULL(MAX(TransactionRefNum), 1000) + 1 FROM AccountTransactions";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 1001;
                    }
                    catch (Exception ex)
                    {
                        return 1001;
                    }
                }
            }
        }

        public static DataTable GetTransactionsByAccountID(int AccountID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT TransactionID, TransactionRefNum, TransactionType, 
                                Amount, TransactionDate, TransferFrom, TransferTo, Commission
                                FROM AccountTransactions 
                                WHERE AccountID = @AccountID 
                                ORDER BY TransactionDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static bool DeleteTransaction(int TransactionID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "DELETE FROM AccountTransactions WHERE TransactionID = @TransactionID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", TransactionID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Log exception
                    }
                }
            }
            return rowsAffected > 0;
        }

        public static bool IsTransactionExist(int TransactionID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM AccountTransactions WHERE TransactionID = @TransactionID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TransactionID", TransactionID);

                    try
                    {
                        connection.Open();
                        isFound = Convert.ToInt32(command.ExecuteScalar()) > 0;
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        // New method to update account balance
        public static bool UpdateAccountBalance(int AccountID, decimal Amount)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Accounts 
                                SET AccountBalance = AccountBalance + @Amount 
                                WHERE AccountID = @AccountID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountID", AccountID);
                    command.Parameters.AddWithValue("@Amount", Amount);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return rowsAffected > 0;
        }
    }
}