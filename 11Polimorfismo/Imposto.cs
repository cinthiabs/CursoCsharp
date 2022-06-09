using System;

class Imposto
{
    //metodos
    //virtual = sofre alteração
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do vale Alimentacao R$"+(salario*0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do vale Trasporte R$"+(salario*0.06));
    }
}