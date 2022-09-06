namespace Patterns;
public abstract class Beverage{
    protected string _description = string.Empty;
    
    public virtual string getDescription(){
        return _description;
    }

    public abstract double cost();
}

public abstract class CondimentDecorator : Beverage{
    public abstract override string getDescription();
}