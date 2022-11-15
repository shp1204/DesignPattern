public class NewMenuItem : MenuComponent{
    private string _name = string.Empty;
    private string _description = string.Empty;
    private bool _vegetarian;
    private double _price;

    public NewMenuItem(string name, string description, bool vegetarian, double price){
        _name = name;
        _description = description;
        _vegetarian = vegetarian;
        _price = price;
    }

    public override string getName(){
        return _name;
    }

    public override string getDescription(){
        return _description;
    }

    public override double getPrice(){
        return _price;
    }

    public override bool isVegetarian(){
        return _vegetarian;
    }

    public override void print(){
        Console.WriteLine(" " + getName());
        if(isVegetarian()){
            Console.WriteLine("(v)");
        }
        Console.WriteLine(", " + getPrice());
        Console.WriteLine("    -- " + getDescription());
    }

    public override void add(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    public override void remove(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    public override MenuComponent getChild(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }
}