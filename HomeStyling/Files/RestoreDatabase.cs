using HomeStyling.Data;
using NPOI.SS.Formula.Functions;
using Org.BouncyCastle.Utilities.Collections;
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
                    string pathMDF= backupPath.Substring(0, lastSlashIndex);
                    string pathLOG= backupPath.Substring(0, lastSlashIndex);
                    pathMDF += "\\HomeStylingRS.mdf";
                    pathLOG += "\\HomeStylingRS_log.ldf";


                    string backupQuery = $@"RESTORE DATABASE [HomeStylingRS] FROM DISK = '{backupPath}' WITH MOVE 'HomeStyling' TO '{pathMDF}' , MOVE 'HomeStyling_log' TO '{pathLOG}' , REPLACE, FILE = 1,NOUNLOAD,STATS = 10";
                    DBConn db = new DBConn();

                    using (SqlConnection connection = new SqlConnection(db.con.ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(backupQuery, connection))
                        {

                            command.ExecuteNonQuery();
                            error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                            if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Database Restore succesfully";
                            else error.ErrorMessage.Text = "Databasegendannelse med succes";
                        }
                    }
                    error.ShowDialog();
                }
                catch (Exception ex)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error occured while restoring database";
                    else error.ErrorMessage.Text = "Der opstod en fejl under gendannelse af databasen";
                    error.ShowDialog();
                }
            }
        }
    }
}
