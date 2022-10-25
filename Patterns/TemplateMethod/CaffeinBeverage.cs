public abstract class CaffeineBeverage{
    public void prepareRecipe(){
        boilWater();
        brew();
        pourInCup();
        if(customerWantsCondiments()){
            addCondiments();
        }
    }

    public void boilWater(){
        Console.WriteLine("boil water");
    }

    public abstract void brew();

    public void pourInCup(){
        Console.WriteLine("pour in cup");
    }
    public abstract void addCondiments();

    bool customerWantsCondiments(){
        return true;
    }
}