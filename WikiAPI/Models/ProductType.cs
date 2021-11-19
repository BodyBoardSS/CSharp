using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("product_type")]
    public class ProductType
    {
        [Column("pdt_id")]
        [Key]
        public int pdtId { get; set; }
        [Column("pdt_description")]
        public string pdtDescription { get; set; }
    }
}