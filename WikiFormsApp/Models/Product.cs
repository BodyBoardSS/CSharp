
using System;

namespace WikiAPI.Models
{
    public class Product
    {
        public int prdId { get; set; }
        public string prdDescription { get; set; }
        public double prdPrice { get; set; }
        public double prdCost { get; set; }
        public double prdStock { get; set; }
        public ProductType productType { get; set; }
        public DateTime prdEntryDate { get; set; }
    }
}