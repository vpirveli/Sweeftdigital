using System;
using System.Collections.Generic;

namespace SixthTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> dictionary = new MyDictionary<string>();

            dictionary.Insert("1");
            dictionary.Insert("1");
            dictionary.Insert("2");

            Console.WriteLine(dictionary.Size());

            dictionary.Delete("1");
            dictionary.Delete("1");
            dictionary.Delete("2");

            Console.WriteLine(dictionary.Size());
        }
    }
}
