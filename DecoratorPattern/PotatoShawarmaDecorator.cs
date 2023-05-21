namespace DecoratorPattern
{
    internal class PotatoShawarmaDecorator : ShawarmaDecorator
    {
        public PotatoShawarmaDecorator(Shawarma shawarma) : base(shawarma) { }

        public override string Description => $"{Shawarma.Description} + potato";

        public override decimal GetPrice()
        {
            return Shawarma.GetPrice() + .29m;
        }
    }
}
