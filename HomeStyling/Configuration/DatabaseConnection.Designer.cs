﻿namespace HomeStyling.Configuration
{
    partial class DatabaseConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnection));
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.DatabaseFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveDatabasePath = new System.Windows.Forms.Button();
            this.CancelDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerManagementLabel
            // 
            resources.ApplyResources(this.CustomerManagementLabel, "CustomerManagementLabel");
            this.CustomerManagementLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
            this.CustomerManagementLabel.Click += new System.EventHandler(this.CustomerManagementLabel_Click);
            // 
            // DatabaseFilePath
            // 
            this.DatabaseFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.DatabaseFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DatabaseFilePath, "DatabaseFilePath");
            this.DatabaseFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.DatabaseFilePath.Name = "DatabaseFilePath";
            //this.DatabaseFilePath.TextChanged += new System.EventHandler(this.DatabaseFilePath_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            // 
            // SaveDatabasePath
            // 
            this.SaveDatabasePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.SaveDatabasePath, "SaveDatabasePath");
            this.SaveDatabasePath.CausesValidation = false;
            this.SaveDatabasePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveDatabasePath.FlatAppearance.BorderSize = 0;
            this.SaveDatabasePath.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SaveDatabasePath.Name = "SaveDatabasePath";
            this.SaveDatabasePath.UseVisualStyleBackColor = false;
            this.SaveDatabasePath.Click += new System.EventHandler(this.SaveDatabasePath_Click);
            // 
            // CancelDatabase
            // 
            this.CancelDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.CancelDatabase, "CancelDatabase");
            this.CancelDatabase.CausesValidation = false;
            this.CancelDatabase.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelDatabase.FlatAppearance.BorderSize = 0;
            this.CancelDatabase.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CancelDatabase.Name = "CancelDatabase";
            this.CancelDatabase.UseVisualStyleBackColor = false;
            this.CancelDatabase.Click += new System.EventHandler(this.CancelDatabase_Click);
            // 
            // DatabaseConnection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.CancelDatabase);
            this.Controls.Add(this.SaveDatabasePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DatabaseFilePath);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Name = "DatabaseConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.TextBox DatabaseFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveDatabasePath;
        private System.Windows.Forms.Button CancelDatabase;
    }
}