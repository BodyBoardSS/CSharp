using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("city")]
    public class City
    {
        [Column("cty_id")]
        [Key]
        [ForeignKey("person")]
        public int ctyId { get; set; }
        [Column("cty_name")]
        public string ctyName { get; set; }

        public virtual Person person { get; set; }
    }
}