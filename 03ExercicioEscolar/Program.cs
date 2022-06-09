using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
           //instanciar obj
           Aluno a = new Aluno();
           a.nome = "Maria";
           a.nota1 = 4;
           a.nota2 = 3;
           a.mensagem();
        }
    }
}
