using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEM.Models
{
    [Table("User")]
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_name")]
        public string? UserName { get; set; }

        [Column("password")]
        public string? Password { get; set; }

        [Column("role")]
        public string? Role { get; set; }
    }
}
