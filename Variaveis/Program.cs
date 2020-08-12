using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 10; // pode armazenar entre 0 e 255
            int num=-10;
            char letra = 'c'; // char só pode armazenar 1 caracter,  
            float valor = 5.3f;
            string nome = "Cinthia";

            var aux =nome; // não precisa declarar o tipo de dado

            Console.WriteLine("O Valor da Variavel é "+ aux );
            Console.Read();


        }
    }
}
