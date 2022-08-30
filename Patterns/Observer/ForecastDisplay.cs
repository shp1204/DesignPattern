namespace Patterns;
public class ForecastDisplay : IObserver, IDisplayElement {
	private float currentPressure = 29.92f;  
	private float lastPressure;
	private WeatherData weatherData;

	public ForecastDisplay(WeatherData weatherData) {
		this.weatherData = weatherData;
		weatherData.registerObserver(this);
	}

	public void update(float temp, float humidity, float pressure) {
        lastPressure = currentPressure;
		currentPressure = pressure;

		display();
	}

	public void display() {
        string result = "";
		if (currentPressure > lastPressure) {
			result = "Improving weather on the way!";
		} else if (currentPressure == lastPressure) {
            result = "More of the same";
		} else if (currentPressure < lastPressure) {
            result = "Watch out for cooler, rainy weather";
		}
		Console.WriteLine("Forecast: "+ result);
	}
}