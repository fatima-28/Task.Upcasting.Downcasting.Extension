using System;
namespace Upcasting.Downcasting
{
    public static class ExtensionMethods
    {


        public static bool CustomContains(this string str)
        {//ab
            int LetterCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                LetterCount++;
            }
            if (LetterCount > 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool CustomContains(this char chr)
        {
            int LetterCount = 0;//a
            for (int i = 0; i < 1; i++)
            {
                LetterCount++;
            }
            if (LetterCount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPrime(this int number)
        {
            int count = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
