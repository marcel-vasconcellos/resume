using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace SortByAlphabeticOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> texto = new List<string>();
            string input = "g";



            while (input != "ok")
            {
                Console.WriteLine("Type in a word that you want to sort in alphabetical order and press ENTER. Type 'ok' to sort all the words entered in a .txt file called 'test' in C:\\Users\\Public");
                input = Console.ReadLine();

                if (hasSpecialChar(input) == true)
                {
                    Console.WriteLine("Use of invalid characters");
                }
                else if (input != "ok" && hasSpecialChar(input) == false) { texto.Add(input); }


            }
            texto.Sort();
            string palavras = string.Join("; ", texto);
            System.IO.File.WriteAllText(@"C:\Users\Public\teste.txt", palavras);

            bool hasSpecialChar(string teste)
            {
                string specialChar = @"\1234567890|!#$%&/()=?»«@£§€{}.-;'<>_,";
                foreach (var item in specialChar)
                {
                    if (teste.Contains(item)) return true;
                }

                return false;
            }


        }











    }
}

