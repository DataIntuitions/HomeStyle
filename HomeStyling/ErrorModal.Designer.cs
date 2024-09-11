namespace HomeStyling
{
    partial class ErrorModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorModal));
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.OkErrorDialouge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorMessage
            // 
            resources.ApplyResources(this.ErrorMessage, "ErrorMessage");
            this.ErrorMessage.ForeColor = System.Drawing.Color.Tomato;
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Click += new System.EventHandler(this.ErrorMessage_Click);
            // 
            // OkErrorDialouge
            // 
            this.OkErrorDialouge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.OkErrorDialouge, "OkErrorDialouge");
            this.OkErrorDialouge.CausesValidation = false;
            this.OkErrorDialouge.Cursor = System.Windows.Forms.Cursors.Default;
            this.OkErrorDialouge.FlatAppearance.BorderSize = 0;
            this.OkErrorDialouge.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.OkErrorDialouge.Name = "OkErrorDialouge";
            this.OkErrorDialouge.UseVisualStyleBackColor = false;
            this.OkErrorDialouge.Click += new System.EventHandler(this.OkErrorDialouge_Click);
            // 
            // ErrorModal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.OkErrorDialouge);
            this.Controls.Add(this.ErrorMessage);
            this.Name = "ErrorModal";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label ErrorMessage;
        public System.Windows.Forms.Button OkErrorDialouge;
    }
}