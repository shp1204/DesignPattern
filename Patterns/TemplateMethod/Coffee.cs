public class Coffee : CaffeineBeverage{
    public override void brew(){
        Console.WriteLine("brew coffee grinds");
    }

    public override void addCondiments(){
        Console.WriteLine("add sugar and milk");
    }
}