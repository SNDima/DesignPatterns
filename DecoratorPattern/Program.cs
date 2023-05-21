using DecoratorPattern;

Shawarma shawarma = new ChickenShawarma();
Console.WriteLine(shawarma.ToString());

Shawarma porkShawarma = new PorkShawarma();
porkShawarma = new CheeseShawarmaDecorator(porkShawarma);
porkShawarma = new PotatoShawarmaDecorator(porkShawarma);
Console.WriteLine(porkShawarma.ToString());

Shawarma beefShawarma = new PorkShawarma();
beefShawarma = new MushroomsShawarmaDecorator(beefShawarma);
beefShawarma = new TomatoShawarmaDecorator(beefShawarma);
beefShawarma = new MushroomsShawarmaDecorator(beefShawarma);
Console.WriteLine(beefShawarma.ToString());
