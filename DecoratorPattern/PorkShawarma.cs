namespace DecoratorPattern
{
    internal class PorkShawarma : Shawarma
    {
        public PorkShawarma()
        {
            Description = "Pork shawarma";
        }

        public override decimal GetPrice()
        {
            return 5.49m;
        }
    }
}
