namespace StrategyPattern
{
    internal class NoCheckBehaviour : ICheckBehaviour
    {
        public void ProcessCheckRequest()
        {
            Console.WriteLine("<< No check is shown >>");
        }
    }
}
