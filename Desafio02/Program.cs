using System;

namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o valor inicial:");
            int valorI = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor final:");
            int valorF = Int32.Parse(Console.ReadLine());

            if (valorF - valorI < 15 && valorF > valorI) {

                for (int i = valorI; i <= valorF; i++) {

                    double cubo = i*i*i;

                    Console.WriteLine("O Cubo de {0} é {1}", i,cubo);
                }

            }

        }
    }
}
