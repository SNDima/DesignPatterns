namespace StrategyPattern
{
    internal class CryptoPaymentMethod : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Paying with a cryptocurrency.");
        }
    }
}
