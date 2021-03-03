using System;
using System.Collections.Generic;
using System.Collections;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> divisiveis = new List<string>();

            int n = Int32.Parse(Console.ReadLine());

            if (n%3==0)
                divisiveis.Add("3,");

            if (n%6==0)
                divisiveis.Add("6,");

            if (n%7==0)
                divisiveis.Add("7");

            for (int i = 0; i < divisiveis.Count;i++)
                Console.Write(divisiveis[i]);

            Console.WriteLine();

            
        }
    }
}
