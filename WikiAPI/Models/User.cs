using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiAPI.Models
{
    [Table("users")]
    public class User
    {

        [Column("use_id")]
        [Key]
        public int useId { get; set; }
        [Column("use_email")]
        public string useEmail { get; set; }
        [Column("use_usuario")]
        public string useUsuario { get; set; }
        [Column("use_password")]
        public string usePassword { get; set; }

        public virtual IList<UserRol> UserRoles { get; set; }
    }
}