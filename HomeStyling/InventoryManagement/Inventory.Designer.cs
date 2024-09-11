namespace HomeStyling.CustomerManagement
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.ItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.ItemCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemCountBeforeSale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ItemSupplier = new System.Windows.Forms.TextBox();
            this.CreateInventory = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteInventory = new System.Windows.Forms.Button();
            this.SaveInventory = new System.Windows.Forms.Button();
            this.FindInventory = new System.Windows.Forms.Button();
            this.InventoryAddPhoto = new System.Windows.Forms.Button();
            this.ItemId = new System.Windows.Forms.TextBox();
            this.InventoryActive = new CustomControls.RJControls.RJToggleButton();
            this.ItemImagePath = new System.Windows.Forms.TextBox();
            this.ViewPhoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ItemName, "ItemName");
            this.ItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ItemName.Name = "ItemName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Name = "label2";
            // 
            // ItemNr
            // 
            this.ItemNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ItemNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ItemNr, "ItemNr");
            this.ItemNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ItemNr.Name = "ItemNr";
            this.ItemNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemNr_KeyPress);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Name = "label1";
            // 
            // CustomerManagementLabel
            // 
            resources.ApplyResources(this.CustomerManagementLabel, "CustomerManagementLabel");
            this.CustomerManagementLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CustomerManagementLabel.Name = "CustomerManagementLabel";
            // 
            // ItemCount
            // 
            this.ItemCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ItemCount, "ItemCount");
            this.ItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ItemCount.Name = "ItemCount";
            this.ItemCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ItemCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCount_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ItemCountBeforeSale
            // 
            this.ItemCountBeforeSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ItemCountBeforeSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ItemCountBeforeSale, "ItemCountBeforeSale");
            this.ItemCountBeforeSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ItemCountBeforeSale.Name = "ItemCountBeforeSale";
            this.ItemCountBeforeSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCountBeforeSale_KeyPress);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Name = "label6";
            // 
            // ItemPrice
            // 
            this.ItemPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ItemPrice, "ItemPrice");
            this.ItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Name = "label7";
            // 
            // ItemSupplier
            // 
            this.ItemSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.ItemSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ItemSupplier, "ItemSupplier");
            this.ItemSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.ItemSupplier.Name = "ItemSupplier";
            // 
            // CreateInventory
            // 
            this.CreateInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.CreateInventory, "CreateInventory");
            this.CreateInventory.CausesValidation = false;
            this.CreateInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateInventory.FlatAppearance.BorderSize = 0;
            this.CreateInventory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CreateInventory.Name = "CreateInventory";
            this.CreateInventory.UseVisualStyleBackColor = false;
            this.CreateInventory.Click += new System.EventHandler(this.CreateInventory_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label13.Name = "label13";
            // 
            // DeleteInventory
            // 
            this.DeleteInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.DeleteInventory, "DeleteInventory");
            this.DeleteInventory.CausesValidation = false;
            this.DeleteInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteInventory.FlatAppearance.BorderSize = 0;
            this.DeleteInventory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.DeleteInventory.Name = "DeleteInventory";
            this.DeleteInventory.UseVisualStyleBackColor = false;
            this.DeleteInventory.Click += new System.EventHandler(this.DeleteInventory_Click);
            // 
            // SaveInventory
            // 
            this.SaveInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.SaveInventory, "SaveInventory");
            this.SaveInventory.CausesValidation = false;
            this.SaveInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveInventory.FlatAppearance.BorderSize = 0;
            this.SaveInventory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SaveInventory.Name = "SaveInventory";
            this.SaveInventory.UseVisualStyleBackColor = false;
            this.SaveInventory.Click += new System.EventHandler(this.SaveInventory_Click);
            // 
            // FindInventory
            // 
            this.FindInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.FindInventory, "FindInventory");
            this.FindInventory.CausesValidation = false;
            this.FindInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.FindInventory.FlatAppearance.BorderSize = 0;
            this.FindInventory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.FindInventory.Name = "FindInventory";
            this.FindInventory.UseVisualStyleBackColor = false;
            this.FindInventory.Click += new System.EventHandler(this.FindInventory_Click);
            // 
            // InventoryAddPhoto
            // 
            this.InventoryAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.InventoryAddPhoto, "InventoryAddPhoto");
            this.InventoryAddPhoto.CausesValidation = false;
            this.InventoryAddPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.InventoryAddPhoto.FlatAppearance.BorderSize = 0;
            this.InventoryAddPhoto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.InventoryAddPhoto.Name = "InventoryAddPhoto";
            this.InventoryAddPhoto.UseVisualStyleBackColor = false;
            this.InventoryAddPhoto.Click += new System.EventHandler(this.InventoryAddPhoto_Click);
            // 
            // ItemId
            // 
            resources.ApplyResources(this.ItemId, "ItemId");
            this.ItemId.Name = "ItemId";
            // 
            // InventoryActive
            // 
            resources.ApplyResources(this.InventoryActive, "InventoryActive");
            this.InventoryActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.InventoryActive.Name = "InventoryActive";
            this.InventoryActive.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.InventoryActive.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.InventoryActive.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.InventoryActive.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.InventoryActive.UseVisualStyleBackColor = false;
            // 
            // ItemImagePath
            // 
            resources.ApplyResources(this.ItemImagePath, "ItemImagePath");
            this.ItemImagePath.Name = "ItemImagePath";
            // 
            // ViewPhoto
            // 
            this.ViewPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.ViewPhoto, "ViewPhoto");
            this.ViewPhoto.CausesValidation = false;
            this.ViewPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.ViewPhoto.FlatAppearance.BorderSize = 0;
            this.ViewPhoto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ViewPhoto.Name = "ViewPhoto";
            this.ViewPhoto.UseVisualStyleBackColor = false;
            this.ViewPhoto.Click += new System.EventHandler(this.ViewPhoto_Click);
            // 
            // Inventory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.ViewPhoto);
            this.Controls.Add(this.ItemImagePath);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.InventoryAddPhoto);
            this.Controls.Add(this.CreateInventory);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.InventoryActive);
            this.Controls.Add(this.DeleteInventory);
            this.Controls.Add(this.SaveInventory);
            this.Controls.Add(this.FindInventory);
            this.Controls.Add(this.ItemSupplier);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemCountBeforeSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNr);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.TextBox ItemCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemCountBeforeSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ItemSupplier;
        private System.Windows.Forms.Button CreateInventory;
        private System.Windows.Forms.Label label13;
        private CustomControls.RJControls.RJToggleButton InventoryActive;
        private System.Windows.Forms.Button DeleteInventory;
        private System.Windows.Forms.Button SaveInventory;
        private System.Windows.Forms.Button FindInventory;
        private System.Windows.Forms.Button InventoryAddPhoto;
        private System.Windows.Forms.TextBox ItemId;
        private System.Windows.Forms.TextBox ItemImagePath;
        private System.Windows.Forms.Button ViewPhoto;
    }
}