using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double reajuste;

            Console.Write("Esse programa calcula o reajuste salarial");

            Console.WriteLine("\nDigite seu salario atual");
            salario = Convert.ToDouble(Console.ReadLine());

            if(salario < 1.700)
            {
                reajuste = salario + 300;

                Console.WriteLine("Salario com reajuste é de: " + reajuste);
            }
            else if(salario>1.700)
            {
                reajuste = salario + 200;
                Console.WriteLine("Salario com reajuste é de: " + reajuste);
            }
            Console.Read();

        }
    }
}
