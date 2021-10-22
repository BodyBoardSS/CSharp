using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("phone")]
    public class Phone
    {
        [Column("pho_id")]
        [Key]
        public int phoId { get; set; }

        [Column("pho_perid")]
        public Person person { get; set; }
        
        [Column("pho_cellphone")]
        public string phoCellPhone { get; set; }
    }
}