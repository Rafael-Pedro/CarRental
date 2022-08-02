namespace CarRental.Services
{
    internal class PayPalService : IOnlinePaymentService
    {

        public double Interest(double amount, int month)
        {
            return amount * 0.01 * month;
        }
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

    }
}
