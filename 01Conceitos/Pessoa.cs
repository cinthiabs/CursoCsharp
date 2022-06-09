using System; // para exibir mensagem é necessario o system

class Pessoa
{
    //atributos
    public string nome;
    public int idade;

    //metodos
    //void null, sem retorno 
    public void Mensagem()
    {
        Console.WriteLine("Olá " +nome+" você tem "+idade+" anos.");
    }
}