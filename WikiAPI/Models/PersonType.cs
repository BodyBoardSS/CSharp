using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("person_type")]
    public class PersonType
    {
        [Column("pet_id")]
        [Key]
        [ForeignKey("person")]
        public int petId { get; set; }
        [Column("pet_description")]
        public string petDescription { get; set; }

        public virtual Person person { get; set; }
    }
}