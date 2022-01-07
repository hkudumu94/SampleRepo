using System;
using Xunit;

namespace DevopsTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 10;

            int b = 20;

            Assert.Equal(a, b);
        }
    }
}
