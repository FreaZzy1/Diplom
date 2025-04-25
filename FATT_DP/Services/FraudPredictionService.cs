using FATT_DP.Data;
using FATT_DP.Interface;
using FATT_DP.Models;

namespace FATT_DP.Services
{
    public class FraudPredictionService : IFraudPredictionService
    {
        private readonly ApplicationDbContext _context;

        public FraudPredictionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> PredictFraudAsync(Transaction transaction)
        {
            bool isFraud = transaction.Amount > 10000;

            var prediction = new Prediction
            {
                TransactionId = transaction.Id,
                PredictionValue = isFraud ? 1.0m : 0.0m, 
                CreatedAt = DateTime.UtcNow
            };

            _context.Predictions.Add(prediction);
            await _context.SaveChangesAsync();

            return isFraud;
        }
    }
}
