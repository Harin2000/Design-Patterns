using Observer.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class WeatherData
    {
        float Temperature {  get; set; }
        float Humidity { get; set; }
        float Pressure { get; set; }

        IDisplay currentConditionsDisplay {  get; set; }
        IDisplay statisticsDisplay { get; set; }
        IDisplay forecastDisplay { get; set; }

        public WeatherData()
        {
            currentConditionsDisplay = new CurrentConditionsDisplay();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
        }

        public void MeasurementChanged()
        {
            // Your code goes here
            currentConditionsDisplay.Update(Temperature, Humidity, Pressure);
            statisticsDisplay.Update(Temperature, Humidity, Pressure);
            forecastDisplay.Update(Temperature, Humidity, Pressure);
        }
    }
}
