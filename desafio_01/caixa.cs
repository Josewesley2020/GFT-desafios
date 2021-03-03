using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace desafio_01
{
    class Caixa
    {

        public Caixa()
        {
            
        }

        public double aplicarDesconto(int tipo, double valor, int quant)
        {
            double valorAtualizado = valor;

            if (tipo == 1 || tipo == 3 && quant > 5) {

                valorAtualizado -= 10*valorAtualizado/100;

            } else if (tipo == 2){

                valorAtualizado -= 20*valorAtualizado/100;

            }

            return valorAtualizado;

        }


        public double calcularValorFinal(double valor, int quant, int tipo){

           double valorCompra = valor * quant;
           double valorFinal = aplicarDesconto(tipo,valorCompra,quant);

           return valorFinal;
        }

    }
}