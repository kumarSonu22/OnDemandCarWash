namespace OnDemandCarWash.Models
{
    public class Car
    {
        public int CarId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public string Image { get; set; }
    }
}
