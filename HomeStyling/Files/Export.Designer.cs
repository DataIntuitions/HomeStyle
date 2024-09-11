namespace HomeStyling.Files
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExportListType = new System.Windows.Forms.ComboBox();
            this.ExportSendEmail = new System.Windows.Forms.Button();
            this.ExportSendCSV = new System.Windows.Forms.Button();
            this.ExportSentClipboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerManagementLabel
            // 
            resources.ApplyResources(this.CustomerManagementLabel, "CustomerManagementLabel");
            this.CustomerManagementLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
            this.CustomerManagementLabel.Click += new System.EventHandler(this.CustomerManagementLabel_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            // 
            // ExportListType
            // 
            this.ExportListType.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.ExportListType.AllowDrop = true;
            this.ExportListType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            resources.ApplyResources(this.ExportListType, "ExportListType");
            this.ExportListType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ExportListType.FormattingEnabled = true;
            this.ExportListType.Items.AddRange(new object[] {
            resources.GetString("ExportListType.Items")});
            this.ExportListType.Name = "ExportListType";
            // 
            // ExportSendEmail
            // 
            this.ExportSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.ExportSendEmail, "ExportSendEmail");
            this.ExportSendEmail.CausesValidation = false;
            this.ExportSendEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportSendEmail.FlatAppearance.BorderSize = 0;
            this.ExportSendEmail.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ExportSendEmail.Name = "ExportSendEmail";
            this.ExportSendEmail.UseVisualStyleBackColor = false;
            this.ExportSendEmail.Click += new System.EventHandler(this.ExportSendEmail_Click);
            // 
            // ExportSendCSV
            // 
            this.ExportSendCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.ExportSendCSV, "ExportSendCSV");
            this.ExportSendCSV.CausesValidation = false;
            this.ExportSendCSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportSendCSV.FlatAppearance.BorderSize = 0;
            this.ExportSendCSV.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ExportSendCSV.Name = "ExportSendCSV";
            this.ExportSendCSV.UseVisualStyleBackColor = false;
            this.ExportSendCSV.Click += new System.EventHandler(this.ExportSendCSV_Click);
            // 
            // ExportSentClipboard
            // 
            this.ExportSentClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.ExportSentClipboard, "ExportSentClipboard");
            this.ExportSentClipboard.CausesValidation = false;
            this.ExportSentClipboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportSentClipboard.FlatAppearance.BorderSize = 0;
            this.ExportSentClipboard.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ExportSentClipboard.Name = "ExportSentClipboard";
            this.ExportSentClipboard.UseVisualStyleBackColor = false;
            this.ExportSentClipboard.Click += new System.EventHandler(this.ExportSentClipboard_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Export
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExportSentClipboard);
            this.Controls.Add(this.ExportSendCSV);
            this.Controls.Add(this.ExportSendEmail);
            this.Controls.Add(this.ExportListType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Name = "Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox ExportListType;
        private System.Windows.Forms.Button ExportSendEmail;
        private System.Windows.Forms.Button ExportSendCSV;
        private System.Windows.Forms.Button ExportSentClipboard;
        private System.Windows.Forms.Button button1;
    }
}