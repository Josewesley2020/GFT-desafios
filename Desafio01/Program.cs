using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace desafio_01
{
    class Program
    {
        static void Main(string[] args)
        {
           Caixa caixa = new Caixa();
           double total;

           Produto Banana = new Produto("banana",0.99,2);
           total = caixa.calcularValorFinal(Banana.valor,3,Banana.tipo);
           Console.WriteLine("{0} {1}",Banana.nome,total.ToString("C"));

           Produto Energetico = new Produto("Energetico",5.49,2);
           total = caixa.calcularValorFinal(Energetico.valor,7,Energetico.tipo);
           Console.WriteLine("{0} {1}",Energetico.nome,total.ToString("C"));

           Produto Arroz = new Produto("Arroz",20,2);
           total = caixa.calcularValorFinal(Arroz.valor,1,Arroz.tipo);
           Console.WriteLine("{0} {1}",Arroz.nome,total.ToString("C"));

           Produto Chocolate = new Produto("Chocolate",4.50,2);
           total = caixa.calcularValorFinal(Chocolate.valor,20,Chocolate.tipo);
           Console.WriteLine("{0} {1}",Chocolate.nome,total.ToString("C"));

           Produto Leite = new Produto("Leite",3.37,2);
           total = caixa.calcularValorFinal(Leite.valor,3,Leite.tipo);
           Console.WriteLine("{0} {1}",Leite.nome,total.ToString("C"));

           Produto Abacaxi = new Produto("Abacaxi",2.40,2);
           total = caixa.calcularValorFinal(Abacaxi.valor,4,Abacaxi.tipo);
           Console.WriteLine("{0} {1}",Abacaxi.nome,total.ToString("C"));

        }
    }
}
