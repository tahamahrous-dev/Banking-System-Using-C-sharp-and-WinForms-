using System;
using System.Data;
using System.Windows.Forms;
using BankBusinessLayer;
using BankSys_WinForms;


namespace BankSys_WinForms
{
    internal class clsScreen
    {
        static public bool CheckAccessRights(clsUser.enPermissions Permission)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermission(Permission))
            {
                MessageBox.Show("ليس لديك صلاحيات وصول", "خطــــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
