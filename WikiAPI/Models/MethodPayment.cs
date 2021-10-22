using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("method_payment")]
    public class MethodPayment
    {
        [Column("mtp_id")]
        [Key]
        public int mtpId { get; set; }
        [Column("mtp_description")]
        public string mtpDescription { get; set; }
    }
}