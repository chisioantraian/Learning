using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.MP3Player
{
    interface IControllerInterface
    {
        void Start();
        void Stop();
        void IncreaseBPM();
        void DecreaseBPM();
        void SetBPM(int bpm);
    }
}
