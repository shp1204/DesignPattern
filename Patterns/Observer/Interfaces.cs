namespace Patterns;
public interface ISubject{
    public void registerObserver(IObserver o);
    public void removeObserver(IObserver o);
    public void notifyObservers();
}

public interface IObserver{
    public void update(float temp, float humidity, float pressure);
}

public interface IDisplayElement{
    public void display();
}