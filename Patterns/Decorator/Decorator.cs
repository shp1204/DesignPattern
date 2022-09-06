namespace Patterns;
public class Decorator{
    public static void Run()
    {
        Beverage beverage = new Espresso();
        Console.WriteLine(beverage.getDescription() + " &" + beverage.cost());

        Beverage beverage2 = new DarkRoast();
        beverage2 = new Mocha(beverage2);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Whip(beverage2);
        Console.WriteLine(beverage2.getDescription() + " &" + beverage2.cost());

        Beverage beverage3 = new HouseBlend();
        beverage3 = new Soy(beverage3);
        beverage3 = new Mocha(beverage3);
        beverage3 = new Whip(beverage3);
        Console.WriteLine(beverage3.getDescription() + " &" + beverage3.cost());

        Beverage beverage4 = new HouseBlend();
        beverage4.setSize(Beverage.Size.VENTI);
        beverage4 = new Soy(beverage4);
        beverage4 = new Mocha(beverage4);
        beverage4 = new Whip(beverage4);
        Console.WriteLine(beverage4.getDescription() + " &" + beverage4.cost());
    }
}

