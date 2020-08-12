using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, soma;

            Console.Write("Digite o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            soma = valor1 + valor2;

            Console.WriteLine("A soma de {0} mais a {1} é igual a: {2}", valor1, valor2, soma);
            Console.Read();


            
        }
    }
}
