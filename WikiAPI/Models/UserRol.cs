using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("user_rol")]
    public class UserRol
    {
        [Column("use_id")]
        [Key]
        public User user { get; set; }

        [Column("rol_id")]
        public Rol rol { get; set; }
    }
}