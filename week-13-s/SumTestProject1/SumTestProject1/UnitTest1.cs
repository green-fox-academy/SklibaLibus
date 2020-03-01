using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SumTestProject1
{
    public class SumUtilTests
    {
        readonly Sum testSum = new Sum(); // arrange (for all tests)

        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(3, new int[] { 3 })]
        [InlineData(28, new int[] { 1, 2, 3, 8, 5, 9 })]

        public void TestSumArrayExceptNull(int expected, int[] testingList)
        {
            Assert.Equal(expected, testSum.SumArray(testingList.ToList()));
        }

        /* line 12 to 20 do the same test like methods: 
            TestSumArrayWithEmptyList, TestSumArrayWithOneElement and TestSumArrayWithMultipleElement
         */

        [Fact]
        public void TestSumArrayWithEmptyList()
        {
            List<int> numbers = new List<int>(); 
            Assert.Equal(0, testSum.SumArray(numbers)); // assert + act
        }

        [Fact]
        public void TestSumArrayWithOneElement()
        {
            List<int> numbers = new List<int> { 3 }; 
            var output = testSum.SumArray(numbers); // act
            Assert.Equal(3, output); // asert
        }

        [Fact]
        public void TestSumArrayWithMultipleElement()
        {
            Assert.Equal(28, testSum.SumArray(new List<int> { 1, 2, 3, 8, 5, 9 })); 
        }

        [Fact]
        public void TestSumArrayWithNull()
        {
            List<int> numbers = null;
            Assert.Equal(0, testSum.SumArray(numbers)); // assert + act
        }
    }
}