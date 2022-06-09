using System;

class Pessoa
{
    //atributo 
    protected string nome;
    protected int idade;
    
    //metodo
    protected void mensagemPessoa(){
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
    }
}