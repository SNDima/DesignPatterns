namespace ObserverPattern
{
    internal class Product : IProductPublisher
    {
        private readonly IList<IProductObserver> _observers;

        public string Name { get; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                Console.WriteLine($">>> {Name} price is updated to {value}");
                NotifyObservers();
            }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            _price = price;
            _observers = new List<IProductObserver>();
        }

        public void RegisterObserver(IProductObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void RemoveObserver(IProductObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
