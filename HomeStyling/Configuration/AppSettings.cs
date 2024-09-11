using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void SaveAppSettings_Click(object sender, EventArgs e)
        {
            CultureInfo culture;
            //CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;

            //CultureInfo.DefaultThreadCurrentCulture = currentCulture;

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
