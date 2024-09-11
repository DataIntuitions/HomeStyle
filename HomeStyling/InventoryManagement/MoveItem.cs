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

namespace HomeStyling.InventoryManagement
{
    public partial class MoveItem : Form
    {
        public string PrevAddress { get; set; }
        public string ItemNr { get; set; }
        public MoveItem(string prevAddress, string itemNr)
        {
            InitializeComponent();
            PrevAddress = prevAddress;
            ItemNr = itemNr;
        }

        private void CancelMoveItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (MoveStylingAddress.SelectedItem == null)
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select styling address to move items";
                else error.ErrorMessage.Text = "Vælg stylingadresse for at flytte varer\r\n";
                error.ShowDialog();
            }
            else
            {
                
                string query = "spCheckInMoveItem";

                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Address", PrevAddress);
                    cmd.Parameters.AddWithValue("@Index2", MoveStylingAddress.SelectedIndex+1);
                    cmd.Parameters.AddWithValue("@ItemNr", ItemNr);
                    // open connection, execute INSERT, close connection
                    db.con.Open();


                    SqlDataReader sdr = cmd.ExecuteReader();
                    if(sdr.Read()) { }
                    error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item is now moved";
                    else error.ErrorMessage.Text = "Varen er nu flyttet";
                    error.ShowDialog();

                    db.con.Close();

                }
            }
            this.Close();
        }
    }
}
