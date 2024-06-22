using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnDemandCarWash.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; } 
   
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string Image { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User user { get; set; }
        public virtual ICollection<Order> order { get; set; }
    }
}
