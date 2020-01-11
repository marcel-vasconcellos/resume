using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTaxOwed
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxpayer[] tp = new Taxpayer[10];
            for (int i = 0; i < tp.Length; i++)
            {
                tp[i] = new Taxpayer();
                Console.WriteLine("Enter taxpayer #{0} - Social security number:", i + 1);
                tp[i].SocialSNumber = Console.ReadLine();
                Console.WriteLine("Enter taxpayer #{0} - Yearly income", i + 1);
                tp[i].YearlyIncome = double.Parse(Console.ReadLine());
                Console.WriteLine("Taxpayer #{0} owes {1} ", i + 1, tp[i].TaxOwed);
                Console.ReadKey();
            }
        }
    }
}
