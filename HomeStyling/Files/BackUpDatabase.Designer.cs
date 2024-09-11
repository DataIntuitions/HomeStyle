namespace HomeStyling.Files
{
    partial class BackUpDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUpDatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.ImportPath = new System.Windows.Forms.TextBox();
            this.BackUpDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Name = "label1";
            // 
            // ImportPath
            // 
            this.ImportPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ImportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ImportPath, "ImportPath");
            this.ImportPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ImportPath.Name = "ImportPath";
            // 
            // BackUpDB
            // 
            this.BackUpDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.BackUpDB, "BackUpDB");
            this.BackUpDB.CausesValidation = false;
            this.BackUpDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackUpDB.FlatAppearance.BorderSize = 0;
            this.BackUpDB.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.BackUpDB.Name = "BackUpDB";
            this.BackUpDB.UseVisualStyleBackColor = false;
            this.BackUpDB.Click += new System.EventHandler(this.BackUpDB_Click);
            // 
            // BackUpDatabase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.BackUpDB);
            this.Controls.Add(this.ImportPath);
            this.Controls.Add(this.label1);
            this.Name = "BackUpDatabase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImportPath;
        private System.Windows.Forms.Button BackUpDB;
    }
}