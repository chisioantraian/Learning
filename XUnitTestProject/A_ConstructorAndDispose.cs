using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class A_ConstructorAndDispose : IDisposable
    {
        private int _counter = 0;
        public A_ConstructorAndDispose()
        {
            _counter++;
        }

        public void Dispose()
        {
            _counter--;
        }

        [Fact]
        public void ShouldBeOne()
        {
            Assert.Equal(1, _counter);
        }

        [Fact]
        public void ShouldBeAlsoOne()
        {
            Assert.Equal(1, _counter);
        }
    }
}
