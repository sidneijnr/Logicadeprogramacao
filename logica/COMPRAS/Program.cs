using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPRAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---ajuda nas compras---");

            Console.WriteLine("informe o valor diponivel: ");
            double carteira= double.Parse(Console.ReadLine());
            
            double somacompra = 0;
            double compra = 0.0;
            int cont = 0;
            bool pode = true;
          
            do
            {
                Console.Write("\nvalor da compra: ");
                compra = double.Parse(Console.ReadLine());
               
                if (compra>0)
                {
                    if (compra<=carteira)
                    {
                        carteira = carteira - compra;
                        somacompra = somacompra - compra;
                        cont++;
                        Console.WriteLine("\nCompra registrada!\nSaldo disponivel: {0:c2}" ,carteira);
                    }
                    else
                    {
                        Console.WriteLine(" saldo indisponivel ");
                        pode = false;
                    }
                }
                else
                {
                    Console.WriteLine("valor inválido");
                }
            } while (pode);
            Console.Clear();
            Console.WriteLine(" foram feitas {0} compras\nforam gastos ao total: {1:c2}", cont,somacompra);
            Console.ReadKey();
        }
    }
}
