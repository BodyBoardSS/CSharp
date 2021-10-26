using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("address")]
    public class Address
    {
        [Column("add_id")]
        [Key]
        public int addId { get; set; }

        [Column("add_address")]
        public string address { get; set; }
        
        [Column("add_perid")]
        public Person person { get; set; }
    }
}