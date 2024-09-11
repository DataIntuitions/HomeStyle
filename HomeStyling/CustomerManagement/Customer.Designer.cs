namespace HomeStyling.CustomerManagement
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.CustomerManagementLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerCity = new System.Windows.Forms.TextBox();
            this.CustomerState = new System.Windows.Forms.TextBox();
            this.CustomerPostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerContactPerson = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomerEmail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CustomerTelephoneNumber = new System.Windows.Forms.TextBox();
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.FindCustomer = new System.Windows.Forms.Button();
            this.SaveCustomer = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.CustomerIsActive = new CustomControls.RJControls.RJToggleButton();
            this.CustomerAdditionalName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerName, "CustomerName");
            this.CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerName.Name = "CustomerName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Name = "label2";
            // 
            // CustomerNr
            // 
            this.CustomerNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerNr, "CustomerNr");
            this.CustomerNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerNr.Name = "CustomerNr";
            this.CustomerNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNr_KeyPress);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CustomerAddress);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CustomerAddress, "CustomerAddress");
            this.CustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeStyling.Properties.Resources.icons8_location_481;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Name = "label7";
            // 
            // CustomerCity
            // 
            this.CustomerCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerCity, "CustomerCity");
            this.CustomerCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerCity.Name = "CustomerCity";
            // 
            // CustomerState
            // 
            this.CustomerState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerState, "CustomerState");
            this.CustomerState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerState.Name = "CustomerState";
            // 
            // CustomerPostalCode
            // 
            this.CustomerPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerPostalCode, "CustomerPostalCode");
            this.CustomerPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerPostalCode.Name = "CustomerPostalCode";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Name = "label9";
            // 
            // CustomerContactPerson
            // 
            this.CustomerContactPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerContactPerson, "CustomerContactPerson");
            this.CustomerContactPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerContactPerson.Name = "CustomerContactPerson";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Name = "label10";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CustomerEmail);
            this.panel2.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CustomerEmail, "CustomerEmail");
            this.CustomerEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerEmail.Name = "CustomerEmail";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HomeStyling.Properties.Resources.email_880421;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Name = "label11";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CustomerPhoneNumber);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // CustomerPhoneNumber
            // 
            this.CustomerPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CustomerPhoneNumber, "CustomerPhoneNumber");
            this.CustomerPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerPhoneNumber.Name = "CustomerPhoneNumber";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label12.Name = "label12";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CustomerTelephoneNumber);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // CustomerTelephoneNumber
            // 
            this.CustomerTelephoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerTelephoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CustomerTelephoneNumber, "CustomerTelephoneNumber");
            this.CustomerTelephoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerTelephoneNumber.Name = "CustomerTelephoneNumber";
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.CreateCustomer, "CreateCustomer");
            this.CreateCustomer.CausesValidation = false;
            this.CreateCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateCustomer.FlatAppearance.BorderSize = 0;
            this.CreateCustomer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.UseVisualStyleBackColor = false;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // FindCustomer
            // 
            this.FindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.FindCustomer, "FindCustomer");
            this.FindCustomer.CausesValidation = false;
            this.FindCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FindCustomer.FlatAppearance.BorderSize = 0;
            this.FindCustomer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.FindCustomer.Name = "FindCustomer";
            this.FindCustomer.UseVisualStyleBackColor = false;
            this.FindCustomer.Click += new System.EventHandler(this.FindCustomer_Click);
            // 
            // SaveCustomer
            // 
            this.SaveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.SaveCustomer, "SaveCustomer");
            this.SaveCustomer.CausesValidation = false;
            this.SaveCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveCustomer.FlatAppearance.BorderSize = 0;
            this.SaveCustomer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SaveCustomer.Name = "SaveCustomer";
            this.SaveCustomer.UseVisualStyleBackColor = false;
            this.SaveCustomer.Click += new System.EventHandler(this.SaveCustomer_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            resources.ApplyResources(this.DeleteCustomer, "DeleteCustomer");
            this.DeleteCustomer.CausesValidation = false;
            this.DeleteCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteCustomer.FlatAppearance.BorderSize = 0;
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label13.Name = "label13";
            // 
            // CustomerIsActive
            // 
            resources.ApplyResources(this.CustomerIsActive, "CustomerIsActive");
            this.CustomerIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerIsActive.Name = "CustomerIsActive";
            this.CustomerIsActive.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerIsActive.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.CustomerIsActive.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.CustomerIsActive.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerIsActive.UseVisualStyleBackColor = false;
            // 
            // CustomerAdditionalName
            // 
            this.CustomerAdditionalName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.CustomerAdditionalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.CustomerAdditionalName, "CustomerAdditionalName");
            this.CustomerAdditionalName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.CustomerAdditionalName.Name = "CustomerAdditionalName";
            // 
            // Customer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CustomerIsActive);
            this.Controls.Add(this.DeleteCustomer);
            this.Controls.Add(this.SaveCustomer);
            this.Controls.Add(this.FindCustomer);
            this.Controls.Add(this.CreateCustomer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustomerContactPerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CustomerPostalCode);
            this.Controls.Add(this.CustomerState);
            this.Controls.Add(this.CustomerCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerAdditionalName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerManagementLabel);
            this.Name = "Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerManagementLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CustomerCity;
        private System.Windows.Forms.TextBox CustomerState;
        private System.Windows.Forms.TextBox CustomerPostalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CustomerContactPerson;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CustomerEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CustomerPhoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CustomerTelephoneNumber;
        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Button FindCustomer;
        private System.Windows.Forms.Button SaveCustomer;
        private System.Windows.Forms.Button DeleteCustomer;
        private CustomControls.RJControls.RJToggleButton CustomerIsActive;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CustomerAdditionalName;
    }
}