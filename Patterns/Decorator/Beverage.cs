namespace Patterns;
public abstract class Beverage{
    protected string _description = string.Empty;
    public virtual string getDescription(){
        return _description;
    }
    public abstract double cost();

    public enum Size{ TALL, GRANDE, VENTI };
    Size size = Size.TALL;
    public virtual void setSize(Size size){
        this.size = size;
    }
    public virtual Size getSize(){
        return this.size;
    }
}

public abstract class CondimentDecorator : Beverage{
    public Beverage beverage =null!;
    public abstract override string getDescription();
    public override Size getSize(){
        return beverage.getSize();
    }
}