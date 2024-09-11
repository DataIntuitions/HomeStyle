using HomeStyling.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace HomeStyling.CustomerManagement
{
    public partial class Customer : Form
    {
        Confirmation confirmation = new Confirmation();
        
        public Customer()
        {
            InitializeComponent();
        }

        //private void CustomerName_Leave(object sender, EventArgs e)
        //{
        //    if (CustomerName.Text == "")
        //    {
        //        CustomerName.Text = "Example : John Doe";
        //    }
        //}

        //private void CustomerName_Enter(object sender, EventArgs e)
        //{
        //    if (CustomerName.Text == "Example : John Doe")
        //    {
        //        CustomerName.Text = "";
        //    }
        //}
        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (CustomerPhoneNumber.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer Phone Number";
                    else error.ErrorMessage.Text = "Indtast venligst kundetelefonnummer";
                    error.ShowDialog();

                }
                else if (CustomerName.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer Name";
                    else error.ErrorMessage.Text = "Indtast venligst kundenavn";
                    error.ShowDialog();
                }
                else if (CustomerNr.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer NR";
                    else error.ErrorMessage.Text = "Indtast venligst kundenummer";
                    error.ShowDialog();
                }
                else if (CustomerEmail.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer Email";
                    else error.ErrorMessage.Text = "Indtast venligst kundemail";
                    error.ShowDialog();
                }
                else
                {
                    string query = "INSERT INTO Customers  (CustomerName,CustomerNr,CustomerAdditionalName,CustomerAddress,CustomerCity,CustomerState,CustomerPostalCode,CustomerContactPerson,CustomerEmail,CustomerPhoneNumber,CustomerIsActive,CustomerTelephoneNumber) " +
                           "VALUES (@CustomerName,@CustomerNr,@CustomerAdditionalName,@CustomerAddress,@CustomerCity,@CustomerState,@CustomerPostalCode,@CustomerContactPerson,@CustomerEmail,@CustomerPhoneNumber,@CustomerIsActive,@CustomerTelephoneNumber) ";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.Parameters.Add("@CustomerName", SqlDbType.VarChar, 50).Value = CustomerName.Text;
                        cmd.Parameters.Add("@CustomerNr", SqlDbType.VarChar, 50).Value = CustomerNr.Text;
                        cmd.Parameters.Add("@CustomerAdditionalName", SqlDbType.VarChar, 50).Value = CustomerAdditionalName.Text;
                        cmd.Parameters.Add("@CustomerAddress", SqlDbType.VarChar, 255).Value = CustomerAddress.Text;
                        cmd.Parameters.Add("@CustomerCity", SqlDbType.VarChar).Value = CustomerCity.Text;
                        cmd.Parameters.Add("@CustomerState", SqlDbType.VarChar, 50).Value = CustomerState.Text;
                        cmd.Parameters.Add("@CustomerPostalCode", SqlDbType.VarChar, 10).Value = CustomerPostalCode.Text;
                        cmd.Parameters.Add("@CustomerContactPerson", SqlDbType.VarChar, 50).Value = CustomerContactPerson.Text;
                        cmd.Parameters.Add("@CustomerEmail", SqlDbType.VarChar, 50).Value = CustomerEmail.Text;
                        cmd.Parameters.Add("@CustomerPhoneNumber", SqlDbType.VarChar, 50).Value = CustomerPhoneNumber.Text;
                        cmd.Parameters.Add("@CustomerTelephoneNumber", SqlDbType.VarChar, 50).Value = CustomerTelephoneNumber.Text;
                        cmd.Parameters.Add("@CustomerIsActive", SqlDbType.Bit).Value = CustomerIsActive.Checked;

                        // open connection, execute INSERT, close connection
                        db.con.Open();
                        cmd.ExecuteNonQuery();
                        db.con.Close();
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "New Customer Created";
                        else error.ErrorMessage.Text = "Ny kunde oprettet";
                        error.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Nr, Name, Email Or Phone Number already exists";
                    else error.ErrorMessage.Text = "Kundenummer, navn, e-mail eller telefonnummer findes allerede";

                }
                else
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while creating customer";
                    else error.ErrorMessage.Text = "Der opstod en fejl under oprettelse af kunde";
                }
                error.ShowDialog();
            }
        }

        private void FindCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                ErrorModal error = new ErrorModal();
                
                string query = "spFindCustomer";

                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerNr", CustomerNr.Text);
                    cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail.Text);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName.Text);
                    cmd.Parameters.AddWithValue("@CustomerPhoneNumber", CustomerPhoneNumber.Text);

                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        CustomerName.Text = sdr["CustomerName"].ToString();
                        CustomerNr.Text = sdr["CustomerNr"].ToString();
                        CustomerAdditionalName.Text = sdr["CustomerAdditionalName"].ToString();
                        CustomerAddress.Text = sdr["CustomerAddress"].ToString();
                        CustomerCity.Text = sdr["CustomerCity"].ToString();
                        CustomerState.Text = sdr["CustomerState"].ToString();
                        CustomerPostalCode.Text = sdr["CustomerPostalCode"].ToString();
                        CustomerContactPerson.Text = sdr["CustomerContactPerson"].ToString();
                        CustomerEmail.Text = sdr["CustomerEmail"].ToString();
                        CustomerPhoneNumber.Text = sdr["CustomerPhoneNumber"].ToString();
                        CustomerTelephoneNumber.Text = sdr["CustomerTelephoneNumber"].ToString();
                        CustomerIsActive.Checked = Convert.ToBoolean(sdr["CustomerIsActive"]);
                    }
                    else
                    {
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "No Record Found";
                        else error.ErrorMessage.Text = "Ingen registrering fundet";
                        error.ShowDialog();
                    }

                    db.con.Close();
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void SaveCustomer_Click(object sender, EventArgs e)
        {
            ErrorModal error = new ErrorModal();
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            try
            {
                
                if (CustomerPhoneNumber.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer Phone Number";
                    else error.ErrorMessage.Text = "Indtast venligst kundetelefonnummer";
                    error.ShowDialog();
                }
                else if (CustomerName.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer Name";
                    else error.ErrorMessage.Text = "Indtast venligst kundenavn";
                    error.ShowDialog();
                }
                else if (CustomerNr.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer NR";
                    else error.ErrorMessage.Text = "Indtast venligst kundenummer";
                    error.ShowDialog();
                }
                else if (CustomerEmail.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer Email";
                    else error.ErrorMessage.Text = "Indtast venligst kundemail";
                    error.ShowDialog();
                }
                else
                {
                    //confirmation.YesConfirmation.Click += new System.EventHandler(this.updateCustomerData);
                    //confirmation.ShowDialog();
                    
                    string query = "spUpdateCustomer";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerName.Text);
                        cmd.Parameters.AddWithValue("@CustomerNr", CustomerNr.Text);
                        cmd.Parameters.AddWithValue("@CustomerAdditionalName", CustomerAdditionalName.Text);
                        cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress.Text);
                        cmd.Parameters.AddWithValue("@CustomerCity", CustomerCity.Text);
                        cmd.Parameters.AddWithValue("@CustomerState", CustomerState.Text);
                        cmd.Parameters.AddWithValue("@CustomerPostalCode", CustomerPostalCode.Text);
                        cmd.Parameters.AddWithValue("@CustomerContactPerson", CustomerContactPerson.Text);
                        cmd.Parameters.AddWithValue("@CustomerEmail", CustomerEmail.Text);
                        cmd.Parameters.AddWithValue("@CustomerPhoneNumber", CustomerPhoneNumber.Text);
                        cmd.Parameters.AddWithValue("@CustomerTelephoneNumber", CustomerTelephoneNumber.Text);
                        cmd.Parameters.AddWithValue("@CustomerIsActive", CustomerIsActive.Checked);

                        // open connection, execute INSERT, close connection
                        db.con.Open();
                        cmd.ExecuteNonQuery();
                        db.con.Close();
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Successfuly Updated";
                        else error.ErrorMessage.Text = "Opdateret med succes";
                        error.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Customer Nr, Name, Email Or Phone Number already exists";
                    else error.ErrorMessage.Text = "Kundenummer, navn, e-mail eller telefonnummer findes allerede";

                }
                else
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while Updating customer";
                    else error.ErrorMessage.Text = "Der opstod en fejl under oprettelse af kunde";
                }
                error.ShowDialog();
                Console.WriteLine(ex.Message);
            }

        }

        private void updateCustomerData(object sender, EventArgs e)
        {
            
            //confirmation.Close();
            
           
            

           
                
              
           
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
              
                if (CustomerNr.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Customer NR";
                    else error.ErrorMessage.Text = "Indtast venligst kundenummer";
                    error.ShowDialog();
                }
                else
                {
                    
                    string query = "spDeleteCustomer";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                      
                        cmd.Parameters.AddWithValue("@CustomerNr", CustomerNr.Text);


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
                            if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Customer Deleted Successfuly";
                            else error.ErrorMessage.Text = "Kunden blev slettet";
                            error.ShowDialog();
                            CustomerName.Text = "";
                            CustomerNr.Text = "";
                            CustomerAdditionalName.Text = "";
                            CustomerAddress.Text = "";
                            CustomerCity.Text = "";
                            CustomerState.Text = "";
                            CustomerPostalCode.Text = "";
                            CustomerContactPerson.Text = "";
                            CustomerEmail.Text = "";
                            CustomerPhoneNumber.Text = "";
                            CustomerTelephoneNumber.Text = "";
                            CustomerIsActive.Checked = Convert.ToBoolean(sdr["CustomerIsActive"]);
                        }
                        db.con.Close();
                    }
                
                }

            }
            catch (Exception ex)
            {
            
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while Deleting customer";
                else error.ErrorMessage.Text = "Der opstod en fejl under oprettelse af kunde";
                
                error.ShowDialog();
            }
        }

        private void CustomerNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}