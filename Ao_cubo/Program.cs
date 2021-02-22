using System;

namespace Ao_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1 = Int32.Parse(Console.ReadLine());
           int num2 = Int32.Parse(Console.ReadLine());

           for (int i = num1; i < num2 ; i++) {
               double cubo = i*i;
               
               Console.WriteLine(cubo);

           }
           

        }
    }
}
