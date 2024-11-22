using System.ComponentModel.DataAnnotations.Schema;

namespace CEM.Models
{
    public class User
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Nên mã hóa mật khẩu trước khi lưu
        [NotMapped]
        public string ConfirmPassword { get; set; }
    }
}
