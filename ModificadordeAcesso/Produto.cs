using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadordeAcesso
{
    /*
         public -> Atributos e métodos visiveis em qualquer classe
         private -> Atributos e métodos visiveis apenas na classe onde são criados
         protected -> Atributos e métodos visiveis em classes onde são criados ou herdados 
         
         */
    class Produto
    {
        public string Nome;
        private double Valor;
        protected double Altura; // apenas consigo visualizar quando a classe produto for herdada em outra classe 
    }

    class Vendas : Produto // herdado
    {
        public Vendas()
        {
            this.Altura = 1.5;
        }
       
    }
}
