namespace mamewinshell
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPathToMame = new System.Windows.Forms.TextBox();
            this.labelPathToMame = new System.Windows.Forms.Label();
            this.buttonBrowsePathToMame = new System.Windows.Forms.Button();
            this.textBoxMameParameters = new System.Windows.Forms.TextBox();
            this.labelMameParameters = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxShutdown = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxPathToMame
            // 
            this.textBoxPathToMame.Location = new System.Drawing.Point(222, 111);
            this.textBoxPathToMame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPathToMame.Name = "textBoxPathToMame";
            this.textBoxPathToMame.Size = new System.Drawing.Size(619, 26);
            this.textBoxPathToMame.TabIndex = 0;
            this.textBoxPathToMame.Text = config.pathtoMame;

            // 
            // labelPathToMame
            // 
            this.labelPathToMame.AutoSize = true;
            this.labelPathToMame.Location = new System.Drawing.Point(22, 114);
            this.labelPathToMame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPathToMame.Name = "labelPathToMame";
            this.labelPathToMame.Size = new System.Drawing.Size(191, 20);
            this.labelPathToMame.TabIndex = 1;
            this.labelPathToMame.Text = "Path to Mame Executable";
            // 
            // buttonBrowsePathToMame
            // 
            this.buttonBrowsePathToMame.Location = new System.Drawing.Point(730, 154);
            this.buttonBrowsePathToMame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrowsePathToMame.Name = "buttonBrowsePathToMame";
            this.buttonBrowsePathToMame.Size = new System.Drawing.Size(112, 35);
            this.buttonBrowsePathToMame.TabIndex = 2;
            this.buttonBrowsePathToMame.Text = "&Browse...";
            this.buttonBrowsePathToMame.UseVisualStyleBackColor = true;
            this.buttonBrowsePathToMame.Click += new System.EventHandler(this.buttonBrowsePathToMame_Click);
            // 
            // textBoxMameParameters
            // 
            this.textBoxMameParameters.Location = new System.Drawing.Point(222, 206);
            this.textBoxMameParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMameParameters.Name = "textBoxMameParameters";
            this.textBoxMameParameters.Size = new System.Drawing.Size(619, 26);
            this.textBoxMameParameters.TabIndex = 3;
            this.textBoxMameParameters.Text = config.mameParameters;
            // 
            // labelMameParameters
            // 
            this.labelMameParameters.AutoSize = true;
            this.labelMameParameters.Location = new System.Drawing.Point(74, 208);
            this.labelMameParameters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMameParameters.Name = "labelMameParameters";
            this.labelMameParameters.Size = new System.Drawing.Size(139, 20);
            this.labelMameParameters.TabIndex = 4;
            this.labelMameParameters.Text = "Mame Parameters";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(560, 348);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(730, 348);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(112, 35);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(428, 348);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 35);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.exe";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(24, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(819, 68);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "The Mame Windows Shell configures Windows to use Mame as the default shell. Selec" +
    "t the Mame executable and enter optional Mame parameters. ";
            // 
            // checkBoxShutdown
            // 
            this.checkBoxShutdown.AutoSize = true;
            this.checkBoxShutdown.Checked = config.shutdown;
            this.checkBoxShutdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShutdown.Location = new System.Drawing.Point(570, 263);
            this.checkBoxShutdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxShutdown.Name = "checkBoxShutdown";
            this.checkBoxShutdown.Size = new System.Drawing.Size(275, 24);
            this.checkBoxShutdown.TabIndex = 10;
            this.checkBoxShutdown.Text = "Shutdown Windows on Mame Exit";
            this.checkBoxShutdown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 403);
            this.Controls.Add(this.checkBoxShutdown);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelMameParameters);
            this.Controls.Add(this.textBoxMameParameters);
            this.Controls.Add(this.buttonBrowsePathToMame);
            this.Controls.Add(this.labelPathToMame);
            this.Controls.Add(this.textBoxPathToMame);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Mame Windows Shell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPathToMame;
        private System.Windows.Forms.Label labelPathToMame;
        private System.Windows.Forms.Button buttonBrowsePathToMame;
        private System.Windows.Forms.TextBox textBoxMameParameters;
        private System.Windows.Forms.Label labelMameParameters;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxShutdown;
    }
}

