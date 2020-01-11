using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hangManWords = { "hello", "yellow", "rhinocerous", "robot", "marriage", "vegetarian", "chickpea", "reptile" };
            Random random = new Random();
            int randomIndex = random.Next(0, 8);
            string chosenWord = hangManWords[randomIndex];
            string hiddenWord = "";
            for (int i = 0; i < chosenWord.Length; i++)
            {
                hiddenWord += "*";
            }
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0}", hiddenWord);
                Console.WriteLine("Try to guess a letter from the word");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (letter == chosenWord[i])
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                    }
                }
                if (containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great! {0} is in the word!", letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry. {0} is not in the word.", letter);
                }
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Congratulations! You have won the game.\nThe word is {0}\nPress any key to continue.", chosenWord);
            Console.ReadKey();

        }
    }
    
}
