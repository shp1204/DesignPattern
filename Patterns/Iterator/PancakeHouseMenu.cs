public class PancakeHouseMenu{
    List<MenuItem> menuItems;

    public PancakeHouseMenu(){
        menuItems = new List<MenuItem>();
        addItem("1", "a, b, c, d", true, 2.99);
        addItem("2", "ㄱ, ㄴ, ㄷ", false, 2.88);
        addItem("3", "Z, X, S", false, 3.32);
    }

    public void addItem(string name, string description, bool vegetarian, double price){
        MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
        menuItems.Add(menuItem);
    }

    public ManualIterator createIterator(){
        return new PancakeHouseIterator(menuItems);
    }
}