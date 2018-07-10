using System;

namespace FizzBuzz
{
    internal static class Program
    {
        private const int StartValue = 1;
        private const int EndValue = 100;

        private static readonly IFizzBuzzService FizzBuzzService = new FizzBuzzService();

        private static void Main(string[] args)
        {
            Console.WriteLine("Starting FizzBuzz!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

            for (var i = StartValue; i < EndValue; i++)
            {
                var valueToPrint = FizzBuzzService.CalculateFizzBuzzValue(i);
                Console.WriteLine(valueToPrint);
            }

            Console.WriteLine();
            Console.WriteLine("Finished FizzBuzz!");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
