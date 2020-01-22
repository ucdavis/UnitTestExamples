using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        [Fact]
        public async Task TestAwait()
        {
            var result1 = await SampleCode.Example1();
            var result2 = await SampleCode.Example2();

            result1.ShouldBe(false);
            result2.ShouldBe(true);
        }

        [Fact]
        public async Task ApiTest()
        {
            var queryUrl = "https://who.ucdavis.edu/api/Iamws";

            var http = new HttpClient();

            using (var stream = await http.GetStreamAsync(queryUrl))
            {
                using (var sr = new StreamReader(stream))
                using (var jsonTextReader = new JsonTextReader(sr))
                {
                    var result = new JsonSerializer().Deserialize(jsonTextReader);
                    result.ShouldNotBeNull();
                }
            }
        }
    }
}
