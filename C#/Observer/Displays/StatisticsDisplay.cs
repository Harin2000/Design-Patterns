using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Displays
{
    internal class StatisticsDisplay:IObserver, IDisplayElement
    {
        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData = weatherData ?? throw new ArgumentNullException();
            weatherData.Add(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"{this.GetType()} received newly updated values: Temperature:{temp}, Humidity:{humidity}, Pressure:{pressure}");
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"{this.GetType()} is displaying...");
        }
    }
}
