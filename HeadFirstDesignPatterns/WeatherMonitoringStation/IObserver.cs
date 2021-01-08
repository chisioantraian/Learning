using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.WeatherMonitoringStation
{
    interface IObserver
    {
        void Update(double temp, double humidity, double pressure);
    }
}
