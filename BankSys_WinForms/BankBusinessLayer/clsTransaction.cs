using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsTransaction
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public int TransactionRefNum { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransferFrom { get; set; }
        public string TransferTo { get; set; }
        public decimal? Commission { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTransaction()
        {
            TransactionID = -1;
            AccountID = -1;
            TransactionRefNum = -1;
            TransactionType = "";
            Amount = 0;
            TransactionDate = DateTime.Now;
            TransferFrom = "";
            TransferTo = "";
            Commission = null;
            CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }

        private clsTransaction(int TransactionID, int AccountID, int TransactionRefNum,
            string TransactionType, decimal Amount, DateTime TransactionDate,
            string TransferFrom, string TransferTo, decimal? Commission, int CreatedByUserID)
        {
            this.TransactionID = TransactionID;
            this.AccountID = AccountID;
            this.TransactionRefNum = TransactionRefNum;
            this.TransactionType = TransactionType;
            this.Amount = Amount;
            this.TransactionDate = TransactionDate;
            this.TransferFrom = TransferFrom;
            this.TransferTo = TransferTo;
            this.Commission = Commission;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        private bool _AddNewTransaction()
        {
            this.TransactionID = clsTransactionDataAccess.AddNewTransaction(
                this.AccountID, this.TransactionRefNum, this.TransactionType,
                this.Amount, this.TransactionDate, this.TransferFrom,
                this.TransferTo, this.Commission, this.CreatedByUserID);

            return (this.TransactionID != -1);
        }

        private bool _UpdateTransaction()
        {
            return clsTransactionDataAccess.UpdateTransaction(
                this.TransactionID, this.AccountID, this.TransactionRefNum,
                this.TransactionType, this.Amount, this.TransactionDate,
                this.TransferFrom, this.TransferTo, this.Commission, this.CreatedByUserID);
        }

        public static clsTransaction Find(int TransactionID)
        {
            int AccountID = -1, TransactionRefNum = -1, CreatedByUserID = -1;
            string TransactionType = "", TransferFrom = "", TransferTo = "";
            decimal Amount = 0;
            DateTime TransactionDate = DateTime.Now;
            decimal? Commission = null;

            if (clsTransactionDataAccess.GetTransactionInfoByID(TransactionID, ref AccountID,
                ref TransactionRefNum, ref TransactionType, ref Amount, ref TransactionDate,
                ref TransferFrom, ref TransferTo, ref Commission, ref CreatedByUserID))
            {
                return new clsTransaction(TransactionID, AccountID, TransactionRefNum,
                    TransactionType, Amount, TransactionDate, TransferFrom,
                    TransferTo, Commission, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTransaction())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateTransaction();
            }

            return false;
        }

        public static DataTable GetAllTransactions()
        {
            return clsTransactionDataAccess.GetAllTransactions();
        }

        public static DataTable GetCostomTransactions()
        {
            return clsTransactionDataAccess.GetAllCostomTransactions();
        }

        public static int GenerateTransactionNumber()
        {
            return clsTransactionDataAccess.GenerateTransactionRefNum();
        }

        public static DataTable GetTransactionsByAccountID(int AccountID)
        {
            return clsTransactionDataAccess.GetTransactionsByAccountID(AccountID);
        }

        public static bool DeleteTransaction(int TransactionID)
        {
            return clsTransactionDataAccess.DeleteTransaction(TransactionID);
        }

        public static bool IsTransactionExist(int TransactionID)
        {
            return clsTransactionDataAccess.IsTransactionExist(TransactionID);
        }

        public static bool UpdateAccountBalance(int AccountID, decimal Amount)
        {
            return clsTransactionDataAccess.UpdateAccountBalance(AccountID, Amount);
        }

        public static clsTransaction AddDepositTransaction(int AccountID, decimal Amount, int CreatedByUserID)
        {
            clsTransaction transaction = new clsTransaction();
            transaction.AccountID = AccountID;
            transaction.TransactionType = "إيداع";
            transaction.Amount = Amount;
            transaction.TransactionDate = DateTime.Now;
            transaction.TransferFrom = "";
            transaction.TransferTo = "";
            transaction.Commission = 0;
            transaction.CreatedByUserID = CreatedByUserID;
            transaction.TransactionRefNum = GenerateTransactionNumber();

            if (transaction.Save())
            {
                // Update account balance
                UpdateAccountBalance(AccountID, Amount);
                return transaction;
            }
            else
            {
                return null;
            }
        }

        public static clsTransaction AddWithdrawTransaction(int AccountID, decimal Amount, int CreatedByUserID)
        {
            clsTransaction transaction = new clsTransaction();
            transaction.AccountID = AccountID;
            transaction.TransactionType = "سحب";
            transaction.Amount = Amount;
            transaction.TransactionDate = DateTime.Now;
            transaction.TransferFrom = "";
            transaction.TransferTo = "";
            transaction.Commission = 0;
            transaction.CreatedByUserID = CreatedByUserID;
            transaction.TransactionRefNum = GenerateTransactionNumber();

            if (transaction.Save())
            {
                // Update account balance (negative amount for withdrawal)
                UpdateAccountBalance(AccountID, -Amount);
                return transaction;
            }
            else
            {
                return null;
            }
        }

        public static bool AddTransferTransaction(int FromAccountID, int ToAccountID,
            decimal Amount, decimal Commission, int CreatedByUserID)
        {
            try
            {
                clsAccount fromAccount = clsAccount.Find(FromAccountID);
                clsAccount toAccount = clsAccount.Find(ToAccountID);

                if (fromAccount == null || toAccount == null)
                    return false;

                int transactionRefNum = GenerateTransactionNumber();
                decimal netAmount = Amount - Commission;

                // Create withdrawal transaction for sender
                clsTransaction withdrawal = new clsTransaction();
                withdrawal.AccountID = FromAccountID;
                withdrawal.TransactionType = "تحويل";
                withdrawal.Amount = Amount;
                withdrawal.TransactionDate = DateTime.Now;
                withdrawal.TransferFrom = fromAccount.AccountNumber.ToString();
                withdrawal.TransferTo = toAccount.AccountNumber.ToString();
                withdrawal.Commission = Commission;
                withdrawal.CreatedByUserID = CreatedByUserID;
                withdrawal.TransactionRefNum = transactionRefNum;

                //// Create deposit transaction for receiver
                //clsTransaction deposit = new clsTransaction();
                //deposit.AccountID = ToAccountID;
                //deposit.TransactionType = "تحويل";
                //deposit.Amount = netAmount;
                //deposit.TransactionDate = DateTime.Now;
                //deposit.TransferFrom = fromAccount.AccountNumber.ToString();
                //deposit.TransferTo = toAccount.AccountNumber.ToString();
                //deposit.Commission = 0;
                //deposit.CreatedByUserID = CreatedByUserID;
                //deposit.TransactionRefNum = transactionRefNum;

                // Save both transactions
                if (withdrawal.Save())
                {
                    // Update account balances
                    UpdateAccountBalance(FromAccountID, -Amount + Commission); // Deduct from sender
                    UpdateAccountBalance(ToAccountID, Amount);  // Add to receiver
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable SearchTransactions(string searchText, DateTime? fromDate = null, DateTime? toDate = null)
        {
            // This would be implemented in data access layer with proper SQL query
            // For now, filter the existing data
            DataTable allTransactions = GetCostomTransactions();
            if (string.IsNullOrEmpty(searchText) && fromDate == null && toDate == null)
                return allTransactions;

            DataTable filtered = allTransactions.Clone();
            foreach (DataRow row in allTransactions.Rows)
            {
                bool matches = true;

                if (!string.IsNullOrEmpty(searchText))
                {
                    matches = row["معرف العملية"].ToString().Contains(searchText) ||
                             row["رقم مرجع العملية"].ToString().Contains(searchText) ||
                             row["نوع العملية"].ToString().Contains(searchText);
                }

                if (fromDate.HasValue)
                {
                    DateTime transactionDate = Convert.ToDateTime(row["تاريخ ووقت العملية"]);
                    matches = matches && transactionDate >= fromDate.Value;
                }

                if (toDate.HasValue)
                {
                    DateTime transactionDate = Convert.ToDateTime(row["تاريخ ووقت العملية"]);
                    matches = matches && transactionDate <= toDate.Value;
                }

                if (matches)
                {
                    filtered.ImportRow(row);
                }
            }

            return filtered;
        }
    }
}