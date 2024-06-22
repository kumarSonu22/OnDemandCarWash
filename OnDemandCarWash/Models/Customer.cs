using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnDemandCarWash.Models
{
    public class Customer
    {
        [Key]
        [ForeignKey("UserId")]
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
