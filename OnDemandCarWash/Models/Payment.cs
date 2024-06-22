using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnDemandCarWash.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; } // Primary Key
        public string PaymentType { get; set; }
        
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        public virtual User user { get; set; }
    }
}
