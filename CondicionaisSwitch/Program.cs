using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionaisSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            char escolha;

            inicio: // voltar ao inicio com o comando  goto
            Console.Clear();

            Console.WriteLine("Belo Horizonte - MG a Vitoria - ES");
            Console.WriteLine("Escolha o transporte:[a] = Avião | [c]Carro | [o] Ônibus ");
            escolha = Convert.ToChar(Console.ReadLine());

            switch (escolha){
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;

            }
            if (tempo < 0)
            {
                Console.WriteLine("Transporte Indisponivel.");

            }
            else
            {
                Console.WriteLine("Para o transporte escolhido é : " + tempo+" Minutos");
            }
            Console.WriteLine("Deseja Calcular outro transporte?[s/n]: ");
            escolha = Convert.ToChar(Console.ReadLine());

            if(escolha == 's' || escolha == 'S')
            {
                goto inicio; // voltar ao inicio
            }
            else
            {
                Console.Clear(); // limpar o programa e mostrar a mensagem abaixo
                Console.WriteLine("Fim do Programa");
            }

            Console.Read();
        } 
    }
}
