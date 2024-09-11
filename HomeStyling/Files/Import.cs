using CsvHelper;
using HomeStyling.CustomerManagement;
using HomeStyling.Data;
using IronXL;
using NPOI.SS.UserModel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.Files
{
    public partial class Import : Form
    {
        public class Item
        {
            public string ItemNr { get; set; }
            public string Description { get; set; }
            public int Count { get; set; }
            public int CountBeforeSale { get; set; }
            public string ItemPrice { get; set; }
            public string ItemSupplier { get; set; }
        }
        public class ItemList
        {
            public List<Item> Items { get; set; }
            public bool IsRepeatedNR { get; set; }

        }
        public Import()
        {
            InitializeComponent();
        }

        private void ImportFromCSV_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (ImportPath.Text == "")
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Import Path";
                else error.ErrorMessage.Text = "Indtast venligst importsti";
                error.ShowDialog();
            }
            else
            {
                List<Item> items = new List<Item>();
                ReadCSVData(ImportPath.Text);

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
        private DataTable ReadExcel(string fileName)
        {
            if (IsFileLocked(fileName))
            {

                CloseExcelProcesses();
            }
            WorkBook workbook = WorkBook.Load(fileName);

            WorkSheet sheet = workbook.DefaultWorkSheet;

            return sheet.ToDataTable(true);
        }




        public void ReadCSVData(string csvFileName)
        {

            ErrorModal error = new ErrorModal();
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            try
            {
                var csvFilereader = new DataTable();
                csvFilereader = ReadExcel(csvFileName);
                ItemList itemList = ConvertDataTableToList(csvFilereader);
                DBConn db= new DBConn();
                string connectionString = db.con.ConnectionString;
                if (itemList.IsRepeatedNR)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item Nr must be unique in excel file";
                    else error.ErrorMessage.Text = "Varenummer skal være unikt i excel-fil";
                }
                else if (itemList.Items.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (Item item in itemList.Items)
                        {
                            using (SqlCommand command = new SqlCommand("delete from Inventory", connection))
                            {


                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (Item item in itemList.Items)
                        {
                            using (SqlCommand command = new SqlCommand("INSERT INTO Inventory (ItemNr, ItemName, ItemCount, ItemCountBeforeSale, ItemPrice, ItemSupplier,ItemImagePath,ItemImageAbsolutePath,ItemIsActive) VALUES (@ItemNr, @ItemName, @ItemCount, @ItemCountBeforeSale, @ItemPrice, @ItemSupplier, @ItemImagePath, @ItemImageAbsolutePath, @ItemIsActive\r\n)", connection))
                            {
                                command.Parameters.AddWithValue("@ItemNr", item.ItemNr);
                                command.Parameters.AddWithValue("@ItemName", item.Description);
                                command.Parameters.AddWithValue("@ItemCount", item.Count);
                                command.Parameters.AddWithValue("@ItemCountBeforeSale", item.CountBeforeSale);
                                command.Parameters.AddWithValue("@ItemPrice", item.ItemPrice);
                                command.Parameters.AddWithValue("@ItemSupplier", item.ItemSupplier);
                                command.Parameters.AddWithValue("@ItemImagePath", "");
                                command.Parameters.AddWithValue("@ItemImageAbsolutePath", "");
                                command.Parameters.AddWithValue("@ItemIsActive", true);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "New Item List added from Excel file";
                    else error.ErrorMessage.Text = "Ny vareliste tilføjet fra Excel-fil";
                }
                else
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Empty Excel file list!";
                    else error.ErrorMessage.Text = "Tøm Excel-filliste!";
                }
                error.ShowDialog();

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item Ne";
                    else error.ErrorMessage.Text = "Kundenummer, navn, e-mail eller telefonnummer findes allerede";

                }
                else
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while Saving Items Data";
                    else error.ErrorMessage.Text = "Der opstod en fejl under lagring af elementdata";
                }
                error.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }
        public static ItemList ConvertDataTableToList(DataTable dataTable)
        {
            var rowsToDelete = dataTable.Rows
            .Cast<DataRow>()
            .Where(row => row.ItemArray.All(cell => cell == DBNull.Value || string.IsNullOrWhiteSpace(cell.ToString())))
            .ToList();

            // Remove each row identified
            foreach (var row in rowsToDelete)
            {
                dataTable.Rows.Remove(row);
            }
            ItemList result = new ItemList();
            List<Item> items = new List<Item>();

            foreach (DataRow row in dataTable.Rows)
            {
                Item item = new Item
                {
                    ItemNr = row["ItemNr"].ToString(),
                    Description = row["Description"].ToString(),
                    Count = int.Parse(row["Count"].ToString()),
                    CountBeforeSale = int.Parse(row["CountBeforeSale"].ToString()),
                    ItemPrice = row["ItemPrice"].ToString(),
                    ItemSupplier = row["ItemSupplier"].ToString()
                };

                items.Add(item);
            }
            result.Items = items;

            ErrorModal error = new ErrorModal();
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            if (items.GroupBy(i => i.ItemNr).Any(g => g.Count() > 1))
            {

                result.IsRepeatedNR = true;
            }
            else
            {
                result.IsRepeatedNR = false;
            }
            return result;
        }


    }
    
}
