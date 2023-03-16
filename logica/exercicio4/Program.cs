using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letras;
            string maior;
            Console.WriteLine("\n\n\n progama que diz qual é nome maior");
            
            Console.Write(" qual o nome da 1 pessoa");
            string n1 =Console.ReadLine();

            Console.Write(" qual o nome da 2 pessoa");
            string n2 = Console.ReadLine();

            if (n1.Length>n2.Length)

            {
                maior = n1;
            }
            else
            {
                maior = n2;
            }
            letras=maior.Length;
            Console.WriteLine($" o maior nome é {maior} com {letras} letras");
            Console.ReadKey();
        }

    }
}
