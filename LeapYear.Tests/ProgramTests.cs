using System;
using Xunit;

namespace LeapYear.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData(2000)]
        [InlineData(1600)]
        public void IsLeapYear_Centurial_True(int year)
        {
            Assert.True(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1400)]
        [InlineData(1800)]
        [InlineData(1700)]
        public void IsLeapYear_Centurial_False(int year)
        {
            Assert.False(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        public void IsLeapYear_Regular_True(int year)
        {
            Assert.True(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(6)]
        public void IsLeapYear_Regular_False(int year)
        {
            Assert.False(Program.IsLeapYear(year));
        }
    }
}
