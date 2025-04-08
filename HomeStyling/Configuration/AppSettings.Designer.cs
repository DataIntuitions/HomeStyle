using System.Drawing;
using System.Windows.Forms;

namespace HomeStyling.Configuration
{
    partial class AppSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettings));
            this.ApplicationSettingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SaveAppSettings = new System.Windows.Forms.Button();
            this.CancelAppSettings = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationSettingLabel
            // 
            resources.ApplyResources(this.ApplicationSettingLabel, "ApplicationSettingLabel");
            this.ApplicationSettingLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ApplicationSettingLabel.Name = "ApplicationSettingLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // toolStripComboBox1
            // 
            resources.ApplyResources(this.toolStripComboBox1, "toolStripComboBox1");
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SaveAppSettings
            // 
            resources.ApplyResources(this.SaveAppSettings, "SaveAppSettings");
            this.SaveAppSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.SaveAppSettings.CausesValidation = false;
            this.SaveAppSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveAppSettings.FlatAppearance.BorderSize = 0;
            this.SaveAppSettings.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SaveAppSettings.Name = "SaveAppSettings";
            this.SaveAppSettings.UseVisualStyleBackColor = false;
            this.SaveAppSettings.Click += new System.EventHandler(this.SaveAppSettings_Click);
            // 
            // CancelAppSettings
            // 
            resources.ApplyResources(this.CancelAppSettings, "CancelAppSettings");
            this.CancelAppSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(208)))), ((int)(((byte)(131)))));
            this.CancelAppSettings.CausesValidation = false;
            this.CancelAppSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.CancelAppSettings.FlatAppearance.BorderSize = 0;
            this.CancelAppSettings.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CancelAppSettings.Name = "CancelAppSettings";
            this.CancelAppSettings.UseVisualStyleBackColor = false;
            this.CancelAppSettings.Click += new System.EventHandler(this.CancelAppSettings_Click);
            // 
            // AppSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.CancelAppSettings);
            this.Controls.Add(this.SaveAppSettings);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplicationSettingLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(167)))), ((int)(((byte)(195)))));
            this.Name = "AppSettings";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApplicationSettingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SaveAppSettings;
        private Button CancelAppSettings;
    }
}
