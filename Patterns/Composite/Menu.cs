public class Menu : MenuComponent{
    private List<MenuComponent> _menuComponents = new List<MenuComponent>();
    private string _name = string.Empty;
    private string _description = string.Empty;

    public Menu(string name, string description){
        _name = name;
        _description = description;
    }

    public override void add(MenuComponent menuComponent){
        _menuComponents.Add(menuComponent);
    }

    public override void remove(MenuComponent menuComponent){
        _menuComponents.Remove(menuComponent);
    }

    public MenuComponent getChild(int i){
        return _menuComponents[i];
    }

    public override string getName(){
        return _name;
    }

    public override string getDescription(){
        return _description;
    }
    
    public override void print(){
        Console.WriteLine("\n" + getName());
        Console.WriteLine(", " + getDescription());
        Console.WriteLine("-------------------------");

        foreach(var menuComponent in _menuComponents){
            menuComponent.print();
        }
    }

    public override MenuComponent getChild(MenuComponent menuComponent)
    {
        throw new NotSupportedException();
    }

    public override double getPrice()
    {
        throw new NotSupportedException();
    }

    public override bool isVegetarian()
    {
        throw new NotSupportedException();
    }
}