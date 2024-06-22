namespace OnDemandCarWash.Models
{
    public class User
    {
        public int UserId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public string Address { get; set; }
        public string PaymentDetails { get; set; }
    }
}
