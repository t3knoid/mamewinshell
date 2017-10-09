using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace mamewinshell
{
    public class Config : ConfigurationSection
    {
        [ConfigurationProperty("Shutdown")]
        public bool shutdown
        {
            get { return (bool)this["Shutdown"]; }
            set { this["Shutdown"] = value; }
        }
        [ConfigurationProperty("PathtoMame")]
        public string pathtoMame
        {
            get { return (string)this["PathtoMame"]; }
            set { this["PathtoMame"] = value; }
        }
        [ConfigurationProperty("MameParameters")]
        public string mameParameters
        {
            get { return (string)this["MameParameters"]; }
            set { this["MameParameters"] = value; }
        }

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Config ()
        {
            
            shutdown = ConfigurationManager.AppSettings["Shutdown"] == "true";
            pathtoMame = ConfigurationManager.AppSettings["PathtoMame"];
            mameParameters = ConfigurationManager.AppSettings["MameParameters"];
        }

        public void Save()
        {
            AppSettingsSection appSettings = config.AppSettings;

            if (appSettings.IsReadOnly() == false)
            {
                appSettings.Settings.Remove("Shutdown");
                appSettings.Settings.Add("Shutdown", this.shutdown.ToString());
                appSettings.Settings.Remove("PathtoMame");
                appSettings.Settings.Add("PathtoMame", this.pathtoMame);
                appSettings.Settings.Remove("MameParameters");
                appSettings.Settings.Add("MameParameters", this.mameParameters);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

    }
}
