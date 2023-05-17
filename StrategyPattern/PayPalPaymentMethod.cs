namespace StrategyPattern
{
    internal class PayPalPaymentMethod : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Paying via PayPal.");
        }
    }
}
