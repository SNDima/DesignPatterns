namespace ObserverPattern
{
    internal class ProductPriceHistory : IProductObserver
    {
        private readonly Dictionary<string, IList<PriceHistory>> _histories;

        public ProductPriceHistory()
        {
            _histories = new Dictionary<string, IList<PriceHistory>>();
        }

        public void Update(Product product)
        {
            var priceHistory = new PriceHistory(product.Price);
            if (_histories.ContainsKey(product.Name))
            {
                _histories[product.Name].Add(priceHistory);
            }
            else
            {
                _histories.Add(product.Name, new List<PriceHistory> { priceHistory });
            }

            ChechPriceTrend(product.Name);
        }

        private void ChechPriceTrend(string productName)
        {
            var priceHistoryList = _histories[productName];

            if (priceHistoryList.Count > 1)
            {
                var currentPrice = priceHistoryList[^1].Price;
                var previousPrice = priceHistoryList[^2].Price;

                if (currentPrice < previousPrice)
                {
                    Console.WriteLine($"ProductPriceHistory: The price of {productName} is falling! " +
                        $"({previousPrice} -> {currentPrice})");
                }
                else
                {
                    Console.WriteLine($"ProductPriceHistory: The price of {productName} is rising! " +
                        $"({previousPrice} -> {currentPrice})");
                }
            }
        }
    }

    internal class PriceHistory
    {
        public decimal Price { get; }
        public DateTime PriceUpdateDate { get; }

        public PriceHistory(decimal price)
        {
            Price = price;
            PriceUpdateDate = DateTime.Now;
        }
    }
}
