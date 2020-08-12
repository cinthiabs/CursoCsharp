using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
         //   int n1,n2,n3,n4,n5; sem vetor
        
            //=======FORMAS DE DECLARAR ARRAYS ==========   

            int[] num = new int[3] {55,77,99};

            int[] numero = { 11, 44, 22 };

            string[] nome = { "Cinthia", "Barbosa", "Silva" };

            string[] veiculo = new string[3];

            veiculo[0] = "Carro";
            veiculo[1] = "Avião";
            veiculo[2] = "Navio";

            int[] n = new int[5];
            // adicionado valores nos indices
            n[0] = 11;
            n[1] = 22;
            n[2] = 33;
            n[3] = 44;
            n[4] = 55;

            Console.WriteLine(nome[0]);

            Console.Read();
        }
    }
}
