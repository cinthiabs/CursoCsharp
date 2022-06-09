using System;

class Atendente:Imposto
{
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Atendente do vale Alimentacao R$"+(salario*0.12));
    }
}