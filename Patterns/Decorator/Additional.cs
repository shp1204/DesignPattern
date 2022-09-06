namespace Patterns;
public class Mocha : CondimentDecorator{
    public Mocha(Beverage beverage){
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", 모카";
    }

    public override double cost(){
        var cost = beverage.cost() + 0.20;
        if(beverage.getSize() == Size.TALL){
            cost += 0.1;
        } else if(beverage.getSize() == Size.GRANDE){
            cost += 0.2;
        } else if(beverage.getSize() == Size.VENTI){
            cost += 0.3;
        }
        return cost;
    }
}

public class Soy : CondimentDecorator{
    public Soy(Beverage beverage){
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", 두유";
    }

    public override double cost(){
        var cost = beverage.cost() + 0.15;
        if(beverage.getSize() == Size.TALL){
            cost += 0.1;
        } else if(beverage.getSize() == Size.GRANDE){
            cost += 0.2;
        } else if(beverage.getSize() == Size.VENTI){
            cost += 0.3;
        }
        return cost;
    }
}

public class Milk : CondimentDecorator{
    public Milk(Beverage beverage){
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", 우유";
    }

    public override double cost(){
        var cost = beverage.cost() + 0.1;
        if(beverage.getSize() == Size.TALL){
            cost += 0.1;
        } else if(beverage.getSize() == Size.GRANDE){
            cost += 0.2;
        } else if(beverage.getSize() == Size.VENTI){
            cost += 0.3;
        }
        return cost;
    }
}

public class Whip : CondimentDecorator{
    public Whip(Beverage beverage){
        this.beverage = beverage;
    }

    public override string getDescription()
    {
        return beverage.getDescription() + ", 휘핑";
    }

    public override double cost(){
        var cost = beverage.cost() + 0.10;
        if(beverage.getSize() == Size.TALL){
            cost += 0.1;
        } else if(beverage.getSize() == Size.GRANDE){
            cost += 0.2;
        } else if(beverage.getSize() == Size.VENTI){
            cost += 0.3;
        }
        return cost;
    }
}
