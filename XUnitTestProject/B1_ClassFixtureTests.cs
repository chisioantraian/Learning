using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class B1_ClassFixtureTests : IClassFixture<B_ClassFixtures>, IDisposable
    {
        private B_ClassFixtures _fixture;

        public B1_ClassFixtureTests(B_ClassFixtures fixture)
        {
            this._fixture = fixture;
        }

        public void Dispose()
        {
            var foo = "foo"; //?
        }

        [Fact]
        public void ThisIsATest()
        {
            Assert.Equal("Skodfg", _fixture.Name);
            Assert.Equal(1, _fixture.InstanceCount);
        }

        [Fact]
        public void ThisIsAnotherTest()
        {
            Assert.Equal("Skodfg", _fixture.Name);
            Assert.Equal(1, _fixture.InstanceCount);
        }
    }
}
