using HomeStyling.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeStyling.Home;

namespace HomeStyling.Configuration
{
    public partial class AppSettings : Form
    {
        private Home _home;
        public AppSettings(Home home)
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("da");
            InitializeComponent();
            _home = home;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

           // Thread.CurrentThread.CurrentUICulture= currentCulture;
           
           // if (comboBox1.SelectedIndex==1)
           // {
           //     Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("da");
           // }
           // else
           // {
           //     Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
           // }
           //// this.Parent = new Home();
           // this.Controls.Clear();
           // InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool IsImageFile(string path)
        {
            if (File.Exists(path))
            {

                string extension = Path.GetExtension(path).ToLower();
                if (extension == ".png" || extension == ".jpg" || extension == ".jpeg" )
                {
                    try
                    {
                        using (var img = Image.FromFile(path))
                        {
                            return true;
                        }
                    }
                    catch
                    {
                        // The file exists but is not a valid image
                        return false;
                    }
                }
            }
            return false;
        }
        private void SaveAppSettings_Click(object sender, EventArgs e)
        {
            CultureInfo culture;
            var culture1 = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            if (!IsImageFile(textBox1.Text))
            {
                if (culture1.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Valid Logo Path";
                else error.ErrorMessage.Text = "Indtast venligst en gyldig logosti";
                error.ShowDialog();
            } 
            else
            {
                DBConn db = new DBConn();
                string query = "Update HomeStylingLogo set LogoFilePath= @FilePath" ;
                string FilePath = textBox1.Text;

                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values

                    cmd.Parameters.Add("@FilePath", SqlDbType.NVarChar, 200).Value = textBox1.Text; 
                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    cmd.ExecuteNonQuery();
                    db.con.Close();
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    culture = new System.Globalization.CultureInfo("da");
                }
                else
                {
                    culture = new System.Globalization.CultureInfo("en-US");
                }
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;

                _home.ChangeCulture(culture);

            }
            this.Close();
        }

        private void CancelAppSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
