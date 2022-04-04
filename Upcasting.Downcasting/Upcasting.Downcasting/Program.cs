using System;

namespace Upcasting.Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Fatima";
            Console.WriteLine(text.CustomContains());
            char character = 'a';
            Console.WriteLine(character.CustomContains());
            int number = 12;
            Console.WriteLine(number.IsPrime());

        }

    }
}
