using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Flurl.Http;
using Xunit;

namespace AppVeyorTest
{
    public class Tests
    {

        [Fact]
        public void OddNumbersAreOdd()
        {
            new Code().EmitOdd().ToList().ForEach(x => (x % 2).Should().Be(1));
        }

        [Fact]
        public void HelloIsHello()
        {
            var client = new FlurlClient();
            client.Url = "http://localhost:80/Default%20Web%20%Site/test";
            var response = client.GetAsync();
            response.Result.StatusCode.Should().Be(HttpStatusCode.OK);

        }
    }
}
