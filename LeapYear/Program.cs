using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Start:
            Console.Write("Type in a year: ");
            string inputYear = Console.ReadLine();
            int year;

            if(!int.TryParse(inputYear, out year))
            {
                Console.WriteLine("Year has to be a number! Try again... \n");
                goto Start;    
            }
            
            if(IsLeapYear(year))
                Console.WriteLine("Yay");
            else
                Console.WriteLine("Nay");
        }

        public static bool IsLeapYear(int year) 
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }
}
