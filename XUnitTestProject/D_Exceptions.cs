using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class D_Exceptions
    {
        private string _customMessage = "Custom message";

        [Fact]
        public void ShouldThrowAnException()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => ThrowAnError());
            Assert.Equal(_customMessage, ex.Message);
        }

        [Fact]
        public void ShouldRecordAnException()
        {
            Exception ex = Record.Exception(() => ThrowAnError());
            Assert.Equal(_customMessage, ex.Message);
        }

        private void ThrowAnError()
        {
            throw new InvalidOperationException(_customMessage);
        }

    }
}
