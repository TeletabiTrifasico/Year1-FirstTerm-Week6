using System.Net.WebSockets;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter number (0 is stop value): ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("negative number entered...");
                }
                else if (number == 0)
                {
                    Console.WriteLine("End of program");
                    break;
                }
                else if (IsPrimeNumber(number) == true)
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
            }
        }
        static bool IsPrimeNumber(int value)
        {
            bool result = false;
            if (value % 3 == 0 || value == 3 || value == 2 || value == 8)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}