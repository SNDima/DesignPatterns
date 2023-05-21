namespace DecoratorPattern
{
    internal class BeefShawarma : Shawarma
    {
        public BeefShawarma()
        {
            Description = "Beef shawarma";
        }

        public override decimal GetPrice()
        {
            return 5.99m;
        }
    }
}
