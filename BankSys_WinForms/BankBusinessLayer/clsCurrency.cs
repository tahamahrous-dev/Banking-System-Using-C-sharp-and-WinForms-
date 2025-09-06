using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsCurrency
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int CurrencyID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }

        public clsCurrency()
        {
            CurrencyID = -1;
            Country = "";
            Code = "";
            Name = "";
            Rate = 0;
            Mode = enMode.AddNew;
        }

        private clsCurrency(int CurrencyID, string Country, string Code, string Name, double Rate)
        {
            this.CurrencyID = CurrencyID;
            this.Country = Country;
            this.Code = Code;
            this.Name = Name;
            this.Rate = Rate;
            Mode = enMode.Update;
        }

        private bool _AddNewCurrency()
        {
            this.CurrencyID = clsCurrencyDataAccess.AddNewCurrency(
                this.Country, this.Code, this.Name, this.Rate);

            return (this.CurrencyID != -1);
        }

        private bool _UpdateCurrency()
        {
            return clsCurrencyDataAccess.UpdateCurrency(
                this.CurrencyID, this.Country, this.Code, this.Name, this.Rate);
        }

        public static clsCurrency Find(int CurrencyID)
        {
            string Country = "", Code = "", Name = "";
            double Rate = 0;

            if (clsCurrencyDataAccess.GetCurrencyInfoByID(CurrencyID, ref Country,
                ref Code, ref Name, ref Rate))
            {
                return new clsCurrency(CurrencyID, Country, Code, Name, Rate);
            }
            else
            {
                return null;
            }
        }

        public static clsCurrency Find(string Code)
        {
            int CurrencyID = -1;
            string Country = "", Name = "";
            double Rate = 0;

            if (clsCurrencyDataAccess.GetCurrencyInfoByCode(Code, ref CurrencyID,
                ref Country, ref Name, ref Rate))
            {
                return new clsCurrency(CurrencyID, Country, Code, Name, Rate);
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
                    if (_AddNewCurrency())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCurrency();
            }

            return false;
        }

        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyDataAccess.GetAllCurrencies();
        }

        public static DataTable GetCostomCurrencies()
        {
            return clsCurrencyDataAccess.GetCostomCurrencies();
        }

        public static bool DeleteCurrency(int CurrencyID)
        {
            return clsCurrencyDataAccess.DeleteCurrency(CurrencyID);
        }

        public static bool IsCurrencyExist(int CurrencyID)
        {
            return clsCurrencyDataAccess.IsCurrencyExist(CurrencyID);
        }

        public static bool IsCurrencyExist(string Code)
        {
            return clsCurrencyDataAccess.IsCurrencyExist(Code);
        }

        public decimal ConvertToUSD(decimal Amount)
        {
            return Amount / (decimal)this.Rate;
        }

        public decimal ConvertFromUSD(decimal Amount)
        {
            return Amount * (decimal)this.Rate;
        }
    }
}
