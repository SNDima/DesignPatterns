namespace DecoratorPattern
{
    internal class CheeseShawarmaDecorator : ShawarmaDecorator
    {
        public override string Description => $"{Shawarma.Description} + cheese";

        public CheeseShawarmaDecorator(Shawarma shawarma) : base(shawarma) { }

        public override decimal GetPrice()
        {
            return Shawarma.GetPrice() + .39m;
        }
    }
}
