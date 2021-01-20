using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.MP3Player
{
    class BeatModel : IBeatModelInterface
    {
        //private Sequencer sequencer;
        private List<IBeatObserver> beatObservers = new();
        private List<IBpmObserver> bpmObservers = new();
        private int bpm = 90;

        public int GetBPM() => bpm;
        public void SetBPM(int bpm)
        {
            this.bpm = bpm;
        }

        public void Initialize()
        {
            //SetUpMidi();
            //BuildTrackAndStart();
        }
        public void On()
        {
            //sequencer.Start();
            SetBPM(90);
        }

        public void Off()
        {
            SetBPM(0);
            //sequencer.Stop();
        }

        //public void BeatEvent() { NotifyObservers(); }



        public void RegisterObserver(IBeatObserver o)
        {
            beatObservers.Add(o);
        }

        public void RegisterObserver(IBpmObserver o)
        {
            bpmObservers.Add(o);
        }

        public void RemoveObserver(IBeatObserver o)
        {
            beatObservers.Remove(o);
        }

        public void RemoveObserver(IBpmObserver o)
        {
            bpmObservers.Remove(o);
        }

    }
}
