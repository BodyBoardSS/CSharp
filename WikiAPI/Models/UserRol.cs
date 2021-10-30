using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("user_rol")]
    public class UserRol
    {
        [Column("use_id")]
        public int userId { get; set; }

        [Column("rol_id")]
        public int rolId { get; set; }
        
        public virtual User User { get; set; }
        
        public virtual Rol Rol { get; set; }
    }
}