using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace mamewinshell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);  // the config that applies to all users
            AppSettingsSection appSettings = config.AppSettings;
            this.checkBoxShutdown.Checked = ConfigurationManager.AppSettings["Shutdown"] == "true";
            this.textBoxPathToMame.Text = ConfigurationManager.AppSettings["PathtoMame"];
            this.textBoxMameParameters.Text = ConfigurationManager.AppSettings["MameParameters"];
        }

        private void buttonBrowsePathToMame_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                this.textBoxPathToMame.Text = openFileDialog1.FileName.ToString();
            }

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Save settings
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);  // the config that applies to all users
            AppSettingsSection appSettings = config.AppSettings;
            if (appSettings.IsReadOnly() == false)
            {
                try
                {
                    appSettings.Settings.Remove("Shutdown");
                    appSettings.Settings.Add("Shutdown", this.checkBoxShutdown.Checked.ToString());
                    appSettings.Settings.Remove("PathtoMame");
                    appSettings.Settings.Add("PathtoMame", this.textBoxPathToMame.Text);
                    appSettings.Settings.Remove("MameParameters");
                    appSettings.Settings.Add("MameParameters", this.textBoxMameParameters.Text);
                    config.Save();
                    MessageBox.Show("Settings saved");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in saving. " + ex.Message);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to discard changes and exit?", "Cancel", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Save settings
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);  // the config that applies to all users
            AppSettingsSection appSettings = config.AppSettings;
            if (appSettings.IsReadOnly() == false)
            {
                appSettings.Settings.Remove("Shutdown");
                appSettings.Settings.Add("Shutdown", this.checkBoxShutdown.Checked.ToString());
                appSettings.Settings.Remove("PathtoMame");
                appSettings.Settings.Add("PathtoMame", this.textBoxPathToMame.Text);
                appSettings.Settings.Remove("MameParameters");
                appSettings.Settings.Add("MameParameters", this.textBoxMameParameters.Text);
                config.Save();
            }
            Application.Exit();
        }

    }
}
