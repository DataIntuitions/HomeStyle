namespace HomeStyling.Files
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ImportFromCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerManagementLabel
            // 
            resources.ApplyResources(this.CustomerManagementLabel, "CustomerManagementLabel");
            this.CustomerManagementLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
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
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Name = "label4";
            // 
            // ImportFromCSV
            // 
            this.ImportFromCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.ImportFromCSV, "ImportFromCSV");
            this.ImportFromCSV.CausesValidation = false;
            this.ImportFromCSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImportFromCSV.FlatAppearance.BorderSize = 0;
            this.ImportFromCSV.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ImportFromCSV.Name = "ImportFromCSV";
            this.ImportFromCSV.UseVisualStyleBackColor = false;
            this.ImportFromCSV.Click += new System.EventHandler(this.ImportFromCSV_Click);
            // 
            // Import
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.ImportFromCSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImportPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerManagementLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Name = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImportPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ImportFromCSV;
    }
}