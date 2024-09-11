namespace HomeStyling.Files
{
    partial class ExportItemList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportItemList));
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.InputExportPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ExportSendAsCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerManagementLabel
            // 
            resources.ApplyResources(this.CustomerManagementLabel, "CustomerManagementLabel");
            this.CustomerManagementLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
            this.CustomerManagementLabel.Click += new System.EventHandler(this.CustomerManagementLabel_Click);
            // 
            // InputExportPath
            // 
            this.InputExportPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.InputExportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.InputExportPath, "InputExportPath");
            this.InputExportPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.InputExportPath.Name = "InputExportPath";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            // 
            // ExportSendAsCSV
            // 
            this.ExportSendAsCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.ExportSendAsCSV, "ExportSendAsCSV");
            this.ExportSendAsCSV.CausesValidation = false;
            this.ExportSendAsCSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportSendAsCSV.FlatAppearance.BorderSize = 0;
            this.ExportSendAsCSV.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ExportSendAsCSV.Name = "ExportSendAsCSV";
            this.ExportSendAsCSV.UseVisualStyleBackColor = false;
            this.ExportSendAsCSV.Click += new System.EventHandler(this.ExportSendAsCSV_Click);
            // 
            // ExportItemList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.ExportSendAsCSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputExportPath);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Name = "ExportItemList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.TextBox InputExportPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ExportSendAsCSV;
    }
}