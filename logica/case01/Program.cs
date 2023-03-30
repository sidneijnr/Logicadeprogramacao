using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t ----Calucaldor de aumento salarial----");
            Console.WriteLine("\nCargos :\n\t[1} gerente \n\t[2] engenheiro \n\t[3]Técnico");
            Console.Write("\nInforme o cargo:");
            int cargo = int.Parse(Console.ReadLine());

            Console.WriteLine("\n informe o seu salario: ");
            double salario = double.Parse(Console.ReadLine());

            double novosal = 0;

            switch (cargo)
            {
                case 1:
                    novosal = salario + (salario * 0.1);
                    break;
                case 2:
                    novosal = salario + (salario * 0.2);
                    break;
                case 3:
                    novosal = salario + (salario * 0.3);
                    break;
                default:
                    novosal = salario + (salario * 0.4);
                    break;


            }
            Console.WriteLine("\nSalário antigo: {0:c2}" +
                "\nNovo Salário: {1:c2}" +
                "\nReajuste: {2:c2}",salario, novosal, novosal-salario);
            Console.ReadKey();


        }
    }
}
