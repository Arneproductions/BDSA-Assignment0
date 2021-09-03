using System;
using Xunit;

namespace LeapYear.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(2000)]
        [InlineData(1600)]
        public void IsLeapYear_Centurial(int year)
        {
            Assert.True(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(2004)]
        [InlineData(2008)]
        public void IsLeapYear_Regular(int year)
        {
            Assert.True(Program.IsLeapYear(year));
        }
    }
}
