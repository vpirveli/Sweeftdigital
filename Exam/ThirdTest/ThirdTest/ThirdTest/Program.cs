using System;
using System.Threading;

namespace ThirdTest
{
    class Program
    {
        #region Private
        private static int textTimer = 100; // change to 0 to be faster
        private static int calculateTimer = 3000; // change to 0 to be faster
        #endregion
        static void Main(string[] args)
        {
            #region MatrixMessage
            Console.ForegroundColor = ConsoleColor.Green;

            string message = "Welcome, To Matrix.\nMatrix will now generate the array of random numbers...\n";

            foreach (var item in message)
            {
                Thread.Sleep(textTimer);
                Console.Write(item);
            }
            Thread.Sleep(calculateTimer);
            #endregion

            Random r = new Random();
            int[] rArray = new int[r.Next(10, 30)];

            for (int i = 0; i < rArray.Length; i++)
            {
                Thread.Sleep(textTimer);
                rArray[i] = r.Next(1, 30);
                Console.Write(rArray[i] + " ");
            }

            int notContains = LowestNotContained(rArray);

            #region MatrixMessage
            message = "\nCalculating the lowest number not cointained in the array.";

            foreach (var item in message)
            {
                Thread.Sleep(textTimer);
                Console.Write(item);
            }

            Thread.Sleep(calculateTimer);
            message = "\nLowest number not contained: ";

            foreach (var item in message)
            {
                Thread.Sleep(textTimer);
                Console.Write(item);
            }

            Thread.Sleep(calculateTimer);
            #endregion

            Console.WriteLine(notContains);
        }

        private static int LowestNotContained(int[] rArray)
        {
            int check = 1;
            while (Array.Exists(rArray, number => number == check))
            {
                check++;
            }
            return check;
        }
    }
}
