namespace HomeStyling.InventoryManagement
{
    partial class ImageView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteInventory
            // 
            this.DeleteInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.DeleteInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteInventory.CausesValidation = false;
            this.DeleteInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteInventory.FlatAppearance.BorderSize = 0;
            this.DeleteInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.DeleteInventory.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.DeleteInventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteInventory.Location = new System.Drawing.Point(315, 393);
            this.DeleteInventory.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteInventory.Name = "DeleteInventory";
            this.DeleteInventory.Size = new System.Drawing.Size(86, 32);
            this.DeleteInventory.TabIndex = 46;
            this.DeleteInventory.Text = "Okay";
            this.DeleteInventory.UseVisualStyleBackColor = false;
            this.DeleteInventory.Click += new System.EventHandler(this.DeleteInventory_Click);
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteInventory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageView";
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteInventory;
    }
}