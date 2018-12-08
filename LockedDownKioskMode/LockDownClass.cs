using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private delegate int LowLevelKeyboardProcDelegate(int nCode, int
            wParam, ref KBDLLHOOKSTRUCT lParam);

        [DllImport("user32.dll", EntryPoint = "SetWindowsHookExA", CharSet = CharSet.Ansi)]
        private static extern int SetWindowsHookEx(
           int idHook,
           LowLevelKeyboardProcDelegate lpfn,
           int hMod,
           int dwThreadId);

        [DllImport("user32.dll")]
        private static extern int UnhookWindowsHookEx(int hHook);


        [DllImport("user32.dll", EntryPoint = "CallNextHookEx", CharSet = CharSet.Ansi)]
        private static extern int CallNextHookEx(
            int hHook, int nCode,
            int wParam, ref KBDLLHOOKSTRUCT lParam);


        const int WH_KEYBOARD_LL = 13;
        private int intLLKey;
        private KBDLLHOOKSTRUCT lParam;

        public void main()
        {
            KeyboardHook(this);
            
            /*
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
            */

            /*
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
            */
        }

        private struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            int scanCode;
            public int flags;
            int time;
            int dwExtraInfo;
        }

        private int LowLevelKeyboardProc(
            int nCode, int wParam,
            ref KBDLLHOOKSTRUCT lParam)
        {
            bool blnEat = false;
            switch (wParam)
            {
                case 256:
                case 257:
                case 260:
                case 261:
                    //Alt+Tab, Alt+Esc, Ctrl+Esc, Windows Key
                    if (((lParam.vkCode == 9) && (lParam.flags == 32)) ||
                    ((lParam.vkCode == 27) && (lParam.flags == 32)) || ((lParam.vkCode ==
                    27) && (lParam.flags == 0)) || ((lParam.vkCode == 91) && (lParam.flags
                    == 1)) || ((lParam.vkCode == 92) && (lParam.flags == 1)) || ((true) &&
                    (lParam.flags == 32)))
                    {
                        blnEat = true;
                    }
                    break;
            }

            if (blnEat)
                return 1;
            else return CallNextHookEx(0, nCode, wParam, ref lParam);

        }

        private void KeyboardHook(object sender)
        {
            intLLKey =
                SetWindowsHookEx(

                WH_KEYBOARD_LL,

                new LowLevelKeyboardProcDelegate(LowLevelKeyboardProc),

                System.Runtime.InteropServices.Marshal.GetHINSTANCE(
                  System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
        }

        private void ReleaseKeyboardHook()
        {
            intLLKey = UnhookWindowsHookEx(intLLKey);
        }

        public static void PreventSleep()
        {
            SetThreadExecutionState(ExecutionState.EsContinuous | ExecutionState.EsSystemRequired);
        }
    }
}
