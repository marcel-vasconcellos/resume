using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsInString
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Type in a word and press enter to sum all numeric characters in it: ");
                string testString = Console.ReadLine();
                int sum = 0;
                for (int i = 0; i < testString.Length; i++)
                {
                    try
                    {
                        int number = int.Parse(testString[i].ToString());
                        sum += number;
                    }
                    catch (Exception) { continue; }
                }
                Console.WriteLine("The sum of digits in this string is {0}", sum);
                Console.Read();
        }
    }
}
