public interface PizzaIngredientFactory{
    public Dough createDough();
    public Sauce createSauce();
    public Cheese createCheese();
    public Veggies[] createVeggies();
    public Pepperoni createPepperoni();
    public Clams createClam();
}

public class NYPizzaIngredientFactory : PizzaIngredientFactory{
    public Dough createDough(){
        return new ThinCrustDough();
    }

    public Sauce createSauce(){
        return new MarinaraSauce();
    }

    public Cheese createCheese(){
        return new ReggianoCheese();
    }

    public Veggies[] createVeggies(){
        Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper()};
        return veggies;
    }

    public Pepperoni createPepperoni(){
        return new SlicedPepperoni();
    }

    public Clams createClam(){
        return new FreshClams();
    }
}

public class Dough{}
public class Sauce{}
public class Cheese{}
public class Veggies{}
public class Pepperoni{}
public class Clams{}

public class ThinCrustDough : Dough{}
public class MarinaraSauce : Sauce{}
public class ReggianoCheese : Cheese{}
public class Garlic : Veggies{}
public class Onion : Veggies{}
public class Mushroom : Veggies{}
public class RedPepper : Veggies{}
public class SlicedPepperoni : Pepperoni{}
public class FreshClams : Clams{}