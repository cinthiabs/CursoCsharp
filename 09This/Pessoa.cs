using System;


class Pessoa
{
    //atributo
    private string nome = "Maria";

    //construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // faz referencia ao atributo
    }
}