using ObserverPattern;

var phone = new Product("Apple iPhone 14", 2500m);
var watch = new Product("Apple Watch Series 8", 1500m);
var headphones = new Product("Наушники Apple AirPods Pro 2", 750m);

var dima = new User("Dima") { AccountBalance = 1300 };
var maksim = new User("Maksim") { AccountBalance = 2000 };

var productPriceHistory = new ProductPriceHistory();

watch.RegisterObserver(dima);
watch.RegisterObserver(maksim);
watch.RegisterObserver(productPriceHistory);

headphones.RegisterObserver(maksim);
headphones.RegisterObserver(dima);
headphones.RegisterObserver(productPriceHistory);

phone.RegisterObserver(maksim);
phone.RegisterObserver(dima);
phone.RegisterObserver(productPriceHistory);

Console.WriteLine(">>> Products are created. Observers are registered.");
Console.WriteLine(">>> Waiting for prices to be updated...\n");

Thread.Sleep(5000);

watch.Price = 1400m;
Console.WriteLine();
headphones.Price = 800m;

Console.WriteLine("\n>>> Removing Maksim from headphones and watch observers.\n" +
    ">>> Removing Dima from headphones observers.\n");
headphones.RemoveObserver(maksim);
watch.RemoveObserver(maksim);
headphones.RemoveObserver(dima);

Thread.Sleep(3000);

phone.Price = 2450m;
Console.WriteLine();
watch.Price = 1300m;

Console.WriteLine("\n>>> Removing Dima from watch observers.\n");
watch.RemoveObserver(dima);

Thread.Sleep(3000);

phone.Price = 2470m;
Console.WriteLine();
watch.Price = 1250m;
Console.WriteLine();
headphones.Price = 820m;