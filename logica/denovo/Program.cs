using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t simulador de conta corrente");
            int op;
            double saldo = 0.0,saque=0, deposito= 0;
            do
            {
                Console.WriteLine("qual ação você quer efetuar:\n1.depositar\n2.Sacar\n3.Exibir saldo\n4.sair");
                op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("qual o valor do depósito ?");
                            deposito=int.Parse(Console.ReadLine());
                            saldo += deposito;
                            Console.Clear();  
                            break;
                            case 2:
                            Console.WriteLine("qual valor do saque");
                            if (saque<=saldo)
                            {
                                saldo -= saque;
                                Console.WriteLine("seu saque foi relizado");
                              Console.Clear();
                        }
                            else 
                            {
                                Console.WriteLine("o saque não pode ser efetuado");
                               Console.Clear();
                        }
                            break;
                        case 3:
                            Console.WriteLine($"o seu saldo atual é de {saldo}");
                                break;
                        Console.Clear();
                    }

            } while (op!=4);
            Console.ReadKey();
        }
    }
}
