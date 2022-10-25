public class Coffee{
    void prepareRecipe(){
        boilWater();
        brewCoffeeGrinds();
        pourInCup();
        addSugarAndMilk();
    }

    public void boilWater(){
        Console.WriteLine("boil water");
    }

    public void brewCoffeeGrinds(){
        Console.WriteLine("brew coffee grinds");
    }

    public void pourInCup(){
        Console.WriteLine("pour in cup");
    }

    public void addSugarAndMilk(){
        Console.WriteLine("add sugar and milk");
    }
}