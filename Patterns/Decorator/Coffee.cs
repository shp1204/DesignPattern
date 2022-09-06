namespace Patterns;
public class Espresso : Beverage{
    public Espresso(){
        _description  = "Espresso";
    }

    public override double cost(){
        return 1.99;
    }
}

public class HouseBlend : Beverage{
    public HouseBlend(){
        _description  = "HouseBlend";
    }

    public override double cost(){
        return 0.89;
    }
}

public class Decaf : Beverage{
    public Decaf(){
        _description  = "Decaf";
    }

    public override double cost(){
        return 1.05;
    }
}

public class DarkRoast : Beverage{
    public DarkRoast(){
        _description  = "DarkRoast";
    }

    public override double cost(){
        return 0.99;
    }
}