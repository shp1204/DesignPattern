namespace Patterns;
public class FactoryMethod {
    public static void Run()
    {
        PizzaStore nyStore = new NYPizzaStore();

        Pizza pizza = nyStore.orderPizza("cheese");
        Console.WriteLine("에단이 주문한 " + pizza.getName());

        pizza = nyStore.orderPizza("clam");
        Console.WriteLine("에단이 주문한 " + pizza.getName());
    }
}