using System.Diagnostics;
using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        public static int vat = 21;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.WriteLine("Enter a price: ");
            double priceInput = Convert.ToDouble(Console.ReadLine());
            float priceInput2 = (float)priceInput;
            double finalPrice = ((priceInput * vat) / 100);
            Console.WriteLine($"price: {priceInput:0.00}, VAT: {finalPrice:0.00}, total: {CalculateVat(priceInput2):0.00}");
        }
        static float CalculateVat(float price)
        {
            double finalPrice = ((price * vat) / 100);
            return (float) (price + finalPrice);
        }
    }
}