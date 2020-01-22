using System;
using Shouldly;
using Xunit;

namespace UnitTestSamples
{
    public class UnitTests
    {
        [Fact]
        public void Test()
        {
            var result = SampleCode.Reverse("Abc");
            result.ShouldBe("cbA");
        }

        [Theory]
        [InlineData("Abc", "cbA")]
        [InlineData("Null", null)] 
        [InlineData(null, null)] 
        [InlineData("XXX", "XXX")]
        public void TestReverse(string value, string expected)
        {
            var result = SampleCode.Reverse(value);
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData("Abc is there", "there is Abc")]
        [InlineData("aaa  bbb ccc", "ccc bbb aaa")] 
        public void TestWords(string value, string expected)
        {
            var result = SampleCode.ReverseWords(value);
            result.ShouldBe(expected);
        }
    }
}
