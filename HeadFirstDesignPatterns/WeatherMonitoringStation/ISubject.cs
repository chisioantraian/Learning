﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.WeatherMonitoringStation
{
    interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObservver(IObserver o);
        void NotifyObservers();
    }
}
