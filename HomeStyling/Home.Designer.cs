using System.Drawing;
using System.Windows.Forms;

namespace HomeStyling
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundedButton2 = new HomeStyling.CSS.RoundedButton();
            this.roundedButton1 = new HomeStyling.CSS.RoundedButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            resources.ApplyResources(this.filesToolStripMenuItem, "filesToolStripMenuItem");
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.backUpToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.filesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            this.importToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            this.exportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // backUpToolStripMenuItem
            // 
            resources.ApplyResources(this.backUpToolStripMenuItem, "backUpToolStripMenuItem");
            this.backUpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            resources.ApplyResources(this.restoreToolStripMenuItem, "restoreToolStripMenuItem");
            this.restoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            resources.ApplyResources(this.customersToolStripMenuItem, "customersToolStripMenuItem");
            this.customersToolStripMenuItem.AutoToolTip = true;
            this.customersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.stylingsToolStripMenuItem});
            this.customersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.customersToolStripMenuItem.MergeIndex = 0;
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            resources.ApplyResources(this.customerToolStripMenuItem, "customerToolStripMenuItem");
            this.customerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.customerToolStripMenuItem.MergeIndex = 0;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // stylingsToolStripMenuItem
            // 
            resources.ApplyResources(this.stylingsToolStripMenuItem, "stylingsToolStripMenuItem");
            this.stylingsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.stylingsToolStripMenuItem.Name = "stylingsToolStripMenuItem";
            this.stylingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.stylingsToolStripMenuItem.Click += new System.EventHandler(this.stylingsToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            resources.ApplyResources(this.inventoryToolStripMenuItem, "inventoryToolStripMenuItem");
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem});
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // iToolStripMenuItem
            // 
            resources.ApplyResources(this.iToolStripMenuItem, "iToolStripMenuItem");
            this.iToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.iToolStripMenuItem.Name = "iToolStripMenuItem";
            this.iToolStripMenuItem.Click += new System.EventHandler(this.iToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            resources.ApplyResources(this.checkInToolStripMenuItem, "checkInToolStripMenuItem");
            this.checkInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click_1);
            // 
            // checkOutToolStripMenuItem
            // 
            resources.ApplyResources(this.checkOutToolStripMenuItem, "checkOutToolStripMenuItem");
            this.checkOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            resources.ApplyResources(this.configurationToolStripMenuItem, "configurationToolStripMenuItem");
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.appsettingToolStripMenuItem});
            this.configurationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            resources.ApplyResources(this.databaseToolStripMenuItem, "databaseToolStripMenuItem");
            this.databaseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // appsettingToolStripMenuItem
            // 
            resources.ApplyResources(this.appsettingToolStripMenuItem, "appsettingToolStripMenuItem");
            this.appsettingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.appsettingToolStripMenuItem.Name = "appsettingToolStripMenuItem";
            this.appsettingToolStripMenuItem.Click += new System.EventHandler(this.appsettingToolStripMenuItem_Click);
            // 
            // roundedButton2
            // 
            resources.ApplyResources(this.roundedButton2, "roundedButton2");
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
            this.roundedButton2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            resources.ApplyResources(this.roundedButton1, "roundedButton1");
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(96)))), ((int)(((byte)(131)))));
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appsettingToolStripMenuItem;
        private CSS.RoundedButton roundedButton1;
        private CSS.RoundedButton roundedButton2;
    }
}

