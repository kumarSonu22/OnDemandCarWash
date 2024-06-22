﻿namespace OnDemandCarWash.Models
{
    public class Order
    {
        public int OrderId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public int CarId { get; set; } // Foreign Key
        public int PackageId { get; set; } // Foreign Key
        public DateTime OrderDate { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }= 100.50m;
    }
}