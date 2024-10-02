namespace HomeStyling.InventoryManagement
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OItemNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OItemSelctedName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OItemCount = new System.Windows.Forms.TextBox();
            this.OExportList = new System.Windows.Forms.Button();
            this.CheckoutItem = new System.Windows.Forms.Button();
            this.ExportEmail = new System.Windows.Forms.Button();
            this.ExportClipboard = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.OSelectedStylingAddressDropdoen = new System.Windows.Forms.ComboBox();
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
            // OItemNr
            // 
            resources.ApplyResources(this.OItemNr, "OItemNr");
            this.OItemNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.OItemNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OItemNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.OItemNr.Name = "OItemNr";
            this.OItemNr.TextChanged += new System.EventHandler(this.OItemNr_TextChanged);
            this.OItemNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OItemNr_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Name = "label2";
            // 
            // OItemSelctedName
            // 
            resources.ApplyResources(this.OItemSelctedName, "OItemSelctedName");
            this.OItemSelctedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.OItemSelctedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OItemSelctedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.OItemSelctedName.Name = "OItemSelctedName";
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // OItemCount
            // 
            resources.ApplyResources(this.OItemCount, "OItemCount");
            this.OItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.OItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.OItemCount.Name = "OItemCount";
            this.OItemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OItemCount_KeyPress);
            // 
            // OExportList
            // 
            resources.ApplyResources(this.OExportList, "OExportList");
            this.OExportList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.OExportList.CausesValidation = false;
            this.OExportList.Cursor = System.Windows.Forms.Cursors.Default;
            this.OExportList.FlatAppearance.BorderSize = 0;
            this.OExportList.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.OExportList.Name = "OExportList";
            this.OExportList.UseVisualStyleBackColor = false;
            this.OExportList.Click += new System.EventHandler(this.OExportList_Click);
            // 
            // CheckoutItem
            // 
            resources.ApplyResources(this.CheckoutItem, "CheckoutItem");
            this.CheckoutItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.CheckoutItem.CausesValidation = false;
            this.CheckoutItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckoutItem.FlatAppearance.BorderSize = 0;
            this.CheckoutItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CheckoutItem.Name = "CheckoutItem";
            this.CheckoutItem.UseVisualStyleBackColor = false;
            this.CheckoutItem.Click += new System.EventHandler(this.CheckoutItem_Click);
            // 
            // ExportEmail
            // 
            resources.ApplyResources(this.ExportEmail, "ExportEmail");
            this.ExportEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.ExportEmail.CausesValidation = false;
            this.ExportEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportEmail.FlatAppearance.BorderSize = 0;
            this.ExportEmail.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ExportEmail.Name = "ExportEmail";
            this.ExportEmail.UseVisualStyleBackColor = false;
            this.ExportEmail.Click += new System.EventHandler(this.ExportEmail_Click);
            // 
            // ExportClipboard
            // 
            resources.ApplyResources(this.ExportClipboard, "ExportClipboard");
            this.ExportClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.ExportClipboard.CausesValidation = false;
            this.ExportClipboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportClipboard.FlatAppearance.BorderSize = 0;
            this.ExportClipboard.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ExportClipboard.Name = "ExportClipboard";
            this.ExportClipboard.UseVisualStyleBackColor = false;
            this.ExportClipboard.Click += new System.EventHandler(this.ExportClipboard_Click);
            // 
            // Done
            // 
            resources.ApplyResources(this.Done, "Done");
            this.Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.Done.CausesValidation = false;
            this.Done.Cursor = System.Windows.Forms.Cursors.Default;
            this.Done.FlatAppearance.BorderSize = 0;
            this.Done.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Done.Name = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // OSelectedStylingAddressDropdoen
            // 
            resources.ApplyResources(this.OSelectedStylingAddressDropdoen, "OSelectedStylingAddressDropdoen");
            this.OSelectedStylingAddressDropdoen.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.OSelectedStylingAddressDropdoen.AllowDrop = true;
            this.OSelectedStylingAddressDropdoen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.OSelectedStylingAddressDropdoen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.OSelectedStylingAddressDropdoen.FormattingEnabled = true;
            this.OSelectedStylingAddressDropdoen.Name = "OSelectedStylingAddressDropdoen";
            // 
            // Checkout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.OSelectedStylingAddressDropdoen);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.ExportClipboard);
            this.Controls.Add(this.ExportEmail);
            this.Controls.Add(this.CheckoutItem);
            this.Controls.Add(this.OExportList);
            this.Controls.Add(this.OItemCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OItemSelctedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OItemNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Name = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OItemNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OItemSelctedName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OItemCount;
        private System.Windows.Forms.Button OExportList;
        private System.Windows.Forms.Button CheckoutItem;
        private System.Windows.Forms.Button ExportEmail;
        private System.Windows.Forms.Button ExportClipboard;
        private System.Windows.Forms.Button Done;
        public System.Windows.Forms.ComboBox OSelectedStylingAddressDropdoen;
    }
}