using HomeStyling.CustomerManagement;
using HomeStyling.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling
{
    
    internal static class Program
    {
        //public static DBConn db;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBConn db = new DBConn();
            Home home= new Home();
            string query = "select LogoFilePath from HomeStylingLogo";

           
            using (SqlCommand cmd = new SqlCommand(query, db.con))
            {
                // define parameters and their values


                // open connection, execute INSERT, close connection
                db.con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    home.BackgroundImage= Image.FromFile(sdr["LogoFilePath"].ToString());

                }
                db.con.Close();

            }
            Application.Run(home);
        }
    }
}
