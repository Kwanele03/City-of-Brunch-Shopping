using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Gugu.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number is required")]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
    }
}
