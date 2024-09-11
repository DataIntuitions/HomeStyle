namespace HomeStyling.Files
{
    partial class RestoreDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreDatabase));
            this.RestoreDB = new System.Windows.Forms.Button();
            this.ImportPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestoreDB
            // 
            this.RestoreDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.RestoreDB, "RestoreDB");
            this.RestoreDB.CausesValidation = false;
            this.RestoreDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.RestoreDB.FlatAppearance.BorderSize = 0;
            this.RestoreDB.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.RestoreDB.Name = "RestoreDB";
            this.RestoreDB.UseVisualStyleBackColor = false;
            this.RestoreDB.Click += new System.EventHandler(this.RestoreDB_Click);
            // 
            // ImportPath
            // 
            this.ImportPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ImportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ImportPath, "ImportPath");
            this.ImportPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ImportPath.Name = "ImportPath";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Name = "label1";
            // 
            // RestoreDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.RestoreDB);
            this.Controls.Add(this.ImportPath);
            this.Controls.Add(this.label1);
            this.Name = "RestoreDatabase";
            this.Load += new System.EventHandler(this.RestoreDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestoreDB;
        private System.Windows.Forms.TextBox ImportPath;
        private System.Windows.Forms.Label label1;
    }
}