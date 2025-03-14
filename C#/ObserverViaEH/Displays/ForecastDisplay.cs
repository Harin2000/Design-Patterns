﻿using ObserverViaEH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Displays
{
    internal class ForecastDisplay:IObserver, IDisplayElement
    {
        public ForecastDisplay(ISubject weatherData)
        {
            weatherData = weatherData ?? throw new ArgumentNullException();
            weatherData.Add(this);
        }
        //public void Update(float temp, float humidity, float pressure)
        //{
        //    Console.WriteLine($"{this.GetType()} received newly updated values: Temperature:{temp}, Humidity:{humidity}, Pressure:{pressure}");
        //    Display();
        //}
        public void Display()
        {
            Console.WriteLine($"{this.GetType()} is displaying...");
        }

        public void Update(object source, WeatherEventArgs weatherEventArgs)
        {
            Console.WriteLine($"{this.GetType()} received newly updated values: Temperature:{weatherEventArgs.Temperature}, Humidity:{weatherEventArgs.Humidity}, Pressure:{weatherEventArgs.Pressure}");
            Display();
        }
    }
}
