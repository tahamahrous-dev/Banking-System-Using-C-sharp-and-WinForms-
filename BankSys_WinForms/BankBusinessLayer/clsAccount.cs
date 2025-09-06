using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsAccount
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public int ClientID { get; set; }
        public int AccountCurrency { get; set; }
        public int AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public string Note { get; set; }

        public clsAccount()
        {
            AccountID = -1;
            AccountName = "";
            ClientID = -1;
            AccountCurrency = -1;
            AccountNumber = -1;
            AccountBalance = 0;
            Note = "";


            Mode = enMode.AddNew;
        }

        private clsAccount(int AccountID,string AccountName, int ClientID, int AccountCurrency,
            int AccountNumber, decimal AccountBalance, string Note)
        {
            this.AccountID = AccountID;
            this.AccountName = AccountName;
            this.ClientID = ClientID;
            this.AccountCurrency = AccountCurrency;
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;
            this.Note = Note;


            Mode = enMode.Update;
        }

        private bool _AddNewAccount()
        {
            this.AccountID = clsAccountDataAccess.AddNewAccount(
                this.AccountName, this.ClientID, this.AccountCurrency, this.AccountNumber,
                this.AccountBalance, this.Note);

            return (this.AccountID != -1);
        }

        private bool _UpdateAccount()
        {
            return clsAccountDataAccess.UpdateAccount(
                this.AccountID, this.AccountName, this.ClientID, this.AccountCurrency,
                this.AccountNumber, this.AccountBalance, this.Note);
        }

        public static int GenerateAccountNumber()
        {
            // Example: Random 10-digit account number
            Random rnd = new Random();
            return rnd.Next(1000, int.MaxValue);
        }

        public static clsAccount Find(int AccountID)
        {
            int ClientID = -1;
            int AccountCurrency = -1;
            int AccountNumber = -1;
            decimal AccountBalance = 0;
            string Note = "", AccountName = "";

            if (clsAccountDataAccess.GetAccountInfoByID(AccountID,ref AccountName ,ref ClientID,
                ref AccountCurrency, ref AccountNumber, ref AccountBalance, ref Note))
            {
                return new clsAccount(AccountID, AccountName, ClientID, AccountCurrency,
                    AccountNumber, AccountBalance, Note);
            }
            else
            {
                return null;
            }
        }

        public static void CreateDefaultAccountsForClient(int clientID)
        {
            DataTable currencies = clsCurrency.GetAllCurrencies();

            foreach (DataRow row in currencies.Rows)
            {
                if (row["Code"].ToString() == "YER" || row["Code"].ToString() == "SAR" || row["Code"].ToString() == "USD")
                {
                    clsAccount NewAccount = new clsAccount();
                    NewAccount.AccountName = row["Name"].ToString();
                    NewAccount.ClientID = clientID;
                    NewAccount.AccountCurrency = Convert.ToInt32(row["CurrencyID"]);
                    NewAccount.AccountNumber = GenerateAccountNumber();
                    NewAccount.AccountBalance = 0;
                    NewAccount.Note = "كود العملة" + row["Code"].ToString();

                    NewAccount.Save();
                }
                
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccount())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateAccount();
            }

            return false;
        }

        public static DataTable GetAllAccounts()
        {
            return clsAccountDataAccess.GetAllAccounts();
        }

        public static DataTable GetAllAccounts(int ClientID)
        {
            return clsAccountDataAccess.GetAllAccounts(ClientID);
        }

        public static DataTable GetCostomAccounts()
        {
            return clsAccountDataAccess.GetCostomAccounts();
        }

        public static bool DeleteAccount(int AccountID)
        {
            return clsAccountDataAccess.DeleteAccount(AccountID);
        }

        public static bool IsAccountExist(int AccountID)
        {
            return clsAccountDataAccess.IsAccountExist(AccountID);
        }

        public bool Deposit(decimal Amount)
        {
            this.AccountBalance += Amount;
            return Save();
        }

        public bool Withdraw(decimal Amount)
        {
            if (Amount > this.AccountBalance)
                return false;

            this.AccountBalance -= Amount;
            return Save();
        }

        public bool Transfer(clsAccount DestinationAccount, decimal Amount)
        {
            if (Amount > this.AccountBalance)
                return false;

            this.AccountBalance -= Amount;
            DestinationAccount.AccountBalance += Amount;

            bool SourceSaved = this.Save();
            bool DestinationSaved = DestinationAccount.Save();

            return (SourceSaved && DestinationSaved);
        }
    }
}
