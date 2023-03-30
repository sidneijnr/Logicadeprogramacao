using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t --- calculador de imc ----");
            Console.Write("digite seu peso");
            double peso= double.Parse(Console.ReadLine());

            Console.Write("digite sua altura");
            double altura= double.Parse(Console.ReadLine());
            double imc = peso/(altura*altura);
          
            if (imc < 18.5)
                {
                Console.WriteLine($" seu imc é {imc}, esta abixo do peso");
            }
             else if(imc<25.0)
            {
                Console.WriteLine($" seu imc é {imc}, peso normal");
            }
            else if(imc<30)
            {
                Console.WriteLine($" seu imc é {imc}, excesso de peso");
            }
            
            else if(imc<35.0)
            {
                Console.WriteLine($" seu imc é {imc}, obesidade classe I");
            }
            else if(imc<40)
            {
                Console.WriteLine($" seu imc é {imc}, obesidade classe II");
            }
            else
            {
                Console.WriteLine($" seu imc é {imc}, obesidade classe III");
            }
            Console.ReadKey();
            // utilizar n2 {0:n2}
            
        }

    }
}
