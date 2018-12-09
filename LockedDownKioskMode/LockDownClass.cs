using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;

namespace LockedDownKioskMode
{
    class LockDownClass : Taskbar
    {
        //Assuming the User Profile Account is already created. I am going to use just a generic User/Pass for this
        
        //Global Variables Here
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
            //Call From Taskbar Class
            Hide();
            
            //Modify Registry to Lock Down Kiosk
            //Key1 Forces Kiosk to Auto Login on Bootup
            RegistryKey key1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            key1 = key1.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            if (key1 != null)
            {
                key1.SetValue("DefaultUserName", "Kiosk");
                key1.SetValue("AutoAdminLogon", 1, RegistryValueKind.DWord);
                key1.Close();
            }

            //Key2 Sets the Password For Kiosk Login
            RegistryKey key2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            key2 = key2.CreateSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
            if (key2 != null)
            {
                key2.SetValue("DefaultPassword", "Pa$$word1", RegistryValueKind.String);
                key2.Close();
            }

            //Key3 Forces Kiosk Program to Auto Start when Kiosk Logs in
            RegistryKey key3 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key3 = key3.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key3 != null)
            {
                key3.SetValue("KioskMode", @"C:\Homepage\LockedDownKioskMode.exe");
                //Needs to be Changed
                key3.Close();
            }

            //Key4 Disables the Task Manager and CTRL + ALT + DEL Menu Options: Change Password & Lock
            RegistryKey key4 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key4 = key4.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            key4.SetValue("DisableTaskmgr", 1);
            key4.SetValue("DisableChangePassword", 1);
            key4.SetValue("DisableLockWorkstation", 1);
            key4.Close();

            //Key5 Disables CTRL + ALT + DEL Menu Option Logoff
            RegistryKey key5 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key5 = key5.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);
            key5.SetValue("NoLogoff", 1);
            key5.Close();

            //Key6 Removes the Nav Bar from IE
            RegistryKey key6 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            key6 = key6.CreateSubKey(@"Software\Policies\Microsoft\Internet Explorer\Toolbars\Restrictions", true);            
            key6.SetValue("NoNavBar", 1);
            key6.Close();
            
            //Key7 Removes the Command Bar from IE
            RegistryKey key7 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            key7 = key7.CreateSubKey(@"Software\Policies\Microsoft\Internet Explorer\Toolbars\Restrictions", true);
            key7.SetValue("NoCommandBar", 1);
            key7.Close();
            
        }

        //Prevent Sleep Mode
        public static void PreventSleep()
        {
            SetThreadExecutionState(ExecutionState.EsContinuous | ExecutionState.EsSystemRequired);
        }
    }
}
