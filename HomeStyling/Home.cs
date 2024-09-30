using HomeStyling.Configuration;
using HomeStyling.CustomerManagement;
using HomeStyling.Data;
using HomeStyling.Files;
using HomeStyling.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling
{
    public partial class Home : Form
    {
        //private ListBox Files;
        //private ListBox Customer;
        //private ListBox Inventory;
        //private ListBox Config;
        //private AppSettings appSettings = new AppSettings();
        DBConn dbConn;
        public Home()
        {
            //UserControl appSettings = new AppSettings();
            InitializeComponent();
            menuStrip1.Renderer = new BlueRenderer();
            //db.con= new SqlConnection("DATA SOURCE=.; DATABASE=HomeStyling; INTEGRATED SECURITY=True;");
        }
      
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void appsettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettings appSettings = new AppSettings(this);
            appSettings.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void ChangeCulture(CultureInfo culture)
        {
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            this.Controls.Clear();
            InitializeComponent();
            menuStrip1.Renderer = new BlueRenderer();


        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer= new Customer();
            customer.CustomerIsActive.Checked = true;
            customer.ShowDialog();
        }

        private void stylingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Styling styling = new Styling();
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
           
            
            string query = "select Id as Id,CustomerName as CustomerName from Customers  ";

            DBConn db= new DBConn(); using (db.con)
            using (SqlCommand cmd = new SqlCommand(query, db.con))
            {
                // define parameters and their values
               

                // open connection, execute INSERT, close connection
                db.con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    styling.CustomerDropDown.Items.Insert(i, sdr["CustomerName"].ToString());
                    i++;
                  
                }
                db.con.Close();
            }
            styling.StylingIsActive.Checked = true;
            styling.ShowDialog();
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory= new Inventory();
            inventory.InventoryActive.Checked = true;
            inventory.ShowDialog();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Checkout checkout = new Checkout();

            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            
            string query = "select Id as Id,StylingAddress as StylingAddress from Styling  ";

            DBConn db= new DBConn(); using (db.con)
            using (SqlCommand cmd = new SqlCommand(query, db.con))
            {
                // define parameters and their values


                // open connection, execute INSERT, close connection
                db.con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    checkout.OSelectedStylingAddressDropdoen.Items.Insert(i, sdr["StylingAddress"].ToString());
                    i++;
                }
                db.con.Close();
            }

            checkout.ShowDialog();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIn checkin= new CheckIn();
            
            //var culture = System.Globalization.CultureInfo.CurrentCulture;
            //ErrorModal error = new ErrorModal();

            //
            //string query = "select Id as Id,StylingAddress as StylingAddress from Styling  ";

            //DBConn db= new DBConn(); using (db.con)
            //using (SqlCommand cmd = new SqlCommand(query, db.con))
            //{
            //    // define parameters and their values


            //    // open connection, execute INSERT, close connection
            //    db.con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    int i = 0;
            //    while (sdr.Read())
            //    {
            //        checkin.IStylingAddress.Items.Insert(i, sdr["StylingAddress"].ToString());
            //        i++;
            //    }
            //    db.con.Close();
            //}
            checkin.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import import=new Import();
            import.ShowDialog();
            
            
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export=new Export();
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            export.ExportListType.Items.Insert(1, "Item for sale");
            //string query = "select Id as Id,ItemName as ItemName from Inventory where itemcountbeforesale>1  ";

            //DBConn db= new DBConn(); using (db.con)
            //using (SqlCommand cmd = new SqlCommand(query, db.con))
            //{
            //    // define parameters and their values


            //    // open connection, execute INSERT, close connection
            //    db.con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    int i = 1;
            //    while (sdr.Read())
            //    {
            //          export.ExportListType.Items.Insert(i, sdr["ItemName"].ToString());
            //          i++;
            //    }
            //    db.con.Close();
            //}
            export.ShowDialog();  
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection=new DatabaseConnection();
            databaseConnection.ShowDialog();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            CheckIn checkin = new CheckIn();
            //var culture = System.Globalization.CultureInfo.CurrentCulture;
            //ErrorModal error = new ErrorModal();

            //
            //string query = "select Id as Id,StylingAddress as StylingAddress from Styling  ";

            //DBConn db= new DBConn(); using (db.con)
            //using (SqlCommand cmd = new SqlCommand(query, db.con))
            //{
            //    // define parameters and their values


            //    // open connection, execute INSERT, close connection
            //    db.con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    int i = 0;
            //    while (sdr.Read())
            //    {
            //        checkin.IStylingAddress.Items.Insert(i, sdr["StylingAddress"].ToString());
            //        i++;
            //    }
            //    db.con.Close();
            //}
            checkin.ShowDialog();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();

            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            
            string query = "select Id as Id,StylingAddress as StylingAddress from Styling  ";

            DBConn db= new DBConn(); using (db.con)
            using (SqlCommand cmd = new SqlCommand(query, db.con))
            {
                // define parameters and their values


                // open connection, execute INSERT, close connection
                db.con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int i = 0;
                while (sdr.Read())
                {
                    checkout.OSelectedStylingAddressDropdoen.Items.Insert(i, sdr["StylingAddress"].ToString());
                    i++;
                }
                db.con.Close();
            }

            checkout.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CheckIn checkin = new CheckIn();
            //var culture = System.Globalization.CultureInfo.CurrentCulture;
            //ErrorModal error = new ErrorModal();

            //
            //string query = "select Id as Id,StylingAddress as StylingAddress from Styling  ";

            //DBConn db= new DBConn(); using (db.con)
            //using (SqlCommand cmd = new SqlCommand(query, db.con))
            //{
            //    // define parameters and their values


            //    // open connection, execute INSERT, close connection
            //    db.con.Open();
            //    SqlDataReader sdr = cmd.ExecuteReader();
            //    int i = 0;
            //    while (sdr.Read())
            //    {
            //        checkin.IStylingAddress.Items.Insert(i, sdr["StylingAddress"].ToString());
            //        i++;
            //    }
            //    db.con.Close();
            //}
            checkin.ShowDialog();  
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUpDatabase backUpDatabase = new BackUpDatabase();
            backUpDatabase.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreDatabase restoreDatabase = new RestoreDatabase();
            restoreDatabase.ShowDialog();
        }
    }
}
