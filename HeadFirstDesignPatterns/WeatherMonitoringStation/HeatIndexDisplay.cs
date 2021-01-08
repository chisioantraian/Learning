using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.WeatherMonitoringStation
{
    class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private ISubject weatherData;

        public HeatIndexDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Complex formula with temp={temperature}, and relative humidity");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
