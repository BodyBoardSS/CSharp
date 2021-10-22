using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("person")]
    public class Person
    {
        [Column("per_id")]
        [Key]
        public int perId { get; set; }
        [Column("per_name")]
        public string perName { get; set; }
        [Column("per_lastname")]
        public string perLastname { get; set; }
        [Column("per_docid")]
        public Document document { get; set; }
    }
}