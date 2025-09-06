using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsClient
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public string Personal_ID_Number { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public string UserName_OR_Phone { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        public clsClient()
        {
            ClientID = -1;
            FirstName = "";
            MidName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Gender = "";
            Email = "";
            Phone = "";
            City = -1;
            Country = -1;
            Personal_ID_Number = "";
            Image = "";
            CreateDate = DateTime.Now;
            UserName_OR_Phone = "";
            Password = "";
            Permissions = 0;
            Mode = enMode.AddNew;
        }

        private clsClient(int ClientID, string FirstName, string MidName, string LastName,
            DateTime DateOfBirth, string Gender, string Email, string Phone, int City,
            int Country, string Personal_ID_Number, string Image, DateTime CreateDate,
            string UserName_OR_Phone, string Password, int Permissions)
        {
            this.ClientID = ClientID;
            this.FirstName = FirstName;
            this.MidName = MidName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.City = City;
            this.Country = Country;
            this.Personal_ID_Number = Personal_ID_Number;
            this.Image = Image;
            this.CreateDate = CreateDate;
            this.UserName_OR_Phone = UserName_OR_Phone;
            this.Password = Password;
            this.Permissions = Permissions;
            Mode = enMode.Update;
        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientDataAccess.AddNewClient(
                this.FirstName, this.MidName, this.LastName,
                this.DateOfBirth, this.Gender, this.Email, this.Phone,
                this.City, this.Country, this.Personal_ID_Number,
                this.Image, this.UserName_OR_Phone, this.Password,
                this.Permissions);

            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            return clsClientDataAccess.UpdateClient(
                this.ClientID, this.FirstName, this.MidName, this.LastName,
                this.DateOfBirth, this.Gender, this.Email, this.Phone,
                this.City, this.Country, this.Personal_ID_Number,
                this.Image, this.UserName_OR_Phone, this.Password,
                this.Permissions);
        }

        public static clsClient Find(int ClientID)
        {
            string FirstName = "", MidName = "", LastName = "", Email = "", Phone = "";
            string Image = "", UserName_OR_Phone = "", Password = "";
            DateTime DateOfBirth = DateTime.Now, CreateDate = DateTime.Now;
            string Gender = "";
            string Personal_ID_Number = "";
            int Permissions = 0, City = -1, Country = -1;

            if (clsClientDataAccess.GetClientInfoByID(ClientID, ref FirstName, ref MidName,
                ref LastName, ref DateOfBirth, ref Gender, ref Email, ref Phone, ref City,
                ref Country, ref Personal_ID_Number, ref Image, ref CreateDate,
                ref UserName_OR_Phone, ref Password, ref Permissions))
            {
                return new clsClient(ClientID, FirstName, MidName, LastName,
                    DateOfBirth, Gender, Email, Phone, City, Country,
                    Personal_ID_Number, Image, CreateDate, UserName_OR_Phone,
                    Password, Permissions);
            }
            else
            {
                return null;
            }
        }

        public static clsClient Find(string UserName_OR_Phone)
        {
            string FirstName = "", MidName = "", LastName = "", Email = "", Phone = "";
            string Image = "", Password = "";
            DateTime DateOfBirth = DateTime.Now, CreateDate = DateTime.Now;
            string Gender = "";
            string Personal_ID_Number = "";
            int Permissions = 0, ClientID = -1, City = -1, Country = -1;

            if (clsClientDataAccess.GetClientInfoByID(ClientID, ref FirstName, ref MidName,
                ref LastName, ref DateOfBirth, ref Gender, ref Email, ref Phone, ref City,
                ref Country, ref Personal_ID_Number, ref Image, ref CreateDate,
                ref UserName_OR_Phone, ref Password, ref Permissions))
            {
                return new clsClient(ClientID, FirstName, MidName, LastName,
                    DateOfBirth, Gender, Email, Phone, City, Country,
                    Personal_ID_Number, Image, CreateDate, UserName_OR_Phone,
                    Password, Permissions);
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
                    if (_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateClient();
            }

            return false;
        }

        public static DataTable GetAllClients()
        {
            return clsClientDataAccess.GetAllClients();
        }

        public static DataTable GetCostomClients()
        {
            return clsClientDataAccess.GetCostomClients();
        }

        public static DataTable GetGenders()
        {
            return clsClientDataAccess.GetDistinctGenders();
        }

        public static DataTable GetAlmohafezas()
        {
            return clsClientDataAccess.GetAllAlmohafezas();
        }

        public static DataTable CostomAlmadireyahs(int AlmohafezaID)
        {
            return clsClientDataAccess.GetCostomAlmadireyahs(AlmohafezaID);
        }

        public static bool DeleteClient(int ClientID)
        {
            return clsClientDataAccess.DeleteClient(ClientID);
        }

        public static bool IsClientExist(int ClientID)
        {
            return clsClientDataAccess.IsClientExist(ClientID);
        }

        public static bool IsClientExist(string UserName_OR_Phone)
        {
            return clsClientDataAccess.IsClientExist(UserName_OR_Phone);
        }

        public DataTable GetAccounts()
        {
            return clsAccountDataAccess.GetAllAccounts();
        }
    }
}
