using System;

namespace FifthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of stairs: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int countVariants = CountVariants(input);

            Console.WriteLine($"There are {countVariants} variants for {input} flight stairs.");
        }

        private static int CountVariants(int input)
        {
            if (input == 0)
                return 1;
            else if (input < 0)
                return 0;

            return CountVariants(input - 1) + CountVariants(input - 2);
        }
    }
}
