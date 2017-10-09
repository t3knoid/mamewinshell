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
        private bool requiresSaving = false;


        public Form1()
        {
            InitializeComponent();
            this.checkBoxShutdown.Checked = config.shutdown;
            this.textBoxMameParameters.Text = config.mameParameters;
            this.textBoxPathToMame.Text = config.pathtoMame;
            this.checkBoxShutdown.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.textBoxMameParameters.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.textBoxPathToMame.TextChanged += new System.EventHandler(this.SomethingChanged);
            this.FormClosing += Form1_FormClosing;
        }

        private void SomethingChanged(object sender, EventArgs e)
        {
            requiresSaving = true;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (requiresSaving)
            {
                var result = MessageBox.Show("Save changes before exiting?", "Save Changes", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        config.Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            
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
            if (requiresSaving) ConfigSave();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

            private void buttonOK_Click(object sender, EventArgs e)
        {
            if (requiresSaving) ConfigSave();
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
