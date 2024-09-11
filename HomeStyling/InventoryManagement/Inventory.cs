using HomeStyling.Data;
using HomeStyling.InventoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.CustomerManagement
{
    public partial class Inventory : Form
    {
        private Image currentImage;

        public Inventory()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CreateInventory_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (ItemName.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Name";
                    else error.ErrorMessage.Text = "Indtast venligst varens navn";
                    error.ShowDialog();
                }
                else if (ItemNr.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Nr";
                    else error.ErrorMessage.Text = "Indtast venligst varenr";
                    error.ShowDialog();
                }
                else if (ItemCount.Text == "" || ItemCountBeforeSale.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please enter Item Count and Item Count before sale";
                    else error.ErrorMessage.Text = "Indtast vareantal og vareantal før salg";
                    error.ShowDialog();
                }
                else
                {

                    
                    string query = "INSERT INTO Inventory  (ItemNr,ItemName,ItemCount,ItemCountBeforeSale,ItemPrice,ItemSupplier,ItemImagePath,ItemImageAbsolutePath,ItemIsActive) " +
                           "VALUES (@ItemNr,@ItemName,@ItemCount,@ItemCountBeforeSale,@ItemPrice,@ItemSupplier,@ItemImagePath,@ItemImageAbsolutePath,@ItemIsActive) ";

                   
                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.Parameters.Add("@ItemNr", SqlDbType.VarChar, 50).Value = ItemNr.Text;
                        cmd.Parameters.Add("@ItemName", SqlDbType.VarChar, 50).Value = ItemName.Text;
                        cmd.Parameters.Add("@ItemCount", SqlDbType.Int).Value = Int32.Parse(ItemCount.Text);
                        cmd.Parameters.Add("@ItemCountBeforeSale", SqlDbType.Int).Value = Int32.Parse(ItemCountBeforeSale.Text);
                        cmd.Parameters.Add("@ItemPrice", SqlDbType.VarChar,10).Value = ItemPrice.Text;
                        cmd.Parameters.Add("@ItemSupplier", SqlDbType.VarChar, 50).Value = ItemSupplier.Text;
                        cmd.Parameters.Add("@ItemImagePath", SqlDbType.VarChar).Value =ItemImagePath.Text;
                        cmd.Parameters.Add("@ItemImageAbsolutePath", SqlDbType.VarChar).Value = ItemImagePath.Text;
                        cmd.Parameters.Add("@ItemIsActive", SqlDbType.Bit).Value = InventoryActive.Checked;
                        // open connection, execute INSERT, close connection
                        db.con.Open();
                        cmd.ExecuteNonQuery();
                        db.con.Close();
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "New Item Added";
                        else error.ErrorMessage.Text = "Ny vare tilføjet";
                        error.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item NR already exists";
                    else error.ErrorMessage.Text = "Vare NR findes allerede";

                }
                else
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while Adding Item";
                    else error.ErrorMessage.Text = "Der opstod en fejl under tilføjelse af element";
                }
                error.ShowDialog();
            }
        }

        private void ItemCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ItemCountBeforeSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FindInventory_Click(object sender, EventArgs e)
        {
            try
            {
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                ErrorModal error = new ErrorModal();
                
                string query = "spFindInventory";
                DBConn db= new DBConn(); using (db.con)
                using (SqlCommand cmd = new SqlCommand(query, db.con))
                {
                    // define parameters and their values
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemNr", ItemNr.Text);
                    cmd.Parameters.AddWithValue("@ItemName", ItemName.Text);

                    // open connection, execute INSERT, close connection
                    db.con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        ItemNr.Text = sdr["ItemNr"].ToString();
                        ItemName.Text = sdr["ItemName"].ToString();
                        ItemCount.Text = sdr["ItemCount"].ToString();
                        ItemCountBeforeSale.Text = sdr["ItemCountBeforeSale"].ToString();
                        ItemPrice.Text = sdr["ItemPrice"].ToString();
                        ItemSupplier.Text = sdr["ItemSupplier"].ToString();
                        InventoryActive.Checked = Convert.ToBoolean(sdr["ItemIsActive"]);
                        ItemId.Text = sdr["Id"].ToString();
                        ItemImagePath.Text = sdr["ItemImagePath"].ToString();
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

        private void SaveInventory_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            try
            {


                if (ItemName.Text == "")
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Name";
                    else error.ErrorMessage.Text = "Indtast venligst varens navn";
                    error.ShowDialog();
                }
                else if (ItemNr.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Nr";
                    else error.ErrorMessage.Text = "Indtast venligst varenr";
                    error.ShowDialog();
                }
                else if (ItemCount.Text == "" || ItemCountBeforeSale.Text == "")
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please enter Item Count and Item Count before sale";
                    else error.ErrorMessage.Text = "Indtast vareantal og vareantal før salg";
                    error.ShowDialog();
                }
                else if(ItemId.Text=="" || ItemId==null)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please find item first";
                    else error.ErrorMessage.Text = "Find venligst varen først";
                    error.ShowDialog();
                }
                else
                {

                    
                    string query = "spUpdateInventory";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ItemNr", ItemNr.Text);
                        cmd.Parameters.AddWithValue("@ItemName", ItemName.Text);
                        cmd.Parameters.AddWithValue("@ItemCount", Int32.Parse(ItemCount.Text));
                        cmd.Parameters.AddWithValue("@ItemCountBeforeSale", Int32.Parse(ItemCountBeforeSale.Text));
                        cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice.Text);
                        cmd.Parameters.AddWithValue("@ItemSupplier", ItemSupplier.Text);
                        cmd.Parameters.AddWithValue("@ItemImagePath", "");
                        cmd.Parameters.AddWithValue("@ItemImageAbsolutePath", "");
                        cmd.Parameters.AddWithValue("@ItemIsActive", InventoryActive.Checked);
                        cmd.Parameters.AddWithValue("@Id", Int32.Parse(ItemId.Text));

                      

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
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item NR already exists";
                    else error.ErrorMessage.Text = "Vare NR findes allerede";

                }
                else
                {

                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while updating Item";
                    else error.ErrorMessage.Text = "Der opstod en fejl under opdatering af element";
                }
                error.ShowDialog();
                Console.WriteLine(ex.Message);
            }
        }

        private void DeleteInventory_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();
            try
            {
                if (ItemId.Text == "" || ItemId == null)
                {
                    if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Please Enter Item Name";
                    else error.ErrorMessage.Text = "Indtast venligst varens navn";
                    error.ShowDialog();
                }
                else
                {

                    
                    string query = "Delete from Inventory where id=@Id";

                    DBConn db= new DBConn(); using (db.con)
                    using (SqlCommand cmd = new SqlCommand(query, db.con))
                    {
                        // define parameters and their values

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Int32.Parse(ItemId.Text);
                        // open connection, execute INSERT, close connection
                        db.con.Open();
                        cmd.ExecuteNonQuery();
                        db.con.Close();
                        ItemName.Text = "";
                        ItemNr.Text = "";
                        ItemPrice.Text = "";
                        ItemSupplier.Text = "";
                        InventoryActive.Checked = false;
                        ItemCount.Text = "";
                        ItemCountBeforeSale.Text = "";
                        ItemId.Text = "";
                        error.ErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
                        if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Item Deleted Succesfuly";
                        else error.ErrorMessage.Text = "Elementet blev slettet";
                        error.ShowDialog();
                    }
                }

            }
            catch (Exception ex)
            {

                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Error Occur while deleting Item";
                else error.ErrorMessage.Text = "Der opstod en fejl under sletning af element";

                error.ShowDialog();
            }
        }

        private void ItemNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InventoryAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                openFileDialog.Title = "Save an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\" + openFileDialog.SafeFileName;
                        //string filePath = "C:\\Users\\ahmad\\Downloads\\Items\\" + openFileDialog.SafeFileName;// openFileDialog.FileName;
                        // Save the image in the selected format
                        string extension = Path.GetExtension(filePath).ToLower();
                        ItemImagePath.Text = filePath;
                        currentImage = Image.FromFile(openFileDialog.FileName);

                        switch (extension)
                        {
                            case ".jpg":
                            case ".jpeg":
                                currentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;
                            case ".png":
                                currentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                                break;
                            case ".bmp":
                                currentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;
                            case ".gif":
                                currentImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                            default:
                                MessageBox.Show("Unsupported file format.");
                                break;
                        }

                        MessageBox.Show("Image saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while saving the image: " + ex.Message);
                    }
                }
            }
         
        }

        private void ViewPhoto_Click(object sender, EventArgs e)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            ErrorModal error = new ErrorModal();

            if (ItemImagePath.Text=="")
            {
                if (culture.TwoLetterISOLanguageName == "en") error.ErrorMessage.Text = "Image not Found";
                else error.ErrorMessage.Text = "Billedet blev ikke fundet";
                error.ShowDialog();

            }
            else
            {
                ImageView image = new ImageView();
                image.pictureBox1.Image = Image.FromFile(ItemImagePath.Text);

                image.ShowDialog();
            }
           
        }
    }
    
}
