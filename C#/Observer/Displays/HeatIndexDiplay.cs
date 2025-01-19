using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Displays
{
    internal class HeatIndexDiplay:IObserver, IDisplayElement
    {
        private ISubject weatherData;
        private float heatIndex;
        public HeatIndexDiplay(ISubject weatherData) {
            this.weatherData = weatherData;
            weatherData.Add(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Console.WriteLine($"{this.GetType()} received newly updated values: Temperature:{temp}, Humidity:{humidity}, Pressure:{pressure}");
            heatIndex = temp + humidity + pressure;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"{this.GetType()} is displaying the heat index:{heatIndex}");
        }
    }
}
