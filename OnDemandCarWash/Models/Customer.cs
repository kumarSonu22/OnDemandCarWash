using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Models
{
    public class Customer
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int Rating { get; set; }

        public virtual User User { get; set; }
    }
}
