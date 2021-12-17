using System;
using System.Collections.Generic;

namespace EighthTest
{
    class Program
    {
        #region Private
        private static List<string> CurrencyNames = CurrencyExchange.GetCurrencyNames();
        private static string input, input2;
        private static int spaceCounter = 0;
        #endregion
        #region Messages
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please select and type two currencies that you want to compare: \n");

                foreach (var item in CurrencyNames)
                {
                    Console.Write($" {item}");
                    spaceCounter++;
                    if (spaceCounter == 10)
                    {
                        spaceCounter = 0;
                        Console.WriteLine();
                    }
                }

                Console.Write("\n\nEnter the first currency from the list: ");
                input = Console.ReadLine().ToUpper();

                Console.Write("Enter the first currency from the list: ");
                input2 = Console.ReadLine().ToUpper();

            } while (!(CurrencyNames.Contains(input) && CurrencyNames.Contains(input2)));

            Console.WriteLine($"Exchange rate between {input} and {input2} is: {CurrencyExchange.Exchange(input, input2)}");
        }
        #endregion
    }
}

