using Gugu.Data.Base;
using System.ComponentModel.DataAnnotations;


namespace Gugu.Models
{
    public class Store : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Store Logo")]
        [Required(ErrorMessage = "Store logo is required")]
        public string Logo { get; set; }

        [Display(Name = "Store Name")]
        [Required(ErrorMessage = "Store name is required")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }


        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAdress{ get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(12, MinimumLength = 0, ErrorMessage = "The Contact Details must be between 10 numbers")]
        [Display(Name = "Contact Details")]
        public int ContactsDetails { get; set; }

        //Relationships
        public List<Product> Products { get; set; }
    }
}
