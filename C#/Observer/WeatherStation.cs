using Observer.Displays;

namespace Observer
{
    internal class WeatherStation
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            //weatherData.MeasurementChanged();

            // After adding observer pattern
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(1.0f, 1.0f, 1.0f);
            Console.WriteLine();
            weatherData.SetMeasurements(2.0f, 2.0f, 2.0f);
            Console.WriteLine();

            // Adding HeatIndexDisplay
            var heatIndexDisplay = new HeatIndexDiplay(weatherData);
            weatherData.SetMeasurements(3.0f, 3.0f, 3.0f);
        }
    }
}
