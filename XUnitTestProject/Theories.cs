using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class Theories
    {
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(7, 3, 4)]
        [InlineData(-1, -3, 2)]
        [InlineData(50, 43, 7)]
        public void FirstTheory(int expected, int addend1, int addend2)
        {
            Assert.Equal(expected, addend1 + addend2);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void MemberDataTheory(int expected, int addend1, int addend2)
        {
            Assert.Equal(expected, addend1 + addend2);
        }

        public static IEnumerable<object[]> TestData =>
            new[]
            {
                new object[] {5, 3, 2},
                new object[] {-1, -3, 2}
            };

        [Theory]
        [ClassData(typeof(TestDataClass))]
        public void ClassDataTheory(int expected, int addend1, int addend2)
        {
            Assert.Equal(expected, addend1 + addend2);
        }
    }

    public class TestDataClass : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {5, 7, -2},
            new object[] {-1, -2, 1}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
