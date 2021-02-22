using System;

namespace Imposto
{
    class Program
    {
            
        static void Main(string[] args)
        {
            double valor = Double.Parse(Console.ReadLine());

            double cofins = 0;
            double api = 0;
            double icms = 0;

            if (valor < 25000) {
                ipi = valor * 5/100;

            } else {
                ipi = valor * 10/100;
            }

            if (valor > 12000 ) {

                cofins = valor * 8/100;

            }

            cofins = valor - cofins;
            api = valor - api;
            icms = valor - icms;


            Console.WriteLine("Confins" + cofins );
            Console.WriteLine("api" + api );
            Console.WriteLine("icms" +  icms);

        }
    }
}
