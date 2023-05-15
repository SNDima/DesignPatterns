namespace ObserverPattern
{
    internal class User : IProductObserver
    {
        public string Name { get; }
        public decimal AccountBalance { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(Product product)
        {
            if (AccountBalance >= product.Price)
            {
                Console.WriteLine($"{Name} ({AccountBalance}): I can afford to buy {product.Name}. Let's make an order!");
            }
            else
            {
                Console.WriteLine($"{Name} ({AccountBalance}): {product.Name} is still too expensive for me :(. " +
                    $"Let's wait more time.");
            }
        }
    }
}
