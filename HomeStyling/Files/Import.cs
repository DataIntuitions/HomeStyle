using CsvHelper;
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
            var culture = CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (string.IsNullOrEmpty(ImportPath.Text))
            {
                error.ErrorMessage.Text = culture.TwoLetterISOLanguageName == "en" ? "Please Enter Import Path" : "Indtast venligst importsti";
                error.ShowDialog();
            }
            else
            {
                ReadCSVData(ImportPath.Text);
            }
        }

        public static bool IsFileLocked(string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException)
            {
                return true;
            }
        }

        public static void CloseExcelProcesses()
        {
            var processes = Process.GetProcessesByName("EXCEL");
            foreach (var process in processes)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
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

            DataTable dataTable = new DataTable();

            using (FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = new XSSFWorkbook(file);
                ISheet sheet = workbook.GetSheetAt(0);
                IRow headerRow = sheet.GetRow(0);
                int cellCount = headerRow.LastCellNum;

                for (int i = 0; i < cellCount; i++)
                {
                    dataTable.Columns.Add(headerRow.GetCell(i)?.ToString() ?? $"Column{i}");
                }

                for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null) continue;

                    DataRow dataRow = dataTable.NewRow();

                    for (int j = row.FirstCellNum; j < cellCount; j++)
                    {
                        if (j < 0) continue;
                        if (row.GetCell(j) != null)
                        {
                            dataRow[j] = row.GetCell(j).ToString();
                        }
                    }

                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        public void ReadCSVData(string csvFileName)
        {
            ErrorModal error = new ErrorModal();
            var culture = CultureInfo.CurrentCulture;
            try
            {
                var csvFilereader = ReadExcel(csvFileName);
                ItemList itemList = ConvertDataTableToList(csvFilereader);
                DBConn db = new DBConn();
                string connectionString = db.con.ConnectionString;
                if (itemList.IsRepeatedNR)
                {
                    error.ErrorMessage.Text = culture.TwoLetterISOLanguageName == "en" ? "Item Nr must be unique in excel file" : "Varenummer skal være unikt i excel-fil";
                }
                else if (itemList.Items.Count > 0)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        foreach (Item item in itemList.Items)
                        {
                            using (SqlCommand command = new SqlCommand(@"
                                MERGE INTO Inventory AS target
                                USING (SELECT @ItemNr AS ItemNr) AS source
                                ON (target.ItemNr = source.ItemNr)
                                WHEN MATCHED THEN 
                                    UPDATE SET 
                                        ItemName = @ItemName,
                                        ItemCount = @ItemCount,
                                        ItemCountBeforeSale = @ItemCountBeforeSale,
                                        ItemPrice = @ItemPrice,
                                        ItemSupplier = @ItemSupplier,
                                        ItemImagePath = @ItemImagePath,
                                        ItemImageAbsolutePath = @ItemImageAbsolutePath,
                                        ItemIsActive = @ItemIsActive
                                WHEN NOT MATCHED THEN
                                    INSERT (ItemNr, ItemName, ItemCount, ItemCountBeforeSale, ItemPrice, ItemSupplier, ItemImagePath, ItemImageAbsolutePath, ItemIsActive)
                                    VALUES (@ItemNr, @ItemName, @ItemCount, @ItemCountBeforeSale, @ItemPrice, @ItemSupplier, @ItemImagePath, @ItemImageAbsolutePath, @ItemIsActive);", connection))
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
                    error.ErrorMessage.ForeColor = SystemColors.ScrollBar;
                    error.ErrorMessage.Text = culture.TwoLetterISOLanguageName == "en" ? "New Item List added from Excel file" : "Ny vareliste tilføjet fra Excel-fil";
                }
                else
                {
                    error.ErrorMessage.Text = culture.TwoLetterISOLanguageName == "en" ? "Empty Excel file list!" : "Tøm Excel-filliste!";
                }
                error.ShowDialog();
            }
            catch (Exception ex)
            {
                LogError(ex);
                if (ex.Message.Contains("UNIQUE"))
                {
                    error.ErrorMessage.Text = culture.TwoLetterISOLanguageName == "en" ? "Item Nr must be unique" : "Kundenummer, navn, e-mail eller telefonnummer findes allerede";
                }
                else
                {
                    error.ErrorMessage.Text = culture.TwoLetterISOLanguageName == "en" ? "Error Occur while Saving Items Data" : "Der opstod en fejl under lagring af elementdata";
                }
                error.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        private void LogError(Exception ex)
        {
            string logDirectory = @"C:\temp";
            string logFile = Path.Combine(logDirectory, "imported.log");

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.WriteLine("Date: " + DateTime.Now.ToString());
                writer.WriteLine("Message: " + ex.Message);
                writer.WriteLine("StackTrace: " + ex.StackTrace);
                writer.WriteLine("--------------------------------------------------");
            }
        }

        public static ItemList ConvertDataTableToList(DataTable dataTable)
        {
            var rowsToDelete = dataTable.Rows
                .Cast<DataRow>()
                .Where(row => row.ItemArray.All(cell => cell == DBNull.Value || string.IsNullOrWhiteSpace(cell.ToString())))
                .ToList();

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
            result.IsRepeatedNR = items.GroupBy(i => i.ItemNr).Any(g => g.Count() > 1);

            return result;
        }
    }
}
