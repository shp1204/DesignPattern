namespace Patterns;
public class CurrentConditionsDisplay : IObserver, IDisplayElement{
    private float temperature;
    private float humidity;
    private WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData){
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    public void update(float temperature, float humidity, float pressure){
        this.temperature = temperature;
        this.humidity = humidity;
        display();
    }

    public void display(){
        Console.WriteLine("현재 상태 : 온도 "+ temperature + "F, 습도 " + humidity + "%");
    }
}