public class Coffee : CaffeineBeverage{
    public override void brew(){
        Console.WriteLine("brew coffee grinds");
    }

    public override void addCondiments(){
        Console.WriteLine("add sugar and milk");
    }
}

public class CoffeeWithOption : CaffeineBeverage{
    public override void brew(){
        Console.WriteLine("brew coffee grinds");
    }

    public override void addCondiments(){
        Console.WriteLine("add sugar and milk");
    }

    public bool customerWantsCondiments(){
        string answer = getUserInput();
        if(answer.ToLower().StartsWith("y")){
            return true;
        }else{
            return false;
        }
    }

    private string getUserInput(){
        string? answer = null;
        Console.WriteLine("Want milk and sugar ? { y / n }");
        answer = Console.ReadLine();
        if(answer == null){
            return "no";
        }
        return answer;
    }
}