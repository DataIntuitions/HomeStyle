using HomeStyling.Data;
using HomeStyling.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.Files
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void CustomerManagementLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExportSendCSV_Click(object sender, EventArgs e)
        {
            
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (ExportListType.SelectedItem == null)
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select export list type";
                else error.ErrorMessage.Text = "Vælg venligst eksportlistetype";
                error.ShowDialog();
            }
            else
            {
                ExportItemList exportItemList = new ExportItemList(ExportListType.SelectedIndex);
                exportItemList.Show();
            }
            
        }
        public static string FormatAsText(List<InventoryModel> items)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("List of Items:");
            sb.AppendLine("ItemName\tItemNr\tItemCount\tItemCountBeforeSale\tItemPrice\tItemSupplier\tItemIsActive");

            foreach (var item in items)
            {
                sb.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\n",
                    item.ItemName,
                    item.ItemNr,
                    item.ItemCount,
                    item.ItemCountBeforeSale,
                    item.ItemPrice,
                    item.ItemSupplier,
                    item.ItemIsActive ? "Yes" : "No");
            }

            return sb.ToString();
        }

        private void ExportSendEmail_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (ExportListType.SelectedItem == null)
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select export list type";
                else error.ErrorMessage.Text = "Vælg venligst eksportlistetype";
                error.ShowDialog();
            }
            else if (ExportListType.SelectedIndex == 0)
            {
                
                string query = "select * from inventory";
                List<InventoryModel> list = new List<InventoryModel>();
                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values


                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        InventoryModel model = new InventoryModel()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ItemNr = reader.GetString(reader.GetOrdinal("ItemNr")),
                            ItemName = reader.GetString(reader.GetOrdinal("ItemName")),
                            ItemCount = reader.GetInt32(reader.GetOrdinal("ItemCount")),
                            ItemCountBeforeSale = reader.GetInt32(reader.GetOrdinal("ItemCountBeforeSale")),
                            ItemPrice = reader.GetString(reader.GetOrdinal("ItemPrice")),
                            ItemSupplier = reader.GetString(reader.GetOrdinal("ItemSupplier")),
                            ItemIsActive = reader.GetBoolean(reader.GetOrdinal("ItemIsActive"))

                        };
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
            else
            {
                
                string query = "spItemsForSale";
                List<InventoryModel> list = new List<InventoryModel>();
                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.AddWithValue("@Index", ExportListType.SelectedIndex);


                    // open connection, execute INSERT, close connection
                    db.con.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        InventoryModel model = new InventoryModel()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ItemNr = reader.GetString(reader.GetOrdinal("ItemNr")),
                            ItemName = reader.GetString(reader.GetOrdinal("ItemName")),
                            ItemCount = reader.GetInt32(reader.GetOrdinal("ItemCount")),
                            ItemCountBeforeSale = reader.GetInt32(reader.GetOrdinal("ItemCountBeforeSale")),
                            ItemPrice = reader.GetString(reader.GetOrdinal("ItemPrice")),
                            ItemSupplier = reader.GetString(reader.GetOrdinal("ItemSupplier")),
                            ItemIsActive = reader.GetBoolean(reader.GetOrdinal("ItemIsActive"))

                        };
                        list.Add(model);
                    }

                    db.con.Close();

                }
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

        private void ExportSentClipboard_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            if (ExportListType.SelectedItem == null)
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please select export list type";
                else error.ErrorMessage.Text = "Vælg venligst eksportlistetype";
                error.ShowDialog();
            }
            else if (ExportListType.SelectedIndex == 0)
            {

                string query = "spItemsForSale";
                List<InventoryModel> list = new List<InventoryModel>();
                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values


                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        InventoryModel model = new InventoryModel()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ItemNr = reader.GetString(reader.GetOrdinal("ItemNr")),
                            ItemName = reader.GetString(reader.GetOrdinal("ItemName")),
                            ItemCount = reader.GetInt32(reader.GetOrdinal("ItemCount")),
                            ItemCountBeforeSale = reader.GetInt32(reader.GetOrdinal("ItemCountBeforeSale")),
                            ItemPrice = reader.GetString(reader.GetOrdinal("ItemPrice")),
                            ItemSupplier = reader.GetString(reader.GetOrdinal("ItemSupplier")),
                            ItemIsActive = reader.GetBoolean(reader.GetOrdinal("ItemIsActive"))

                        };
                        list.Add(model);

                    }
                    db.con.Close();
                    string mailtoUri = FormatAsText(list);
                    Clipboard.SetText(mailtoUri);
                    error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Items Copied To Clip Board";
                    else error.ErrorMessage.Text = "Elementer kopieret til udklipsholder";
                    error.ShowDialog();
                }
            }
            else
            {
                
                string query = "spExportItems";
                List<InventoryModel> list = new List<InventoryModel>();
                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Index", ExportListType.SelectedIndex);


                    // open connection, execute INSERT, close connection
                    db.con.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        InventoryModel model = new InventoryModel()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ItemNr = reader.GetString(reader.GetOrdinal("ItemNr")),
                            ItemName = reader.GetString(reader.GetOrdinal("ItemName")),
                            ItemCount = reader.GetInt32(reader.GetOrdinal("ItemCount")),
                            ItemCountBeforeSale = reader.GetInt32(reader.GetOrdinal("ItemCountBeforeSale")),
                            ItemPrice = reader.GetString(reader.GetOrdinal("ItemPrice")),
                            ItemSupplier = reader.GetString(reader.GetOrdinal("ItemSupplier")),
                            ItemIsActive = reader.GetBoolean(reader.GetOrdinal("ItemIsActive"))

                        };
                        list.Add(model);
                    }

                    db.con.Close();

                }
                string mailtoUri = FormatAsText(list);
                Clipboard.SetText(mailtoUri);
                error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Items Copied To Clip Board";
                else error.ErrorMessage.Text = "Elementer kopieret til udklipsholder";
                error.ShowDialog();
            }
        }
    }
}
