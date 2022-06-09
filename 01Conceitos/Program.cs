using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Cinthia";
            obj.idade = 23;
            obj.Mensagem();
        }
    }
}
