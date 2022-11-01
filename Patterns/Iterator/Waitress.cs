public class Waitress{
    PancakeHouseMenu pancakeHouseMenu;
    DinnerMenu dinnerMenu;

    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinnerMenu dinnerMenu){
        this.pancakeHouseMenu = pancakeHouseMenu;
        this.dinnerMenu = dinnerMenu;
    }

    public void printMenu(){
        ManualIterator pancakeIterator = pancakeHouseMenu.createIterator();
        ManualIterator dinnerIterator = dinnerMenu.createIterator();

        Console.WriteLine("------아침 메뉴-----");
        printMenu(pancakeIterator);

        Console.WriteLine("------저녁 메뉴-----");
        printMenu(dinnerIterator);
    }

    private void printMenu(ManualIterator iterator){
        while (iterator.hasNext()){
            MenuItem menuItem = iterator.next();
            Console.Write(menuItem.getName() + ", ");
            Console.Write(menuItem.getPrice() + " -- ");
            Console.WriteLine(menuItem.getDescription());
        }
    }
}