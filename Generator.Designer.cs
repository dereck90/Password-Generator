namespace Password_Generator
{
    partial class frmGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerator));
            grpOptions = new GroupBox();
            lblLength = new Label();
            numericLength = new NumericUpDown();
            grpPassword = new GroupBox();
            btnGenerate = new Button();
            btnCopy = new Button();
            tbPassword = new TextBox();
            grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericLength).BeginInit();
            grpPassword.SuspendLayout();
            SuspendLayout();
            // 
            // grpOptions
            // 
            grpOptions.Controls.Add(lblLength);
            grpOptions.Controls.Add(numericLength);
            grpOptions.Location = new Point(12, 3);
            grpOptions.Name = "grpOptions";
            grpOptions.Size = new Size(223, 64);
            grpOptions.TabIndex = 0;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(24, 29);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(97, 15);
            lblLength.TabIndex = 1;
            lblLength.Text = "Password Length";
            // 
            // numericLength
            // 
            numericLength.Location = new Point(127, 27);
            numericLength.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericLength.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericLength.Name = "numericLength";
            numericLength.ReadOnly = true;
            numericLength.Size = new Size(63, 23);
            numericLength.TabIndex = 0;
            numericLength.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // grpPassword
            // 
            grpPassword.Controls.Add(btnGenerate);
            grpPassword.Controls.Add(btnCopy);
            grpPassword.Controls.Add(tbPassword);
            grpPassword.Location = new Point(12, 73);
            grpPassword.Name = "grpPassword";
            grpPassword.Size = new Size(223, 88);
            grpPassword.TabIndex = 1;
            grpPassword.TabStop = false;
            grpPassword.Text = "Generated Password";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(55, 51);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(126, 23);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate Password";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(169, 22);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(48, 23);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(15, 22);
            tbPassword.Name = "tbPassword";
            tbPassword.ReadOnly = true;
            tbPassword.Size = new Size(148, 23);
            tbPassword.TabIndex = 0;
            // 
            // frmGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 173);
            Controls.Add(grpPassword);
            Controls.Add(grpOptions);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGenerator";
            Text = "Password Generator";
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericLength).EndInit();
            grpPassword.ResumeLayout(false);
            grpPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOptions;
        private Label lblLength;
        private NumericUpDown numericLength;
        private GroupBox grpPassword;
        private Button btnGenerate;
        private Button btnCopy;
        private TextBox tbPassword;
    }
}