using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestProject
{
    public class B_ClassFixtures : IDisposable
    {
        public int InstanceCount = 0;
        private string _name;

        public string Name
        {
            get => _name;
            private set
            {
                _name = value;
                InstanceCount++;
            }
        }

        public B_ClassFixtures()
        {
            Name = "Skodfg";
        }

        public void Dispose()
        {
            Name = string.Empty;
        }
    }
}
