using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("invoice_detail")]
    public class InvoiceDetail
    {
        [Column("det_id")]
        [Key]
        public int detId { get; set; }

        [Column("det_prdis")]
        public Product product { get; set; }

        [Column("det_quantity")]
        public decimal detQuantity { get; set; }

        [Column("det_total")]
        public decimal detTotal { get; set; }
    }
}