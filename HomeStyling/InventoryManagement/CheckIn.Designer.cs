namespace HomeStyling.InventoryManagement
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.IItemNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IItemSelctedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IStylingAddress = new System.Windows.Forms.ComboBox();
            this.MoveItem = new System.Windows.Forms.Button();
            this.IItemCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.CehckInItem = new System.Windows.Forms.Button();
            this.GetStylingAddress = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IItemNr
            // 
            resources.ApplyResources(this.IItemNr, "IItemNr");
            this.IItemNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.IItemNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IItemNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.IItemNr.Name = "IItemNr";
            this.IItemNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IItemNr_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Name = "label1";
            // 
            // IItemSelctedName
            // 
            resources.ApplyResources(this.IItemSelctedName, "IItemSelctedName");
            this.IItemSelctedName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.IItemSelctedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IItemSelctedName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.IItemSelctedName.Name = "IItemSelctedName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Name = "label2";
            // 
            // IStylingAddress
            // 
            resources.ApplyResources(this.IStylingAddress, "IStylingAddress");
            this.IStylingAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.IStylingAddress.AllowDrop = true;
            this.IStylingAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.IStylingAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.IStylingAddress.FormattingEnabled = true;
            this.IStylingAddress.Name = "IStylingAddress";
            // 
            // MoveItem
            // 
            resources.ApplyResources(this.MoveItem, "MoveItem");
            this.MoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.MoveItem.CausesValidation = false;
            this.MoveItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.MoveItem.FlatAppearance.BorderSize = 0;
            this.MoveItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.MoveItem.Name = "MoveItem";
            this.MoveItem.UseVisualStyleBackColor = false;
            this.MoveItem.Click += new System.EventHandler(this.MoveItem_Click);
            // 
            // IItemCount
            // 
            resources.ApplyResources(this.IItemCount, "IItemCount");
            this.IItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.IItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.IItemCount.Name = "IItemCount";
            this.IItemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IItemCount_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            // 
            // CustomerManagementLabel
            // 
            resources.ApplyResources(this.CustomerManagementLabel, "CustomerManagementLabel");
            this.CustomerManagementLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
            this.CustomerManagementLabel.Click += new System.EventHandler(this.CustomerManagementLabel_Click);
            // 
            // CehckInItem
            // 
            resources.ApplyResources(this.CehckInItem, "CehckInItem");
            this.CehckInItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.CehckInItem.CausesValidation = false;
            this.CehckInItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.CehckInItem.FlatAppearance.BorderSize = 0;
            this.CehckInItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CehckInItem.Name = "CehckInItem";
            this.CehckInItem.UseVisualStyleBackColor = false;
            this.CehckInItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetStylingAddress
            // 
            resources.ApplyResources(this.GetStylingAddress, "GetStylingAddress");
            this.GetStylingAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.GetStylingAddress.CausesValidation = false;
            this.GetStylingAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.GetStylingAddress.FlatAppearance.BorderSize = 0;
            this.GetStylingAddress.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.GetStylingAddress.Name = "GetStylingAddress";
            this.GetStylingAddress.UseVisualStyleBackColor = false;
            this.GetStylingAddress.Click += new System.EventHandler(this.GetStylingAddress_Click);
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
            // 
            // CheckIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Done);
            this.Controls.Add(this.GetStylingAddress);
            this.Controls.Add(this.CehckInItem);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Controls.Add(this.IStylingAddress);
            this.Controls.Add(this.MoveItem);
            this.Controls.Add(this.IItemCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IItemSelctedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IItemNr);
            this.Controls.Add(this.label1);
            this.Name = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IItemNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IItemSelctedName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox IStylingAddress;
        private System.Windows.Forms.Button MoveItem;
        private System.Windows.Forms.TextBox IItemCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.Button CehckInItem;
        private System.Windows.Forms.Button GetStylingAddress;
        private System.Windows.Forms.Button Done;
    }
}