﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling.InventoryManagement
{
    public partial class ImageView : Form
    {
        public ImageView()
        {
            InitializeComponent();
        }

        private void DeleteInventory_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
