using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace desafio_01
{
    class Produto
    {
         public string nome;
         public double valor; 
         public int tipo; 
         

         public Produto (string n, double vlr, int tp)
         {
             nome = n;
             valor = vlr;
             tipo = tp;
             
         }
    }
}