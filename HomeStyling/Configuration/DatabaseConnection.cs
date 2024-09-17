using HomeStyling.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;
namespace HomeStyling.Configuration
{
    public partial class DatabaseConnection : Form
    {
        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void CustomerManagementLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaveDatabasePath_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (DatabaseFilePath.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter DatabaseName";
                    else error.ErrorMessage.Text = "Indtast venligst en gyldig logosti";
                    error.ShowDialog();
                }
              
                string ConnectionString = ConfigurationManager.AppSettings["DBConnection"].ToString();
                ConnectionString = ReplaceDatabaseName(ConnectionString, DatabaseFilePath.Text);
                SqlConnection con = new SqlConnection(ConnectionString);
                string query = "select * from Customers";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // define parameters and their values


                    // open connection, execute INSERT, close connection
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = DatabaseFilePath.Text+ " is Connected";
                    else error.ErrorMessage.Text = " er tilsluttet";
                    error.ShowDialog();
                    UpdateSetting(key: "DBConnection", value: ConnectionString);
                    
                }
            }
            catch(Exception ex)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Connecting Databse";
                else error.ErrorMessage.Text = "Indtast venligst en gyldig logosti";
                error.ShowDialog();
            }

            this.Close();
        }
        private void UpdateSetting(string key, string value)
        {
            // Open App.Config of executable
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");
            config.AppSettings.Settings.Remove(key);
            config.AppSettings.Settings.Add(key, value);

            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        static string ReplaceDatabaseName(string connectionString, string newDatabaseName)
        {
            var builder = new System.Data.SqlClient.SqlConnectionStringBuilder(connectionString);
            builder.InitialCatalog = newDatabaseName;
            return builder.ToString();
        }
        private void CancelDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void DatabaseFilePath_TextChanged(object sender, EventArgs e)
        //{
           
        //    var culture = System.Globalization.CultureInfo.CurrentCulture;
        //    ErrorModal error = new ErrorModal();
        //    if (DatabaseFilePath.Text == "")
        //    {
                
        //        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Databse Name";
        //        else error.ErrorMessage.Text = "Indtast venligst databasenavn";
        //        error.ShowDialog();
        //    }
        //    else
        //    {
        //        string databaseName = DatabaseFilePath.Text;  // Example value

        //        // Create the connection string using string interpolation
        //        //string connectionString = $"DATA SOURCE=.; DATABASE={databaseName}; INTEGRATED SECURITY=True;";
        //        //DBConn.Instance().SetConnectionString(connectionString);
        //        //db.con = new SqlConnection($"DATA SOURCE=.; DATABASE={databaseName}; INTEGRATED SECURITY=True;");
        //        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "New Database Configured";
        //        else error.ErrorMessage.Text = "Ny database konfigureret";
        //        error.ShowDialog();

        //    }

        //}
    }
}
