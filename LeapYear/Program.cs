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
            if(year % 4 == 0)
                return true;
            else if(year % 400 == 0)
                return true;

            return false;
        }
    }
}
