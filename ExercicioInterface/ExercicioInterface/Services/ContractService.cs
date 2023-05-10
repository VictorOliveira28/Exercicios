using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    internal class ContractService
    {
        private IOnlyPaymentService _onlinePaymentService;

        public ContractService(IOnlyPaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int numberInstallments)
        {
            double basicQuota = contract.TotalValue / numberInstallments;
            
            for(int i = 1; i <= numberInstallments; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
