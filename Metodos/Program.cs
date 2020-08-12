using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, r;

            Console.WriteLine("Digite o valor1: ");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor2: ");
            v2 = Convert.ToInt32(Console.ReadLine());

            Curso(); // chamando o metodo Curso para o metodo Main
            soma(v1,v2); //chamando o metodo e  passando valores para os parametros
            r = Sub(10, 9); // retornar valor com uma variavel
            Console.WriteLine("A subtração é: " +r);

            Console.Read();
        }
        static void Curso() // quando o metodo é void, não tem retorno
        {
            Console.WriteLine("Curso de C#");
            Console.Read();
        }
        static void soma(int n1,int n2) // add parametros
        {
            int res = n1 + n2;

            Console.WriteLine("A soma de {0} e {1} é : {2}",n1,n2,res);
            Console.Read();
        }

        static int Sub(int n1,int n2) // metodo com retorno
        {
            int res = n1 - n2;
            return res; // retornar o resultado
           
        }

        
    }
}
