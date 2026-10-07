namespace Kassa
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PXL catering kassa");
            Console.ResetColor();

            Console.Write("Geef de prijs van het product: ");
            string prijsInput = Console.ReadLine();
            decimal.TryParse(prijsInput, out decimal prijsProduct);

            Console.Write("Geef het aantal: ");
            string aantalInput = Console.ReadLine();
            decimal.TryParse(aantalInput, out decimal aantal);

            decimal totaalBedrag = prijsProduct * aantal;
            

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHet totaal bedrag is {totaalBedrag:c}");
            Console.ResetColor();
        }
    }
}
