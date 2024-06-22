namespace OnDemandCarWash.Models
{
    public class Package
    {
        public int PackageId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = 100.25m;
    }
}
