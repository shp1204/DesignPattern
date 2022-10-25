public class TemplateMethod{
    public static void Run()
    {
        Tea myTea = new Tea();
        myTea.prepareRecipe();
        
        Console.WriteLine("-------");

        Coffee myCoffee = new Coffee();
        myCoffee.prepareRecipe();
    }
}