using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("METODOS PARA ARRAY");
            Console.WriteLine("===================");

            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

            Random random = new Random(); // gerando numeros aleatorios
            for(int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50); // valor maximo 0 a 49 

            } // for vai sortear valores de 0 a 49 dentro do vetor1 5 vezes
            Console.WriteLine("Elementos do vetor1");
            foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("BirarySeacrh"); // retorna a posição do elemento procurado
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("Valor {0} está na posição {1} ",procurado,pos);
            Console.WriteLine("==============================================");


            Console.WriteLine("Copy"); // copias de elementos para outro vetor 
            Array.Copy(vetor1, vetor2, vetor1.Length);// vetor1 como vator de origem, vetor2 como vetor de destino, vator1.length quantidade de vezes que eu quero copiar
            foreach(int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("==============================================");

            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0); // vetor3 = vetor de destino, 0 = apartir de qual posição copiar
            foreach(int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("==============================================");

            Console.WriteLine("GetLongLength"); // retorna a quantidade do vetor
            long qtdeElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine("Quantidade de elementos: "+qtdeElementosVetor);
            Console.WriteLine("==============================================");

            Console.WriteLine("GetLowerBound"); // retorna menor indice do array ou matriz
            long MenorIndiceVetor = vetor1.GetLowerBound(0);
            int MenorindiceMetriz = matriz.GetLowerBound(1);
            Console.WriteLine("Menor indice do vetor: "+MenorIndiceVetor);
            Console.WriteLine("==============================================");

            Console.WriteLine("GetUpperBound"); // retorna maior indice do array ou matriz
            long MaiorIndiceVetor = vetor1.GetUpperBound(0);
            int MaiorindiceMetriz = matriz.GetUpperBound(1);
            Console.WriteLine("Maior indice do vetor: "+MaiorIndiceVetor);
            Console.WriteLine("==============================================");

            Array.Reverse(vetor1); // inverte a ordem dos elementos
           foreach(int n in vetor1)
            {
                Console.WriteLine(n);
            }

            vetor2.SetValue(99,0); // definir valor na posicao do vetor
            for(int i = 0; i < vetor2.Length; i++)
            {
                vetor2.SetValue(0, 1);
            }
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }

            Array.Sort(vetor1); // ordenar em ordem crescente
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("Vetor1");

            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Vetor2");

            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Vetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }


            Console.Read(); 
        }
    }
}
