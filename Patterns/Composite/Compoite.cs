public class Composite{
    public static void Run()
    {
        MenuComponent pancakeHouseMenu = new Menu("pancake-house", "breakfast");
        MenuComponent dinnerMenu = new Menu("object", "lunch");
        MenuComponent cafeMenu = new Menu("cafe menu", "dinner");
        MenuComponent dessertMenu = new Menu("dessert", "enjoy dessert");

        MenuComponent allMenus = new Menu("전체 메뉴", "전체 메뉴");
        allMenus.add(pancakeHouseMenu);
        allMenus.add(dinnerMenu);
        allMenus.add(cafeMenu);
        allMenus.add(dessertMenu);

        dinnerMenu.add(new NewMenuItem("파스타", "마리나라 소스 스파게티", true, 3.89));
        dinnerMenu.add(dessertMenu);
    
        NewWaitress waitress = new NewWaitress(allMenus);
        waitress.printMenu();
    }
}