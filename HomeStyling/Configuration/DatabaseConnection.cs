using HomeStyling.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
        }

        private void CancelDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatabaseFilePath_TextChanged(object sender, EventArgs e)
        {
           
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (DatabaseFilePath.Text == "")
            {
                
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Databse Name";
                else error.ErrorMessage.Text = "Indtast venligst databasenavn";
                error.ShowDialog();
            }
            else
            {
                string databaseName = DatabaseFilePath.Text;  // Example value

                // Create the connection string using string interpolation
                //string connectionString = $"DATA SOURCE=.; DATABASE={databaseName}; INTEGRATED SECURITY=True;";
                //DBConn.Instance().SetConnectionString(connectionString);
                //db.con = new SqlConnection($"DATA SOURCE=.; DATABASE={databaseName}; INTEGRATED SECURITY=True;");
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "New Database Configured";
                else error.ErrorMessage.Text = "Ny database konfigureret";
                error.ShowDialog();

            }

        }
    }
}
