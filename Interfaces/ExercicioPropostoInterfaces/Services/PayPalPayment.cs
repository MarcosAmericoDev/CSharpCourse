namespace ExercicioPropostoInterfaces.Services
{
    class PayPalPayment : IOnlinePaymentService
    {
        public double Interest(double amount, int month)
        {
            return amount * 1.01 * month;
        }

        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }
    }
}
