using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversõesdeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4, media;
            string resultado;

            Console.Write("Digite a nota 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 1: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 1: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a nota 1: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            media = (n1 + n2 + n3 + n4)/4;

            if (media < 4)
            {
                resultado = "Preprovado";
            }
            else if(media < 6 )
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Aprovado";

            }
            Console.WriteLine(" A Media foi de "+media+ " Resultado: " + resultado);
            Console.Read();
        }
    }
}
