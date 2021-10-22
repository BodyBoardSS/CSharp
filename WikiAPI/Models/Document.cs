using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("document")]
    public class Document
    {
        [Column("doc_id")]
        [Key]
        public int dotId { get; set; }
        [Column("doc_number")]
        public string docNumber { get; set; }

        [Column("doc_dctid")]
        public DocumentType documentType { get; set; }
    }
}