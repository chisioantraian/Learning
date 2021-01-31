using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject
{
    public class CapturingOutput
    {
        private readonly ITestOutputHelper _output;

        public CapturingOutput(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void MyTest()
        {
            var temp = "My Class";
            _output.WriteLine("This is output from {0}", temp);
        }
    }
}
