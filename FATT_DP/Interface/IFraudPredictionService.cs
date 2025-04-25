using FATT_DP.Models;

namespace FATT_DP.Interface
{
    public interface IFraudPredictionService
    {
        Task<bool> PredictFraudAsync(Transaction transaction);
    }
}
