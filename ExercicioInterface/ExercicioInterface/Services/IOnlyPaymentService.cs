

namespace ExercicioInterface.Services
{
    interface IOnlyPaymentService 
    {
        double PaymentFee(double amount);
        double Interest(double amount, int numberInstallments);
    }
}
