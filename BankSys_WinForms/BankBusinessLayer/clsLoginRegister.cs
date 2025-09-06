using System;
using System.Data;
using BankDataAccessLayer;

namespace BankBusinessLayer
{
    public class clsLoginRegister
    {
        public int LoginID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsSuccess { get; set; }
        public string ClientMachine { get; set; }

        public clsLoginRegister()
        {
            LoginID = -1;
            UserID = -1;
            UserName = "";
            LoginDate = DateTime.Now;
            IsSuccess = false;
            ClientMachine = "";
        }

        private bool _AddNewLoginRegister()
        {
            this.LoginID = clsLoginRegister.AddNewLoginRegister(this.UserID, this.IsSuccess, this.ClientMachine);

            return (this.LoginID != -1);
        }

        public static DataTable GetAllLoginRegisters()
        {
            return clsLoginRegisterDataAccess.GetAllLoginRegisters();
        }

        public static DataTable GetLoginRegistersByUserID(int UserID)
        {
            return clsLoginRegisterDataAccess.GetLoginRegistersByUserID(UserID);
        }

        public static int AddNewLoginRegister(int UserID, bool IsSuccess, string ClientMachine)
        {
            return clsLoginRegisterDataAccess.AddNewLoginRegister(UserID, IsSuccess, ClientMachine);
        }
    }
}