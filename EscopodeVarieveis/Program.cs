using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscopodeVarieveis
{
    class Program
    {
        int num = 10; // variavel global pode ser usada nos escopos
        static void Main(string[] args)//escopo
        {
            int num2 = 0;  // variaveis locais, pode ser usada somente dentro do escopo
        }

        void teste() // criando metodo
        {
            int num3 = 10; // variaveis locais
            Console.WriteLine(num);
            Console.Read();
        }
    }
}
