using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Start:

            // Get user input 
            Console.Write("Type in a year: ");
            string inputYear = Console.ReadLine();
            int year;

            // Parse input
            if(!int.TryParse(inputYear, out year))
            {
                Console.WriteLine("Year has to be a number! Try again... \n");
                goto Start;    
            }
            
            try
            {
                if(IsLeapYear(year))
                    Console.WriteLine("Yay");
                else
                    Console.WriteLine("Nay");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        public static bool IsLeapYear(int year) 
        {
            if(year <= 1582)
                throw new ArgumentException("Year has to be above 1582");

            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }
}
