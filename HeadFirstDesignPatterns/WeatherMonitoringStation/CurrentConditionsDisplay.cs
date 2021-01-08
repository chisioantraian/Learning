using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.WeatherMonitoringStation
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature} degrees and {humidity} humidity");
        }

        public void Update(double temp, double humidity, double pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
