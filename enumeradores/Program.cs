using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeradores
{
    class Program
    {
        enum DiasSemana {Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
        static void Main(string[] args)
        {
            DiasSemana ds = DiasSemana.Domingo; 

            Console.WriteLine(ds);
            Console.Read();
        }
    }
}
