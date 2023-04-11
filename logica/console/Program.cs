using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op==1)
            {

            }
            Console.WriteLine("\t\t---Calculadora com While---\n");
            Console.Write("informe um numero");
            int num= int.Parse(Console.ReadLine());

            int cont = 0;
            while (cont <=10)
            {
                Console.WriteLine($"{num} X {cont} = {num*cont}");
                cont++;
            }
            Console.WriteLine(" \ndeseja realizar outra operação?\n[0]Não\n[1]sim")
             Console.Write("escolha uma opção: ");
            op= int.Parse(Console.ReadLine());
            Console.Clear();    
            Console.ReadKey();
        }
    }
}

