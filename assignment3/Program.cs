using System.ComponentModel.Design;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter year (0 is stop value): ");
                int yearInput = Convert.ToInt32(Console.ReadLine());

                if (yearInput == 0)
                {
                    Console.WriteLine("End of program");
                    break;
                }
                else if (yearInput < 0)
                {
                    Console.WriteLine("Negative year entered...");
                }
                else if (IsLeapYear(yearInput) == true)
                {
                    Console.WriteLine($"{yearInput} is not a leap year.");
                }
                else
                {
                    Console.WriteLine($"{yearInput} is a leap year.");
                }
            }
        }
        static bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}