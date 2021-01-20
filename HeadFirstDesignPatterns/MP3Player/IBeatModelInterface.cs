using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.MP3Player
{
    interface IBeatModelInterface
    {
        void Initialize();
        void On();
        void Off();
        void SetBPM(int bpm); // or use properties
        int GetBPM();
        void RegisterObserver(IBeatObserver o);
        void RemoveObserver(IBeatObserver o);
        void RegisterObserver(IBpmObserver o);
        void RemoveObserver(IBpmObserver o);
    }
}
