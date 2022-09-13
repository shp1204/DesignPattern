public abstract class PizzaStore{
    public Pizza orderPizza(String type){
        Pizza pizza;
        pizza = createPizza(type);

        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();

        return pizza;
    }
    
    protected abstract Pizza createPizza(string type);
}

public class NYPizzaStore : PizzaStore{
    protected override Pizza createPizza(string item){     
        if (item == "cheese"){
            return new NYStyleCheesePizza();
        } else if (item == "veggie"){
            return new NYStyleVeggiePizza();
        } else return new BasicStylePizza();
    }
}

public class ChicagoPizzaStore : PizzaStore{
    protected override Pizza createPizza(string type)
    {
        if (type == "cheese"){
            return new ChicagoStyleCheesePizza();
        } else if (type == "veggie"){
            return new ChicagoStyleVeggiePizza();
        } else return new BasicStylePizza();
    }
}