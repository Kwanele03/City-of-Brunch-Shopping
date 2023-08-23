using System.ComponentModel.DataAnnotations;

namespace Gugu.Data.ViewModels
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
