public class NewWaitress{
    private MenuComponent _allMenus;

    public NewWaitress(MenuComponent allMenus){
        _allMenus = allMenus;
    }

    public void printMenu(){
        _allMenus.print();
    }
}