

namespace ExercicioInterface.Services
{
    internal class PaylpalService : IOnlyPaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int numberInstallments)
        {
            return amount * MonthlyInterest * numberInstallments;
        }
        
        public double PaymentFee(double amount)
        {
            return FeePercentage * amount;
        }
    }
}
