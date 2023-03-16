using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reajuste,sal2;
            Console.WriteLine("\n\n\n reajuste de salarios");
            Console.Write("digite o seu salario ");
            double sal= double.Parse(Console.ReadLine());

            if (sal<=1500.00)
            {
                reajuste = sal * 23 / 100;
                sal2 = sal + reajuste;
                Console.WriteLine($"o salario de {sal} foi reajustado para {sal2}R$");
            }
            else
            {
                reajuste = sal * 18 / 100;
                sal2 = sal + reajuste;
                Console.WriteLine($" o salario de {sal} foi reajustado para {sal2}R$");
            }
            Console.ReadKey();
        }
    }
}
