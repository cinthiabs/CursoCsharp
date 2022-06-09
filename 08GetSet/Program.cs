using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
         //   p.Nome;

         //enviando uma informação para o set
            p.Nome ="Cinthia";
            Console.WriteLine(p.Nome);
        }
    }
}
