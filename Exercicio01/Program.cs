using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCompleto, endereco, bairro, sexo;
            int telefone, idade, cep;
        
            Console.WriteLine("Bem vindo ao Formulario!");

            Console.Write("Digite o seu Nome Completo: ");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite o seu Endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Digite o nome do seu Bairro: ");
            bairro = Console.ReadLine();

            Console.Write("Digite o nome do seu Sexo: ");
            sexo = Console.ReadLine();

            Console.Write("Digite o numero do seu telefone: ");
            telefone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu CEP");
            cep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");
            Console.WriteLine("==================================");
            Console.WriteLine("Formulario preenchido com Sucesso!");
            Console.WriteLine("==================================");
            Console.WriteLine("\n\n");

            Console.WriteLine("Nome Completo: \t" + nomeCompleto);
            Console.WriteLine("Endereço: \t" + endereco);
            Console.WriteLine("Bairro: \t" + bairro);
            Console.WriteLine("Sexo: \t\t" + sexo);
            Console.WriteLine("Telefone: \t" + telefone);
            Console.WriteLine("Idade: \t\t" + idade);
            Console.WriteLine("CEP: \t\t" + cep);

            Console.Read();



        }
    }
}
