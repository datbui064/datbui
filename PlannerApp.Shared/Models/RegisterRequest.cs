
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerApp.Shared.Models
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50)]
        public string ComfirmPassword { get; set; }

    }
}
