using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    class LockDownClass
    {
        //Assuming the User Profile Account is already created. I am going to use just a generic User/Pass for this

        public void main()
        {
            RegistryKey key1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            key1 = key1.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            if (key1 != null)
            {
                key1.SetValue("DefaultUserName", "Kiosk");
                //key1.SetValue("DefaultPassword", "Pa$$word1", RegistryValueKind.String);
                key1.SetValue("AutoAdminLogon", 1, RegistryValueKind.DWord);
                key1.Close();
            }

            RegistryKey key2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            key2 = key2.CreateSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            if (key2 != null)
            {
                key2.SetValue("DefaultPassword", "Pa$$word1", RegistryValueKind.String);
                key2.Close();
            }
        }
    }
}
