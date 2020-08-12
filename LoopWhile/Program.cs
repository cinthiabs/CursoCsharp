using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhauser;
            int tentativas=0;


            do
            {
                Console.Clear();
                Console.WriteLine("Digite uma senha ");
                senhauser = Console.ReadLine();
                tentativas++;

            } while (senha == senhauser);
                Console.WriteLine("Senha correta, Numero de tentativas" +tentativas);
            
           
            Console.Read();
        }
    }
}
