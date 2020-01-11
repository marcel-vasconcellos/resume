using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[100];
            int[,] studentsGrades = new int[3, 100];
            int[] notaGeralAluno = new int[100];
            Console.WriteLine("Digite quantos alunos existem:");
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Digite o nome do aluno:");
                students[i] = Console.ReadLine();
                Console.WriteLine("Digite a note do aluno em informática (sobre 100)");
                studentsGrades[0, i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a note do aluno em matemática (sobre 100)");
                studentsGrades[1, i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a note do aluno em português(sobre 100)");
                studentsGrades[2, i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Aluno: {0} \n nota de informática: {1}/100 \n nota de matemática: {2}/100" +
                    " \n nota de português {3}/100", students[i], studentsGrades[0, i], studentsGrades[1, i], studentsGrades[2, i]);
            }
        }
    }
}


