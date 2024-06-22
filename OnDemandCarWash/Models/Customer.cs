namespace OnDemandCarWash.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int Rating { get; set; }
    }
}
