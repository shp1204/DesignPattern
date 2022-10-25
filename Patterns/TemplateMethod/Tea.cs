public class Tea{
    void prepareRecipe(){
        boilWater();
        steepTeaBag();
        pourInCup();
        addLemon();
    }

    public void boilWater(){
        Console.WriteLine("boil water");
    }

    public void steepTeaBag(){
        Console.WriteLine("steep tea bag");
    }

    public void pourInCup(){
        Console.WriteLine("pour in cup");
    }

    public void addLemon(){
        Console.WriteLine("add lemon");
    }
}