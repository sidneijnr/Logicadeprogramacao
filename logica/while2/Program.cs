using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---calcula media da turma---\n");
            Console.Write("informa o numero de alunos na turma: ");
            int aluno = int.Parse(Console.ReadLine());
            double somaturma = 0.0;
            double mediaturma = 0.0;
            int i = 1;

            while (i <= aluno)
            {
                Console.WriteLine($"aluno numero {i}");
                Console.Write("qual a nota do aluno no 1° bimestre? ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("qual a nota do aluno no 2° bimestre? ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.Write("qual a nota do aluno no 3° bimestre? ");
                double nota3 = double.Parse(Console.ReadLine());
                Console.Write("qual a nota do aluno no 4° bimestre? ");
                double nota4 = double.Parse(Console.ReadLine());

                double somamedia = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine($"\na media do aluno foi {somamedia}");

                somaturma = somamedia+mediaturma;
                mediaturma = somaturma / i;

                Console.WriteLine($"a media da turma é {mediaturma}");

                i++;
            }

            Console.ReadKey();
        }
    }
}

