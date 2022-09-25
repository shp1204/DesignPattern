public abstract class Pizza{
    public string name = null!;
    public Dough dough = null!;
    public Sauce sauce = null!;
    public Veggies[] veggies = null!;
    public Cheese cheese = null!;
    public Pepperoni pepperoni = null!;
    public Clams clam = null!;

    public abstract void prepare();

    public void bake(){
        Console.WriteLine("175도에서 25분간 굽기");
    }

    public virtual void cut(){
        Console.WriteLine("피자를 사선으로 자르기");
    }

    public void box(){
        Console.WriteLine("상자에 피자 담기");
    }

    public void setName(string name){
        this.name = name;
    }

    public string getName(){
        return name;
    }
}

public class CheesePizza : Pizza{
    PizzaIngredientFactory ingredientFactory;
    public CheesePizza(PizzaIngredientFactory ingredientFactory){
        this.ingredientFactory = ingredientFactory;
    }

    public override void prepare(){
        Console.WriteLine("준비 중 : ", name);
        dough = ingredientFactory.createDough();
        sauce = ingredientFactory.createSauce();
        cheese = ingredientFactory.createCheese();
    }
}

public class ClamPizza : Pizza{
    PizzaIngredientFactory ingredientFactory;
    public ClamPizza(PizzaIngredientFactory ingredientFactory){
        this.ingredientFactory = ingredientFactory;
    }

    public override void prepare(){
        Console.WriteLine("준비 중 : ", name);
        dough = ingredientFactory.createDough();
        sauce = ingredientFactory.createSauce();
        cheese = ingredientFactory.createCheese();
        clam = ingredientFactory.createClam();
    }
}

public class PepperoniPizza : Pizza{
    PizzaIngredientFactory ingredientFactory;
    public PepperoniPizza(PizzaIngredientFactory ingredientFactory){
        this.ingredientFactory = ingredientFactory;
    }

    public override void prepare(){
        Console.WriteLine("준비 중 : ", name);
        dough = ingredientFactory.createDough();
        sauce = ingredientFactory.createSauce();
        cheese = ingredientFactory.createCheese();
        pepperoni = ingredientFactory.createPepperoni();
    }
}