using System;
using Xunit;

namespace sample.list.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new sample.lib.Class1();

            var ver = c.Version;

            Assert.Equal("2.0.1", ver);
        }
    }
}
