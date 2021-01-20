using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.MP3Player
{
    class BeatController : IControllerInterface
    {
        private IBeatModelInterface model;
        //private DJView view;

        public BeatController(IBeatModelInterface model)
        {
            this.model = model;
            //view = new DJView(this, model);
            //other view methods
            model.Initialize();
        }

        public void Start()
        {
            model.On();
            //view.DisableStartMenu();
            //view.EnableStopMenu();
        }

        public void Stop()
        {
            model.Off();
            //view.DisableStopMenu();
            //view.EnableStartMenu();
        }

        public void IncreaseBPM()
        {
            int bpm = model.GetBPM();
            model.SetBPM(bpm + 1);
        }

        public void DecreaseBPM()
        {
            int bpm = model.GetBPM();
            model.SetBPM(bpm + 1);
        }

        public void SetBPM(int bpm)
        {
            model.SetBPM(bpm);
        }
    }
}
