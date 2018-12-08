using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockedDownKioskMode
{
    class LockDownClass
    {
        //Assuming the User Profile Account is already created. I am going to use just a generic User/Pass for this
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        [FlagsAttribute]
        private enum ExecutionState : uint
        {
            EsAwaymodeRequired = 0x00000040,
            EsContinuous = 0x80000000,
            EsDisplayRequired = 0x00000002,
            EsSystemRequired = 0x00000001
        }


        public void main()
        {
            RegistryKey key1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            key1 = key1.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            if (key1 != null)
            {
                key1.SetValue("DefaultUserName", "Kiosk");
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

            RegistryKey key3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key3 = key3.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key3 != null)
            {
                key3.SetValue("KioskMode", @"C:\Homepage\LockedDownKioskMode.exe");
                //Needs to be Changed
                key3.Close();
            }

            RegistryKey key4 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key4 = key4.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);

            key4.SetValue("DisableTaskmgr", 1);
            key4.SetValue("DisableChangePassword", 1);
            key4.SetValue("DisableLockWorkstation", 1);
            key4.Close();

            RegistryKey key5 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key5 = key5.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);

            key5.SetValue("NoLogoff", 1);
            key5.Close();

            string root = @"C:\Users\Setup\AppData\Local\Microsoft\Windows\WinX";
            // If directory does not exist, don't even try   
            if (Directory.Exists(root))
            {
                foreach (var item in Directory.GetFiles(root))
                {
                    File.Delete(item);
                }
                Directory.Delete(root);
            }
        }

        public static void PreventSleep()
        {
            SetThreadExecutionState(ExecutionState.EsContinuous | ExecutionState.EsSystemRequired);
        }
    }
}
