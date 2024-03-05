namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrOfFullStops, nrOfCommas, nrOfSemiColons;


            Console.WriteLine("Enter a text>");
            string input = Console.ReadLine();
            SearchText(input, out nrOfFullStops, out nrOfCommas, out nrOfSemiColons);

            Console.Write(nrOfFullStops + " full stops, ");
            Console.Write(nrOfCommas + " commas, ");
            Console.WriteLine(nrOfSemiColons + " semicolons");
        }   
        static void SearchText(string text, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = 0;
            nrOfCommas = 0;
            nrOfSemiColons = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    nrOfFullStops++;
                }
                else if (text[i] == ',')
                {
                    nrOfCommas++;
                }
                else if (text[i] == ';')
                {
                    nrOfSemiColons++;
                }
            }
        }
    }
}