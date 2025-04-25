using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FATT_DP.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Role { get; set; } = "User";  

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

       
        public ICollection<Transaction> Transactions { get; set; }
    }
}
