using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("supplier")]
    public class Supplier
    {
        [Column("sup_id")]
        [Key]
        public int dotId { get; set; }
        [Column("sup_name")]
        public string supName { get; set; }

        [Column("sup_lastname")]
        public string supLasname { get; set; }

        [Column("sup_tradename")]
        public string supTradename { get; set; }

        [Column("sup_address")]
        public string supAddress { get; set; }

        [Column("sup_ctyid")]
        public City city { get; set; }

        [Column("sup_ctyid")]
        public Document document { get; set; }
    }
}