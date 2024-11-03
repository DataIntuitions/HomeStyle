using HomeStyling.Data;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.Files
{
    public partial class RestoreDatabase : Form
    {
        public RestoreDatabase()
        {
            InitializeComponent();
        }

        private void RestoreDatabase_Load(object sender, EventArgs e)
        {

        }

        private void RestoreDB_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (ImportPath.Text == "")
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Import Path";
                else error.ErrorMessage.Text = "Indtast venligst importsti";
                error.ShowDialog();
            }
            else
            {
                try
                {
                    string backupPath = ImportPath.Text;
                    int lastSlashIndex = ImportPath.Text.LastIndexOf('\\');

                    // Return the substring before the last slash
                    string pathMDF = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\DATA\\HomeStyling.mdf";
                    string pathLOG = "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\DATA\\HomeStyling_log.ldf";

                    string setSingleUserQuery = "ALTER DATABASE [HomeStyling] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    string restoreQuery = $@"RESTORE DATABASE [HomeStyling] FROM DISK = '{backupPath}' WITH MOVE 'HomeStyling' TO '{pathMDF}' , MOVE 'HomeStyling_log' TO '{pathLOG}' , REPLACE, FILE = 1, NOUNLOAD, STATS = 10";
                    string setMultiUserQuery = "ALTER DATABASE [HomeStyling] SET MULTI_USER";

                    DBConn db = new DBConn();
                    string connectionString = $"{db.con.ConnectionString};Integrated Security=True;TrustServerCertificate=True";

                    LogMessage("Opening SQL connection...");
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        LogMessage("SQL connection opened.");

                        // Switch to the master database
                        using (SqlCommand useMasterCommand = new SqlCommand("USE master", connection))
                        {
                            useMasterCommand.ExecuteNonQuery();
                            LogMessage("Switched to master database.");
                        }

                        // Set database to single-user mode
                        using (SqlCommand setSingleUserCommand = new SqlCommand(setSingleUserQuery, connection))
                        {
                            setSingleUserCommand.ExecuteNonQuery();
                            LogMessage("Database set to single-user mode.");
                        }

                        // Restore the database
                        using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
                        {
                            LogMessage($"Executing query: {restoreQuery}");
                            restoreCommand.ExecuteNonQuery();
                            LogMessage("Database restored successfully.");
                        }

                        // Set database back to multi-user mode
                        using (SqlCommand setMultiUserCommand = new SqlCommand(setMultiUserQuery, connection))
                        {
                            setMultiUserCommand.ExecuteNonQuery();
                            LogMessage("Database set to multi-user mode.");
                        }

                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Database Restore successfully";
                        else error.ErrorMessage.Text = "Databasegendannelse med succes";
                        error.ShowDialog();
                    }
                }
                catch (SqlException sqlEx)
                {
                    LogMessage($"SQL Error: {sqlEx.Message}");
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = $"SQL Error occurred while restoring database: {sqlEx.Message}";
                    else error.ErrorMessage.Text = $"Der opstod en SQL-fejl under gendannelse af databasen: {sqlEx.Message}";
                    error.ShowDialog();
                }
                catch (Exception ex)
                {
                    LogMessage($"Error: {ex.Message}");
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = $"Error occurred while restoring database: {ex.Message}";
                    else error.ErrorMessage.Text = $"Der opstod en fejl under gendannelse af databasen: {ex.Message}";
                    error.ShowDialog();
                }
            }
        }

        private void LogMessage(string message)
        {
            string logDirectory = @"C:\temp";
            string logFilePath = Path.Combine(logDirectory, "restore.log");

            // Check if the directory exists, if not, create it
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }


    }
}

