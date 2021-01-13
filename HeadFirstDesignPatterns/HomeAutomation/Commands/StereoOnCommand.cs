using HeadFirstDesignPatterns.HomeAutomation.Receivers;

namespace HeadFirstDesignPatterns.HomeAutomation.Commands
{
    class StereoOnCommand : ICommand
    {
        private Stereo stereo;

        public StereoOnCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute() => stereo.On();
        public void Undo() => stereo.Off();
    }
}