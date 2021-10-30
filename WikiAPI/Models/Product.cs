using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("product")]
    public class Product
    {
        [Column("prd_id")]
        [Key]
        public int prdId { get; set; }
        [Column("prd_description")]
        public string prdDescription { get; set; }

        [Column("prd_price")]
        public double prdPrice { get; set; }

         [Column("prd_cost")]
        public double prdCost { get; set; }

         [Column("prd_stock")]
        public double prdStock { get; set; }

        [Column("prd_pdtid")]
        public int prdPedtId { get; set; }

        [Column("prd_entry_date")]
        public DateTime prdEntryDate { get; set; }
    }
}