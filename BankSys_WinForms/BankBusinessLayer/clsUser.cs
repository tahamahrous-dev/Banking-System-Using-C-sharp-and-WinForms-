using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enPermissions { eAll = -1, pClientsManagement = 1, pAccountsManagement = 2, pTranactionsManagement = 4, pUsersManagement = 8,
                                    pCurrencyManagement = 16, pLoginRegister = 32 };
        public int _Permissions;


        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public int Permissions { get; set; }
        public string Image { get; set; }

        public clsUser()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            CreateDate = DateTime.Now;
            Permissions = 0;
            Image = "";
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string UserName, string Password, string FirstName,
            string LastName, string Email, string Phone, DateTime CreateDate,
            int Permissions, string Image)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.CreateDate = CreateDate;
            this.Permissions = Permissions;
            this.Image = Image;
            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(
                this.UserName, this.Password, this.FirstName, this.LastName,
                this.Email, this.Phone, this.Permissions, this.Image);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(
                this.UserID, this.UserName, this.Password, this.FirstName,
                this.LastName, this.Email, this.Phone, this.Permissions, this.Image);
        }

        public static clsUser Find(int UserID)
        {
            string UserName = "", Password = "", FirstName = "", LastName = "";
            string Email = "", Phone = "", Image = "";
            DateTime CreateDate = DateTime.Now;
            int Permissions = 0;

            if (clsUserDataAccess.GetUserInfoByID(UserID, ref UserName, ref Password,
                ref FirstName, ref LastName, ref Email, ref Phone, ref CreateDate,
                ref Permissions, ref Image))
            {
                return new clsUser(UserID, UserName, Password, FirstName, LastName,
                    Email, Phone, CreateDate, Permissions, Image);
            }
            else
            {
                return null;
            }
        }

        public static clsUser Find(string UserName)
        {
            int UserID = -1;
            string Password = "", FirstName = "", LastName = "";
            string Email = "", Phone = "", Image = "";
            DateTime CreateDate = DateTime.Now;
            int Permissions = 0;

            if (clsUserDataAccess.GetUserInfoByUserName(UserName, ref UserID, ref Password,
                ref FirstName, ref LastName, ref Email, ref Phone, ref CreateDate,
                ref Permissions, ref Image))
            {
                return new clsUser(UserID, UserName, Password, FirstName, LastName,
                    Email, Phone, CreateDate, Permissions, Image);
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
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static DataTable GetCostomUsers()
        {
            return clsUserDataAccess.GetAllCostomUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserDataAccess.IsUserExist(UserID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserDataAccess.IsUserExist(UserName);
        }

        public DataTable GetLoginHistory()
        {
            return clsLoginRegisterDataAccess.GetLoginRegistersByUserID(this.UserID);
        }


        public bool CheckAccessPermission(enPermissions Permission)
        {
            if (this.Permissions == (int)enPermissions.eAll)
                return true;

            int Per = (int)Permission & this.Permissions;

            if (Per == (int)Permission)
                return true;
            else
                return false;

        }

        public bool HasPermission(int Permission)
        {
            return (this.Permissions & Permission) == Permission;
        }
    }
}
