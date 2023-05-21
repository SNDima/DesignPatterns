namespace DecoratorPattern
{
    internal class MushroomsShawarmaDecorator : ShawarmaDecorator
    {
        public MushroomsShawarmaDecorator(Shawarma shawarma) : base(shawarma) { }

        public override string Description => $"{Shawarma.Description} + mushrooms";

        public override decimal GetPrice()
        {
            return Shawarma.GetPrice() + .29m;
        }
    }
}
