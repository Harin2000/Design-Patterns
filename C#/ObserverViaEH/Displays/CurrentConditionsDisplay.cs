using ObserverViaEH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Displays
{
    internal class CurrentConditionsDisplay:IObserver, IDisplayElement
    {
        private ISubject weatherData;
        private float temperature;
        private float humidity;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            weatherData = weatherData ?? throw new ArgumentNullException();
            weatherData.Add(this);
        }
        //public void Update(float temp, float humidity, float pressure)
        //{
        //    Console.WriteLine($"{this.GetType()} received newly updated values: Temperature:{temp}, Humidity:{humidity}, Pressure:{pressure}");
        //    this.temperature = temp;
        //    this.humidity = humidity;
        //    Display();
        //}
        public void Display()
        {
            Console.WriteLine($"{this.GetType()} is displaying with current values being: Temperature:{temperature}, Humidity:{humidity}.");
        }
        public void Update(object source, WeatherEventArgs weatherEventArgs)
        {
            Console.WriteLine($"{this.GetType()} received newly updated values: Temperature:{weatherEventArgs.Temperature}, Humidity:{weatherEventArgs.Humidity}, Pressure:{weatherEventArgs.Pressure}");
            this.temperature = weatherEventArgs.Temperature;
            this.humidity = weatherEventArgs.Humidity;
            Display();
        }
    }
}
