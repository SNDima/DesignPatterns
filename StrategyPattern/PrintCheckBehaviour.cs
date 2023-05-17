namespace StrategyPattern
{
    internal class PrintCheckBehaviour : ICheckBehaviour
    {
        public void ProcessCheckRequest()
        {
            Console.WriteLine("Printing a check...");
        }
    }
}
