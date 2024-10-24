using ExercicioPropostoInterfaces.Entites;

namespace ExercicioPropostoInterfaces.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = _onlinePaymentService.Interest(basicQuota, i);
                double finalQuota = _onlinePaymentService.PaymentFee(updatedQuota);
                Installment installment = new Installment(date, finalQuota);

                contract.AddInstallment(installment);
            }
        }
    }
}
