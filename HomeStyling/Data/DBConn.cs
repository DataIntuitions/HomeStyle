using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HomeStyling.Data
{
    public class DBConn
    {
        //private static DBConn _instance;
        //private static readonly object _lock = new object();

        //public SqlConnection con;

        //// Private constructor to prevent instantiation from outside
        //private DBConn(string connectionString)
        //{
        //    con = new SqlConnection(connectionString);
        //}

        //public static DBConn Instance(string connectionString = null)
        //{
        //    lock (_lock)
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new DBConn(connectionString ?? "DATA SOURCE=.; DATABASE=HomeStyling; INTEGRATED SECURITY=True;");
        //        }
        //        return _instance;
        //    }
        //}

        //public void SetConnectionString(string newConnectionString)
        //{
        //    con.ConnectionString = newConnectionString;
        //}

        //public void OpenConnection()
        //{
        //    if (con.State == System.Data.ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }
        //}

        //public void CloseConnection()
        //{
        //    if (con.State == System.Data.ConnectionState.Open)
        //    {
        //        con.Close();
        //    }
        //}


        public SqlConnection con = new SqlConnection("DATA SOURCE=.; DATABASE=HomeStyling; INTEGRATED SECURITY=True;");
        //public SqlConnection con;

    }
}
