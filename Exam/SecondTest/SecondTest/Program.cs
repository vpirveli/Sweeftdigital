using System;

namespace SecondTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Welcome, to Matrix. \n\nInput your money(in cents): ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            int[] splitMin = MinSplit(userInput);

            Console.Write($"50: {splitMin[0]}\n20: {splitMin[1]}\n10: {splitMin[2]}\n5: {splitMin[3]}\n1: {splitMin[4]}");

        }

        private static int[] MinSplit(int userInput)
        {
            int[] array = new int[5];
            if (userInput / 50 > 0)
            {
                array[0] += userInput / 50;
                userInput %= 50;
            }
            if (userInput / 20 > 0)
            {
                array[1] += userInput / 20;
                userInput %= 20;
            }
            if (userInput / 10 > 0)
            {
                array[2] += userInput / 10;
                userInput %= 10;
            }
            if (userInput / 5 > 0)
            {
                array[3] += userInput / 5;
                userInput %= 5;
            }
            if (userInput / 1 > 0)
            {
                array[4] += userInput / 1;
            }

            return array;
        }
    }
}
