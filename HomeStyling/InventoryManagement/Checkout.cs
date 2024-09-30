using HomeStyling.CustomerManagement;
using HomeStyling.Data;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeStyling.InventoryManagement
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ExportEmail_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (OSelectedStylingAddressDropdoen.SelectedItem == null)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Address before Checkout";
                else error.ErrorMessage.Text = "Indtast venligst styling-adresser til kassen";
                error.ShowDialog();
            }
            else
            {
                
                string query = "spExportCheckoutItem";

                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Index", OSelectedStylingAddressDropdoen.SelectedIndex + 1);


                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    List<ExportItemModel> list = new List<ExportItemModel>();
                    while (sdr.Read())
                    {
                        ExportItemModel model = new ExportItemModel();
                        model.ItemNr = sdr["ItemNr"].ToString();
                        model.ItemName = sdr["ItemName"].ToString();
                        model.ItemCount = Convert.ToInt32(sdr["ItemCount"]);
                        list.Add(model);

                    }
                    db.con.Close();
                    string emailBody = FormatAsText(list);

                    // Create a mailto URI
                    string mailtoUri = $"mailto:recipient@example.com?subject=List of Objects&body={Uri.EscapeDataString(emailBody)}";

                    try
                    {
                        // Open the default email client with the pre-filled message
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = mailtoUri,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to open email client: " + ex.Message);
                    }

                }
            }
          
            
        }
        public static string FormatAsText(List<ExportItemModel> objects)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("List of Objects:");
            sb.AppendLine("ItemName\tItemNr\tItemCount");

            foreach (var obj in objects)
            {
                sb.AppendFormat("{0}\t{1}\t{2}\n", obj.ItemName, obj.ItemNr,obj.ItemCount);
            }

            return sb.ToString();
        }
        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void CheckoutItem_Click(object sender, EventArgs e)
        {

            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (OItemNr.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Nr";
                    else error.ErrorMessage.Text = "Indtast venligst varenr";
                    error.ShowDialog();
                }
                else if (OSelectedStylingAddressDropdoen.SelectedItem==null )
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Address before Checkout";
                    else error.ErrorMessage.Text = "Indtast venligst styling-adresser til kassen";
                    error.ShowDialog();
                }
                else if (OItemCount.Text == "" )
                {
                    OItemCount.Text = "1";
                }
                else if (OItemCount.Text == "0")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item Count should be greater than 0";
                    else error.ErrorMessage.Text = "Indtast vareantal og vareantal før salg";
                    error.ShowDialog();
                }
                else if (int.Parse(OItemCount.Text)<1)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item Count cannot be negaitive";
                    else error.ErrorMessage.Text = "Antallet af varer kan ikke være negativt";
                    error.ShowDialog();
                }
                else
                {
                    
                    string query = "spCheckoutItem";


                   
                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Index",OSelectedStylingAddressDropdoen.SelectedIndex+1);
                        cmd.Parameters.AddWithValue("@ItemCount", Int32.Parse(OItemCount.Text));
                        cmd.Parameters.AddWithValue("@ItemNr", OItemNr.Text);
                        cmd.Parameters.AddWithValue("@SelectedItemName",OItemSelctedName.Text);
                        cmd.Parameters.AddWithValue("@StylingAddress", OSelectedStylingAddressDropdoen.SelectedItem.ToString());
                        

                        // open connection, execute INSERT, close connection
                        db.con.Open();


                        SqlDataReader sdr = cmd.ExecuteReader();

                        //if (sdr.Read())
                        //{
                        //    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "No Record Found";
                        //    else error.ErrorMessage.Text = "Ingen registrering fundet";
                        //    error.ShowDialog();
                        //}
                        //else
                        //{
                        //error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        //if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item is now checkout";
                        //else error.ErrorMessage.Text = "Varen er nu til kassen";
                        //error.ShowDialog();

                        // }
                        OItemNr.Text = "";
                        OItemNr.Focus();
                        ShowPopupForOneSecond();
                        
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
        private void ShowPopupForOneSecond()
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            // Create and show the popup form
            //using (error)
            //{
                error.StartPosition = FormStartPosition.CenterScreen;
                error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item is now checkout";
                else error.ErrorMessage.Text = "Varen er nu til kassen";
                error.Show();

                // Set up a Timer to close the error after 1 second (1000 milliseconds)
                Timer timer = new Timer();
                timer.Interval = 2000; // 1 second
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    error.Close();
                };
                timer.Start();

                // Optionally, you might want to keep the main form responsive
                // while the popup is shown. This ensures the application
                // does not hang or freeze while the timer is running.
                Application.DoEvents();
            //}
        }
        private void OItemCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OItemNr_TextChanged(object sender, EventArgs e)
        {
            if (OItemNr.Text.Length == 5)
            {
                SimulateEnterKeyPress(sender,e);

            }
        }
        private void SimulateEnterKeyPress(object sender, EventArgs e)
        {
            CheckoutItem_Click(sender,e);
        }

        private void OItemNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExportClipboard_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (OSelectedStylingAddressDropdoen.SelectedItem == null)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Styling Address before Checkout";
                else error.ErrorMessage.Text = "Indtast venligst styling-adresser til kassen";
                error.ShowDialog();
            }
            else
            {
                
                string query = "spExportCheckoutItem";

                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Index", OSelectedStylingAddressDropdoen.SelectedIndex + 1);


                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    List<ExportItemModel> list = new List<ExportItemModel>();
                    while (sdr.Read())
                    {
                        ExportItemModel model = new ExportItemModel();
                        model.ItemNr = sdr["ItemNr"].ToString();
                        model.ItemName = sdr["ItemName"].ToString();
                        model.ItemCount = Convert.ToInt32(sdr["ItemCount"]);
                        
                        list.Add(model);

                    }
                    db.con.Close();

                    // Create a mailto URI
                    string mailtoUri = FormatAsText(list);
                    Clipboard.SetText(mailtoUri);
                    error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Items Copied To Clip Board";
                    else error.ErrorMessage.Text = "Elementer kopieret til udklipsholder";
                    error.ShowDialog();


                }
            }
         
        }
        public static bool IsFileLocked(string filePath)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                // The file is locked
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            // The file is not locked
            return false;
        }

        public static void CloseExcelProcesses()
        {
            var processes = Process.GetProcessesByName("EXCEL");
            foreach (var process in processes)
            {
                try
                {
                    process.Kill(); // Terminates the process
                    process.WaitForExit(); // Optional: Waits for the process to exit
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while closing Excel: " + ex.Message);
                }
            }
        }
        private void OExportList_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (OSelectedStylingAddressDropdoen.SelectedItem == null)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select Styling Address";
                else error.ErrorMessage.Text = "Vælg venligst stylingadresse";
                error.ShowDialog();
            }
            else
            {
                
                var memory = new MemoryStream();
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //string filePath = "C:\\Users\\ahmad\\Downloads\\Items\\"; // openFileDialog.FileName;
                string sFileName = @"exportList.xlsx";
                if (IsFileLocked(Path.Combine(filePath, sFileName)))
                {

                    CloseExcelProcesses();
                }
                using (var fs = new FileStream(Path.Combine(filePath, sFileName), FileMode.Create, FileAccess.Write))
                {
                    IWorkbook workbook;
                    workbook = new XSSFWorkbook();
                    ISheet excelSheet = workbook.CreateSheet("ExportItems");
                    IRow row = excelSheet.CreateRow(0);
                    var currentCell = 0;

                    row.CreateCell(currentCell++).SetCellValue("ItemNr");
                    row.CreateCell(currentCell++).SetCellValue("ItemCount");
                    row.CreateCell(currentCell++).SetCellValue("StylingAddress");

                    var counter = 1;
                    currentCell = 0;
                    
                    string query = "spExportCheckoutItem";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Index", OSelectedStylingAddressDropdoen.SelectedIndex + 1);


                        // open connection, execute INSERT, close connection
                        db.con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        List<ExportItemModel> list = new List<ExportItemModel>();
                        while (sdr.Read())
                        {
                            ExportItemModel model = new ExportItemModel();
                            model.ItemNr = sdr["ItemNr"].ToString();
                            model.ItemCount = Convert.ToInt32(sdr["ItemCount"]);
                            model.StylingAddrress = sdr["StylingAddress"].ToString();
                            list.Add(model);
                            row = excelSheet.CreateRow(counter);
                            row.CreateCell(currentCell++).SetCellValue(model.ItemNr);
                            row.CreateCell(currentCell++).SetCellValue(model.ItemCount);
                            row.CreateCell(currentCell++).SetCellValue(model.StylingAddrress);
                            counter++;
                            currentCell = 0;

                        }
                        db.con.Close();
                    }
                    workbook.Write(fs);
                        
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Export Item File Created";
                        else error.ErrorMessage.Text = "Eksporter elementfil oprettet";
                        error.ShowDialog();
                }
            }

        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
