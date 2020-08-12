using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = (10+5)*2;
            int num = 10;
            num = num + 1; //incremento
            num += 1; // forma abreviada
            num++; // forma mais abreviada
            bool resp = 10<5;

            Console.WriteLine(resp); // imprimindo valor verdadeiro ou falso
            Console.WriteLine(res); // imprimindo o valor da operação matematica
            Console.WriteLine(num); // imprimindo o incremento
            Console.Read();

        }
        void logicos()
        {
            //------------LOGICOS  & = and/E  | = OR/ OU
            bool res=(5<3)|(10<5);

            Console.WriteLine(res);
        }
    }
}
