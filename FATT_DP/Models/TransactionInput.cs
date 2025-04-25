using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FATT_DP.Models
{
    public class TransactionInput
    {

        public int Id { get; set; }

        public string Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; } = string.Empty;
        public bool? IsFraud { get; set; }

        // Внешний ключ для связи с Transaction
        public int TransactionId { get; set; }

        // Навигационное свойство для связи с Transaction
        public Transaction Transaction { get; set; }

        public int? PredictionId { get; set; }
        public Prediction? Prediction { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
