namespace DecoratorPattern
{
    internal class TomatoShawarmaDecorator : ShawarmaDecorator
    {
        public TomatoShawarmaDecorator(Shawarma shawarma) : base(shawarma) { }

        public override string Description => $"{Shawarma.Description} + tomato";

        public override decimal GetPrice()
        {
            return Shawarma.GetPrice() + .19m;
        }
    }
}
