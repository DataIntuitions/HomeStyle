using HomeStyling.Data;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.Files
{
    public partial class ExportItemList : Form
    {
        public int index { get; set; }
        public ExportItemList(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void CustomerManagementLabel_Click(object sender, EventArgs e)
        {

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

        private void ExportSendAsCSV_Click(object sender, EventArgs e)
        {
            try
            {
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                ErrorModal error = new ErrorModal();

                if (IsFileLocked(Path.Combine(InputExportPath.Text, "export.xlsx")))
                {

                    CloseExcelProcesses();
                }
                if (InputExportPath.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Import Path";
                    else error.ErrorMessage.Text = "Indtast venligst importsti";
                    error.ShowDialog();
                }
                else if (index == 0)
                {

                    using (var fs = new FileStream(Path.Combine(InputExportPath.Text, "export.xlsx"), FileMode.Create, FileAccess.Write))
                    {
                        IWorkbook workbook = new XSSFWorkbook();
                        ISheet excelSheet = workbook.CreateSheet("ExportItems");

                        // Create header row
                        IRow headerRow = excelSheet.CreateRow(0);
                        headerRow.CreateCell(0).SetCellValue("ItemNr");
                        headerRow.CreateCell(1).SetCellValue("ItemName");
                        headerRow.CreateCell(2).SetCellValue("ItemCount");
                        headerRow.CreateCell(3).SetCellValue("ItemCountBeforeSale");
                        headerRow.CreateCell(4).SetCellValue("ItemPrice");
                        headerRow.CreateCell(5).SetCellValue("ItemSupplier");

                        // Fetch data from the database
                        var counter = 1;
                        string query = "select * from inventory";
                        List<InventoryModel> list = new List<InventoryModel>();

                        DBConn db = new DBConn(); using (db.con)
                        using (SqlCommand cmd = new SqlCommand(query, db.con))
                        {
                            db.con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            while (sdr.Read())
                            {
                                // Create a new row for each record
                                IRow row = excelSheet.CreateRow(counter++);

                                row.CreateCell(0).SetCellValue(sdr["ItemNr"].ToString());
                                row.CreateCell(1).SetCellValue(sdr["ItemName"].ToString());
                                row.CreateCell(2).SetCellValue(Convert.ToInt32(sdr["ItemCount"]));
                                row.CreateCell(3).SetCellValue(Convert.ToInt32(sdr["ItemCountBeforeSale"]));
                                row.CreateCell(4).SetCellValue(sdr["ItemPrice"].ToString());
                                row.CreateCell(5).SetCellValue(sdr["ItemSupplier"].ToString());
                            }
                            db.con.Close();
                        }

                        // Write the Excel file
                        workbook.Write(fs);
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Export Item File Created";
                        else error.ErrorMessage.Text = "Eksporter elementfil oprettet";
                        error.ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    using (var fs = new FileStream(Path.Combine(InputExportPath.Text, "export.xlsx"), FileMode.Create, FileAccess.Write))
                    {
                        IWorkbook workbook = new XSSFWorkbook();
                        ISheet excelSheet = workbook.CreateSheet("ExportItems");

                        // Create header row
                        IRow headerRow = excelSheet.CreateRow(0);
                        headerRow.CreateCell(0).SetCellValue("ItemNr");
                        headerRow.CreateCell(1).SetCellValue("ItemName");
                        headerRow.CreateCell(2).SetCellValue("ItemCount");
                        headerRow.CreateCell(3).SetCellValue("ItemCountBeforeSale");
                        headerRow.CreateCell(4).SetCellValue("ItemPrice");
                        headerRow.CreateCell(5).SetCellValue("ItemSupplier");

                        // Fetch data from the database
                        var counter = 1;
                        string query = "spExportItems";
                        List<InventoryModel> list = new List<InventoryModel>();
                        DBConn db = new DBConn(); using (db.con)
                        using (SqlCommand cmd = new SqlCommand(query, db.con))
                        {
                            // define parameters and their values
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Index", index);
                            db.con.Open();
                            SqlDataReader sdr = cmd.ExecuteReader();
                            while (sdr.Read())
                            {
                                // Create a new row for each record
                                IRow row = excelSheet.CreateRow(counter++);

                                row.CreateCell(0).SetCellValue(sdr["ItemNr"].ToString());
                                row.CreateCell(1).SetCellValue(sdr["ItemName"].ToString());
                                row.CreateCell(2).SetCellValue(Convert.ToInt32(sdr["ItemCount"]));
                                row.CreateCell(3).SetCellValue(Convert.ToInt32(sdr["ItemCountBeforeSale"]));
                                row.CreateCell(4).SetCellValue(sdr["ItemPrice"].ToString());
                                row.CreateCell(5).SetCellValue(sdr["ItemSupplier"].ToString());
                            }
                            db.con.Close();
                        }

                        // Write the Excel file
                        workbook.Write(fs);
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Export Item File Created";
                        else error.ErrorMessage.Text = "Eksporter elementfil oprettet";
                        error.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                ErrorModal error = new ErrorModal();
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Exporting Item File";
                else error.ErrorMessage.Text = "Fejl ved eksport af elementfil";
                error.ShowDialog();
            }
        }
    }
}
