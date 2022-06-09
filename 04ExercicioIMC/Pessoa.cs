using System;

class Pessoa 
{
    public double peso;
    public double altura;

    public double IMC(double peso, double altura)
    {
        double calculo = peso /(altura * altura);
        return calculo;
    }

    public string Retorno (double calculo)
    {
        string msg="";
        if(calculo < 18.5)
        {
            msg="Abaixo do peso.";
        }
        else if (calculo <25)
        {
            msg="Peso normal.";
        }
        else if (calculo <30)
        {
            msg="Acima do peso.";
        }
        else if (calculo <35)
        {
            msg="Obesidade I";
        }
        else if (calculo <40)
        {
            msg="Obesidade II";
        }
         else if (calculo >=40)
        {
            msg="Obesidade III";
        }
        return msg;
    }
    public void Mensagem ()
    {
        var obterMedia = IMC(peso,altura );
        var obterRetorno = Retorno(obterMedia);
        Console.WriteLine("Peso: "+peso+ " Altura: "+altura+ " IMC calculado: " +obterMedia);
        Console.WriteLine("Resultado: "+obterRetorno); 
    }
}