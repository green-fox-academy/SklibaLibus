using System;
using Xunit;

namespace AppleTestProject1
{
    public class AppleUnitTest
    {
        [Fact]
        public void GetAppleTest()
        {
            var myObject = new Apple();

            string output = myObject.GetApple();

            Assert.Equal("apple", output);
        }
    }
}
