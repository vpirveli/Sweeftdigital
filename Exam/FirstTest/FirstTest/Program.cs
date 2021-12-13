using System;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Welcome, to Matrix. \n\nInput any word: ");

            string userInput = Console.ReadLine();
            bool isPalindrome = Palindrome(userInput);

            Console.Write($"\nThe statement that the word {userInput} is a palindrome is {isPalindrome}\n");
        }

        private static bool Palindrome(string text)
        {
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (!text.EndsWith(text[0]))
                {
                    return false;
                }
                else
                {
                    return Palindrome(text.Substring(1, text.Length - 2));
                }
            }
        }
    }
}
