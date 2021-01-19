using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.JawBreakers
{
    class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }
        public IState CurrentState { get; set; }

        public int Count { get; private set; }
        public string Location { get; }


        public GumballMachine(string location, int count)
        {
            this.SoldOutState = new SoldOutState(this);
            this.NoQuarterState = new NoQuarterState(this);
            this.HasQuarterState = new HasQuarterState(this);
            this.SoldState = new SoldState(this);
            this.WinnerState = new WinnerState(this);

            this.Location = location;
            this.Count = count;
            this.CurrentState = this.SoldOutState;
            if (Count > 0)
            {
                this.CurrentState = this.NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            this.CurrentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            this.CurrentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            this.CurrentState.TurnCrank();
            this.CurrentState.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }
    }
}
