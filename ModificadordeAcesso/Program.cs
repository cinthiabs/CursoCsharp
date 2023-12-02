using System;

namespace ModificadordeAcesso
{

    /*
     public -> Atributos e métodos visiveis em qualquer classe
     private -> Atributos e métodos visiveis apenas na classe onde são criados
     protected -> Atributos e métodos visiveis em classes onde são criados ou herdados 

     */
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "Cinthia"; // p.valor não está visivel porque foi declarado como Private;
            Console.WriteLine("Hello World!");
        }
    }
}
