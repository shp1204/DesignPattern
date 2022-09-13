public abstract class Pizza{
    public string name = null!;
    public string dough = null!;
    public string sauce = null!;
    public string[] toppings = new string[]{};
    public void prepare(){
        Console.WriteLine("준비 중 : " + name);
        Console.WriteLine("도우 돌리는 중~");
        Console.WriteLine("소스 뿌리는 중~");
        Console.WriteLine("토핑 올리는 중~");
        foreach(var t in toppings){
            Console.WriteLine(" " + t);
        }
    }

    public void bake(){
        Console.WriteLine("175도에서 25분간 굽기");
    }

    public virtual void cut(){
        Console.WriteLine("피자를 사선으로 자르기");
    }

    public void box(){
        Console.WriteLine("상자에 피자 담기");
    }

    public string getName(){
        return name;
    }
}

public class NYStyleCheesePizza : Pizza{
    public NYStyleCheesePizza(){
        name = "뉴욕 스타일 소스와 cheese 피자";
        dough = "씬 크러스트 도우";
        sauce = "마리나라 소스";
        toppings.Append("잘게 썬 레지아노 치즈");
    }
}

public class NYStyleVeggiePizza : Pizza{
    public NYStyleVeggiePizza(){
        name = "뉴욕 스타일 소스와 veggie 피자";
        dough = "씬 크러스트 도우";
        sauce = "olive oil";
        toppings.Append("잘게 썬 레지아노 치즈");
    }
}

public class ChicagoStyleCheesePizza : Pizza{
    public ChicagoStyleCheesePizza(){
        name = "시카고 스타일 딥 디쉬 치즈 피자";
        dough = "아주 두꺼운 크러스트 도우";
        sauce = "플럼토마토 소스";
        toppings.Append("잘게 조각낸 모짜렐라 치즈");
    }

    public override void cut(){
        Console.WriteLine("네모난 모양으로 피자 자르기");
    }
}

public class ChicagoStyleVeggiePizza : Pizza{
    public ChicagoStyleVeggiePizza(){
        name = "chicago style veggie pizza";
        dough = "thick crust dough";
        sauce = "salsa sauce";
    }
}

public class BasicStylePizza : Pizza{
    public BasicStylePizza(){
        name = "basic style pizza";
        dough = "basic";
        sauce = "sourcream";
    }
}