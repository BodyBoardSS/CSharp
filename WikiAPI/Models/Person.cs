using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("person")]
    public class Person
    {
        [Column("per_id")]
        [Key]
        [ForeignKey("supplier")]
        public int perId { get; set; }
        [Column("per_name")]
        public string perName { get; set; }
        [Column("per_lastname")]
        public string perLastname { get; set; }

        [Column("per_ctyid")]
        public int perCtyId { get; set; }

        [Column("per_petid")]
        public int perPetId { get; set; }
        public virtual City city { get; set; }
        public virtual PersonType personType { get; set; }
        public virtual Supplier supplier { get; set; }
    }
}