using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace HomeStyling
{
    public class InventoryModel
    {
        public int Id { get; set; }
        public string ItemNr { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }
        public int ItemCountBeforeSale { get; set; }
        public string ItemPrice { get; set; }
        public string ItemSupplier { get; set; }
        public bool ItemIsActive { get; set; }
    }
    public class ExportItemModel
    {
        public string ItemNr { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
        public int ItemCount { get; set; }
        public int ItemCountAfterSale { get; set; }
        public string ItemSupplier { get; set; }
        public string StylingName { get; set; }
        public string StylingAddrress { get; set; }

    }

}
