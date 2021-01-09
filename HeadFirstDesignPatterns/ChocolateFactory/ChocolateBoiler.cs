using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.ChocolateFactory
{
    class ChocolateBoiler
    {
        private bool isEmpty;
        private bool isBoiled;
        private static ChocolateBoiler? instance;
        private static readonly object padlock = new object();

        private ChocolateBoiler()
        {
            isEmpty = true;
            isBoiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if (instance is null)
                {
                    lock (padlock)
                    {
                        instance ??= new ChocolateBoiler();
                    }
                }
                return instance;
            }
        }

        public void Fill()
        {
            if (isEmpty)
            {
                isEmpty = false;
                isBoiled = false;
            }
        }

        public void Drain()
        {
            if (!isEmpty && isBoiled)
            {
                isEmpty = true;
            }
        }

        public void Boil()
        {
            if (!isEmpty && !isBoiled)
            {
                isBoiled = true;
            }
        }
    }
}
