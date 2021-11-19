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
        public decimal prdPrice { get; set; }

         [Column("prd_cost")]
        public decimal prdCost { get; set; }

         [Column("prd_stock")]
        public decimal prdStock { get; set; }

        [Column("prd_pdtid")]
        public int prdPdtId { get; set; }

        [Column("prd_supid")]
        public int prdSupId { get; set; }

        [Column("prd_entry_date")]
        public DateTime prdEntryDate { get; set; }
    }
}