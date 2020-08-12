using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatandoSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            n1 = 10;
            n2 = 20;
            n3 = 30;

            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Patel";

            valorVenda = valorCompra + (valorCompra * lucro);

            // \n = quebra de linha, \t = tabulação
            // :c = formato moeda :p = porcentagem

            Console.WriteLine("Produto ........:{0,15}", produto);
            Console.WriteLine("Val. Compra.....:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro...........:{0,15:p}", lucro);
            Console.WriteLine("Val. Venda......:{0,15:c}", valorVenda);

            Console.Write("n1={0}, n2={1}, n3={2}",n1,n2,n3);
            Console.Read();
        }
    }
}
