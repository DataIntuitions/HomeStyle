using HomeStyling.CustomerManagement;
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

namespace HomeStyling.Files
{
    public partial class BackUpDatabase : Form
    {
        public BackUpDatabase()
        {
            InitializeComponent();
        }

        private void BackUpDB_Click(object sender, EventArgs e)
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

                    string backupPath = ImportPath.Text + "\\HomeStylingBackup.bak";
                

                    string backupQuery = $@"BACKUP DATABASE [HomeStyling]TO DISK = '{backupPath}'WITH FORMAT, INIT,NAME = 'Full Backup of HomeStyling'";

                    DBConn db= new DBConn();

                    using (SqlConnection connection = new SqlConnection(db.con.ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(backupQuery, connection))
                        {

                            command.ExecuteNonQuery();
                            error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                            if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Database Backed up succesfully";
                            else error.ErrorMessage.Text = "Database Sikkerhedskopieret";
                        }
                    }
                    error.ShowDialog();

                }
                catch (Exception ex)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error occured while backing up database";
                    else error.ErrorMessage.Text = "Der opstod en fejl under sikkerhedskopiering af database";
                    error.ShowDialog();
                }
            }
        }
    }
}
