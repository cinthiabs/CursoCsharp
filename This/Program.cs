using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Calculos
    {
        public int v1;
        public int v2;

        public Calculos(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }


        public int somar()
        {
            return v1 + v2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculos calculos = new Calculos(10,2);

            Console.WriteLine(calculos.somar());

            Console.Read();
        }
    }
}
