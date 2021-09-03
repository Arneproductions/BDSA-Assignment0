using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IsLeapYear(2000);
        }

        public static bool IsLeapYear(int year) 
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }
}
