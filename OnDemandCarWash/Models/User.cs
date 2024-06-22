using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public string Address { get; set; }
        public string PaymentDetails { get; set; }

        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
