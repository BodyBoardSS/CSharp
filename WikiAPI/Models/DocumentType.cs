using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("document_type")]
    public class DocumentType
    {
        [Column("dct_id")]
        [Key]
        public int dctId { get; set; }
        [Column("dct_description")]
        public string dctDescription { get; set; }
    }
}