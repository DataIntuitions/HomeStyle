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

namespace HomeStyling.CustomerManagement
{
    public partial class Styling : Form
    {
        Confirmation confirmation = new Confirmation();
        public Styling()
        {
            InitializeComponent();
        }

        

        private void CreateStyling_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (StylingName.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Name";
                    else error.ErrorMessage.Text = "Indtast venligst stylingnavn";
                    error.ShowDialog();
                }
                else if (StylingContactPersonName.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Contact Person Name";
                    else error.ErrorMessage.Text = "Indtast venligst stylingkontaktpersonens navn";
                    error.ShowDialog();
                }
                else if (CustomerDropDown.SelectedItem==null )
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select Customer Nr";
                    else error.ErrorMessage.Text = "Vælg venligst kundenr";
                    error.ShowDialog();
                }
                else
                {

                    
                    string query = "spCreateStyling";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StylingName", StylingName.Text);
                        cmd.Parameters.AddWithValue("@StylingAdditionalName", StylingAdditionalName.Text);
                        cmd.Parameters.AddWithValue("@StylingAddress", StylingLocation.Text);
                        cmd.Parameters.AddWithValue("@StylingCity", StylingCity.Text);
                        cmd.Parameters.AddWithValue("@StylingState", StylingState.Text);
                        cmd.Parameters.AddWithValue("@StylingPostalCode", StylingPostalCode.Text);
                        cmd.Parameters.AddWithValue("@StylingContactPerson", StylingContactPersonName.Text);
                        cmd.Parameters.AddWithValue("@Index", CustomerDropDown.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("@StylingIsActive", StylingIsActive.Checked);


                        // open connection, execute INSERT, close connection
                        db.con.Open();
                        cmd.ExecuteNonQuery();
                        db.con.Close();
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "New styling Created";
                        else error.ErrorMessage.Text = "Ny styling oprettet";
                        error.ShowDialog();
                       
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Address already exists";
                    else error.ErrorMessage.Text = "Adressen findes allerede";

                }
                else
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while creating styling";
                    else error.ErrorMessage.Text = "Der opstod en fejl under oprettelse af styling";
                }
              
                
                error.ShowDialog();
            }
        }

        private void FindStyling_Click(object sender, EventArgs e)
        {
            try
            {
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                ErrorModal error = new ErrorModal();
                
                string query = "spFindStyling";
                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StylingName", StylingName.Text);
                    cmd.Parameters.AddWithValue("@StylingContactPerson", StylingContactPersonName.Text);
                    cmd.Parameters.AddWithValue("@StylingAddress", StylingLocation.Text);
                    //cmd.Parameters.AddWithValue("@CustomerNr ", CustomerDropDown.SelectedItem==null?"":CustomerDropDown.SelectedItem);

                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                  
                    if (sdr.Read())
                    {
                        StylingName.Text = sdr["StylingName"].ToString();
                        StylingAdditionalName.Text = sdr["StylingAdditionalName"].ToString();
                        StylingLocation.Text = sdr["StylingAddress"].ToString();
                        StylingCity.Text = sdr["StylingCity"].ToString();
                        StylingState.Text = sdr["StylingState"].ToString();
                        StylingPostalCode.Text = sdr["StylingPostalCode"].ToString();
                        StylingContactPersonName.Text = sdr["StylingContactPerson"].ToString();
                        CustomerDropDown.SelectedIndex= Convert.ToInt32(CustomerDropDown.FindStringExact(sdr["CustomerName"].ToString())); ;
                        StylingIsActive.Checked = Convert.ToBoolean(sdr["StylingIsActive"]);
                        StylingIdLabel.Text = sdr["Id"].ToString();
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

        private void SaveStyling_Click(object sender, EventArgs e)
        {
            //confirmation.YesConfirmation.Click += new System.EventHandler(this.updateStylingData);
            //confirmation.Show();
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            try
            {


                if (StylingName.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Name";
                    else error.ErrorMessage.Text = "Indtast venligst stylingnavn";
                    error.ShowDialog();
                }
                else if (StylingContactPersonName.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Contact Person Name";
                    else error.ErrorMessage.Text = "Indtast venligst stylingkontaktpersonens navn";
                    error.ShowDialog();
                }
                else if (CustomerDropDown.SelectedItem == null)
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select Customer Nr";
                    else error.ErrorMessage.Text = "Vælg venligst kundenr";
                    error.ShowDialog();
                }
                else if (StylingIdLabel.Text == "" || StylingIdLabel.Text == null)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Find the styling the first";
                    else error.ErrorMessage.Text = "Find venligst stylingen først";
                    error.ShowDialog();
                }
                else
                {

                    
                    string query = "spUpdateStyling";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StylingName", StylingName.Text) ;
                        cmd.Parameters.AddWithValue("@StylingAdditionalName", StylingAdditionalName.Text);
                        cmd.Parameters.AddWithValue("@StylingAddress", StylingLocation.Text);
                        cmd.Parameters.AddWithValue("@StylingCity", StylingCity.Text);
                        cmd.Parameters.AddWithValue("@StylingState",StylingState.Text);
                        cmd.Parameters.AddWithValue("@StylingPostalCode", StylingPostalCode.Text);
                        cmd.Parameters.AddWithValue("@StylingContactPerson",StylingContactPersonName.Text);
                        cmd.Parameters.AddWithValue("@CustomerName",  CustomerDropDown.SelectedItem);
                        cmd.Parameters.AddWithValue("@StylingIsActive", StylingIsActive.Checked);
                        cmd.Parameters.AddWithValue("@Id", Int32.Parse(StylingIdLabel.Text));

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
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Customer Nr, Email Or Phone Number already exists";
                    else error.ErrorMessage.Text = "Kundenummer, e-mail eller telefonnummer findes allerede";

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
        private void updateStylingData(object sender, EventArgs e)
        {
            //confirmation.Hide();

           
        }

        private void DeleteStyling_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
               if (StylingIdLabel.Text == "" || StylingIdLabel.Text == null)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Find the styling the first";
                    else error.ErrorMessage.Text = "Find venligst stylingen først";
                    error.ShowDialog();
                }
                else
                {

                    
                    string query = "Delete from Styling where id=@Id";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        
                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Int32.Parse(StylingIdLabel.Text);
                        // open connection, execute INSERT, close connection
                        db.con.Open(); 
                        cmd.ExecuteNonQuery();
                        db.con.Close();
                        StylingName.Text = "";
                        StylingAdditionalName.Text = "";
                        StylingContactPersonName.Text = "";
                        StylingIdLabel.Text = "";
                        StylingIsActive.Checked =false;
                        StylingLocation.Text = "";
                        StylingPostalCode.Text = "";
                        StylingState.Text = "";
                        StylingCity.Text = "";
                        CustomerDropDown.Text = "";
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Styling Deleted Succesfuly";
                        else error.ErrorMessage.Text = "Styling blev slettet";
                        error.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while deleting styling";
                else error.ErrorMessage.Text = "Der opstod en fejl under sletning af styling";

                error.ShowDialog();
            }
        }

      
    }
}
