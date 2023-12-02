using System;

namespace LoopWhile
{
    class Program
    {
        public class Usuario
        {
            public int Senha { get; set; } = 123;
            public int Tentativas { get; set; } = 0;
            public int LimiteTentativas { get; set; } = 5;
            public int SenhaUsuario { get; set; }
        }

        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            do
            {
                Console.WriteLine("Digite uma senha ");
                user.SenhaUsuario = Convert.ToInt32(Console.ReadLine());
                user.Tentativas++;
                user.LimiteTentativas--;

                if (user.SenhaUsuario != user.Senha)
                {
                    Console.WriteLine("Senha incorreta, Número de tentativas: " + user.Tentativas + " Limite: " + user.LimiteTentativas);
                }

            } while (user.SenhaUsuario != user.Senha && user.LimiteTentativas > 0);

            if (user.SenhaUsuario == user.Senha)
            {
                Console.WriteLine("Senha correta, Número de tentativas: " + user.Tentativas);
            }
            else
            {
                Console.WriteLine("Limite de tentativas atingido. Senha incorreta.");
            }

            Console.Read();
        }
    }
}