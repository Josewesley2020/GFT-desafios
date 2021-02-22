using System;

namespace Calcula_valor
{
        class Program
        {   
            static double calcular(int tipo, double valor, int quantidade)
            {
                double desc = 0;
                double preco = valor * quantidade;
                double total = 0;

                 if (tipo == 1) {
                     
                     desc = preco * 10/100;

                 } else if (tipo == 2) {
                     desc = preco * 20/100;

                 } else if (tipo == 3){

                     desc = preco * 30/100;

                 }

                 total = preco - desc;

                return total;
            }



        static void Main(string[] args)
        {

            string nome = Console.ReadLine();
            int quantidade = Int32.Parse(Console.ReadLine());
            double valor = Double.Parse(Console.ReadLine());
            int tipo = Int32.Parse(Console.ReadLine());
            

            double valor_final = calcular(tipo, valor, quantidade);

            Console.WriteLine(valor_final);

            
        }
    }
}
