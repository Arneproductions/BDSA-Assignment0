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
        [InlineData(1800)]
        [InlineData(1700)]
        public void IsLeapYear_Centurial_False(int year)
        {
            Assert.False(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1604)]
        [InlineData(1608)]
        public void IsLeapYear_Regular_True(int year)
        {
            Assert.True(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1601)]
        [InlineData(1606)]
        public void IsLeapYear_Regular_False(int year)
        {
            Assert.False(Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData(1582)]
        [InlineData(1581)]
        [InlineData(-1)]
        public void IsLeapYear_Under1583_ThrowArgumentException(int year)
        {
            Assert.Throws<ArgumentException>(() => Program.IsLeapYear(year));
        }
    }
}
