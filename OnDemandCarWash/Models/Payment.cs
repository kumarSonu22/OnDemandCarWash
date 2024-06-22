namespace OnDemandCarWash.Models
{
    public class Payment
    {
        public int PaymentId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public string PaymentType { get; set; }
    }
}
