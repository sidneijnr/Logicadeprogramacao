using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---Verificador de numero é maior");
            Console.Write("digite um numero");
            int n1= int.Parse(Console.ReadLine());

            Console.Write("digite um numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("digite um numero");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"numero {n1} é maior");
            }
            else if (n2 > n3)
            {
                Console.WriteLine($"numero {n2} é maior");
            }
            else
            {
                Console.WriteLine($"numero {n3} é maior ");
            }
            Console.ReadKey();
        }
    }
}
