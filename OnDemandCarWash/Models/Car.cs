using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; } 
        public int UserId { get; set; } 
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string Image { get; set; }

        public virtual User User { get; set; }
    }
}
