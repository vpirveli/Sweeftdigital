using System;

namespace FourthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool check;

            do
            {
                check = false;
                Console.Write("Write the text using '(' and ')' signs: ");
                input = Console.ReadLine();
                foreach (var item in input)
                {
                    if (item != ')' & item != '(')
                    {
                        check = true;
                    }
                }
            } while (check);

            bool isProperly = IsProperly(input);
            Console.WriteLine("The Statement:");
            Console.WriteLine($"'(' and ')' signs are used correctly - is {isProperly}");
        }

        private static bool IsProperly(string input)
        {
            int count = 0;

            foreach (var item in input)
            {
                if (item == '(')
                {
                    count++;
                }
                else if (item == ')')
                {
                    count--;
                    if (count < 0)
                        return false;

                }
            }

            if (count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
