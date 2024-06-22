namespace OnDemandCarWash.Models
{
    public class Review
    {
        public int ReviewId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public int WasherId { get; set; } // Foreign Key
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
