using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCE.Models
{

    public class Product
    {
        public int idkey { get; set; }
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public ProductResult[] results { get; set; }
    }

    public class ProductResult
    {
        public int idkey { get; set; }
        public int product_idkey { get; set; }
        public string id { get; set; }
        public string vendor_code { get; set; }
        public string barcode { get; set; }
        public string title { get; set; }
        public string remainder { get; set; }
        public string price { get; set; }
        public string am { get; set; }
        public string dm { get; set; }
    }
}
