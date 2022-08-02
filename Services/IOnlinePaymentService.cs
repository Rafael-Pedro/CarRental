namespace CarRental.Services
{
    internal interface IOnlinePaymentService
    {
        public double Interest(double amount, int months);
        public double PaymentFee(double amount);

    }
}
