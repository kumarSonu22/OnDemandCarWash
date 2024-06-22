using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Models
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = 100.25m;

        public virtual ICollection<Order> order { get; set; }
    }
}
