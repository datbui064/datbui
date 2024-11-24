using System.ComponentModel.DataAnnotations;

namespace CEM.Models
{
    public class LoginView
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập User")]

        public string? UserName { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập Password")]
        public string? Password { get; set; } = string.Empty;

    }
}
