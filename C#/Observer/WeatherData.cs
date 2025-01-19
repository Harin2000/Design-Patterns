using Observer.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class WeatherData : ISubject
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        //IObserver currentConditionsDisplay {  get; set; }
        //IObserver statisticsDisplay { get; set; }
        //IObserver forecastDisplay { get; set; }

        List<IObserver> Observers { get; set; }

        public WeatherData()
        {
            //currentConditionsDisplay = new CurrentConditionsDisplay();
            //statisticsDisplay = new StatisticsDisplay();
            //forecastDisplay = new ForecastDisplay();
            Observers = new List<IObserver>();
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            Temperature = temp; Humidity = humidity; Pressure = pressure;
            MeasurementChanged();
        }
        void MeasurementChanged()
        {
            // Your code goes here
            //currentConditionsDisplay.Update(Temperature, Humidity, Pressure);
            //statisticsDisplay.Update(Temperature, Humidity, Pressure);
            //forecastDisplay.Update(Temperature, Humidity, Pressure);

            foreach (var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }
        public void Add(IObserver toadd)
        {
            Observers.Add(toadd);
        }
        public void Remove(IObserver toremove)
        {
            Observers.Remove(toremove);
        }
        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }
    }
}
