using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("invoice")]
    public class Invoice
    {
        [Column("inv_id")]
        [Key]
        public int addId { get; set; }

        [Column("inv_mtpid")]
        public MethodPayment methodPayment { get; set; }
        
        [Column("inv_perid")]
        public Peson person { get; set; }

        [Column("inv_employee")]
        public string invEmployee { get; set; }

        [Column("inv_date")]
        public date invDate { get; set; }

        [Column("inv_total")]
        public double invTotal { get; set; }
    }
}