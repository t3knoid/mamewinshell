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
        Config config = new Config();

        public Form1()
        {
            InitializeComponent();           
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
            ConfigSave();
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
            ConfigSave();
            Application.Exit();
        }

        private void ConfigSave()
        {
            config.shutdown = this.checkBoxShutdown.Checked;
            config.pathtoMame = this.textBoxPathToMame.Text;
            config.mameParameters = this.textBoxMameParameters.Text;

            try
            {
                config.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in saving. " + ex.Message);
            }

        }
    }
}
