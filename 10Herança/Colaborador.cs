using System;

// herança , consegue usar os 2 metodos
class Colaborador : Pessoa
{
    //atributos 
    private double salario;

    //construtor
    public Colaborador(string nomeN, int idadeN,double salarioN)
    {
        this.nome =nomeN;
        this.salario = salarioN;
        this.idade = idadeN;
        mensagemPessoa();
        mensagemColaborador();

    }

    //Metodo
     protected void mensagemColaborador()
    {
        Console.WriteLine("salario: "+salario);
    }
}