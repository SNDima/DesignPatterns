namespace DecoratorPattern
{
    internal abstract class ShawarmaDecorator : Shawarma
    {
        protected Shawarma Shawarma { get; set; }

        protected ShawarmaDecorator(Shawarma shawarma)
        {
            Shawarma = shawarma;
        }

        public override abstract string Description { get; }
    }
}
