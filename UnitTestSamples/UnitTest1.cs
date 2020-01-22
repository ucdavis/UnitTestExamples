using System;
using Shouldly;
using Xunit;

namespace UnitTestSamples
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var xxx = "123";
            xxx.ShouldBe("123");
        }
    }
}
