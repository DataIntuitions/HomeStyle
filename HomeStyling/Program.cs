using HomeStyling.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //db= new DBConn();
            //db.con = new SqlConnection("DATA SOURCE=.; DATABASE=HomeStyling; INTEGRATED SECURITY=True;");
            Application.Run(new Home());
        }
    }
}
