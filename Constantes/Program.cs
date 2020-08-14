using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const string canal = "Cursos"; // não é possivel alterar o valor de uma constante 
            const double pi = 3.1415;

            Console.WriteLine("Canal{0}\n Pi: {1} ", canal,pi);
            Console.Read();
        }
    }
}
