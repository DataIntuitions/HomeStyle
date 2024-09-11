using HomeStyling.CustomerManagement;

namespace HomeStyling
{
    partial class Confirmation
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
            this.YesConfirmation = new System.Windows.Forms.Button();
            this.CancelConfirmation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesConfirmation
            // 
            this.YesConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.YesConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YesConfirmation.CausesValidation = false;
            this.YesConfirmation.Cursor = System.Windows.Forms.Cursors.Default;
            this.YesConfirmation.FlatAppearance.BorderSize = 0;
            this.YesConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.YesConfirmation.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.YesConfirmation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.YesConfirmation.Location = new System.Drawing.Point(40, 120);
            this.YesConfirmation.Margin = new System.Windows.Forms.Padding(0);
            this.YesConfirmation.Name = "YesConfirmation";
            this.YesConfirmation.Size = new System.Drawing.Size(86, 32);
            this.YesConfirmation.TabIndex = 8;
            this.YesConfirmation.Text = "Yes";
            this.YesConfirmation.UseVisualStyleBackColor = false;
            // 
            // CancelConfirmation
            // 
            this.CancelConfirmation.BackColor = System.Drawing.Color.Salmon;
            this.CancelConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelConfirmation.CausesValidation = false;
            this.CancelConfirmation.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelConfirmation.FlatAppearance.BorderSize = 0;
            this.CancelConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.CancelConfirmation.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CancelConfirmation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CancelConfirmation.Location = new System.Drawing.Point(327, 120);
            this.CancelConfirmation.Margin = new System.Windows.Forms.Padding(0);
            this.CancelConfirmation.Name = "CancelConfirmation";
            this.CancelConfirmation.Size = new System.Drawing.Size(86, 32);
            this.CancelConfirmation.TabIndex = 9;
            this.CancelConfirmation.Text = "Cancel";
            this.CancelConfirmation.UseVisualStyleBackColor = false;
            this.CancelConfirmation.Click += new System.EventHandler(this.CancelConfirmation_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(138, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please Confirm";
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(456, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelConfirmation);
            this.Controls.Add(this.YesConfirmation);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button YesConfirmation;
        private System.Windows.Forms.Button CancelConfirmation;
        private System.Windows.Forms.Label label1;
    }
}