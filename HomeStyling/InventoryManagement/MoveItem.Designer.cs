namespace HomeStyling.InventoryManagement
{
    partial class MoveItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveItem));
            this.MoveStylingAddress = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Move = new System.Windows.Forms.Button();
            this.CancelMoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoveStylingAddress
            // 
            this.MoveStylingAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.MoveStylingAddress.AllowDrop = true;
            this.MoveStylingAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            resources.ApplyResources(this.MoveStylingAddress, "MoveStylingAddress");
            this.MoveStylingAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.MoveStylingAddress.FormattingEnabled = true;
            this.MoveStylingAddress.Name = "MoveStylingAddress";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            // 
            // Move
            // 
            this.Move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.Move, "Move");
            this.Move.CausesValidation = false;
            this.Move.Cursor = System.Windows.Forms.Cursors.Default;
            this.Move.FlatAppearance.BorderSize = 0;
            this.Move.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Move.Name = "Move";
            this.Move.UseVisualStyleBackColor = false;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // CancelMoveItem
            // 
            this.CancelMoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.CancelMoveItem, "CancelMoveItem");
            this.CancelMoveItem.CausesValidation = false;
            this.CancelMoveItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelMoveItem.FlatAppearance.BorderSize = 0;
            this.CancelMoveItem.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CancelMoveItem.Name = "CancelMoveItem";
            this.CancelMoveItem.UseVisualStyleBackColor = false;
            this.CancelMoveItem.Click += new System.EventHandler(this.CancelMoveItem_Click);
            // 
            // MoveItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.CancelMoveItem);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MoveStylingAddress);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MoveItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox MoveStylingAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button CancelMoveItem;
    }
}