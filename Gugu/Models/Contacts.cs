using System.ComponentModel.DataAnnotations;

namespace Gugu.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
    }
}
