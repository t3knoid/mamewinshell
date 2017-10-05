using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mamewinshell
{
    class NewShell
    {
        public void SetNewShell(string shell)
        {
            try
            {
                // Disable Task Manager
                //regKey = Registry.CurrentUser.OpenSubKey(subKey, true).CreateSubKey("System");
                //regKey.SetValue("DisableTaskMgr", 1);
                //regKey.Close();
                // Change the Local Machine shell executable
                var regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
                regKey.SetValue("Shell", shell, RegistryValueKind.String);
                regKey.Close();
                // Create the Shell executable Registry entry for Current User
                regKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion\Winlogon", true);
                regKey.SetValue("Shell", shell);
                regKey.Close();
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }
    }
}
