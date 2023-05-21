namespace DecoratorPattern
{
    internal class ChickenShawarma : Shawarma
    {
        public ChickenShawarma() {
            Description = "Chicken shawarma";
        }

        public override decimal GetPrice()
        {
            return 4.99m;
        }
    }
}
