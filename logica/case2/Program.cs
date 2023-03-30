using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t ----- Calcula nota do aluno----");
            Console.Write("qual o nome do aluno: ");
            string nome= Console.ReadLine();

            Console.Write("nota do aluno no 1 bimestre");
            
            int n1= int.Parse(Console.ReadLine());

            Console.Write("nota do aluno no 2 bimestre :");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("nota do aluno no 3 bimestre: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.Write("nota do aluno no 4 bimestre: ");
            int n4 = int.Parse(Console.ReadLine());

            int media;
            media = (n1 + n2 + n3 + n4) / 4;

            char conc='0';


            if(media>=90)
            {
                conc = 'A';
            }
            else if(media>=80)
            {
                conc = 'B';
            }
            else if(media>=60)
            {
                 conc = 'C';
            }
            else if(media>=40)
            {
                conc = 'D';
            }
            else
            {
                conc = 'E';
            }
            switch(conc)
            {
                case 'A':
                    Console.WriteLine($" o {nome} foi aprovado\n{conc}\nmédia foi {media}");
                    break;
                case 'B':
                    Console.WriteLine($" o {nome} foi aprovado\n{conc}\nmédia foi {media}");
                    break;
                case 'C':
                    Console.WriteLine($" o {nome} foi aprovado\n{conc}\nmédia foi {media}");
                    break;
                case 'D':
                    Console.WriteLine($" o aluno {nome} foi para o exame\n conceito :{conc}\nMédia do aluno {media}");
                    break;
                case 'E':
                    Console.WriteLine($" o aluno {nome} foi para a recuperação\n conceito :{conc}\nMédia do aluno {media}");
                    break;
                    default:
                    Console.WriteLine($" o aluno {nome} foi REPROVADO\nMédia do aluno {media}");
                    break;

            }
             Console.ReadKey();
        }

    }
}
