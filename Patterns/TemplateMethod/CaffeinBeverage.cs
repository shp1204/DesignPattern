public abstract class CaffeineBeverage{
    void prepareRecipe(){
        boilWater();
        brew();
        pourInCup();
        addCondiments();
    }

    public void boilWater(){
        Console.WriteLine("boil water");
    }

    public abstract void brew();

    public void pourInCup(){
        Console.WriteLine("pour in cup");
    }

    public abstract void addCondiments();
}