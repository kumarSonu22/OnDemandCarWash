using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnDemandCarWash.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; } // Primary Key
        public int WasherId { get; set; } // Foreign Key
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User user { get; set; }
    }
}
