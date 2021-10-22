using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("city")]
    public class City
    {
        [Column("cty_id")]
        [Key]
        public int ctyId { get; set; }
        [Column("cty_name")]
        public string ctyName { get; set; }
    }
}