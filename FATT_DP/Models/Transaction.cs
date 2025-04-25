using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FATT_DP.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public decimal Amount { get; set; } // 💡 вот это свойство важно

        public DateTime Timestamp { get; set; }

        public string Location { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<TransactionInput> TransactionInputs { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
