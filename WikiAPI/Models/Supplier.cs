using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("supplier")]
    public class Supplier
    {
        [Column("sup_id")]
        [Key]
        public int supId { get; set; }

        [Column("sup_tradename")]
        public string supTradename { get; set; }
        [Column("sup_perid")]
        public int supPerId { get; set; }
        public virtual Person person { get; set; }
    }
}