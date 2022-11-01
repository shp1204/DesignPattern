public class DinnerMenu{
    static int MAX_ITEMS = 6;
    int numberOfItems = 0;
    MenuItem[] menuItems;

    public DinnerMenu(){
        menuItems = new MenuItem[MAX_ITEMS];
        addItem("A", "a, b, c, d", true, 2.99);
        addItem("B", "ㄱ, ㄴ, ㄷ", false, 2.88);
        addItem("C", "Z, X, S", false, 3.32);
    }

    public void addItem(string name, string description, bool vegetarian, double price){
        MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
        if(numberOfItems >= MAX_ITEMS){
            Console.WriteLine("cannot add more");
        }else{
            menuItems[numberOfItems] = menuItem;
            numberOfItems = numberOfItems + 1;
        }
    }

    public ManualIterator createIterator(){
        return new DinnerMenuIterator(menuItems);
    }
}