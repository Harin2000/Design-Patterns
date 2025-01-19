namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            weatherData.MeasurementChanged();
        }
    }
}
