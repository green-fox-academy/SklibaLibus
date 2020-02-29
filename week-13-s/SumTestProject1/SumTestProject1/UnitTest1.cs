using System.Collections.Generic;
using Xunit;

namespace SumTestProject1
{
    public class SumUtilTests
    {
        [Fact]
        public void SumTestEmptyList()
        {
            List<int> numbers = new List<int>();
            Assert.Equal(0, Sum.SumArray(numbers));
        }

        [Fact]
        public void SumTestOneElement()
        {
            List<int> numbers = new List<int> { 3 };
            Assert.Equal(3, Sum.SumArray(numbers));
        }

        [Fact]
        public void SumTestMultipleElement()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 8, 5, 9 };
            Assert.Equal(28, Sum.SumArray(numbers));
        }

        [Fact]
        public void SumTestNull()
        {
            List<int> numbers = null;
            Assert.Equal(0, Sum.SumArray(numbers));
        }
    }
}