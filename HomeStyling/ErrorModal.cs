using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeStyling
{
    public partial class ErrorModal : Form
    {
        public ErrorModal()
        {
            InitializeComponent();
        }

        private void ErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void OkErrorDialouge_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
