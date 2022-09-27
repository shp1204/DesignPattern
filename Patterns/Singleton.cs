public class ChocolateBoiler{
    private bool empty;
    private bool boiled;
    private static ChocolateBoiler? uniqueInstance;
    private ChocolateBoiler(){
        empty = true;
        boiled =false;
    }

    public static ChocolateBoiler getInstance(){
        if(uniqueInstance == null){
            uniqueInstance = new ChocolateBoiler();
        }
        return uniqueInstance;
    }

    public void fill(){
        if(isEmpty()){
            empty = false;
            boiled = false;
        }
    }

    public void drain(){
        if (!isEmpty() && isBoiled()){
            empty = true;
        }
    }

    public void boil(){
        if (!isEmpty() && !isBoiled()){
            boiled = true;
        }
    }

    public bool isEmpty(){
        return empty;
    }

    public bool isBoiled(){
        return boiled;
    }
}