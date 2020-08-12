using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static string nome;
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade >= 18)
            {
                Permitir();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // add cor na fonte
                Console.WriteLine("Acesso Negado!");
            }
            Console.Read();
        }
        static void Permitir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bem vindo ao Sistema " + nome);
            Console.Read();
        }
    }
}
