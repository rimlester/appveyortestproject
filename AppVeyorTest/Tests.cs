using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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
    }
}
