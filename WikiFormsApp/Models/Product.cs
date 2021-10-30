using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiAPI.Models;

namespace WikiFormsApp.Models
{
    public class Product
    {
        public int prdId { get; set; }
        public string prdDescription { get; set; }
        public double prdPrice { get; set; }
        public double prdCost { get; set; }
        public double prdStock { get; set; }
        public DateTime prdEntryDate { get; set; }
        public int prdPdtId { get; set; }
        public int prdSupId { get; set; }
        public ProductType productType { get; set; }
        public Supplier supplier { get; set; }

    }
}



