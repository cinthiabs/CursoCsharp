using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos01
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo,divisor, quoc, resto;
            dividendo = 10;
            divisor=5;
            quoc = Div(dividendo, divisor, out resto);

            Console.WriteLine("{0} / {1}: quociente = {2} e resto = {3}",dividendo,divisor,quoc,resto);


            int num = 10;
            Dobrar(ref num);

            int num2 = 10;
            Dobrar2(num2);


            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.Read();
        }
        static void Dobrar( ref int valor)  // passagem por referencia  usa o endereço de memoria
        {
            valor *= 2;
        }

        static void Dobrar2( int valor)  // passagem por valor 
        {
            valor *= 2;
        }

        static int Div(int dividendo, int divisor, out int resto) // out me retorna mais de um resultado
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}
