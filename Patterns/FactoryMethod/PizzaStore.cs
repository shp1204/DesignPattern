public abstract class PizzaStore{
    public Pizza orderPizza(string type){
        Pizza pizza = null!;
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
        Pizza pizza = null!;
        PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        if(item == "cheese"){
            pizza = new CheesePizza(ingredientFactory);
            pizza.setName("뉴욕 스타일 치즈 피자");
        }else if(item == "clam"){
            pizza = new ClamPizza(ingredientFactory);
            pizza.setName("뉴욕 스타일 조개 피자");
        }else {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.setName("뉴욕 스타일 페퍼로니 피자");
        }
        return pizza;
    }   
}