using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto
{

    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador(string n) // metodo construtor deve ter o mesmo nome da classe
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador() // destrutor
        {
            Console.WriteLine("Jogador foi deletado "+nome);
            Console.Read();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            Console.WriteLine("Digite  nome do jogador 1: ");
            nome1 = Console.ReadLine();

            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador("Theo");

            Console.WriteLine("Nome do jogador 1: " +j1.nome);
            Console.WriteLine("Nome do jogador 2: " + j2.nome);

            Console.Read();
        }
    }
}
