public interface IWeatherService
{
    Guid guid { get; set; }
    string GetWeather();
}

public class WeatherService : IWeatherService
{
    private readonly string _weatherData;
    private Guid _guid = Guid.NewGuid();

    public WeatherService()
    {
        // Simulating some data retrieval or computation
        _weatherData = "Sunny";
    }
    public Guid guid
    {
        get { return _guid; }
        set { _guid = value; }
    }

    public string GetWeather()
    {
        return _weatherData;
    }
}