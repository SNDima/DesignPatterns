namespace StrategyPattern
{
    internal class NoPaymentMethod : IPaymentMethod
    {
        public void Pay()
        {
            throw new Exception("No payment method selected.");
        }
    }
}
