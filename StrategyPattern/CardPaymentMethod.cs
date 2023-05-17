namespace StrategyPattern
{
    internal class CardPaymentMethod : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Paying by card.");
        }
    }
}
