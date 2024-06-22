using System.ComponentModel.DataAnnotations;

namespace OnDemandCarWash.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key
        public int WasherId { get; set; } // Foreign Key
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual User User { get; set; }
    }
}
