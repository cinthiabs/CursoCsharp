using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto e = new Estagiario();
            e.valeAlimentacao(1000);
            e.valeTransporte(1000);
            Console.WriteLine("---------");

            Imposto g = new Gerente();
            g.valeAlimentacao(5000);
            g.valeTransporte(1000);
            Console.WriteLine("---------");

            Imposto a = new Atendente();
            a.valeAlimentacao(2000);
            a.valeTransporte(2000);
            Console.WriteLine("---------");

        }
    }
}
