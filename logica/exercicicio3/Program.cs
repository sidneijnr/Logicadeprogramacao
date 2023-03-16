using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n verificado de aprovação");
            Console.Write("nome do aluno");
            string a1=Console.ReadLine();

            Console.Write(" digite a nota do primeiro aluno");
            double no1 = double.Parse(Console.ReadLine());

            Console.Write(" digite a nota do aluno");
            double no2 = double.Parse(Console.ReadLine());

            Console.Write(" digite a nota do aluno");
            double no3 = double.Parse(Console.ReadLine());

            Console.Write(" digite a nota do aluno");
            double no4 = double.Parse(Console.ReadLine());

            Console.Clear();

            double total = no1 + no2 + no3 + no4;
            double media = total / 4.0;
             
            if (media >= 6.0)
            {
                Console.WriteLine($"{a1} esta aprovado");
            }
             else
            {
                Console.WriteLine($" {a1} esta reprovado");
            }
            Console.ReadKey();


        }
    }
}
