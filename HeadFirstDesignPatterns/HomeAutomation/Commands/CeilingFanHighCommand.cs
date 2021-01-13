﻿using HeadFirstDesignPatterns.HomeAutomation.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class CeilingFanHighCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private FanSpeed prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.Speed;
            ceilingFan.High();
        }

        public void Undo()
        {
            if (prevSpeed == FanSpeed.High)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == FanSpeed.Medium)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == FanSpeed.Low)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == FanSpeed.Off)
            {
                ceilingFan.Off();
            }
        }
    }
}
