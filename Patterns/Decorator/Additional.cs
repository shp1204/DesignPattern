namespace Patterns;
public class Mocha : CondimentDecorator{
    private Beverage _beverage;
    public Mocha(Beverage beverage){
        this._beverage = beverage;
    }

    public override string getDescription()
    {
        return _beverage.getDescription() + ", 모카";
    }

    public override double cost(){
        return _beverage.cost() + 0.20;
    }
}

public class Soy : CondimentDecorator{
    private Beverage _beverage;
    public Soy(Beverage beverage){
        this._beverage = beverage;
    }

    public override string getDescription()
    {
        return _beverage.getDescription() + ", 두유";
    }

    public override double cost(){
        return _beverage.cost() + 0.15;
    }
}

public class Milk : CondimentDecorator{
    private Beverage _beverage;
    public Milk(Beverage beverage){
        this._beverage = beverage;
    }

    public override string getDescription()
    {
        return _beverage.getDescription() + ", 우유";
    }

    public override double cost(){
        return _beverage.cost() + 0.1;
    }
}

public class Whip : CondimentDecorator{
    private Beverage _beverage;
    public Whip(Beverage beverage){
        this._beverage = beverage;
    }

    public override string getDescription()
    {
        return _beverage.getDescription() + ", 휘핑";
    }

    public override double cost(){
        return _beverage.cost() + 0.1;
    }
}
