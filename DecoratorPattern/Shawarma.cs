namespace DecoratorPattern
{
    internal abstract class Shawarma
    {
        public virtual string Description { get; protected set; } = "Unknown shawarma";

        public abstract decimal GetPrice();

        public override string ToString()
        {
            return $"Description: {Description}\n" +
                $"Price: {GetPrice()}\n";
        }
    }
}
