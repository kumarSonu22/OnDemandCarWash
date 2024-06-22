using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public string PaymentType { get; set; }

        public virtual User User { get; set; }
    }
}
