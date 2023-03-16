using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("digite um numero");
            n1 = int.Parse(Console.ReadLine());
           {
             if (n1 % 2 == 0)
                Console.WriteLine($"numero {n1} é par");
            }
            else
            {
                Console.WriteLine($"numero {n1} impar");
            }
            Console.ReadKey();
        }
    }
}
         