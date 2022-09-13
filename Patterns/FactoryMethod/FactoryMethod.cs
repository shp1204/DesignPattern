namespace Patterns;
public class FactoryMethod {
    public static void Run()
    {
        PizzaStore nyStore = new NYPizzaStore();
        PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza pizza = nyStore.orderPizza("cheese");
        Console.WriteLine("에단이 주문한 " + pizza.getName());

        pizza = chicagoStore.orderPizza("veggie");
        Console.WriteLine("jake ordered : " + pizza.getName());
    }
}