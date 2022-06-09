using System;

class Gerente:Imposto
{
    //metodo
    // override sobre escrevendo o metodo da classe imposto
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Gerente do vale Alimentacao R$"+(salario*0.15));
    }
}