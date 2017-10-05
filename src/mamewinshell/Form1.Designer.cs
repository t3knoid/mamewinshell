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
            this.textBoxPathToMame.Location = new System.Drawing.Point(148, 72);
            this.textBoxPathToMame.Name = "textBoxPathToMame";
            this.textBoxPathToMame.Size = new System.Drawing.Size(414, 20);
            this.textBoxPathToMame.TabIndex = 0;
            // 
            // labelPathToMame
            // 
            this.labelPathToMame.AutoSize = true;
            this.labelPathToMame.Location = new System.Drawing.Point(15, 74);
            this.labelPathToMame.Name = "labelPathToMame";
            this.labelPathToMame.Size = new System.Drawing.Size(129, 13);
            this.labelPathToMame.TabIndex = 1;
            this.labelPathToMame.Text = "Path to Mame Executable";
            // 
            // buttonBrowsePathToMame
            // 
            this.buttonBrowsePathToMame.Location = new System.Drawing.Point(487, 100);
            this.buttonBrowsePathToMame.Name = "buttonBrowsePathToMame";
            this.buttonBrowsePathToMame.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowsePathToMame.TabIndex = 2;
            this.buttonBrowsePathToMame.Text = "&Browse...";
            this.buttonBrowsePathToMame.UseVisualStyleBackColor = true;
            this.buttonBrowsePathToMame.Click += new System.EventHandler(this.buttonBrowsePathToMame_Click);
            // 
            // textBoxMameParameters
            // 
            this.textBoxMameParameters.Location = new System.Drawing.Point(148, 134);
            this.textBoxMameParameters.Name = "textBoxMameParameters";
            this.textBoxMameParameters.Size = new System.Drawing.Size(414, 20);
            this.textBoxMameParameters.TabIndex = 3;
            // 
            // labelMameParameters
            // 
            this.labelMameParameters.AutoSize = true;
            this.labelMameParameters.Location = new System.Drawing.Point(49, 135);
            this.labelMameParameters.Name = "labelMameParameters";
            this.labelMameParameters.Size = new System.Drawing.Size(92, 13);
            this.labelMameParameters.TabIndex = 4;
            this.labelMameParameters.Text = "Mame Parameters";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(373, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(487, 226);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "&Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(285, 226);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
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
            this.richTextBox1.Location = new System.Drawing.Point(16, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 44);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "The Mame Windows Shell configures Windows to use Mame as the default shell. Selec" +
    "t the Mame executable and enter optional Mame parameters. ";
            // 
            // checkBoxShutdown
            // 
            this.checkBoxShutdown.AutoSize = true;
            this.checkBoxShutdown.Location = new System.Drawing.Point(380, 171);
            this.checkBoxShutdown.Name = "checkBoxShutdown";
            this.checkBoxShutdown.Size = new System.Drawing.Size(188, 17);
            this.checkBoxShutdown.TabIndex = 10;
            this.checkBoxShutdown.Text = "Shutdown Windows on Mame Exit";
            this.checkBoxShutdown.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 262);
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
            this.Name = "Form1";
            this.Text = "Form1";
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

