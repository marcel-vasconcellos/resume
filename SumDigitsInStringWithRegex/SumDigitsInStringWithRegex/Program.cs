using System;
using System.Text.RegularExpressions;

namespace SumDigitsInStringWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionWithoutFor();
        }
        public static int OptionWithoutFor()
        {
            Console.WriteLine("Type in a word to get the sum of the numeric characters");
            string testString = Console.ReadLine();
            int sum2 = 0;
            string digits2 = Regex.Replace(testString, "[^0-9 _]", "");
            for (int i = 0; i < digits2.Length; i++)
            {
                sum2 += (int)(digits2[i] - '0');
                Console.Write(digits2[i]);
            }
            Console.Write(" - Total: " + sum2);
            Console.ReadKey();
            return sum2;
        }
    }
}
