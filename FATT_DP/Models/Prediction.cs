using System.ComponentModel.DataAnnotations;

namespace FATT_DP.Models
{
    public class Prediction
    {
        [Key]
        public int Id { get; set; }

        public int TransactionId { get; set; } // Связь с таблицей Transactions

        public decimal PredictionValue { get; set; } // Предсказанное значение

        public DateTime CreatedAt { get; set; }

        public Transaction Transaction { get; set; }
    }
}
