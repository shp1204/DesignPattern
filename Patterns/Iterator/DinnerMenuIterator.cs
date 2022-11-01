public class DinnerMenuIterator : ManualIterator{
    MenuItem[] items;
    int position = 0;

    public DinnerMenuIterator(MenuItem[] items){
        this.items = items;
    }

    public MenuItem next(){
        MenuItem menuItem = items[position];
        position = position + 1;
        return menuItem;
    }

    public bool hasNext(){
        if(position >= items.Length || items[position] == null){
            return false;
        }else{
            return true;
        }
    }
}