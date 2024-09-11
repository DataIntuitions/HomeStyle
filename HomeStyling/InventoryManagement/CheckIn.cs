using HomeStyling.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.InventoryManagement
{
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CustomerManagementLabel_Click(object sender, EventArgs e)
        {

        }

        private void MoveItem_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (IStylingAddress.SelectedItem==null)
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select styling address to move items";
                else error.ErrorMessage.Text = "Vælg stylingadresse for at flytte varer\r\n";
                error.ShowDialog();
            }
            else if (IItemNr.Text == "")
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Nr";
                else error.ErrorMessage.Text = "Indtast venligst varenr";
                error.ShowDialog();
            }
            else
            {
                MoveItem moveItem = new MoveItem(IStylingAddress.SelectedItem.ToString(),IItemNr.Text);
                
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
                        moveItem.MoveStylingAddress.Items.Insert(i, sdr["StylingAddress"].ToString());
                        i++;
                    }
                    db.con.Close();
                }
                IStylingAddress.Items.Clear();
                this.Close();
                moveItem.Show();
            }
           
        }

        private void IItemNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IItemCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (IItemNr.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Nr";
                    else error.ErrorMessage.Text = "Indtast venligst varenr";
                    error.ShowDialog();
                }
                else
                {
                    
                    string query = "spCheckInItem";
                    if(IItemCount.Text=="" || IItemCount.Text=="0")
                    {
                        IItemCount.Text = "1";
                    }
                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ItemCount", Int32.Parse(IItemCount.Text));
                        cmd.Parameters.AddWithValue("@ItemNr", IItemNr.Text);
                        cmd.Parameters.AddWithValue("@SelectedItemName", IItemSelctedName.Text);


                        // open connection, execute INSERT, close connection
                        db.con.Open();


                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.Read())
                        {
                            if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "No Record Found";
                            else error.ErrorMessage.Text = "Ingen registrering fundet";
                            error.ShowDialog();
                        }
                        else
                        {
                            error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                            if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item is now checked in";
                            else error.ErrorMessage.Text = "Varen tjekkes nu ind";
                            error.ShowDialog();
                        }
                       
                       
                        // }
                        db.con.Close();

                    }
                }
            }




            catch (Exception ex)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while Item Check Out";
                else error.ErrorMessage.Text = "Der opstod en fejl under oprettelse af styling";

                error.ShowDialog();
            }
        }

        private void GetStylingAddress_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (IItemNr.Text == "")
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Nr";
                else error.ErrorMessage.Text = "Indtast venligst varenr";
                error.ShowDialog();
            }


            else
            {
                IStylingAddress.Items.Clear();
                
                string query = "spFindStylingAddressItem";

                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemCount", Int32.Parse(IItemCount.Text));
                    cmd.Parameters.AddWithValue("@ItemNr", IItemNr.Text);
                    cmd.Parameters.AddWithValue("@SelectedItemName", IItemSelctedName.Text);
                    // open connection, execute INSERT, close connection
                    db.con.Open();

                     
                    SqlDataReader sdr = cmd.ExecuteReader();

                    int i = 0;
                    while (sdr.Read())
                    {
                        IStylingAddress.Items.Insert(i, sdr["StylingAddress"].ToString());
                        i++;
                    }
                    db.con.Close();

                }
            }
        }
    }
}
