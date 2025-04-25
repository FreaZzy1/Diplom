using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FATT_DP.Models
{
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Action { get; set; } = string.Empty;

        public DateTime Timestamp { get; set; }

        
        public User User { get; set; }
    }
}
