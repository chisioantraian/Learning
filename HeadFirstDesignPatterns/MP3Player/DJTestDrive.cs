using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.MP3Player
{
    class DJTestDrive
    {
        public static void Run()
        {
            var model = new BeatModel();
            var controller = new BeatController(model);
        }
    }
}
