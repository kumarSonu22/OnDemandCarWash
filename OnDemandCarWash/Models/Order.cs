using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnDemandCarWash.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } 
      
        public DateTime OrderDate { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }= 100.50m;
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User user { get; set; }
        [ForeignKey("CarId")]
        public int CarId { get; set; }
        public virtual Car car { get; set; }
        [ForeignKey("PackageId")]
        public int PackageId { get; set; }
        public virtual Package package { get; set; }
    }
}
