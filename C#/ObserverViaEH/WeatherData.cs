using Observer;
using Observer.Displays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverViaEH
{

    internal class WeatherData:ISubject
    {
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private event EventHandler<WeatherEventArgs> OnMeasurementChangeEvent;

        //List<IObserver> Observers { get; set; }

        public WeatherData()
        {
            //Observers = new List<IObserver>();
        }
        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            Temperature = temp; Humidity = humidity; Pressure = pressure;
            MeasurementChanged();
        }
        void MeasurementChanged()
        {
            Notify();
        }
        public void Add(IObserver toadd)
        {
            //Observers.Add(toadd);
            OnMeasurementChangeEvent += toadd.Update;
        }
        public void Remove(IObserver toremove)
        {
            //Observers.Remove(toremove);
            OnMeasurementChangeEvent -= toremove.Update;
        }
        public void Notify()
        {
            //foreach (var observer in Observers)
            //{
            //    observer.Update(Temperature, Humidity, Pressure);
            //}
            OnMeasurementChangeEvent(this, new WeatherEventArgs(this.Temperature, this.Humidity, this.Pressure));
        }
    }

    public class WeatherEventArgs : EventArgs
    {
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        public WeatherEventArgs(float temp, float humidity, float pressure)
        {
            Temperature = temp; Humidity = humidity; Pressure = pressure;
        }
    }
}
