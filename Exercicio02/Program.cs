using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int valor1, valor2, soma, mult, divisao, sub;


            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + " Bem vindo ao Jogo de Operações\n");

            Console.Write(nome + " Digite o primeiro numero: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(nome + " Digite o segundo numero: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            soma = valor1 + valor2;
            mult = valor1 * valor2;
            divisao = valor1 / valor2;
            sub = valor1 - valor2;

            Console.Write("\n\n");
            Console.WriteLine(nome + " O resultado dos numeros digitados em operções basicas");
            Console.WriteLine("Soma:\t\t\t" + soma);
            Console.WriteLine("Multiplicação:\t\t" + mult);
            Console.WriteLine("Divisão:\t\t" + divisao);
            Console.WriteLine("Subtração:\t\t" + sub);

            Console.Read();
        }
    }
}
